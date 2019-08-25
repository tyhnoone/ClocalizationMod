﻿using Newtonsoft.Json;
using ReLogic.Reflection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.ModLoader.IO;

namespace ZZLocalizationMod
{
	public class LootCache
	{
		[JsonIgnore]
		public static LootCache instance;

		public Version ZZLocalizationModVersion;

		//public int iterations;
		public long lastUpdateTime;

		//public List<Tuple<string, Version>> cachedMods; // Dictionary better?
		public Dictionary<string, Version> cachedMods;

		public Dictionary<JSONItem, List<JSONNPC>> lootInfos;

		public LootCache()
		{
			//cachedMods = new List<Tuple<string, Version>>();
			cachedMods = new Dictionary<string, Version>();
			lootInfos = new Dictionary<JSONItem, List<JSONNPC>>();
		}
	}

	//public class ModRecord
	//{
	//	public string modname;
	//	public Version version;
	//}

	public class LootInfo
	{
		public static List<JSONNPC> npcsthatdropme;
	}

	[DebuggerDisplay("Mod = {mod}, Name = {name}, ID = {id}")]
	public class JSONNPC
	{
		public string mod;
		public string name;
		public int id;

		public JSONNPC(string mod, string name, int id)
		{
			this.mod = mod;
			this.name = name;
			this.id = id;
			if (id != 0)
			{
				this.mod = "Terraria";
			}
		}

		// We only want to serialize id when name is null, meaning it's a vanilla npc. ModNPC have a guaranteed (ModName, Name) uniqueness. Name for vanilla is just convenience for editing json manually.
		public bool ShouldSerializeid()
		{
			return mod == "Terraria";
		}

		internal int GetID()
		{
			if (id != 0) return id;
			return ModLoader.GetMod(this.mod)?.GetNPC(this.name)?.npc.type ?? 0;
		}
	}

	/*
	[TypeConverter(typeof(JSONItemConverter))]
	public class JSONItem2
	{
		public string mod;
		public string name;

		public JSONItem2(string mod, string name)
		{
			this.mod = mod;
			this.name = name;
		}

		public JSONItem2(string mod, int id)
		{
			this.mod = mod;
			if (mod == "Terraria")
				name = ItemID.Search.GetName(id);
			else
			{
				name = NPCLoader.GetNPC(id).Name;
			}
		}


		public JSONItem2(int id)
		{
			if (id < ItemID.Count)
			{
				mod = "Terraria";
				name = ItemID.Search.GetName(id);
			}
			else
			{
				mod = NPCLoader.GetNPC(id).mod.Name;
				name = NPCLoader.GetNPC(id).Name;
			}
		}

		public override bool Equals(object obj)
		{
			JSONItem p = obj as JSONItem;
			if (p == null)
			{
				return false;
			}
			return (mod == p.mod) && (name == p.name);
		}

		public override int GetHashCode()
		{
			return new { mod, name }.GetHashCode();
		}

		internal bool IsAvailable()
		{
			return true;
		}

		internal int GetID()
		{
			//IdDictionary Search = IdDictionary.Create<NPCID, short>();

			if (mod == "Terraria")
			{
				if (ItemID.Search.ContainsName(name))
					return ItemID.Search.GetId(name);
				return 0;
			}

			return ModLoader.GetMod(this.mod)?.GetItem(this.name)?.item.type ?? 0;
		}
	}
	*/

	[TypeConverter(typeof(JSONItemConverter))]
	public class JSONItem
	{
		public string mod;
		public string name;
		public int id;

		public JSONItem(string mod, string name, int id)
		{
			this.mod = mod;
			this.name = name;
			this.id = id;
			if (id != 0)
			{
				this.mod = "Terraria";
			}
		}

		// We only want to serialize id when name is null, meaning it's a vanilla npc. ModNPC have a guaranteed (ModName, Name) uniqueness. Name for vanilla is just convinience for editing json manually.
		public bool ShouldSerializeid()
		{
			return mod == "Terraria";
		}

		public override bool Equals(object obj)
		{
			JSONItem p = obj as JSONItem;
			if (p == null)
			{
				return false;
			}
			return (mod == p.mod) && (name == p.name);
		}

		public override int GetHashCode()
		{
			return new { mod, name }.GetHashCode();
		}

		internal int GetID()
		{
			if (id != 0) return id;
			return ModLoader.GetMod(this.mod)?.GetItem(this.name)?.item.type ?? 0;
		}
	}

	internal class JSONItemConverter : TypeConverter
	{
		// Overrides the CanConvertFrom method of TypeConverter.
		// The ITypeDescriptorContext interface provides the context for the
		// conversion. Typically, this interface is used at design time to
		// provide information about the design-time container.
		public override bool CanConvertFrom(ITypeDescriptorContext context,
		   Type sourceType)
		{
			if (sourceType == typeof(string))
			{
				return true;
			}
			return base.CanConvertFrom(context, sourceType);
		}

		// Overrides the ConvertFrom method of TypeConverter.
		public override object ConvertFrom(ITypeDescriptorContext context,
		   CultureInfo culture, object value)
		{
			if (value is string)
			{
				string[] v = ((string)value).Split('\t');
				if (v[0] == "Terraria")
				{
					return new JSONItem(v[0], v[1], int.Parse(v[2]));
				}
				return new JSONItem(v[0], v[1], 0);
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Overrides the ConvertTo method of TypeConverter.
		public override object ConvertTo(ITypeDescriptorContext context,
		   CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string))
			{
				JSONItem item = (JSONItem)value;
				if (item.mod == "Terraria")
				{
					return $"{item.mod}\t{item.name}\t{item.id}";
				}
				return $"{item.mod}\t{item.name}";
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}

	internal static class LootCacheManager
	{
		internal static bool LootCacheManagerActive;

		internal static void Setup(Mod ZZLocalizationMod)
		{
			// Save format:
			/*
			 * .. hmm, vanilla item drops...do I have to recalculate each time? New Set of mods => complete refresh?
			 *
			 * ZZLocalizationModVersion // So if we add more features we can ignore this file
			 * [ of Mod Info
			 * -> ModName
			 * -> Version
			 * -> [ of npc drop info? or item info?
			 * -->  Tuple<JSONNPC, LootItem[]> or
			 * -->  JSONNPC<T>
			 * -->
			 * ---> OR
			 * --> Item Info
			 * ---> ["NPCInfo" with droprate]
			 * -->
			 * -> ]
			 * ]
			 *
			 * hmm, instead of mod info, just a list of npc? just a list of Item?
			 *
			 * <Mod, Version>[] --> For knowing which have updated....for now, any update or unaccounted mod, recalculate allll
			 * ItemInfo[] JSONNPC and array of JSONNPC that drop it. (forget droprates for now?)
			 *
			 *
			 * item to npc or npc to item....
			 */
			string json;
			string filename = "zzmodLootCache.json";
			string folder = Path.Combine(Main.SavePath, "Mods", "Cache");
			string path = Path.Combine(folder, filename);
			LootCache li = new LootCache();
			bool needsRecalculate = true;
			LootCacheManagerActive = true;
			List<string> modsThatNeedRecalculate = new List<string>();
			if (File.Exists(path))
			{
				using (StreamReader r = new StreamReader(path))
				{
					json = r.ReadToEnd();
					li = JsonConvert.DeserializeObject<LootCache>(json, new JsonSerializerSettings { Converters = { new Newtonsoft.Json.Converters.VersionConverter() } });
					needsRecalculate = false;
					if (li == null) // Investigate why some people get LootCache.json with only 0s in it.
						li = new LootCache();
				}
			}

			// New Recipe Browser version, assume total reset needed (adjust this logic next update.)
			if (li.ZZLocalizationModVersion != ZZLocalizationMod.Version)
			{
				li.lootInfos.Clear();
				li.cachedMods.Clear();
				li.ZZLocalizationModVersion = ZZLocalizationMod.Version;
				needsRecalculate = true;
			}

			// If we aren't up to date on each mod...
			foreach (var m in ModLoader.Mods)
			{
				if (/*mod == "ModLoader" || */m.Name == "ZZLocalizationMod")
					continue;
				string modName = m.Name == "ModLoader" ? "Terraria" : m.Name;
				if (!li.cachedMods.Any(x => x.Key == modName && x.Value == m.Version)) // if this mod is either updated or doesn't exist yet
																					   //if (li.cachedMods.ContainsKey(modName) && li.cachedMods[modName] == m.Version)
				{
					needsRecalculate = true;
					// Remove mod from list
					li.cachedMods.Remove(modName);
					// Remove items from this mod
					var toRemove = li.lootInfos.Where(pair => pair.Key.mod == modName) // Can't detect if a vanilla npc dropping a vanilla is because of mod. It's fine
					 .Select(pair => pair.Key)
					 .ToList();
					foreach (var key in toRemove)
					{
						li.lootInfos.Remove(key);
					}
					// Remove npc from items.
					foreach (var itemToNPCs in li.lootInfos)
					{
						itemToNPCs.Value.RemoveAll(x => x.mod == modName);
					}
					modsThatNeedRecalculate.Add(modName);
					li.cachedMods[modName] = m.Version; // (new Tuple<string, Version>(modName, m.Version));
				}
			}
			//li.cachedMods.Add(new Tuple<string, Version>(m.Name, m.Version));

			if (needsRecalculate)
			{
				// Temp variables
				float soundVolume = Main.soundVolume;
				Main.soundVolume = 0f;
				if (!Main.dedServ)
				{
					try {
						Reflect();
					}
					catch {
					}
				}
				setLoadProgressText?.Invoke("正在计算掉落物品，请稍等");
				setLoadProgressProgress?.Invoke(0f);

				// expert drops?
				for (int playernum = 0; playernum < 256; playernum++)
				{
					Main.player[playernum] = new Player();
				}
				//Main.player[0].active = true;

				// Fix Terraria Overhaul bug
				if(Main.maxTilesY < 600 || Main.maxTilesX < 2100)
				{
					Main.maxTilesX = 8400;
					Main.maxTilesY = 2400;
					Main.tile = new Tile[Main.maxTilesX + 1, Main.maxTilesY + 1];
				}

				int oldMx = Main.maxTilesX;
				Main.maxTilesX = 2100;
				int oldMy = Main.maxTilesY;
				Main.maxTilesY = 600;
				for (int x = 0; x < Main.maxTilesX; x++)
				{
					for (int y = 0; y < Main.maxTilesY; y++)
					{
						Main.tile[x, y] = new Tile();
						Main.tile[x, y].type = 0;
						if (y > Main.maxTilesY * 0.3f)
							Main.tile[x, y].active(true);
					}
				}
				Main.worldSurface = 200;
				//Main.netMode = 1; // hope this doesn't do anything weird
				NPC npc = new NPC();
				Item item = new Item();
				loots = new HashSet<int>();
				string lastMod = "";
				var watch = Stopwatch.StartNew();
				var oldRand = Main.rand;
				if (Main.rand == null)
					Main.rand = new Terraria.Utilities.UnifiedRandom();

				for (int i = 1; i < NPCLoader.NPCCount; i++) // for every npc...
				{
					npc.SetDefaults(i);
					npc.value = 0; // Causes some drops to be missed, why is this here?
					string currentMod = npc.modNPC?.mod.Name ?? "Terraria";
					if (!modsThatNeedRecalculate.Contains(currentMod))
						continue;
					if (lastMod != currentMod)
					{
						lastMod = currentMod;
						setLoadSubProgressText?.Invoke(lastMod);
					}
					setLoadProgressProgress?.Invoke((float)i / NPCLoader.NPCCount);
					JSONNPC jsonNPC = new JSONNPC(npc.modNPC?.mod.Name ?? "Terraria", npc.modNPC?.Name ?? npc.TypeName, npc.modNPC != null ? 0 : i);

					loots.Clear();
					CalculateLoot(npc);  // ...calculate drops

					foreach (var loot in loots)
					{
						if (ignoreItemIDS.Contains(loot))
							continue;

						item.SetDefaults(loot, true);

						//JSONItem jsonitem = new JSONItem(item.modItem?.mod.Name ?? "Terraria", Lang.GetItemNameValue(loot), item.modItem != null ? 0 : loot);
						JSONItem jsonitem = new JSONItem(item.modItem?.mod.Name ?? "Terraria", item.modItem?.Name ?? Lang.GetItemNameValue(loot), item.modItem != null ? 0 : loot);

						if (!li.lootInfos.TryGetValue(jsonitem, out LootInfo.npcsthatdropme))
							li.lootInfos.Add(jsonitem, LootInfo.npcsthatdropme = new List<JSONNPC>());
						LootInfo.npcsthatdropme.Add(jsonNPC);
					}
				}
				loots.Clear();
				// Reset temp values
				Main.rand = oldRand; // value 8 seconds.  // don't value to 0 and ignore.contains: 5 seconds.
									 // value to 0, contains, 4 seconds.   .6 seconds without contains.
				Main.maxTilesX = oldMx;
				Main.maxTilesY = oldMy;
				Main.soundVolume = soundVolume;

				// Save json:
				watch.Stop();
				var elapsedMs = watch.ElapsedMilliseconds;
				//li.iterations = MaxNumberLootExperiments;
				li.lastUpdateTime = elapsedMs;
				Directory.CreateDirectory(folder);
				json = JsonConvert.SerializeObject(li, Formatting.Indented, new JsonSerializerSettings { Converters = { new Newtonsoft.Json.Converters.VersionConverter() } });
				File.WriteAllText(path, json);

				// Reset Load Mods Progress bar
				setLoadSubProgressText?.Invoke("");
				setLoadProgressText?.Invoke("Adding Recipes");
				setLoadProgressProgress?.Invoke(0f);
			}
			LootCacheManagerActive = false;
			LootCache.instance = li;
		}

		private static Action<string> setLoadProgressText;
		private static Action<float> setLoadProgressProgress;
		private static Action<string> setLoadSubProgressText;

		private static void Reflect()
		{
			Assembly assembly = Assembly.GetAssembly(typeof(Mod));
			// TODO, return to old float and string.
			var type = assembly.GetType("Terraria.ModLoader.Interface");
			FieldInfo loadModsField = type.GetField("loadModsProgress", BindingFlags.Static | BindingFlags.NonPublic);
			var loadModsProgressField = loadModsField.GetValue(null);


			Type UILoadModsProgressType = assembly.GetType("Terraria.ModLoader.UI.DownloadManager.UILoadModsProgress");
			//FieldInfo loadProgressField = UILoadModsProgressType.GetField("loadProgress", BindingFlags.Instance | BindingFlags.NonPublic);
			//var loadProgressObject = loadProgressField.GetValue(loadModsProgressField);

			MethodInfo SetLoadStageMethod = UILoadModsProgressType.GetMethod("SetLoadStage", BindingFlags.Instance | BindingFlags.Public);
			PropertyInfo setProgressMethod = UILoadModsProgressType.GetProperty("Progress", BindingFlags.Instance | BindingFlags.Public);
			PropertyInfo setSubTextMethod = UILoadModsProgressType.GetProperty("SubProgressText", BindingFlags.Instance | BindingFlags.Public);

			setLoadProgressText = (string s) => SetLoadStageMethod.Invoke(loadModsProgressField, new object[] { s, -1 });
			setLoadProgressProgress = (float f) => setProgressMethod.SetValue(loadModsProgressField, f );
			setLoadSubProgressText = (string s) => setSubTextMethod.SetValue(loadModsProgressField, s);
		}

		//Check if the field IsMono is in PlatformUtilities, as it's exclusive to tML FNA/64bit
		private static bool IsTMLFNA => typeof(PlatformUtilities).GetField("IsMono", BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly) != null;

		private static int[] ignoreItemIDS = { ItemID.Heart, 1734, 1867, 184, 1735, 1868, ItemID.CopperCoin, ItemID.CopperCoin, ItemID.SilverCoin, ItemID.GoldCoin, ItemID.PlatinumCoin };

		public const int MaxNumberLootExperiments = 5000;
		internal static HashSet<int> loots;

		internal static void CalculateLoot(NPC npc)
		{
			if (npc.type == NPCID.WallofFlesh) Main.hardMode = true;//return;
																	// Hmmmmmm, start hardmode code might overwrite world....
			NPC.downedBoss1 = true;
			NPC.downedBoss2 = true;
			NPC.downedBoss3 = true;
			NPC.downedMechBossAny = true;
			NPC.downedMoonlord = true;
			NPC.downedGolemBoss = true;
			
			if(ModLoader.GetMod("CalamityMod") != null)
			{
				List<string> list = new List<string>();
				list.Add("desertScourge");
				list.Add("aquaticScourge");
				list.Add("hiveMind");
				list.Add("perforator");
				list.Add("slimeGod");
				list.Add("cryogen");
				list.Add("brimstoneElemental");
				list.Add("calamitas");
				list.Add("leviathan");
				list.Add("devourerOfGods");
				list.Add("plaguebringerGoliath");
				list.Add("guardians");
				list.Add("providence");
				list.Add("ceaselessVoid");
				list.Add("stormWeaver");
				list.Add("signus");
				list.Add("yharon");
				list.Add("eclipse");
				list.Add("supremeCalamitas");
				list.Add("bumblebirb");
				list.Add("crabulon");
				list.Add("betsy");
				list.Add("scavenger");
				list.Add("boss2");
				list.Add("boss3");
				list.Add("wall");
				list.Add("skeletronPrime");
				list.Add("planter");
				list.Add("baby");
				list.Add("moonDude");
				list.Add("anyBoss");
				list.Add("demonMode");
				list.Add("onionMode");
				list.Add("revenge");
				list.Add("starGod");
				list.Add("astrageldon");
				list.Add("astralMeteor");
				list.Add("astralMeteor2");
				list.Add("astralMeteor3");
				list.Add("hardBoss");
				list.Add("polterghast");
				list.Add("lorde");
				list.Add("moth");
				list.Add("oldDuke");
				list.Add("death");
				list.Add("defiled");
				list.Add("armageddon");
				list.Add("ironHeart");
				list.Add("abyssSide");
				list.Add("clam");
				TagCompound tag = new TagCompound();
				tag.Add("downed", list);
				ModLoader.GetMod("CalamityMod").GetModWorld("CalamityWorld").Load(tag);
			}
			npc.Center = new Microsoft.Xna.Framework.Vector2(1000, 1000);
			int iterationsWithNoChange = 0;

			var realRandom = Main.rand;
			var fakeRandom = new LootUnifiedRandom();
			for (int i = 0; i < MaxNumberLootExperiments; i++)
			{
				if (i == 0)
					Main.rand = fakeRandom;
				if (i == 50)
					Main.rand = realRandom;
				try
				{
					LootUnifiedRandom.loop = i;
					npc.NPCLoot();
				}
				catch
				{
				}
				npc.active = false;
				bool anyNew = false;
				//if(Main.item[400].active || Main.item[399].active)
				//{
				//	Console.WriteLine();
				//}
				foreach (var item in Main.item)
				{
					if (item.active)
					{
						//if (ignoreItemIDS.Contains(item.type))  // npc.value = 0;
						//	continue;
						loots.Add(item.type); // hmm, Item.NewItem reverseLookup?
						item.active = false;
						anyNew = true;
						//if (iterationsWithNoChange > 150)
						//	Debug.WriteLine($"{i}: {iterationsWithNoChange} {item.Name}");
					}
					else
					{
						break;
					}
				}
				if (anyNew)
					iterationsWithNoChange = 0;
				else
					iterationsWithNoChange++;

				if (iterationsWithNoChange > 250)
					break;
			}
			//}
			Main.hardMode = false;
			NPC.downedBoss1 = false;
			NPC.downedBoss2 = false;
			NPC.downedBoss3 = false;
			NPC.downedMechBossAny = false;
			NPC.downedMoonlord = false;
			NPC.downedGolemBoss = false;
			if(ModLoader.GetMod("CalamityMod") != null)
			{
				TagCompound tag = new TagCompound();
				List<string> list = new List<string>();
				ModLoader.GetMod("CalamityMod").GetModWorld("CalamityWorld").Load(tag);
			}
		}
	}

	public class ZZLocalizationModGlobalNPC : GlobalNPC
	{
		public override bool PreNPCLoot(NPC npc)
		{
			if (LootCacheManager.LootCacheManagerActive)
				((List<int>)(NPCLoader.blockLoot)).AddRange(LootCacheManager.loots);
			return true;
		}
	}
}