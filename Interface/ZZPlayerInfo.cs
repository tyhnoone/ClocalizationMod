using ReLogic.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;
using System;
using Terraria.ID;
using System.Linq;
using System.Collections.Generic;
using Terraria.DataStructures;

namespace ZZLocalizationMod.Interface
{
	class ZZPlayerInfo : UIState
	{
		public UIPanel ZZPlayerInfoInterface;
		public static bool visible = false;

		
		public UIPlayerInfoDisplay PlayerInfo;
		public UIPlayerClass PlayerClass;
		public static bool[] PlayButton = {false, false, false, false, false};
		public static bool[] PlayButtonThorium = {false, false};
		public override void OnInitialize()
		{
			float add = 0f;
			float width = 0f;
			float Revenge = 0f;
			if(ModLoader.GetMod("ThoriumMod") != null)
			{
				add += 60f;
				width += 160f;
			}
			if(ModLoader.GetMod("CalamityMod") != null)
			{
				add += 90f;
				Revenge = 90f;
			}

			ZZPlayerInfoInterface = new UIPanel();
			ZZPlayerInfoInterface.SetPadding(0);
			ZZPlayerInfoInterface.Left.Set(325f, 0f);
			ZZPlayerInfoInterface.Top.Set(335f, 0f);
			ZZPlayerInfoInterface.Width.Set(500f + width, 0f);
			ZZPlayerInfoInterface.Height.Set(380f + add + Revenge, 0f);
			ZZPlayerInfoInterface.BackgroundColor = new Color(73, 94, 171, 200);

			ZZPlayerInfoInterface.OnMouseDown += new UIElement.MouseEvent(DragStart);
			ZZPlayerInfoInterface.OnMouseUp += new UIElement.MouseEvent(DragEnd);


			PlayerInfo = new UIPlayerInfoDisplay();
			PlayerInfo.Left.Set(30, 0f);
			PlayerInfo.Top.Set(30, 0f);
			PlayerInfo.Width.Set(60, 0f);
			PlayerInfo.Height.Set(22, 0f);
			ZZPlayerInfoInterface.Append(PlayerInfo);

			PlayerClass = new UIPlayerClass();
			PlayerClass.Left.Set(35, 0f);
			PlayerClass.Top.Set(240 + add, 0f);
			PlayerClass.Width.Set(15, 0f);
			PlayerClass.Height.Set(22, 0f);
			ZZPlayerInfoInterface.Append(PlayerClass);

			Texture2D buttonPlayerClass = ModContent.GetTexture("Terraria/UI/ButtonPlay");;
			UIImageButton PlayButton = new UIImageButton(buttonPlayerClass);
			PlayButton.Left.Set(40, 0f);
			PlayButton.Top.Set(240 + add, 0f);
			PlayButton.Width.Set(20, 0f);
			PlayButton.Height.Set(20, 0f);
			PlayButton.OnClick += new MouseEvent(PlayButtonClicked);
			ZZPlayerInfoInterface.Append(PlayButton);

			UIImageButton PlayButton2 = new UIImageButton(buttonPlayerClass);
			PlayButton2.Left.Set(120, 0f);
			PlayButton2.Top.Set(240 + add, 0f);
			PlayButton2.Width.Set(20, 0f);
			PlayButton2.Height.Set(20, 0f);
			PlayButton2.OnClick += new MouseEvent(PlayButton2Clicked);
			ZZPlayerInfoInterface.Append(PlayButton2);

			UIImageButton PlayButton3 = new UIImageButton(buttonPlayerClass);
			PlayButton3.Left.Set(200, 0f);
			PlayButton3.Top.Set(240 + add, 0f);
			PlayButton3.Width.Set(20, 0f);
			PlayButton3.Height.Set(20, 0f);
			PlayButton3.OnClick += new MouseEvent(PlayButton3Clicked);
			ZZPlayerInfoInterface.Append(PlayButton3);

			UIImageButton PlayButton4 = new UIImageButton(buttonPlayerClass);
			PlayButton4.Left.Set(280, 0f);
			PlayButton4.Top.Set(240 + add, 0f);
			PlayButton4.Width.Set(20, 0f);
			PlayButton4.Height.Set(20, 0f);
			PlayButton4.OnClick += new MouseEvent(PlayButton4Clicked);
			ZZPlayerInfoInterface.Append(PlayButton4);

			UIImageButton PlayButton5 = new UIImageButton(buttonPlayerClass);
			PlayButton5.Left.Set(360, 0f);
			PlayButton5.Top.Set(240 + add, 0f);
			PlayButton5.Width.Set(20, 0f);
			PlayButton5.Height.Set(20, 0f);
			PlayButton5.OnClick += new MouseEvent(PlayButton5Clicked);
			ZZPlayerInfoInterface.Append(PlayButton5);

			if(ModLoader.GetMod("ThoriumMod") != null)
			{
				UIImageButton PlayButton6 = new UIImageButton(buttonPlayerClass);
				PlayButton6.Left.Set(440, 0f);
				PlayButton6.Top.Set(240 + add, 0f);
				PlayButton6.Width.Set(20, 0f);
				PlayButton6.Height.Set(20, 0f);
				PlayButton6.OnClick += new MouseEvent(PlayButtonThorium1Clicked);
				ZZPlayerInfoInterface.Append(PlayButton6);

				UIImageButton PlayButton7 = new UIImageButton(buttonPlayerClass);
				PlayButton7.Left.Set(520, 0f);
				PlayButton7.Top.Set(240 + add, 0f);
				PlayButton7.Width.Set(20, 0f);
				PlayButton7.Height.Set(20, 0f);
				PlayButton7.OnClick += new MouseEvent(PlayButtonThorium2Clicked);
				ZZPlayerInfoInterface.Append(PlayButton7);
			}
			
			

			Mod mod = ZZLocalizationMod.Instance;
			
			Texture2D buttonDeleteTexture = ModContent.GetTexture("Terraria/UI/ButtonDelete");
			UIImageButton closeButton = new UIImageButton(buttonDeleteTexture);
			closeButton.Left.Set(460 + width, 0f);
			closeButton.Top.Set(10, 0f);
			closeButton.Width.Set(22, 0f);
			closeButton.Height.Set(22, 0f);
			closeButton.OnClick += new MouseEvent(CloseButtonClicked);
			ZZPlayerInfoInterface.Append(closeButton);

			base.Append(ZZPlayerInfoInterface);
		}
		private void PlayButtonClicked(UIMouseEvent evt, UIElement listeningElement)
		{
			PlayButton[0] = true;
			PlayButton[1] = false;
			PlayButton[2] = false;
			PlayButton[3] = false;
			PlayButton[4] = false;
			PlayButtonThorium[0] = false;
			PlayButtonThorium[1] = false;
		}
		private void PlayButton2Clicked(UIMouseEvent evt, UIElement listeningElement)
		{
			PlayButton[0] = false;
			PlayButton[1] = true;
			PlayButton[2] = false;
			PlayButton[3] = false;
			PlayButton[4] = false;
			PlayButtonThorium[0] = false;
			PlayButtonThorium[1] = false;
		}
		private void PlayButton3Clicked(UIMouseEvent evt, UIElement listeningElement)
		{
			PlayButton[0] = false;
			PlayButton[1] = false;
			PlayButton[2] = true;
			PlayButton[3] = false;
			PlayButton[4] = false;
			PlayButtonThorium[0] = false;
			PlayButtonThorium[1] = false;
		}
		private void PlayButton4Clicked(UIMouseEvent evt, UIElement listeningElement)
		{
			PlayButton[0] = false;
			PlayButton[1] = false;
			PlayButton[2] = false;
			PlayButton[3] = true;
			PlayButton[4] = false;
			PlayButtonThorium[0] = false;
			PlayButtonThorium[1] = false;
		}
		private void PlayButton5Clicked(UIMouseEvent evt, UIElement listeningElement)
		{
			PlayButton[0] = false;
			PlayButton[1] = false;
			PlayButton[2] = false;
			PlayButton[3] = false;
			PlayButton[4] = true;
			PlayButtonThorium[0] = false;
			PlayButtonThorium[1] = false;
		}
		private void PlayButtonThorium1Clicked(UIMouseEvent evt, UIElement listeningElement)
		{
			PlayButton[0] = false;
			PlayButton[1] = false;
			PlayButton[2] = false;
			PlayButton[3] = false;
			PlayButton[4] = false;
			PlayButtonThorium[0] = true;
			PlayButtonThorium[1] = false;
		}
		private void PlayButtonThorium2Clicked(UIMouseEvent evt, UIElement listeningElement)
		{
			PlayButton[0] = false;
			PlayButton[1] = false;
			PlayButton[2] = false;
			PlayButton[3] = false;
			PlayButton[4] = false;
			PlayButtonThorium[0] = false;
			PlayButtonThorium[1] = true;
		}
		private void CloseButtonClicked(UIMouseEvent evt, UIElement listeningElement)
		{
			Main.PlaySound(SoundID.MenuOpen);
			visible = false;
		}

		Vector2 offset;
		public bool dragging = false;
		private void DragStart(UIMouseEvent evt, UIElement listeningElement)
		{
			offset = new Vector2(evt.MousePosition.X - ZZPlayerInfoInterface.Left.Pixels, evt.MousePosition.Y - ZZPlayerInfoInterface.Top.Pixels);
			dragging = true;
		}

		private void DragEnd(UIMouseEvent evt, UIElement listeningElement)
		{
			Vector2 end = evt.MousePosition;
			dragging = false;

			ZZPlayerInfoInterface.Left.Set(end.X - offset.X, 0f);
			ZZPlayerInfoInterface.Top.Set(end.Y - offset.Y, 0f);

			Recalculate();
		}
		public void UpdateValue(Player player) 
		{
			PlayerInfo.lifeR = player.lifeRegen;
			PlayerInfo.ManaR = player.manaRegen;
			PlayerInfo.flytime = player.wingTimeMax;
			PlayerInfo.endurance = (int)(player.endurance)*100;
			PlayerInfo.slotsMinions = (int)player.slotsMinions;
			PlayerInfo.maxMinions = player.maxMinions;
			PlayerInfo.maxTurrets = player.maxTurrets;
			PlayerInfo.around = ZZLocalizationMod.zoneString(player);

			PlayerClass.meleedamage = (int)((player.meleeDamage*100)-100);
			PlayerClass.meleeSpeed = (int)(100 - (player.meleeSpeed*100));
			PlayerClass.meleeCrit = (int)(player.meleeCrit-4);

			PlayerClass.magicDamage = (int)((player.magicDamage*100)-100);
			PlayerClass.manaCost = (int)((player.manaCost*100)-100);
			PlayerClass.magicCrit = (int)(player.magicCrit-4);

			PlayerClass.rangedDamage = (int)((player.rangedDamage*100)-100);
			PlayerClass.rangedCrit = (int)(player.rangedCrit-4);
			PlayerClass.moveSpeed = (int)((player.moveSpeed*100)-100);

			PlayerClass.miniondamage = (int)((player.minionDamage*100)-100);
			PlayerClass.minionknockback = (int)(player.minionKB)*100;

			PlayerClass.thrownDamage = (int)((player.thrownDamage*100)-100);
			PlayerClass.thrownCrit = (int)(player.thrownCrit-4);
			PlayerClass.thrownVelocity = (int)((player.thrownVelocity*100)-100);
			
			
			if(ModLoader.GetMod("ThoriumMod") != null)
			{
				ModPlayer playerthorium = Main.player[Main.myPlayer].GetModPlayer(ModLoader.GetMod("ThoriumMod"), "ThoriumPlayer");
				PlayerInfo.thoriumbardResource = (int) ModLoader.GetMod("ThoriumMod").GetPlayer("ThoriumPlayer").GetType().GetField("bardResource").GetValue(playerthorium);

				float symphonicDamage = (float)ModLoader.GetMod("ThoriumMod").GetPlayer("ThoriumPlayer").GetType().GetField("symphonicDamage").GetValue(playerthorium);
				int symphonicCrit = (int) ModLoader.GetMod("ThoriumMod").GetPlayer("ThoriumPlayer").GetType().GetField("symphonicCrit").GetValue(playerthorium);

				PlayerClass.symphonicDamage = (int)((symphonicDamage*100)-100);
				PlayerClass.symphonicCrit = (int)((symphonicCrit-4));

				float radiantBoost = (float)ModLoader.GetMod("ThoriumMod").GetPlayer("ThoriumPlayer").GetType().GetField("radiantBoost").GetValue(playerthorium);
				int radiantCrit = (int) ModLoader.GetMod("ThoriumMod").GetPlayer("ThoriumPlayer").GetType().GetField("radiantCrit").GetValue(playerthorium);

				PlayerClass.radiantBoost = (int)((radiantBoost*100)-100);
				PlayerClass.radiantCrit = (int)(radiantCrit-4);

			}

			if(ModLoader.GetMod("CalamityMod") != null)
			{
				ModPlayer playerCalamity = Main.player[Main.myPlayer].GetModPlayer(ModLoader.GetMod("CalamityMod"), "CalamityPlayer");
				PlayerInfo.stress = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("stress").GetValue(playerCalamity);
				PlayerInfo.adrenaline = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("adrenaline").GetValue(playerCalamity);
				PlayerInfo.stressMax = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("stressMax").GetValue(playerCalamity);
				PlayerInfo.adrenalineMax = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("adrenalineMax").GetValue(playerCalamity);
				
				PlayerClass.meleeLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("meleeLevel").GetValue(playerCalamity);
				PlayerClass.exactMeleeLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("exactMeleeLevel").GetValue(playerCalamity);

				PlayerClass.magicLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("magicLevel").GetValue(playerCalamity);
				PlayerClass.exactmagicLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("exactMagicLevel").GetValue(playerCalamity);

				PlayerClass.rangedLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("rangedLevel").GetValue(playerCalamity);
				PlayerClass.exactRangedLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("exactRangedLevel").GetValue(playerCalamity);

				PlayerClass.rangedLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("rangedLevel").GetValue(playerCalamity);
				PlayerClass.exactRangedLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("exactRangedLevel").GetValue(playerCalamity);
				
				PlayerClass.summonLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("summonLevel").GetValue(playerCalamity);
				PlayerClass.exactSummonLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("exactSummonLevel").GetValue(playerCalamity);

				PlayerClass.rogueLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("rogueLevel").GetValue(playerCalamity);
				PlayerClass.exactRogueLevel = (int) ModLoader.GetMod("CalamityMod").GetPlayer("CalamityPlayer").GetType().GetField("exactRogueLevel").GetValue(playerCalamity);

				CalamityInfo(player);
			}	
		}
		private void CalamityInfo(Player player)
        {
			CalamityMod.Items.CalamityCustomThrowingDamage.CalamityCustomThrowingDamagePlayer CalamityPlayer = player.GetModPlayer<CalamityMod.Items.CalamityCustomThrowingDamage.CalamityCustomThrowingDamagePlayer>(Calamity);
			PlayerClass.thrownDamage = (int)((CalamityPlayer.throwingDamage*100)-100);
			PlayerClass.thrownCrit = (int)(CalamityPlayer.throwingCrit-4);
			PlayerClass.thrownVelocity = (int)((CalamityPlayer.throwingVelocity*100)-100);
		}
		private readonly Mod Calamity = ModLoader.GetMod("CalamityMod");
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			Vector2 MousePosition = new Vector2((float)Main.mouseX, (float)Main.mouseY);
			if (ZZPlayerInfoInterface.ContainsPoint(MousePosition))
			{
				Main.LocalPlayer.mouseInterface = true;
			}
			if (dragging)
			{
				ZZPlayerInfoInterface.Left.Set(MousePosition.X - offset.X, 0f);
				ZZPlayerInfoInterface.Top.Set(MousePosition.Y - offset.Y, 0f);
				Recalculate();
			}
			
		}
	}
		public class UIPlayerInfoDisplay : UIElement
		{
			public int lifeR = 0;
			public int ManaR = 0;
			public int flytime = 0;
			public int endurance = 0;
			public int slotsMinions = 0;
			public int maxMinions = 0;
			public int maxTurrets = 0;
			public string around = "";
			public int thoriumbardResource = 0;
			public int stress = 0;
			public int adrenaline = 0;
			public int stressMax = 0;
			public int adrenalineMax = 0;

			public UIPlayerInfoDisplay() 
			{
				Width.Set(100, 0f);
				Height.Set(40, 0f);
			}

			protected override void DrawSelf(SpriteBatch spriteBatch) 
			{
			CalculatedStyle innerDimensions = GetInnerDimensions();	
			//Vector2 drawPos = new Vector2(innerDimensions.X + 5f, innerDimensions.Y + 30f);

			float shopx = innerDimensions.X;
			float shopy = innerDimensions.Y;
			float i = 0;

			Color lifeRcolor;
			if(lifeR > 0)
			{
				lifeRcolor = Color.DarkGreen;
			}
			else if(lifeR < 0)
			{
				lifeRcolor = Color.DarkRed;
			}
			else {lifeRcolor = Color.Yellow;}

			Color Minionscolor;
			float Minions = (float)(slotsMinions)/(float)(maxMinions);
			if(Minions < 0.33)
			{
				Minionscolor = Color.DarkGreen;
			}
			else if(Minions > 0.66)
			{
				Minionscolor = Color.DarkRed;
			}
			else {Minionscolor = Color.Yellow;}

			Color thoriumbardResourcecolor;
			if(thoriumbardResource > 8)
			{
				thoriumbardResourcecolor = Color.Purple;
			}
			else
			{
				thoriumbardResourcecolor = Color.LightGreen;
			}

			DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "每秒" + lifeR + "生命再生", new Vector2(shopx, shopy), lifeRcolor, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
			DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "每秒" + ManaR + "魔力再生", new Vector2(shopx, shopy + 30), Color.DarkBlue, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
			DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, flytime + "最大飞行时间", new Vector2(shopx, shopy + 60), Color.Coral, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
			DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "获得" + endurance + "%伤害减免", new Vector2(shopx, shopy + 90), Color.RosyBrown, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
			DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "召唤物栏已用/上限："+ slotsMinions + " / " + maxMinions, new Vector2(shopx, shopy + 120), Minionscolor, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
			DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "哨兵炮塔上限：" + maxTurrets, new Vector2(shopx, shopy + 150), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);

			DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, around, new Vector2(shopx + 250, shopy), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);

			if(ModLoader.GetMod("ThoriumMod") != null)
			{
				i+=60;
				DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "瑟银乐师灵感：" + thoriumbardResource +"灵感", new Vector2(shopx, shopy + 150 + i), thoriumbardResourcecolor, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
			}
			if(ModLoader.GetMod("CalamityMod") != null)
			{
				Color stresscolor;
				if(stress == stressMax)
				{
					stresscolor = Color.Green;
				}
				else
				{
					stresscolor = Color.IndianRed;
				}
				Color adrenalinecolor;
				if(adrenaline == adrenalineMax)
				{
					adrenalinecolor = Color.Green;
				}
				else
				{
					adrenalinecolor = Color.DeepSkyBlue;
				}	
				i += 60;
				DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄复仇模式："+ stress + "怒气压力", new Vector2(shopx, shopy + 150 + i), stresscolor, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
				i += 30;
				DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄复仇模式：" + adrenaline + "肾上腺素", new Vector2(shopx, shopy + 150 + i), adrenalinecolor, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
			}
			}
		}

		public class UIPlayerClass : UIElement
		{
			public int meleedamage = 0;
			public int meleeSpeed = 0;
			public int meleeCrit = 0;
			public int meleeLevel = 0;
			public int exactMeleeLevel = 0;
			public int magicDamage = 0;
			public int magicCrit = 0;
			public int manaCost = 0;
			public int magicLevel = 0;
			public int exactmagicLevel = 0;
			public int rangedDamage = 0;
			public int rangedCrit = 0;
			public int moveSpeed = 0;
			public int rangedLevel = 0;
			public int exactRangedLevel = 0;
			public int miniondamage = 0;
			public int minionknockback = 0;
			public int summonLevel = 0;
			public int exactSummonLevel = 0;
			public int thrownDamage = 0;
			public int thrownVelocity = 0;
			public int thrownCrit = 0;
			public int rogueLevel = 0;
			public int exactRogueLevel = 0;
			public int symphonicDamage = 0;
			public int symphonicCrit = 0;
			public int radiantBoost = 0;
			public int radiantCrit = 0;
			public UIPlayerClass() 
			{
				Width.Set(100, 0f);
				Height.Set(40, 0f);
			}
			
			protected override void DrawSelf(SpriteBatch spriteBatch) 
			{
				CalculatedStyle innerDimensions = GetInnerDimensions();	
			//Vector2 drawPos = new Vector2(innerDimensions.X + 5f, innerDimensions.Y + 30f);
				Color[] color = {Color.White, Color.White, Color.White, Color.White, Color.White};
				Color[] Thoriumcolor = {Color.White, Color.White};
				float shopx = innerDimensions.X;
				float shopy = innerDimensions.Y;

				for(int i=0; i<5; i++)
				{
					if(ZZPlayerInfo.PlayButton[i])
					{
						color[i] = Color.LawnGreen;
					}
				}

				DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "近战", new Vector2(shopx + 30, shopy), color[0], 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
				DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "魔法", new Vector2(shopx + 110, shopy), color[1], 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
				DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "远程", new Vector2(shopx + 190, shopy), color[2], 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
				DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "召唤", new Vector2(shopx + 270, shopy), color[3], 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
				DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, ModLoader.GetMod("CalamityMod") != null ? "盗贼":"投掷", new Vector2(shopx + 350, shopy), color[4], 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);

				if(ZZPlayerInfo.PlayButton[0])
				{
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "近战伤害加成" + meleedamage + "%", new Vector2(shopx, shopy+40), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					//DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "近战速度加成" + meleeSpeed + "%", new Vector2(shopx, shopy+100), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "近战暴击加成" + meleeCrit + "%", new Vector2(shopx, shopy+70), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					if(ModLoader.GetMod("CalamityMod") != null)
					{
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄近战熟练度：" + (meleeLevel - ((meleeLevel > 12500) ? 1 : 0)), new Vector2(shopx, shopy+140), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄近战等级：" + exactMeleeLevel, new Vector2(shopx, shopy+170), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					}
				}
				if(ZZPlayerInfo.PlayButton[1])
				{
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "魔法伤害加成" + magicDamage + "%", new Vector2(shopx, shopy+40), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "魔力消耗减少" + manaCost + "%", new Vector2(shopx, shopy+70), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "魔法暴击加成" + magicCrit + "%", new Vector2(shopx, shopy+100), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					if(ModLoader.GetMod("CalamityMod") != null)
					{
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄魔法熟练度：" + (magicLevel - ((magicLevel > 12500) ? 1 : 0)), new Vector2(shopx, shopy+140), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄魔法等级：" + exactmagicLevel, new Vector2(shopx, shopy+170), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					}
				}

				if(ZZPlayerInfo.PlayButton[2])
				{
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "远程伤害加成" + rangedDamage + "%", new Vector2(shopx, shopy+40), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "移动速度增加" + moveSpeed + "%", new Vector2(shopx, shopy+70), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "远程暴击加成" + rangedCrit + "%", new Vector2(shopx, shopy+100), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					if(ModLoader.GetMod("CalamityMod") != null)
					{
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄远程熟练度：" + (rangedLevel - ((rangedLevel > 12500) ? 1 : 0)), new Vector2(shopx, shopy+140), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄远程等级：" + exactRangedLevel, new Vector2(shopx, shopy+170), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					}
				}

				if(ZZPlayerInfo.PlayButton[3])
				{
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "召唤伤害加成" + miniondamage + "%", new Vector2(shopx, shopy+40), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "召唤物击退增加" + minionknockback + "%", new Vector2(shopx, shopy+70), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					if(ModLoader.GetMod("CalamityMod") != null)
					{
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄远程熟练度：" + (summonLevel - ((summonLevel > 12500) ? 1 : 0)), new Vector2(shopx, shopy+140), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄远程等级：" + exactSummonLevel, new Vector2(shopx, shopy+170), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					}
				}
				if(ZZPlayerInfo.PlayButton[4])
				{
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, (ModLoader.GetMod("CalamityMod") != null ? "盗贼":"投掷")+"伤害加成" + thrownDamage + "%", new Vector2(shopx, shopy+40), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, (ModLoader.GetMod("CalamityMod") != null ? "盗贼投掷":"投掷")+"速度增加" + thrownVelocity + "%", new Vector2(shopx, shopy+70), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, (ModLoader.GetMod("CalamityMod") != null ? "盗贼投掷":"投掷")+"暴击加成" + thrownCrit + "%", new Vector2(shopx, shopy+100), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					if(ModLoader.GetMod("CalamityMod") != null)
					{
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄盗贼熟练度：" + (rogueLevel - ((rogueLevel > 12500) ? 1 : 0)), new Vector2(shopx, shopy+140), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "灾厄盗贼等级：" + exactRogueLevel, new Vector2(shopx, shopy+170), Color.DarkRed, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					}
				}
				if(ModLoader.GetMod("ThoriumMod") != null)
				{
					for(int i=0; i<2; i++)
					{
						if(ZZPlayerInfo.PlayButtonThorium[i])
						{
							Thoriumcolor[i] = Color.LawnGreen;
						}
					}
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "乐师", new Vector2(shopx + 430, shopy), Thoriumcolor[0], 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "牧师", new Vector2(shopx + 510, shopy), Thoriumcolor[1], 0f,default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					if(ZZPlayerInfo.PlayButtonThorium[0])
					{
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "交响伤害加成" + symphonicDamage + "%", new Vector2(shopx, shopy+40), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "交响暴击加成" + symphonicCrit + "%", new Vector2(shopx, shopy+70), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					}
					if(ZZPlayerInfo.PlayButtonThorium[1])
					{
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "光辉伤害加成" + radiantBoost + "%", new Vector2(shopx, shopy+40), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
						DynamicSpriteFontExtensionMethods.DrawString(Main.spriteBatch, Main.fontMouseText, "光辉暴击加成" + radiantCrit + "%", new Vector2(shopx, shopy+70), Color.White, 0f, default(Vector2), new Vector2(1f), SpriteEffects.None, 0f);
					}

				}
			}
		}
		
}
