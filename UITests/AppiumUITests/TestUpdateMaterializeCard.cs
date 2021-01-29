using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using ReportManager;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;

namespace TestEditMaterializeCard
{
	[TestClass]
	public class UnitTestCreateOrder : SessionSettingClass
	{
		string materialNumber = "";
		[TestMethod]
		public void TestMethod1()
		{
			//    // LeftClick on Button "miLIMS" at (44,14)
			//    Console.WriteLine("LeftClick on Button \"miLIMS\" at (44,14)");
			//    string xpath_LeftClickButtonmiLIMS_44_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Group[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Pøichytit nahoru\"]/ToolBar[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[@Name=\"miLIMS\"]";
			//    var winElem_LeftClickButtonmiLIMS_44_14 = root.FindByXPath(xpath_LeftClickButtonmiLIMS_44_14);
			//    if (winElem_LeftClickButtonmiLIMS_44_14 != null)
			//    {
			//        winElem_LeftClickButtonmiLIMS_44_14.Click();
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_44_14}");
			//        return;
			//    }


			//    // LeftClick on MenuItem "miLimsLosUnfinished" at (58,5)
			//    Console.WriteLine("LeftClick on MenuItem \"miLimsLosUnfinished\" at (58,5)");
			//    string xpath_LeftClickMenuItemmiLimsLosU_58_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Menu[starts-with(@ClassName,\"WindowsForms10\")]/MenuItem[@Name=\"miLimsLosUnfinished\"]";
			//    var winElem_LeftClickMenuItemmiLimsLosU_58_5 = root.FindByXPath(xpath_LeftClickMenuItemmiLimsLosU_58_5);
			//    if (winElem_LeftClickMenuItemmiLimsLosU_58_5 != null)
			//    {
			//        winElem_LeftClickMenuItemmiLimsLosU_58_5.Click();
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickMenuItemmiLimsLosU_58_5}");
			//        return;
			//    }


			//    // LeftClick on MenuItem "miLimsLosUnfinishedClassic" at (39,21)
			//    Console.WriteLine("LeftClick on MenuItem \"miLimsLosUnfinishedClassic\" at (39,21)");
			//    string xpath_LeftClickMenuItemmiLimsLosU_39_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Menu[starts-with(@ClassName,\"WindowsForms10\")]/MenuItem[@Name=\"miLimsLosUnfinishedClassic\"]";
			//    var winElem_LeftClickMenuItemmiLimsLosU_39_21 = root.FindByXPath(xpath_LeftClickMenuItemmiLimsLosU_39_21);
			//    if (winElem_LeftClickMenuItemmiLimsLosU_39_21 != null)
			//    {
			//        winElem_LeftClickMenuItemmiLimsLosU_39_21.Click();
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickMenuItemmiLimsLosU_39_21}");
			//        return;
			//    }


			//    // LeftClick on DataItem "Èíslo protokolu row3" at (43,13)
			//    Console.WriteLine("LeftClick on DataItem \"Èíslo protokolu row3\" at (43,13)");
			//    string xpath_LeftClickDataItemÈísloproto_43_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmLimsLosUnfinishedClassic\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam zakázek\"][@AutomationId=\"tpList\"]/Pane[starts-with(@AutomationId,\"ucLimsLoListClassic\")]/Table[@AutomationId=\"gridLos\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 4\"]/DataItem[@Name=\"Èíslo protokolu row3\"]";
			//    var winElem_LeftClickDataItemÈísloproto_43_13 = root.FindByXPath(xpath_LeftClickDataItemÈísloproto_43_13);
			//    if (winElem_LeftClickDataItemÈísloproto_43_13 != null)
			//    {
			//        winElem_LeftClickDataItemÈísloproto_43_13.Click();
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈísloproto_43_13}");
			//        return;
			//    }


			//    // LeftClick on Button "Editovat" at (7,19)
			//    Console.WriteLine("LeftClick on Button \"Editovat\" at (7,19)");
			//    string xpath_LeftClickButtonEditovat_7_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmLimsLosUnfinishedClassic\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"1552/2020\"]/Pane[@AutomationId=\"ucLimsLoTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucLimsLoDetail\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
			//    var winElem_LeftClickButtonEditovat_7_19 = root.FindByXPath(xpath_LeftClickButtonEditovat_7_19);
			//    if (winElem_LeftClickButtonEditovat_7_19 != null)
			//    {
			//        winElem_LeftClickButtonEditovat_7_19.Click();
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_7_19}");
			//        return;
			//    }


			//    // LeftClick on Edit "" at (439,29)
			//    Console.WriteLine("LeftClick on Edit \"\" at (439,29)");
			//    string xpath_LeftClickEdit_439_29 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmLimsLosUnfinishedClassic\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"1552/2020\"]/Pane[@AutomationId=\"ucLimsLoTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucLimsLoDetail\"]/Pane[@AutomationId=\"panelDetailTypeWrap\"]/Pane[@Name=\"panelDetailType\"][@AutomationId=\"panelDetailType\"]/Pane[@AutomationId=\"da\"]/Pane[@AutomationId=\"memoNote\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			//    var winElem_LeftClickEdit_439_29 = root.FindByXPath(xpath_LeftClickEdit_439_29);
			//    if (winElem_LeftClickEdit_439_29 != null)
			//    {
			//        winElem_LeftClickEdit_439_29.Click();
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_439_29}");
			//        return;
			//    }


			//    // KeyboardInput VirtualKeys="Keys.NumberPad1 + Keys.NumberPad1Keys.NumberPad5 + Keys.NumberPad5Keys.NumberPad3 + Keys.NumberPad3" CapsLock=False NumLock=True ScrollLock=False
			//    Console.WriteLine("KeyboardInput VirtualKeys=\"Keys.NumberPad1 + Keys.NumberPad1Keys.NumberPad5 + Keys.NumberPad5Keys.NumberPad3 + Keys.NumberPad3\" CapsLock=False NumLock=True ScrollLock=False");
			//    System.Threading.Thread.Sleep(100);
			//    winElem_LeftClickEdit_439_29.SendKeys(Keys.NumberPad1 + Keys.NumberPad1);
			//    winElem_LeftClickEdit_439_29.SendKeys(Keys.NumberPad5 + Keys.NumberPad5);
			//    winElem_LeftClickEdit_439_29.SendKeys(Keys.NumberPad3 + Keys.NumberPad3);


			//    // LeftClick on Button "Uložit" at (54,6)
			//    Console.WriteLine("LeftClick on Button \"Uložit\" at (54,6)");
			//    string xpath_LeftClickButtonUložit_54_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmLimsLosUnfinishedClassic\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"1552/2020\"]/Pane[@AutomationId=\"ucLimsLoTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucLimsLoDetail\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
			//    var winElem_LeftClickButtonUložit_54_6 = root.FindByXPath(xpath_LeftClickButtonUložit_54_6);
			//    if (winElem_LeftClickButtonUložit_54_6 != null)
			//    {
			//        winElem_LeftClickButtonUložit_54_6.Click();
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_54_6}");
			//        return;
			//    }


			//    // LeftClick on Button "Ukonèit" at (15,10)
			//    Console.WriteLine("LeftClick on Button \"Ukonèit\" at (15,10)");
			//    string xpath_LeftClickButtonUkonèit_15_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmLimsLosUnfinishedClassic\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"1552/2020\"]/Pane[@AutomationId=\"ucLimsLoTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucLimsLoDetail\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukonèit\"]";
			//    var winElem_LeftClickButtonUkonèit_15_10 = root.FindByXPath(xpath_LeftClickButtonUkonèit_15_10);
			//    if (winElem_LeftClickButtonUkonèit_15_10 != null)
			//    {
			//        winElem_LeftClickButtonUkonèit_15_10.Click();
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_15_10}");
			//        return;
			//    }


			//    // LeftClick on Hyperlink "R: Klasické testy" at (164,17)
			//    Console.WriteLine("LeftClick on Hyperlink \"R: Klasické testy\" at (164,17)");
			//    string xpath_LeftClickHyperlinkRKlasickét_164_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[@AutomationId=\"tlpNavBar\"]/Pane[@Name=\"navBarControl1\"][@AutomationId=\"nbcTabs\"]/Group[@Name=\"Navigace\"]/Hyperlink[@Name=\"R: Klasické testy\"]";
			//    var winElem_LeftClickHyperlinkRKlasickét_164_17 = root.FindByXPath(xpath_LeftClickHyperlinkRKlasickét_164_17);
			//    if (winElem_LeftClickHyperlinkRKlasickét_164_17 != null)
			//    {
			//        winElem_LeftClickHyperlinkRKlasickét_164_17.Click();
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickHyperlinkRKlasickét_164_17}");
			//        return;
			//    }
		}


		[TestMethod]
		public void TestMethod2()
		{
			// Sekne se na hlavní MJ protože už jedna taková položka v systému je

			// LeftClick on Button "miBasicData" at (45,13)
			Console.WriteLine("LeftClick on Button \"miBasicData\" at (45,13)");
			var winElem_LeftClickButtonmiBasicDat_45_13 = root.FindByName("miBasicData");
			if (winElem_LeftClickButtonmiBasicDat_45_13 != null)
			{
				winElem_LeftClickButtonmiBasicDat_45_13.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element named: miBasicData");
				return;
			}


			// LeftClick on MenuItem "miAdmMaterialCards" at (43,16)
			Console.WriteLine("LeftClick on MenuItem \"miAdmMaterialCards\" at (43,16)");
			string xpath_LeftClickMenuItemmiAdmMater_43_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Menu[starts-with(@ClassName,\"WindowsForms10\")]/MenuItem[@Name=\"miAdmMaterialCards\"]";
			var winElem_LeftClickMenuItemmiAdmMater_43_16 = root.FindByName("miAdmMaterialCards");
			if (winElem_LeftClickMenuItemmiAdmMater_43_16 != null)
			{
				winElem_LeftClickMenuItemmiAdmMater_43_16.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickMenuItemmiAdmMater_43_16}");
				return;
			}

			// LeftClick on DataItem "Èíslo materiálu row2" at (31,7)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row2\" at (31,7)");
			string xpath_LeftClickDataItemÈíslomater_31_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 3\"]/DataItem[@Name=\"Èíslo materiálu row2\"]";
			var winElem_LeftClickDataItemÈíslomater_31_7 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_31_7);
			if (winElem_LeftClickDataItemÈíslomater_31_7 != null)
			{
				winElem_LeftClickDataItemÈíslomater_31_7.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_31_7}");
				return;
			}

			// LeftClick on Button "Zavøít" at (20,11)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (20,11)");
			string xpath_LeftClickButtonZavøít_20_11 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{winElem_LeftClickDataItemÈíslomater_31_7.Text}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
			var winElem_LeftClickButtonZavøít_20_11 = root.FindByAccessibilityId("btnClose_Click");
			if (winElem_LeftClickButtonZavøít_20_11 != null)
			{
				winElem_LeftClickButtonZavøít_20_11.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_20_11}");
				return;
			}

			if (!createMaterialCard())
			{
				return;
			}


			// LeftClick on DataItem "Èíslo materiálu filter row" at (44,10)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu filter row\" at (44,10)");
			string xpath_LeftClickDataItemÈíslomater_44_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Øádek filtru\"]/DataItem[@Name=\"Èíslo materiálu filter row\"]";
			var winElem_LeftClickDataItemÈíslomater_44_10 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_44_10);
			if (winElem_LeftClickDataItemÈíslomater_44_10 != null)
			{
				winElem_LeftClickDataItemÈíslomater_44_10.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_44_10}");
				return;
			}

			winElem_LeftClickDataItemÈíslomater_44_10.SendKeys(Keys.NumberPad1);
			winElem_LeftClickDataItemÈíslomater_44_10.SendKeys(Keys.NumberPad0);
			winElem_LeftClickDataItemÈíslomater_44_10.SendKeys(Keys.NumberPad0);

			//if (!copyMaterializeCard())
			//{
			//	return;
			//}

			//if (!editingMaterialCard())
			//{
			//	return;
			//}

			//if (!editingUnits())
			//{
			//	return;
			//}


			//editingFirms();


			//creatingMaterial();


			//editingMaterial();


			//creatingParams();


			//creatingIdent();


			//creatingReg();


			//statesOfMaterializeCard();


			//deleteMaterializeCard();

			/*
            // LeftClick on DataItem "Èíslo materiálu row8" at (53,12)
            Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row8\" at (53,12)");
            string xpath_LeftClickDataItemÈíslomater_53_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 9\"]/DataItem[@Name=\"Èíslo materiálu row8\"]";
            var winElem_LeftClickDataItemÈíslomater_53_12 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_53_12);
            if (winElem_LeftClickDataItemÈíslomater_53_12 != null)
            {
                winElem_LeftClickDataItemÈíslomater_53_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_53_12}");
                return;
            }


            // LeftClick on Button "Zneplatnit" at (60,19)
            Console.WriteLine("LeftClick on Button \"Zneplatnit\" at (60,19)");
            string xpath_LeftClickButtonZneplatnit_60_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"102\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zneplatnit\"][@AutomationId=\"btnSetInvalid_Click\"]";
            var winElem_LeftClickButtonZneplatnit_60_19 = root.FindByXPath(xpath_LeftClickButtonZneplatnit_60_19);
            if (winElem_LeftClickButtonZneplatnit_60_19 != null)
            {
                winElem_LeftClickButtonZneplatnit_60_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZneplatnit_60_19}");
                return;
            }


            // LeftClick on Button "Ano" at (37,6)
            Console.WriteLine("LeftClick on Button \"Ano\" at (37,6)");
            string xpath_LeftClickButtonAno_37_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Zneplatnìní materiálové karty\"][@AutomationId=\"mbMC_ChangeMaterialCardStateConseqDialog\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"Ano\"][@AutomationId=\"BtnYes\"]";
            var winElem_LeftClickButtonAno_37_6 = root.FindByXPath(xpath_LeftClickButtonAno_37_6);
            if (winElem_LeftClickButtonAno_37_6 != null)
            {
                winElem_LeftClickButtonAno_37_6.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_37_6}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (151,9)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (151,9)");
            string xpath_LeftClickEditPasswordTe_151_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_151_9 = root.FindByXPath(xpath_LeftClickEditPasswordTe_151_9);
            if (winElem_LeftClickEditPasswordTe_151_9 != null)
            {
                winElem_LeftClickEditPasswordTe_151_9.Click();
                winElem_LeftClickEditPasswordTe_151_9.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_151_9}");
                return;
            }

            */
			// Tohle si dobøe rozmysli
			/*
            // LeftClick on Button "OK" at (48,17)
            Console.WriteLine("LeftClick on Button \"OK\" at (48,17)");
            string xpath_LeftClickButtonOK_48_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_48_17 = root.FindByXPath(xpath_LeftClickButtonOK_48_17);
            if (winElem_LeftClickButtonOK_48_17 != null)
            {
                winElem_LeftClickButtonOK_48_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_48_17}");
                return;
            }
            */

		}

		private static void statesOfMaterializeCard()
		{
			/*
            // LeftClick on Edit "Editing control" at (13,11)
            Console.WriteLine("LeftClick on Edit \"Editing control\" at (13,11)");
            string xpath_LeftClickEditEditingcon_13_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editing control\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editing control\"]";
            var winElem_LeftClickEditEditingcon_13_11 = root.FindByXPath(xpath_LeftClickEditEditingcon_13_11);
            if (winElem_LeftClickEditEditingcon_13_11 != null)
            {
                winElem_LeftClickEditEditingcon_13_11.Click();
                winElem_LeftClickEditEditingcon_13_11.SendKeys(Keys.NumberPad1);
                winElem_LeftClickEditEditingcon_13_11.SendKeys(Keys.NumberPad0);
                winElem_LeftClickEditEditingcon_13_11.SendKeys(Keys.NumberPad0);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditEditingcon_13_11}");
                return;
            }
            */

			// LeftClick on DataItem "Èíslo materiálu row0" at (40,8)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (40,8)");
			string xpath_LeftClickDataItemÈíslomater_40_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_40_8 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_40_8);
			if (winElem_LeftClickDataItemÈíslomater_40_8 != null)
			{
				winElem_LeftClickDataItemÈíslomater_40_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_40_8}");
				return;
			}


			// LeftClick on Button "K ovìøení" at (65,2)
			Console.WriteLine("LeftClick on Button \"K ovìøení\" at (65,2)");
			string xpath_LeftClickButtonKovìøení_65_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"K ovìøení\"]";
			var winElem_LeftClickButtonKovìøení_65_2 = root.FindByXPath(xpath_LeftClickButtonKovìøení_65_2);
			if (winElem_LeftClickButtonKovìøení_65_2 != null)
			{
				winElem_LeftClickButtonKovìøení_65_2.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKovìøení_65_2}");
				return;
			}


			// LeftClick on Button "Storno" at (39,9)
			Console.WriteLine("LeftClick on Button \"Storno\" at (39,9)");
			string xpath_LeftClickButtonStorno_39_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"Storno\"][@AutomationId=\"btnCancel\"]";
			var winElem_LeftClickButtonStorno_39_9 = root.FindByXPath(xpath_LeftClickButtonStorno_39_9);
			if (winElem_LeftClickButtonStorno_39_9 != null)
			{
				winElem_LeftClickButtonStorno_39_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_39_9}");
				return;
			}


			// LeftClick on Button "K ovìøení" at (46,15)
			Console.WriteLine("LeftClick on Button \"K ovìøení\" at (46,15)");
			string xpath_LeftClickButtonKovìøení_46_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"K ovìøení\"]";
			var winElem_LeftClickButtonKovìøení_46_15 = root.FindByXPath(xpath_LeftClickButtonKovìøení_46_15);
			if (winElem_LeftClickButtonKovìøení_46_15 != null)
			{
				winElem_LeftClickButtonKovìøení_46_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKovìøení_46_15}");
				return;
			}


			// LeftClick on Edit "PasswordTextEdit" at (26,7)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (26,7)");
			string xpath_LeftClickEditPasswordTe_26_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
			var winElem_LeftClickEditPasswordTe_26_7 = root.FindByXPath(xpath_LeftClickEditPasswordTe_26_7);
			if (winElem_LeftClickEditPasswordTe_26_7 != null)
			{
				winElem_LeftClickEditPasswordTe_26_7.Click();
				winElem_LeftClickEditPasswordTe_26_7.SendKeys("mesbrno");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_26_7}");
				return;
			}


			// LeftClick on Button "OK" at (41,14)
			Console.WriteLine("LeftClick on Button \"OK\" at (41,14)");
			string xpath_LeftClickButtonOK_41_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_41_14 = root.FindByXPath(xpath_LeftClickButtonOK_41_14);
			if (winElem_LeftClickButtonOK_41_14 != null)
			{
				winElem_LeftClickButtonOK_41_14.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_41_14}");
				return;
			}


			// LeftClick on Button "Zamítnout" at (47,5)
			Console.WriteLine("LeftClick on Button \"Zamítnout\" at (47,5)");
			string xpath_LeftClickButtonZamítnout_47_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zamítnout\"]";
			var winElem_LeftClickButtonZamítnout_47_5 = root.FindByXPath(xpath_LeftClickButtonZamítnout_47_5);
			if (winElem_LeftClickButtonZamítnout_47_5 != null)
			{
				winElem_LeftClickButtonZamítnout_47_5.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZamítnout_47_5}");
				return;
			}


			// LeftClick on Edit "PasswordTextEdit" at (87,14)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (87,14)");
			string xpath_LeftClickEditPasswordTe_87_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
			var winElem_LeftClickEditPasswordTe_87_14 = root.FindByXPath(xpath_LeftClickEditPasswordTe_87_14);
			if (winElem_LeftClickEditPasswordTe_87_14 != null)
			{
				winElem_LeftClickEditPasswordTe_87_14.Click();
				winElem_LeftClickEditPasswordTe_87_14.SendKeys("mesbrno");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_87_14}");
				return;
			}


			// LeftClick on Button "OK" at (15,6)
			Console.WriteLine("LeftClick on Button \"OK\" at (15,6)");
			string xpath_LeftClickButtonOK_15_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_15_6 = root.FindByXPath(xpath_LeftClickButtonOK_15_6);
			if (winElem_LeftClickButtonOK_15_6 != null)
			{
				winElem_LeftClickButtonOK_15_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_15_6}");
				return;
			}


			// LeftClick on Button "K ovìøení" at (41,18)
			Console.WriteLine("LeftClick on Button \"K ovìøení\" at (41,18)");
			string xpath_LeftClickButtonKovìøení_41_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"K ovìøení\"]";
			var winElem_LeftClickButtonKovìøení_41_18 = root.FindByXPath(xpath_LeftClickButtonKovìøení_41_18);
			if (winElem_LeftClickButtonKovìøení_41_18 != null)
			{
				winElem_LeftClickButtonKovìøení_41_18.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKovìøení_41_18}");
				return;
			}


			// LeftClick on Edit "PasswordTextEdit" at (118,1)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (118,1)");
			string xpath_LeftClickEditPasswordTe_118_1 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
			var winElem_LeftClickEditPasswordTe_118_1 = root.FindByXPath(xpath_LeftClickEditPasswordTe_118_1);
			if (winElem_LeftClickEditPasswordTe_118_1 != null)
			{
				winElem_LeftClickEditPasswordTe_118_1.Click();
				winElem_LeftClickEditPasswordTe_118_1.SendKeys("mesbrno");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_118_1}");
				return;
			}


			// LeftClick on Button "OK" at (28,6)
			Console.WriteLine("LeftClick on Button \"OK\" at (28,6)");
			string xpath_LeftClickButtonOK_28_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_28_6 = root.FindByXPath(xpath_LeftClickButtonOK_28_6);
			if (winElem_LeftClickButtonOK_28_6 != null)
			{
				winElem_LeftClickButtonOK_28_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_28_6}");
				return;
			}


			// LeftClick on Button "Ovìøit" at (60,15)
			Console.WriteLine("LeftClick on Button \"Ovìøit\" at (60,15)");
			string xpath_LeftClickButtonOvìøit_60_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ovìøit\"]";
			var winElem_LeftClickButtonOvìøit_60_15 = root.FindByXPath(xpath_LeftClickButtonOvìøit_60_15);
			if (winElem_LeftClickButtonOvìøit_60_15 != null)
			{
				winElem_LeftClickButtonOvìøit_60_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOvìøit_60_15}");
				return;
			}


			// LeftClick on Button "Storno" at (20,2)
			Console.WriteLine("LeftClick on Button \"Storno\" at (20,2)");
			string xpath_LeftClickButtonStorno_20_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"Storno\"][@AutomationId=\"btnCancel\"]";
			var winElem_LeftClickButtonStorno_20_2 = root.FindByXPath(xpath_LeftClickButtonStorno_20_2);
			if (winElem_LeftClickButtonStorno_20_2 != null)
			{
				winElem_LeftClickButtonStorno_20_2.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_20_2}");
				return;
			}


			// LeftClick on Button "Ovìøit" at (50,6)
			Console.WriteLine("LeftClick on Button \"Ovìøit\" at (50,6)");
			string xpath_LeftClickButtonOvìøit_50_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ovìøit\"]";
			var winElem_LeftClickButtonOvìøit_50_6 = root.FindByXPath(xpath_LeftClickButtonOvìøit_50_6);
			if (winElem_LeftClickButtonOvìøit_50_6 != null)
			{
				winElem_LeftClickButtonOvìøit_50_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOvìøit_50_6}");
				return;
			}


			// LeftClick on Edit "PasswordTextEdit" at (168,9)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (168,9)");
			string xpath_LeftClickEditPasswordTe_168_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
			var winElem_LeftClickEditPasswordTe_168_9 = root.FindByXPath(xpath_LeftClickEditPasswordTe_168_9);
			if (winElem_LeftClickEditPasswordTe_168_9 != null)
			{
				winElem_LeftClickEditPasswordTe_168_9.Click();
				winElem_LeftClickEditPasswordTe_168_9.SendKeys("mesbrno");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_168_9}");
				return;
			}


			// LeftClick on Button "OK" at (83,14)
			Console.WriteLine("LeftClick on Button \"OK\" at (83,14)");
			string xpath_LeftClickButtonOK_83_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_83_14 = root.FindByXPath(xpath_LeftClickButtonOK_83_14);
			if (winElem_LeftClickButtonOK_83_14 != null)
			{
				winElem_LeftClickButtonOK_83_14.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_83_14}");
				return;
			}


			// LeftClick on Button "Zamítnout" at (18,20)
			Console.WriteLine("LeftClick on Button \"Zamítnout\" at (18,20)");
			string xpath_LeftClickButtonZamítnout_18_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zamítnout\"]";
			var winElem_LeftClickButtonZamítnout_18_20 = root.FindByXPath(xpath_LeftClickButtonZamítnout_18_20);
			if (winElem_LeftClickButtonZamítnout_18_20 != null)
			{
				winElem_LeftClickButtonZamítnout_18_20.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZamítnout_18_20}");
				return;
			}


			// LeftClick on Edit "PasswordTextEdit" at (102,0)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (102,0)");
			string xpath_LeftClickEditPasswordTe_102_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
			var winElem_LeftClickEditPasswordTe_102_0 = root.FindByXPath(xpath_LeftClickEditPasswordTe_102_0);
			if (winElem_LeftClickEditPasswordTe_102_0 != null)
			{
				winElem_LeftClickEditPasswordTe_102_0.Click();
				winElem_LeftClickEditPasswordTe_102_0.SendKeys("mesbrno");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_102_0}");
				return;
			}


			// LeftClick on Button "OK" at (52,4)
			Console.WriteLine("LeftClick on Button \"OK\" at (52,4)");
			string xpath_LeftClickButtonOK_52_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_52_4 = root.FindByXPath(xpath_LeftClickButtonOK_52_4);
			if (winElem_LeftClickButtonOK_52_4 != null)
			{
				winElem_LeftClickButtonOK_52_4.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_52_4}");
				return;
			}


			// LeftClick on Button "Ovìøit" at (64,4)
			Console.WriteLine("LeftClick on Button \"Ovìøit\" at (64,4)");
			string xpath_LeftClickButtonOvìøit_64_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ovìøit\"]";
			var winElem_LeftClickButtonOvìøit_64_4 = root.FindByXPath(xpath_LeftClickButtonOvìøit_64_4);
			if (winElem_LeftClickButtonOvìøit_64_4 != null)
			{
				winElem_LeftClickButtonOvìøit_64_4.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOvìøit_64_4}");
				return;
			}


			// LeftClick on Edit "PasswordTextEdit" at (245,0)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (245,0)");
			string xpath_LeftClickEditPasswordTe_245_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]";
			var winElem_LeftClickEditPasswordTe_245_0 = root.FindByXPath(xpath_LeftClickEditPasswordTe_245_0);
			if (winElem_LeftClickEditPasswordTe_245_0 != null)
			{
				winElem_LeftClickEditPasswordTe_245_0.Click();
				winElem_LeftClickEditPasswordTe_245_0.SendKeys("mesbrno");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_245_0}");
				return;
			}


			// LeftClick on Button "OK" at (93,5)
			Console.WriteLine("LeftClick on Button \"OK\" at (93,5)");
			string xpath_LeftClickButtonOK_93_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_93_5 = root.FindByXPath(xpath_LeftClickButtonOK_93_5);
			if (winElem_LeftClickButtonOK_93_5 != null)
			{
				winElem_LeftClickButtonOK_93_5.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_93_5}");
				return;
			}


			// LeftClick on Button "Schválit" at (47,21)
			Console.WriteLine("LeftClick on Button \"Schválit\" at (47,21)");
			string xpath_LeftClickButtonSchválit_47_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Schválit\"]";
			var winElem_LeftClickButtonSchválit_47_21 = root.FindByXPath(xpath_LeftClickButtonSchválit_47_21);
			if (winElem_LeftClickButtonSchválit_47_21 != null)
			{
				winElem_LeftClickButtonSchválit_47_21.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSchválit_47_21}");
				return;
			}


			// LeftClick on Edit "PasswordTextEdit" at (120,9)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (120,9)");
			string xpath_LeftClickEditPasswordTe_120_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
			var winElem_LeftClickEditPasswordTe_120_9 = root.FindByXPath(xpath_LeftClickEditPasswordTe_120_9);
			if (winElem_LeftClickEditPasswordTe_120_9 != null)
			{
				System.Threading.Thread.Sleep(1000);
				winElem_LeftClickEditPasswordTe_120_9.Click();
				winElem_LeftClickEditPasswordTe_120_9.SendKeys("mesbrno");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_120_9}");
				return;
			}


			// LeftClick on Button "OK" at (80,14)
			Console.WriteLine("LeftClick on Button \"OK\" at (80,14)");
			string xpath_LeftClickButtonOK_80_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_80_14 = root.FindByXPath(xpath_LeftClickButtonOK_80_14);
			if (winElem_LeftClickButtonOK_80_14 != null)
			{
				winElem_LeftClickButtonOK_80_14.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_80_14}");
				return;
			}


			// LeftClick on Button "Vydat" at (49,10)
			Console.WriteLine("LeftClick on Button \"Vydat\" at (49,10)");
			string xpath_LeftClickButtonVydat_49_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Vydat\"]";
			var winElem_LeftClickButtonVydat_49_10 = root.FindByXPath(xpath_LeftClickButtonVydat_49_10);
			if (winElem_LeftClickButtonVydat_49_10 != null)
			{
				winElem_LeftClickButtonVydat_49_10.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonVydat_49_10}");
				return;
			}


			// LeftClick on Button "OK" at (36,14)
			Console.WriteLine("LeftClick on Button \"OK\" at (36,14)");
			string xpath_LeftClickButtonOK_36_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vydání\"][@AutomationId=\"mbDeferredValidity\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_36_14 = root.FindByXPath(xpath_LeftClickButtonOK_36_14);
			if (winElem_LeftClickButtonOK_36_14 != null)
			{
				winElem_LeftClickButtonOK_36_14.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_36_14}");
				return;
			}


			// LeftClick on Button "Storno" at (65,14)
			Console.WriteLine("LeftClick on Button \"Storno\" at (65,14)");
			string xpath_LeftClickButtonStorno_65_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"Storno\"][@AutomationId=\"btnCancel\"]";
			var winElem_LeftClickButtonStorno_65_14 = root.FindByXPath(xpath_LeftClickButtonStorno_65_14);
			if (winElem_LeftClickButtonStorno_65_14 != null)
			{
				winElem_LeftClickButtonStorno_65_14.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_65_14}");
				return;
			}


			// LeftClick on Button "Vydat" at (50,22)
			Console.WriteLine("LeftClick on Button \"Vydat\" at (50,22)");
			string xpath_LeftClickButtonVydat_50_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Vydat\"]";
			var winElem_LeftClickButtonVydat_50_22 = root.FindByXPath(xpath_LeftClickButtonVydat_50_22);
			if (winElem_LeftClickButtonVydat_50_22 != null)
			{
				winElem_LeftClickButtonVydat_50_22.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonVydat_50_22}");
				return;
			}


			// LeftClick on Button "OK" at (50,20)
			Console.WriteLine("LeftClick on Button \"OK\" at (50,20)");
			string xpath_LeftClickButtonOK_50_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vydání\"][@AutomationId=\"mbDeferredValidity\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_50_20 = root.FindByXPath(xpath_LeftClickButtonOK_50_20);
			if (winElem_LeftClickButtonOK_50_20 != null)
			{
				winElem_LeftClickButtonOK_50_20.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_50_20}");
				return;
			}


			// LeftClick on Edit "PasswordTextEdit" at (107,5)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (107,5)");
			string xpath_LeftClickEditPasswordTe_107_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
			var winElem_LeftClickEditPasswordTe_107_5 = root.FindByXPath(xpath_LeftClickEditPasswordTe_107_5);
			if (winElem_LeftClickEditPasswordTe_107_5 != null)
			{
				winElem_LeftClickEditPasswordTe_107_5.Click();
				winElem_LeftClickEditPasswordTe_107_5.SendKeys("mesbrno");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_107_5}");
				return;
			}


			// LeftClick on Button "OK" at (76,6)
			Console.WriteLine("LeftClick on Button \"OK\" at (76,6)");
			string xpath_LeftClickButtonOK_76_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_76_6 = root.FindByXPath(xpath_LeftClickButtonOK_76_6);
			if (winElem_LeftClickButtonOK_76_6 != null)
			{
				winElem_LeftClickButtonOK_76_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_76_6}");
				return;
			}


			// LeftClick on Button "Zneplatnit" at (58,15)
			Console.WriteLine("LeftClick on Button \"Zneplatnit\" at (58,15)");
			string xpath_LeftClickButtonZneplatnit_58_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zneplatnit\"]";
			var winElem_LeftClickButtonZneplatnit_58_15 = root.FindByXPath(xpath_LeftClickButtonZneplatnit_58_15);
			if (winElem_LeftClickButtonZneplatnit_58_15 != null)
			{
				winElem_LeftClickButtonZneplatnit_58_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZneplatnit_58_15}");
				return;
			}


			// LeftClick on Button "Ano" at (59,9)
			Console.WriteLine("LeftClick on Button \"Ano\" at (59,9)");
			string xpath_LeftClickButtonAno_59_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Zneplatnìní materiálové karty\"][@AutomationId=\"mbMC_ChangeMaterialCardStateConseqDialog\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"Ano\"][@AutomationId=\"BtnYes\"]";
			var winElem_LeftClickButtonAno_59_9 = root.FindByXPath(xpath_LeftClickButtonAno_59_9);
			if (winElem_LeftClickButtonAno_59_9 != null)
			{
				winElem_LeftClickButtonAno_59_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_59_9}");
				return;
			}


			// LeftClick on Edit "PasswordTextEdit" at (121,9)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (121,9)");
			string xpath_LeftClickEditPasswordTe_121_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
			var winElem_LeftClickEditPasswordTe_121_9 = root.FindByXPath(xpath_LeftClickEditPasswordTe_121_9);
			if (winElem_LeftClickEditPasswordTe_121_9 != null)
			{
				winElem_LeftClickEditPasswordTe_121_9.Click();
				winElem_LeftClickEditPasswordTe_121_9.SendKeys("mesbrno");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_121_9}");
				return;
			}


			// LeftClick on Button "OK" at (69,15)
			Console.WriteLine("LeftClick on Button \"OK\" at (69,15)");
			string xpath_LeftClickButtonOK_69_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_69_15 = root.FindByXPath(xpath_LeftClickButtonOK_69_15);
			if (winElem_LeftClickButtonOK_69_15 != null)
			{
				winElem_LeftClickButtonOK_69_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_69_15}");
				return;
			}


			// LeftClick on Button "Zavøít" at (35,20)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (35,20)");
			string xpath_LeftClickButtonZavøít_35_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavøít\"]";
			var winElem_LeftClickButtonZavøít_35_20 = root.FindByXPath(xpath_LeftClickButtonZavøít_35_20);
			if (winElem_LeftClickButtonZavøít_35_20 != null)
			{
				winElem_LeftClickButtonZavøít_35_20.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_35_20}");
				return;
			}



			//1.8

			// LeftClick on DataItem "Èíslo materiálu row0" at (22,17)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (22,17)");
			string xpath_LeftClickDataItemÈíslomater_22_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_22_17 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_22_17);
			if (winElem_LeftClickDataItemÈíslomater_22_17 != null)
			{
				winElem_LeftClickDataItemÈíslomater_22_17.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_22_17}");
				return;
			}


			// LeftClick on DataItem " row 6" at (59,25)
			Console.WriteLine("LeftClick on DataItem \" row 6\" at (59,25)");
			string xpath_LeftClickDataItemrow6_59_25 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel6\"]/DataItem[@Name=\" row 6\"]";
			var winElem_LeftClickDataItemrow6_59_25 = root.FindByXPath(xpath_LeftClickDataItemrow6_59_25);
			if (winElem_LeftClickDataItemrow6_59_25 != null)
			{
				winElem_LeftClickDataItemrow6_59_25.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow6_59_25}");
				return;
			}


			// LeftClick on DataItem " row 0" at (54,13)
			Console.WriteLine("LeftClick on DataItem \" row 0\" at (54,13)");
			string xpath_LeftClickDataItemrow0_54_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel0\"]/DataItem[@Name=\" row 0\"]";
			var winElem_LeftClickDataItemrow0_54_13 = root.FindByXPath(xpath_LeftClickDataItemrow0_54_13);
			if (winElem_LeftClickDataItemrow0_54_13 != null)
			{
				winElem_LeftClickDataItemrow0_54_13.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_54_13}");
				return;
			}


			// LeftClick on Button "Zavøít" at (24,12)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (24,12)");
			string xpath_LeftClickButtonZavøít_24_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
			var winElem_LeftClickButtonZavøít_24_12 = root.FindByXPath(xpath_LeftClickButtonZavøít_24_12);
			if (winElem_LeftClickButtonZavøít_24_12 != null)
			{
				winElem_LeftClickButtonZavøít_24_12.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_24_12}");
				return;
			}
		}

		private static void deleteMaterializeCard()
		{
			// LeftClick on DataItem "Èíslo materiálu row0" at (46,3)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (46,3)");
			string xpath_LeftClickDataItemÈíslomater_46_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_46_3 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_46_3);
			if (winElem_LeftClickDataItemÈíslomater_46_3 != null)
			{
				winElem_LeftClickDataItemÈíslomater_46_3.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_46_3}");
				return;
			}


			// LeftClick on Button "Smazat" at (46,14)
			Console.WriteLine("LeftClick on Button \"Smazat\" at (46,14)");
			string xpath_LeftClickButtonSmazat_46_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Smazat\"]";
			var winElem_LeftClickButtonSmazat_46_14 = root.FindByXPath(xpath_LeftClickButtonSmazat_46_14);
			if (winElem_LeftClickButtonSmazat_46_14 != null)
			{
				winElem_LeftClickButtonSmazat_46_14.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSmazat_46_14}");
				return;
			}


			// LeftClick on Button "&amp;Yes" at (47,9)
			Console.WriteLine("LeftClick on Button \"&amp;Yes\" at (47,9)");
			string xpath_LeftClickButtonYes_47_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Opravdu smazat?\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Yes\"]";
			var winElem_LeftClickButtonYes_47_9 = root.FindByXPath(xpath_LeftClickButtonYes_47_9);
			if (winElem_LeftClickButtonYes_47_9 != null)
			{
				winElem_LeftClickButtonYes_47_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonYes_47_9}");
				return;
			}
		}

		private static void creatingReg()
		{
			// LeftClick on DataItem "Èíslo materiálu row0" at (33,11)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (33,11)");
			string xpath_LeftClickDataItemÈíslomater_33_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_33_11 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_33_11);
			if (winElem_LeftClickDataItemÈíslomater_33_11 != null)
			{
				winElem_LeftClickDataItemÈíslomater_33_11.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_33_11}");
				return;
			}


			// LeftClick on DataItem " row 5" at (65,12)
			Console.WriteLine("LeftClick on DataItem \" row 5\" at (65,12)");
			string xpath_LeftClickDataItemrow5_65_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node5\"]/DataItem[@Name=\" row 5\"]";
			var winElem_LeftClickDataItemrow5_65_12 = root.FindByXPath(xpath_LeftClickDataItemrow5_65_12);
			if (winElem_LeftClickDataItemrow5_65_12 != null)
			{
				winElem_LeftClickDataItemrow5_65_12.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow5_65_12}");
				return;
			}


			// LeftClick on Button "Editovat" at (27,8)
			Console.WriteLine("LeftClick on Button \"Editovat\" at (27,8)");
			string xpath_LeftClickButtonEditovat_27_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
			var winElem_LeftClickButtonEditovat_27_8 = root.FindByXPath(xpath_LeftClickButtonEditovat_27_8);
			if (winElem_LeftClickButtonEditovat_27_8 != null)
			{
				winElem_LeftClickButtonEditovat_27_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_27_8}");
				return;
			}


			// LeftClick on Edit "" at (289,0)
			Console.WriteLine("LeftClick on Edit \"\" at (289,0)");
			string xpath_LeftClickEdit_289_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Edit[@AutomationId=\"txtRegionCode\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_289_0 = root.FindByXPath(xpath_LeftClickEdit_289_0);
			if (winElem_LeftClickEdit_289_0 != null)
			{
				winElem_LeftClickEdit_289_0.Click();
				winElem_LeftClickEdit_289_0.SendKeys("e");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_289_0}");
				return;
			}


			// LeftClick on Edit "" at (273,11)
			Console.WriteLine("LeftClick on Edit \"\" at (273,11)");
			string xpath_LeftClickEdit_273_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Edit[@AutomationId=\"txtCustomer\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_273_11 = root.FindByXPath(xpath_LeftClickEdit_273_11);
			if (winElem_LeftClickEdit_273_11 != null)
			{
				winElem_LeftClickEdit_273_11.Click();
				winElem_LeftClickEdit_273_11.SendKeys("e");

			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_273_11}");
				return;
			}


			// LeftClick on Pane "" at (12,3)
			Console.WriteLine("LeftClick on Pane \"\" at (12,3)");
			string xpath_LeftClickPane_12_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Pane[@AutomationId=\"deRegistrationDate\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickPane_12_3 = root.FindByXPath(xpath_LeftClickPane_12_3);
			if (winElem_LeftClickPane_12_3 != null)
			{
				winElem_LeftClickPane_12_3.Click();
				winElem_LeftClickPane_12_3.SendKeys(Keys.NumberPad0);
				winElem_LeftClickPane_12_3.SendKeys(Keys.NumberPad7);
				winElem_LeftClickPane_12_3.SendKeys(".");
				winElem_LeftClickPane_12_3.SendKeys(Keys.NumberPad0);
				winElem_LeftClickPane_12_3.SendKeys(Keys.NumberPad9);
				winElem_LeftClickPane_12_3.SendKeys(".");
				winElem_LeftClickPane_12_3.SendKeys(Keys.NumberPad2);
				winElem_LeftClickPane_12_3.SendKeys(Keys.NumberPad0);
				winElem_LeftClickPane_12_3.SendKeys(Keys.NumberPad2);
				winElem_LeftClickPane_12_3.SendKeys(Keys.NumberPad0);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_12_3}");
				return;
			}


			// LeftClick on Pane "" at (43,4)
			Console.WriteLine("LeftClick on Pane \"\" at (43,4)");
			string xpath_LeftClickPane_43_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"100\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Pane[@AutomationId=\"deRegistredTo\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickPane_43_4 = root.FindByXPath(xpath_LeftClickPane_43_4);
			if (winElem_LeftClickPane_43_4 != null)
			{
				winElem_LeftClickPane_43_4.Click();
				winElem_LeftClickPane_43_4.SendKeys(Keys.NumberPad0);
				winElem_LeftClickPane_43_4.SendKeys(Keys.NumberPad9);
				winElem_LeftClickPane_43_4.SendKeys(".");
				winElem_LeftClickPane_43_4.SendKeys(Keys.NumberPad0);
				winElem_LeftClickPane_43_4.SendKeys(Keys.NumberPad9);
				winElem_LeftClickPane_43_4.SendKeys(".");
				winElem_LeftClickPane_43_4.SendKeys(Keys.NumberPad2);
				winElem_LeftClickPane_43_4.SendKeys(Keys.NumberPad0);
				winElem_LeftClickPane_43_4.SendKeys(Keys.NumberPad2);
				winElem_LeftClickPane_43_4.SendKeys(Keys.NumberPad0);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_43_4}");
				return;
			}


			// LeftClick on Edit "" at (107,7)
			Console.WriteLine("LeftClick on Edit \"\" at (107,7)");
			string xpath_LeftClickEdit_107_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Edit[@AutomationId=\"txtRegistrationNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_107_7 = root.FindByXPath(xpath_LeftClickEdit_107_7);
			if (winElem_LeftClickEdit_107_7 != null)
			{
				winElem_LeftClickEdit_107_7.Click();
				winElem_LeftClickEdit_107_7.SendKeys("e");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_107_7}");
				return;
			}


			// LeftClick on Edit "" at (233,11)
			Console.WriteLine("LeftClick on Edit \"\" at (233,11)");
			string xpath_LeftClickEdit_233_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Edit[@AutomationId=\"txtBatchSize\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_233_11 = root.FindByXPath(xpath_LeftClickEdit_233_11);
			if (winElem_LeftClickEdit_233_11 != null)
			{
				winElem_LeftClickEdit_233_11.Click();
				winElem_LeftClickEdit_233_11.SendKeys("e");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_233_11}");
				return;
			}

			// LeftClick on Button "Up" at (8,8)
			Console.WriteLine("LeftClick on Button \"Up\" at (8,8)");
			string xpath_LeftClickButtonUp_8_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Edit[@Name=\"0\"][@AutomationId=\"txtNumberOfUnits\"]/Spinner[@Name=\"Spinner\"]/Button[@Name=\"Up\"]";
			var winElem_LeftClickButtonUp_8_8 = root.FindByXPath(xpath_LeftClickButtonUp_8_8);
			if (winElem_LeftClickButtonUp_8_8 != null)
			{
				winElem_LeftClickButtonUp_8_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUp_8_8}");
				return;
			}


			// LeftClick on Edit "" at (130,10)
			Console.WriteLine("LeftClick on Edit \"\" at (130,10)");
			string xpath_LeftClickEdit_130_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Edit[@AutomationId=\"txtSUKLCode\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_130_10 = root.FindByXPath(xpath_LeftClickEdit_130_10);
			if (winElem_LeftClickEdit_130_10 != null)
			{
				winElem_LeftClickEdit_130_10.Click();
				winElem_LeftClickEdit_130_10.SendKeys("e");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_130_10}");
				return;
			}


			// LeftClick on Button "Uložit" at (41,16)
			Console.WriteLine("LeftClick on Button \"Uložit\" at (41,16)");
			string xpath_LeftClickButtonUložit_41_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
			var winElem_LeftClickButtonUložit_41_16 = root.FindByXPath(xpath_LeftClickButtonUložit_41_16);
			if (winElem_LeftClickButtonUložit_41_16 != null)
			{
				winElem_LeftClickButtonUložit_41_16.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_41_16}");
				return;
			}


			// LeftClick on Button "Ukonèit" at (51,6)
			Console.WriteLine("LeftClick on Button \"Ukonèit\" at (51,6)");
			string xpath_LeftClickButtonUkonèit_51_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukonèit\"]";
			var winElem_LeftClickButtonUkonèit_51_6 = root.FindByXPath(xpath_LeftClickButtonUkonèit_51_6);
			if (winElem_LeftClickButtonUkonèit_51_6 != null)
			{
				winElem_LeftClickButtonUkonèit_51_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_51_6}");
				return;
			}


			// LeftClick on Button "Zavøít" at (31,16)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (31,16)");
			string xpath_LeftClickButtonZavøít_31_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavøít\"]";
			var winElem_LeftClickButtonZavøít_31_16 = root.FindByXPath(xpath_LeftClickButtonZavøít_31_16);
			if (winElem_LeftClickButtonZavøít_31_16 != null)
			{
				winElem_LeftClickButtonZavøít_31_16.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_31_16}");
				return;
			}
		}

		private static void creatingIdent()
		{
			// LeftClick on DataItem "Èíslo materiálu row0" at (15,2)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (15,2)");
			string xpath_LeftClickDataItemÈíslomater_15_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_15_2 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_15_2);
			if (winElem_LeftClickDataItemÈíslomater_15_2 != null)
			{
				winElem_LeftClickDataItemÈíslomater_15_2.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_15_2}");
				return;
			}


			// LeftClick on DataItem " row 4" at (46,15)
			Console.WriteLine("LeftClick on DataItem \" row 4\" at (46,15)");
			string xpath_LeftClickDataItemrow4_46_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node4\"]/DataItem[@Name=\" row 4\"]";
			var winElem_LeftClickDataItemrow4_46_15 = root.FindByXPath(xpath_LeftClickDataItemrow4_46_15);
			if (winElem_LeftClickDataItemrow4_46_15 != null)
			{
				winElem_LeftClickDataItemrow4_46_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow4_46_15}");
				return;
			}


			// LeftClick on Button "Editovat" at (1,13)
			Console.WriteLine("LeftClick on Button \"Editovat\" at (1,13)");
			string xpath_LeftClickButtonEditovat_1_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
			var winElem_LeftClickButtonEditovat_1_13 = root.FindByXPath(xpath_LeftClickButtonEditovat_1_13);
			if (winElem_LeftClickButtonEditovat_1_13 != null)
			{
				winElem_LeftClickButtonEditovat_1_13.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_1_13}");
				return;
			}


			// LeftClick on Edit "" at (27,10)
			Console.WriteLine("LeftClick on Edit \"\" at (27,10)");
			string xpath_LeftClickEdit_27_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelIdentification\"]/Edit[@AutomationId=\"txtChemicalName\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_27_10 = root.FindByXPath(xpath_LeftClickEdit_27_10);
			if (winElem_LeftClickEdit_27_10 != null)
			{
				winElem_LeftClickEdit_27_10.Click();
				winElem_LeftClickEdit_27_10.SendKeys("qwe");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_27_10}");
				return;
			}


			// LeftClick on Edit "" at (9,9)
			Console.WriteLine("LeftClick on Edit \"\" at (9,9)");
			string xpath_LeftClickEdit_9_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelIdentification\"]/Edit[@AutomationId=\"txtCAS\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_9_9 = root.FindByXPath(xpath_LeftClickEdit_9_9);
			if (winElem_LeftClickEdit_9_9 != null)
			{
				winElem_LeftClickEdit_9_9.Click();
				winElem_LeftClickEdit_9_9.SendKeys("qwe");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_9_9}");
				return;
			}


			// LeftClick on Edit "" at (58,7)
			Console.WriteLine("LeftClick on Edit \"\" at (58,7)");
			string xpath_LeftClickEdit_58_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelIdentification\"]/Edit[@AutomationId=\"txtMoleculeWeight\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_58_7 = root.FindByXPath(xpath_LeftClickEdit_58_7);
			if (winElem_LeftClickEdit_58_7 != null)
			{
				winElem_LeftClickEdit_58_7.Click();
				winElem_LeftClickEdit_58_7.SendKeys("qwe");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_58_7}");
				return;
			}


			// LeftClick on Edit "" at (614,8)
			Console.WriteLine("LeftClick on Edit \"\" at (614,8)");
			string xpath_LeftClickEdit_614_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelIdentification\"]/Edit[@AutomationId=\"txtMoleculeDescription\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_614_8 = root.FindByXPath(xpath_LeftClickEdit_614_8);
			if (winElem_LeftClickEdit_614_8 != null)
			{
				winElem_LeftClickEdit_614_8.Click();
				winElem_LeftClickEdit_614_8.SendKeys("qwe");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_614_8}");
				return;
			}


			// LeftClick on Button "..." at (6,9)
			Console.WriteLine("LeftClick on Button \"...\" at (6,9)");
			string xpath_LeftClickButton_6_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelIdentification\"]/Button[@Name=\"...\"][@AutomationId=\"btnPickImage\"]";
			var winElem_LeftClickButton_6_9 = root.FindByXPath(xpath_LeftClickButton_6_9);
			if (winElem_LeftClickButton_6_9 != null)
			{
				winElem_LeftClickButton_6_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_6_9}");
				return;
			}


			// LeftClick on Button "Close" at (13,15)
			Console.WriteLine("LeftClick on Button \"Close\" at (13,15)");
			string xpath_LeftClickButtonClose_13_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@ClassName=\"#32770\"][@Name=\"Open\"]/TitleBar[@AutomationId=\"TitleBar\"]/Button[@Name=\"Close\"]";
			var winElem_LeftClickButtonClose_13_15 = root.FindByXPath(xpath_LeftClickButtonClose_13_15);
			if (winElem_LeftClickButtonClose_13_15 != null)
			{
				winElem_LeftClickButtonClose_13_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonClose_13_15}");
				return;
			}


			// LeftClick on Button "Uložit" at (34,18)
			Console.WriteLine("LeftClick on Button \"Uložit\" at (34,18)");
			string xpath_LeftClickButtonUložit_34_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
			var winElem_LeftClickButtonUložit_34_18 = root.FindByXPath(xpath_LeftClickButtonUložit_34_18);
			if (winElem_LeftClickButtonUložit_34_18 != null)
			{
				winElem_LeftClickButtonUložit_34_18.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_34_18}");
				return;
			}


			// LeftClick on Button "Ukonèit" at (17,10)
			Console.WriteLine("LeftClick on Button \"Ukonèit\" at (17,10)");
			string xpath_LeftClickButtonUkonèit_17_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukonèit\"]";
			var winElem_LeftClickButtonUkonèit_17_10 = root.FindByXPath(xpath_LeftClickButtonUkonèit_17_10);
			if (winElem_LeftClickButtonUkonèit_17_10 != null)
			{
				winElem_LeftClickButtonUkonèit_17_10.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_17_10}");
				return;
			}


			// LeftClick on Button "Zavøít" at (30,15)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (30,15)");
			string xpath_LeftClickButtonZavøít_30_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavøít\"]";
			var winElem_LeftClickButtonZavøít_30_15 = root.FindByXPath(xpath_LeftClickButtonZavøít_30_15);
			if (winElem_LeftClickButtonZavøít_30_15 != null)
			{
				winElem_LeftClickButtonZavøít_30_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_30_15}");
				return;
			}
		}

		private static void creatingParams()
		{
			// LeftClick on DataItem "Èíslo materiálu row0" at (63,8)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (63,8)");
			string xpath_LeftClickDataItemÈíslomater_63_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_63_8 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_63_8);
			if (winElem_LeftClickDataItemÈíslomater_63_8 != null)
			{
				winElem_LeftClickDataItemÈíslomater_63_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_63_8}");
				return;
			}


			// LeftClick on DataItem " row 3" at (40,17)
			Console.WriteLine("LeftClick on DataItem \" row 3\" at (40,17)");
			string xpath_LeftClickDataItemrow3_40_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node3\"]/DataItem[@Name=\" row 3\"]";
			var winElem_LeftClickDataItemrow3_40_17 = root.FindByXPath(xpath_LeftClickDataItemrow3_40_17);
			if (winElem_LeftClickDataItemrow3_40_17 != null)
			{
				winElem_LeftClickDataItemrow3_40_17.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow3_40_17}");
				return;
			}


			// LeftClick on Button "Editovat" at (24,24)
			Console.WriteLine("LeftClick on Button \"Editovat\" at (24,24)");
			string xpath_LeftClickButtonEditovat_24_24 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
			var winElem_LeftClickButtonEditovat_24_24 = root.FindByXPath(xpath_LeftClickButtonEditovat_24_24);
			if (winElem_LeftClickButtonEditovat_24_24 != null)
			{
				winElem_LeftClickButtonEditovat_24_24.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_24_24}");
				return;
			}


			// LeftClick on CheckBox "GHS - akutní toxicita dermální" at (5,10)
			Console.WriteLine("LeftClick on CheckBox \"GHS - akutní toxicita dermální\" at (5,10)");
			string xpath_LeftClickCheckBoxGHSakutnít_5_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/List[@Name=\"GHS - akutní toxicita dermální\"][@AutomationId=\"clbClassifications\"]/CheckBox[@Name=\"GHS - akutní toxicita dermální\"]";
			var winElem_LeftClickCheckBoxGHSakutnít_5_10 = root.FindByXPath(xpath_LeftClickCheckBoxGHSakutnít_5_10);
			if (winElem_LeftClickCheckBoxGHSakutnít_5_10 != null)
			{
				winElem_LeftClickCheckBoxGHSakutnít_5_10.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxGHSakutnít_5_10}");
				return;
			}


			// LeftClick on DataItem "Hodnota row1" at (71,10)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row1\" at (71,10)");
			string xpath_LeftClickDataItemHodnotarow_71_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 4\"]/DataItem[@Name=\"Hodnota row1\"]";
			var winElem_LeftClickDataItemHodnotarow_71_10 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_71_10);
			if (winElem_LeftClickDataItemHodnotarow_71_10 != null)
			{
				winElem_LeftClickDataItemHodnotarow_71_10.Click();
				winElem_LeftClickDataItemHodnotarow_71_10.SendKeys(Keys.ArrowDown);
				winElem_LeftClickDataItemHodnotarow_71_10.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_71_10}");
				return;
			}


			// LeftClick on DataItem "Hodnota row0" at (53,15)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row0\" at (53,15)");
			string xpath_LeftClickDataItemHodnotarow_53_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 2\"]/DataItem[@Name=\"Hodnota row0\"]";
			var winElem_LeftClickDataItemHodnotarow_53_15 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_53_15);
			if (winElem_LeftClickDataItemHodnotarow_53_15 != null)
			{
				winElem_LeftClickDataItemHodnotarow_53_15.Click();
				winElem_LeftClickDataItemHodnotarow_53_15.SendKeys(Keys.ArrowDown);
				winElem_LeftClickDataItemHodnotarow_53_15.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_53_15}");
				return;
			}


			// LeftClick on DataItem "Hodnota row2" at (65,16)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row2\" at (65,16)");
			string xpath_LeftClickDataItemHodnotarow_65_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 5\"]/DataItem[@Name=\"Hodnota row2\"]";
			var winElem_LeftClickDataItemHodnotarow_65_16 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_65_16);
			if (winElem_LeftClickDataItemHodnotarow_65_16 != null)
			{
				winElem_LeftClickDataItemHodnotarow_65_16.Click();
				winElem_LeftClickDataItemHodnotarow_65_16.SendKeys(Keys.ArrowDown);
				winElem_LeftClickDataItemHodnotarow_65_16.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_65_16}");
				return;
			}


			// LeftClick on DataItem "Hodnota row3" at (56,13)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row3\" at (56,13)");
			string xpath_LeftClickDataItemHodnotarow_56_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 6\"]/DataItem[@Name=\"Hodnota row3\"]";
			var winElem_LeftClickDataItemHodnotarow_56_13 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_56_13);
			if (winElem_LeftClickDataItemHodnotarow_56_13 != null)
			{
				winElem_LeftClickDataItemHodnotarow_56_13.Click();
				winElem_LeftClickDataItemHodnotarow_56_13.SendKeys(Keys.ArrowDown);
				winElem_LeftClickDataItemHodnotarow_56_13.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_56_13}");
				return;
			}


			// LeftClick on DataItem "Hodnota row7" at (44,8)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row7\" at (44,8)");
			string xpath_LeftClickDataItemHodnotarow_44_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 11\"]/DataItem[@Name=\"Hodnota row7\"]";
			var winElem_LeftClickDataItemHodnotarow_44_8 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_44_8);
			if (winElem_LeftClickDataItemHodnotarow_44_8 != null)
			{
				winElem_LeftClickDataItemHodnotarow_44_8.Click();
				winElem_LeftClickDataItemHodnotarow_44_8.SendKeys(Keys.ArrowDown);
				winElem_LeftClickDataItemHodnotarow_44_8.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_44_8}");
				return;
			}


			// LeftClick on DataItem "Hodnota row8" at (36,13)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row8\" at (36,13)");
			string xpath_LeftClickDataItemHodnotarow_36_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 12\"]/DataItem[@Name=\"Hodnota row8\"]";
			var winElem_LeftClickDataItemHodnotarow_36_13 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_36_13);
			if (winElem_LeftClickDataItemHodnotarow_36_13 != null)
			{
				winElem_LeftClickDataItemHodnotarow_36_13.Click();
				winElem_LeftClickDataItemHodnotarow_36_13.SendKeys(Keys.ArrowDown);
				winElem_LeftClickDataItemHodnotarow_36_13.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_36_13}");
				return;
			}


			// LeftClick on DataItem "Hodnota row9" at (35,15)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row9\" at (35,15)");
			string xpath_LeftClickDataItemHodnotarow_35_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 13\"]/DataItem[@Name=\"Hodnota row9\"]";
			var winElem_LeftClickDataItemHodnotarow_35_15 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_35_15);
			if (winElem_LeftClickDataItemHodnotarow_35_15 != null)
			{
				winElem_LeftClickDataItemHodnotarow_35_15.Click();
				winElem_LeftClickDataItemHodnotarow_35_15.SendKeys(Keys.ArrowDown);
				winElem_LeftClickDataItemHodnotarow_35_15.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_35_15}");
				return;
			}


			// LeftClick on DataItem "Hodnota row10" at (35,13)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row10\" at (35,13)");
			string xpath_LeftClickDataItemHodnotarow_35_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 14\"]/DataItem[@Name=\"Hodnota row10\"]";
			var winElem_LeftClickDataItemHodnotarow_35_13 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_35_13);
			if (winElem_LeftClickDataItemHodnotarow_35_13 != null)
			{
				winElem_LeftClickDataItemHodnotarow_35_13.Click();
				winElem_LeftClickDataItemHodnotarow_35_13.SendKeys(Keys.ArrowDown);
				winElem_LeftClickDataItemHodnotarow_35_13.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_35_13}");
				return;
			}


			// LeftClick on DataItem "Hodnota row11" at (31,10)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row11\" at (31,10)");
			string xpath_LeftClickDataItemHodnotarow_31_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 15\"]/DataItem[@Name=\"Hodnota row11\"]";
			var winElem_LeftClickDataItemHodnotarow_31_10 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_31_10);
			if (winElem_LeftClickDataItemHodnotarow_31_10 != null)
			{
				winElem_LeftClickDataItemHodnotarow_31_10.Click();
				winElem_LeftClickDataItemHodnotarow_31_10.SendKeys(Keys.ArrowDown);
				winElem_LeftClickDataItemHodnotarow_31_10.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_31_10}");
				return;
			}


			// LeftClick on DataItem "Hodnota row4" at (97,8)
			Console.WriteLine("LeftClick on DataItem \"Hodnota row4\" at (97,8)");
			string xpath_LeftClickDataItemHodnotarow_97_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 7\"]/DataItem[@Name=\"Hodnota row4\"]";
			var winElem_LeftClickDataItemHodnotarow_97_8 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_97_8);
			if (winElem_LeftClickDataItemHodnotarow_97_8 != null)
			{
				winElem_LeftClickDataItemHodnotarow_97_8.Click();
				winElem_LeftClickDataItemHodnotarow_97_8.SendKeys(Keys.NumberPad2);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_97_8}");
				return;
			}

			// LeftClick on Button "Uložit" at (26,11)
			Console.WriteLine("LeftClick on Button \"Uložit\" at (26,11)");
			string xpath_LeftClickButtonUložit_26_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
			var winElem_LeftClickButtonUložit_26_11 = root.FindByXPath(xpath_LeftClickButtonUložit_26_11);
			if (winElem_LeftClickButtonUložit_26_11 != null)
			{
				winElem_LeftClickButtonUložit_26_11.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_26_11}");
				return;
			}


			// LeftClick on Button "Ukonèit" at (26,11)
			Console.WriteLine("LeftClick on Button \"Ukonèit\" at (26,11)");
			string xpath_LeftClickButtonUkonèit_26_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukonèit\"]";
			var winElem_LeftClickButtonUkonèit_26_11 = root.FindByXPath(xpath_LeftClickButtonUkonèit_26_11);
			if (winElem_LeftClickButtonUkonèit_26_11 != null)
			{
				winElem_LeftClickButtonUkonèit_26_11.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_26_11}");
				return;
			}


			// LeftClick on Button "Zavøít" at (56,12)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (56,12)");
			string xpath_LeftClickButtonZavøít_56_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavøít\"]";
			var winElem_LeftClickButtonZavøít_56_12 = root.FindByXPath(xpath_LeftClickButtonZavøít_56_12);
			if (winElem_LeftClickButtonZavøít_56_12 != null)
			{
				winElem_LeftClickButtonZavøít_56_12.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_56_12}");
				return;
			}
		}

		private static void editingMaterial()
		{
			// LeftClick on DataItem "Èíslo materiálu filter row" at (90,8)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu filter row\" at (90,8)");
			string xpath_LeftClickDataItemÈíslomater_90_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Filter Row\"]/DataItem[@Name=\"Èíslo materiálu filter row\"]";
			var winElem_LeftClickDataItemÈíslomater_90_8 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_90_8);
			if (winElem_LeftClickDataItemÈíslomater_90_8 != null)
			{
				winElem_LeftClickDataItemÈíslomater_90_8.Click();
				winElem_LeftClickDataItemÈíslomater_90_8.SendKeys(Keys.NumberPad1);
				winElem_LeftClickDataItemÈíslomater_90_8.SendKeys(Keys.NumberPad0);
				winElem_LeftClickDataItemÈíslomater_90_8.SendKeys(Keys.NumberPad1);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_90_8}");
				return;
			}


			// LeftClick on DataItem "Èíslo materiálu row0" at (55,12)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (55,12)");
			string xpath_LeftClickDataItemÈíslomater_55_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_55_12 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_55_12);
			if (winElem_LeftClickDataItemÈíslomater_55_12 != null)
			{
				winElem_LeftClickDataItemÈíslomater_55_12.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_55_12}");
				return;
			}


			// LeftClick on DataItem " row 2" at (39,20)
			Console.WriteLine("LeftClick on DataItem \" row 2\" at (39,20)");
			string xpath_LeftClickDataItemrow2_39_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"101\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node2\"]/DataItem[@Name=\" row 2\"]";
			var winElem_LeftClickDataItemrow2_39_20 = root.FindByXPath(xpath_LeftClickDataItemrow2_39_20);
			if (winElem_LeftClickDataItemrow2_39_20 != null)
			{
				winElem_LeftClickDataItemrow2_39_20.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow2_39_20}");
				return;
			}


			// LeftClick on Button "Editovat" at (28,13)
			Console.WriteLine("LeftClick on Button \"Editovat\" at (28,13)");
			string xpath_LeftClickButtonEditovat_28_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"101\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
			var winElem_LeftClickButtonEditovat_28_13 = root.FindByXPath(xpath_LeftClickButtonEditovat_28_13);
			if (winElem_LeftClickButtonEditovat_28_13 != null)
			{
				winElem_LeftClickButtonEditovat_28_13.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_28_13}");
				return;
			}


			// LeftClick on CheckBox "Pøedepsaný odbìratel" at (51,6)
			Console.WriteLine("LeftClick on CheckBox \"Pøedepsaný odbìratel\" at (51,6)");
			string xpath_LeftClickCheckBoxPøedepsaný_51_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelClients\"]/Pane[@Name=\"grpClients\"][@AutomationId=\"grpClients\"]/CheckBox[@Name=\"Pøedepsaný odbìratel\"][@AutomationId=\"chbHasClients\"]";
			var winElem_LeftClickCheckBoxPøedepsaný_51_6 = root.FindByXPath(xpath_LeftClickCheckBoxPøedepsaný_51_6);
			if (winElem_LeftClickCheckBoxPøedepsaný_51_6 != null)
			{
				winElem_LeftClickCheckBoxPøedepsaný_51_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxPøedepsaný_51_6}");
				return;
			}


			// LeftClick on Button "Nový odbìratel" at (68,14)
			Console.WriteLine("LeftClick on Button \"Nový odbìratel\" at (68,14)");
			string xpath_LeftClickButtonNovýodbìra_68_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nový odbìratel\"][@AutomationId=\"btnAddClient_Click\"]";
			var winElem_LeftClickButtonNovýodbìra_68_14 = root.FindByXPath(xpath_LeftClickButtonNovýodbìra_68_14);
			if (winElem_LeftClickButtonNovýodbìra_68_14 != null)
			{
				winElem_LeftClickButtonNovýodbìra_68_14.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovýodbìra_68_14}");
				return;
			}


			// LeftClick on Button "OK" at (25,22)
			Console.WriteLine("LeftClick on Button \"OK\" at (25,22)");
			string xpath_LeftClickButtonOK_25_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbMC_PickFirmCard\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_25_22 = root.FindByXPath(xpath_LeftClickButtonOK_25_22);
			if (winElem_LeftClickButtonOK_25_22 != null)
			{
				winElem_LeftClickButtonOK_25_22.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_25_22}");
				return;
			}


			// LeftClick on DataItem " row0" at (44,20)
			Console.WriteLine("LeftClick on DataItem \" row0\" at (44,20)");
			string xpath_LeftClickDataItemrow0_44_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelClients\"]/Pane[@Name=\"grpClients\"][@AutomationId=\"grpClients\"]/Table[@AutomationId=\"gridClients\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\" row0\"]";
			var winElem_LeftClickDataItemrow0_44_20 = root.FindByXPath(xpath_LeftClickDataItemrow0_44_20);
			if (winElem_LeftClickDataItemrow0_44_20 != null)
			{
				winElem_LeftClickDataItemrow0_44_20.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_44_20}");
				return;
			}


			// LeftClick on CheckBox "Pøedepsaný odbìratel" at (22,12)
			Console.WriteLine("LeftClick on CheckBox \"Pøedepsaný odbìratel\" at (22,12)");
			string xpath_LeftClickCheckBoxPøedepsaný_22_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelClients\"]/Pane[@Name=\"grpClients\"][@AutomationId=\"grpClients\"]/CheckBox[@Name=\"Pøedepsaný odbìratel\"][@AutomationId=\"chbHasClients\"]";
			var winElem_LeftClickCheckBoxPøedepsaný_22_12 = root.FindByXPath(xpath_LeftClickCheckBoxPøedepsaný_22_12);
			if (winElem_LeftClickCheckBoxPøedepsaný_22_12 != null)
			{
				winElem_LeftClickCheckBoxPøedepsaný_22_12.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxPøedepsaný_22_12}");
				return;
			}


			// LeftClick on Button "Uložit" at (21,13)
			Console.WriteLine("LeftClick on Button \"Uložit\" at (21,13)");
			string xpath_LeftClickButtonUložit_21_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
			var winElem_LeftClickButtonUložit_21_13 = root.FindByXPath(xpath_LeftClickButtonUložit_21_13);
			if (winElem_LeftClickButtonUložit_21_13 != null)
			{
				winElem_LeftClickButtonUložit_21_13.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_21_13}");
				return;
			}


			// LeftClick on Button "Ukonèit" at (13,16)
			Console.WriteLine("LeftClick on Button \"Ukonèit\" at (13,16)");
			string xpath_LeftClickButtonUkonèit_13_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
			var winElem_LeftClickButtonUkonèit_13_16 = root.FindByXPath(xpath_LeftClickButtonUkonèit_13_16);
			if (winElem_LeftClickButtonUkonèit_13_16 != null)
			{
				winElem_LeftClickButtonUkonèit_13_16.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_13_16}");
				return;
			}


			// LeftClick on Button "Zavøít" at (34,16)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (34,16)");
			string xpath_LeftClickButtonZavøít_34_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
			var winElem_LeftClickButtonZavøít_34_16 = root.FindByXPath(xpath_LeftClickButtonZavøít_34_16);
			if (winElem_LeftClickButtonZavøít_34_16 != null)
			{
				winElem_LeftClickButtonZavøít_34_16.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_34_16}");
				return;
			}
		}

		private static void creatingMaterial()
		{
			// LeftClick on TabItem "Karty materiálù" at (41,8)
			Console.WriteLine("LeftClick on TabItem \"Karty materiálù\" at (41,8)");
			string xpath_LeftClickTabItemKartymater_41_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/TabItem[@Name=\"Karty materiálù\"]";
			var winElem_LeftClickTabItemKartymater_41_8 = root.FindByXPath(xpath_LeftClickTabItemKartymater_41_8);
			if (winElem_LeftClickTabItemKartymater_41_8 != null)
			{
				winElem_LeftClickTabItemKartymater_41_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickTabItemKartymater_41_8}");
				return;
			}


			// LeftClick on DataItem "Èíslo materiálu filter row" at (53,9)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu filter row\" at (53,9)");
			string xpath_LeftClickDataItemÈíslomater_53_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Filter Row\"]/DataItem[@Name=\"Èíslo materiálu filter row\"]";
			var winElem_LeftClickDataItemÈíslomater_53_9 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_53_9);
			if (winElem_LeftClickDataItemÈíslomater_53_9 != null)
			{
				winElem_LeftClickDataItemÈíslomater_53_9.Click();
				winElem_LeftClickDataItemÈíslomater_53_9.SendKeys(Keys.Backspace + Keys.Backspace);
				winElem_LeftClickDataItemÈíslomater_53_9.SendKeys(Keys.Backspace);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_53_9}");
				return;
			}


			// LeftClick on Button "Nová karta" at (7,10)
			Console.WriteLine("LeftClick on Button \"Nová karta\" at (7,10)");
			string xpath_LeftClickButtonNovákarta_7_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová karta\"]";
			var winElem_LeftClickButtonNovákarta_7_10 = root.FindByXPath(xpath_LeftClickButtonNovákarta_7_10);
			if (winElem_LeftClickButtonNovákarta_7_10 != null)
			{
				winElem_LeftClickButtonNovákarta_7_10.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovákarta_7_10}");
				return;
			}


			// LeftClick on Edit "" at (35,9)
			Console.WriteLine("LeftClick on Edit \"\" at (35,9)");
			string xpath_LeftClickEdit_35_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Edit[@AutomationId=\"txtMaterialNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_35_9 = root.FindByXPath(xpath_LeftClickEdit_35_9);
			if (winElem_LeftClickEdit_35_9 != null)
			{
				winElem_LeftClickEdit_35_9.Click();
				winElem_LeftClickEdit_35_9.SendKeys(Keys.NumberPad1);
				winElem_LeftClickEdit_35_9.SendKeys(Keys.NumberPad0);
				winElem_LeftClickEdit_35_9.SendKeys(Keys.NumberPad1);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_35_9}");
				return;
			}


			// LeftClick on Pane "" at (151,15)
			Console.WriteLine("LeftClick on Pane \"\" at (151,15)");
			string xpath_LeftClickPane_151_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtName\"]";
			var winElem_LeftClickPane_151_15 = root.FindByXPath(xpath_LeftClickPane_151_15);
			if (winElem_LeftClickPane_151_15 != null)
			{
				winElem_LeftClickPane_151_15.Click();
				winElem_LeftClickPane_151_15.SendKeys(Keys.Shift + "m" + Keys.Shift);
				winElem_LeftClickPane_151_15.SendKeys("aterial");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_151_15}");
				return;
			}


			// LeftClick on Pane "" at (39,11)
			Console.WriteLine("LeftClick on Pane \"\" at (39,11)");
			string xpath_LeftClickPane_39_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtShortName\"]";
			var winElem_LeftClickPane_39_11 = root.FindByXPath(xpath_LeftClickPane_39_11);
			if (winElem_LeftClickPane_39_11 != null)
			{
				winElem_LeftClickPane_39_11.Click();
				winElem_LeftClickPane_39_11.SendKeys(Keys.Shift + "m" + Keys.Shift);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_39_11}");
				return;
			}


			// LeftClick on Text "" at (120,10)
			Console.WriteLine("LeftClick on Text \"\" at (120,10)");
			string xpath_LeftClickText_120_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@AutomationId=\"cmbGroup\"]/Text";
			var winElem_LeftClickText_120_10 = root.FindByXPath(xpath_LeftClickText_120_10);
			if (winElem_LeftClickText_120_10 != null)
			{
				winElem_LeftClickText_120_10.Click();
				winElem_LeftClickText_120_10.SendKeys(Keys.NumberPad5);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_120_10}");
				return;
			}


			// LeftClick on Text "" at (95,13)
			Console.WriteLine("LeftClick on Text \"\" at (95,13)");
			string xpath_LeftClickText_95_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@AutomationId=\"cmbSubGroup\"]/Text";
			var winElem_LeftClickText_95_13 = root.FindByXPath(xpath_LeftClickText_95_13);
			if (winElem_LeftClickText_95_13 != null)
			{
				winElem_LeftClickText_95_13.Click();
				winElem_LeftClickText_95_13.SendKeys(Keys.ArrowDown);
				winElem_LeftClickText_95_13.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_95_13}");
				return;
			}


			// LeftClick on Button "OK" at (45,1)
			Console.WriteLine("LeftClick on Button \"OK\" at (45,1)");
			string xpath_LeftClickButtonOK_45_1 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
			var winElem_LeftClickButtonOK_45_1 = root.FindByXPath(xpath_LeftClickButtonOK_45_1);
			if (winElem_LeftClickButtonOK_45_1 != null)
			{
				winElem_LeftClickButtonOK_45_1.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_45_1}");
				return;
			}

			// LeftClick on Button "&amp;Yes" at (22,15)
			Console.WriteLine("LeftClick on Button \"&amp;Yes\" at (22,15)");
			string xpath_LeftClickButtonYes_22_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Yes\"]";
			var winElem_LeftClickButtonYes_22_15 = root.FindByXPath(xpath_LeftClickButtonYes_22_15);
			if (winElem_LeftClickButtonYes_22_15 != null)
			{
				winElem_LeftClickButtonYes_22_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonYes_22_15}");
				return;
			}


			// LeftClick on Button "Uložit" at (63,13)
			Console.WriteLine("LeftClick on Button \"Uložit\" at (63,13)");
			string xpath_LeftClickButtonUložit_63_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"101\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
			var winElem_LeftClickButtonUložit_63_13 = root.FindByXPath(xpath_LeftClickButtonUložit_63_13);
			if (winElem_LeftClickButtonUložit_63_13 != null)
			{
				winElem_LeftClickButtonUložit_63_13.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_63_13}");
				return;
			}


			// LeftClick on Button "Ukonèit" at (10,12)
			Console.WriteLine("LeftClick on Button \"Ukonèit\" at (10,12)");
			string xpath_LeftClickButtonUkonèit_10_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"101\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukonèit\"]";
			var winElem_LeftClickButtonUkonèit_10_12 = root.FindByXPath(xpath_LeftClickButtonUkonèit_10_12);
			if (winElem_LeftClickButtonUkonèit_10_12 != null)
			{
				winElem_LeftClickButtonUkonèit_10_12.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_10_12}");
				return;
			}


			// LeftClick on Button "Zavøít" at (19,2)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (19,2)");
			string xpath_LeftClickButtonZavøít_19_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"101\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavøít\"]";
			var winElem_LeftClickButtonZavøít_19_2 = root.FindByXPath(xpath_LeftClickButtonZavøít_19_2);
			if (winElem_LeftClickButtonZavøít_19_2 != null)
			{
				winElem_LeftClickButtonZavøít_19_2.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_19_2}");
				return;
			}
		}

		private static void editingFirms()
		{
			// LeftClick on DataItem "Èíslo materiálu row0" at (26,9)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (26,9)");
			string xpath_LeftClickDataItemÈíslomater_26_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_26_9 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_26_9);
			if (winElem_LeftClickDataItemÈíslomater_26_9 != null)
			{
				winElem_LeftClickDataItemÈíslomater_26_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_26_9}");
				return;
			}


			// LeftClick on DataItem " row 2" at (31,23)
			Console.WriteLine("LeftClick on DataItem \" row 2\" at (31,23)");
			string xpath_LeftClickDataItemrow2_31_23 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node2\"]/DataItem[@Name=\" row 2\"]";
			var winElem_LeftClickDataItemrow2_31_23 = root.FindByXPath(xpath_LeftClickDataItemrow2_31_23);
			if (winElem_LeftClickDataItemrow2_31_23 != null)
			{
				winElem_LeftClickDataItemrow2_31_23.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow2_31_23}");
				return;
			}


			// LeftClick on Button "Editovat" at (32,9)
			Console.WriteLine("LeftClick on Button \"Editovat\" at (32,9)");
			string xpath_LeftClickButtonEditovat_32_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
			var winElem_LeftClickButtonEditovat_32_9 = root.FindByXPath(xpath_LeftClickButtonEditovat_32_9);
			if (winElem_LeftClickButtonEditovat_32_9 != null)
			{
				winElem_LeftClickButtonEditovat_32_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_32_9}");
				return;
			}


			// LeftClick on CheckBox "Pøedepsaný dodavatel" at (42,8)
			Console.WriteLine("LeftClick on CheckBox \"Pøedepsaný dodavatel\" at (42,8)");
			string xpath_LeftClickCheckBoxPøedepsaný_42_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelSuppliers\"]/Pane[@Name=\"grpSuppliers\"][@AutomationId=\"grpSuppliers\"]/CheckBox[@Name=\"Pøedepsaný dodavatel\"][@AutomationId=\"chbHasSuppliers\"]";
			var winElem_LeftClickCheckBoxPøedepsaný_42_8 = root.FindByXPath(xpath_LeftClickCheckBoxPøedepsaný_42_8);
			if (winElem_LeftClickCheckBoxPøedepsaný_42_8 != null)
			{
				winElem_LeftClickCheckBoxPøedepsaný_42_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxPøedepsaný_42_8}");
				return;
			}


			// LeftClick on CheckBox "Pøedepsaný výrobce" at (90,3)
			Console.WriteLine("LeftClick on CheckBox \"Pøedepsaný výrobce\" at (90,3)");
			string xpath_LeftClickCheckBoxPøedepsaný_90_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelProducers\"]/Pane[@Name=\"grpProducers\"][@AutomationId=\"grpProducers\"]/CheckBox[@Name=\"Pøedepsaný výrobce\"][@AutomationId=\"chbHasProducers\"]";
			var winElem_LeftClickCheckBoxPøedepsaný_90_3 = root.FindByXPath(xpath_LeftClickCheckBoxPøedepsaný_90_3);
			if (winElem_LeftClickCheckBoxPøedepsaný_90_3 != null)
			{
				winElem_LeftClickCheckBoxPøedepsaný_90_3.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxPøedepsaný_90_3}");
				return;
			}


			// LeftClick on Button "Nový dodavatel" at (9,6)
			Console.WriteLine("LeftClick on Button \"Nový dodavatel\" at (9,6)");
			string xpath_LeftClickButtonNovýdodava_9_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nový dodavatel\"]";
			var winElem_LeftClickButtonNovýdodava_9_6 = root.FindByXPath(xpath_LeftClickButtonNovýdodava_9_6);
			if (winElem_LeftClickButtonNovýdodava_9_6 != null)
			{
				winElem_LeftClickButtonNovýdodava_9_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovýdodava_9_6}");
				return;
			}


			// LeftClick on Button "OK" at (24,17)
			Console.WriteLine("LeftClick on Button \"OK\" at (24,17)");
			string xpath_LeftClickButtonOK_24_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbMC_PickFirmCard\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_24_17 = root.FindByXPath(xpath_LeftClickButtonOK_24_17);
			if (winElem_LeftClickButtonOK_24_17 != null)
			{
				winElem_LeftClickButtonOK_24_17.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_24_17}");
				return;
			}


			// LeftClick on Button "Nový výrobce" at (11,6)
			Console.WriteLine("LeftClick on Button \"Nový výrobce\" at (11,6)");
			string xpath_LeftClickButtonNovývýrobc_11_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nový výrobce\"]";
			var winElem_LeftClickButtonNovývýrobc_11_6 = root.FindByXPath(xpath_LeftClickButtonNovývýrobc_11_6);
			if (winElem_LeftClickButtonNovývýrobc_11_6 != null)
			{
				winElem_LeftClickButtonNovývýrobc_11_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovývýrobc_11_6}");
				return;
			}


			// LeftClick on Button "OK" at (36,15)
			Console.WriteLine("LeftClick on Button \"OK\" at (36,15)");
			string xpath_LeftClickButtonOK_36_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbMC_PickFirmCard\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_36_15 = root.FindByXPath(xpath_LeftClickButtonOK_36_15);
			if (winElem_LeftClickButtonOK_36_15 != null)
			{
				winElem_LeftClickButtonOK_36_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_36_15}");
				return;
			}


			// LeftClick on DataItem " row0" at (50,11)
			Console.WriteLine("LeftClick on DataItem \" row0\" at (50,11)");
			string xpath_LeftClickDataItemrow0_50_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelSuppliers\"]/Pane[@Name=\"grpSuppliers\"][@AutomationId=\"grpSuppliers\"]/Table[@AutomationId=\"gridSuppliers\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\" row0\"]";
			var winElem_LeftClickDataItemrow0_50_11 = root.FindByXPath(xpath_LeftClickDataItemrow0_50_11);
			if (winElem_LeftClickDataItemrow0_50_11 != null)
			{
				winElem_LeftClickDataItemrow0_50_11.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_50_11}");
				return;
			}


			// LeftClick on DataItem " row0" at (26,9)
			Console.WriteLine("LeftClick on DataItem \" row0\" at (26,9)");
			string xpath_LeftClickDataItemrow0_26_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelProducers\"]/Pane[@Name=\"grpProducers\"][@AutomationId=\"grpProducers\"]/Table[@AutomationId=\"gridProducers\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\" row0\"]";
			var winElem_LeftClickDataItemrow0_26_9 = root.FindByXPath(xpath_LeftClickDataItemrow0_26_9);
			if (winElem_LeftClickDataItemrow0_26_9 != null)
			{
				winElem_LeftClickDataItemrow0_26_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_26_9}");
				return;
			}


			// LeftClick on Button "Nový dodavatel" at (59,15)
			Console.WriteLine("LeftClick on Button \"Nový dodavatel\" at (59,15)");
			string xpath_LeftClickButtonNovýdodava_59_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nový dodavatel\"]";
			var winElem_LeftClickButtonNovýdodava_59_15 = root.FindByXPath(xpath_LeftClickButtonNovýdodava_59_15);
			if (winElem_LeftClickButtonNovýdodava_59_15 != null)
			{
				winElem_LeftClickButtonNovýdodava_59_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovýdodava_59_15}");
				return;
			}


			// LeftClick on Button "OK" at (40,20)
			Console.WriteLine("LeftClick on Button \"OK\" at (40,20)");
			string xpath_LeftClickButtonOK_40_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbMC_PickFirmCard\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_40_20 = root.FindByXPath(xpath_LeftClickButtonOK_40_20);
			if (winElem_LeftClickButtonOK_40_20 != null)
			{
				winElem_LeftClickButtonOK_40_20.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_40_20}");
				return;
			}


			// LeftClick on Button "Nový výrobce" at (46,21)
			Console.WriteLine("LeftClick on Button \"Nový výrobce\" at (46,21)");
			string xpath_LeftClickButtonNovývýrobc_46_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nový výrobce\"]";
			var winElem_LeftClickButtonNovývýrobc_46_21 = root.FindByXPath(xpath_LeftClickButtonNovývýrobc_46_21);
			if (winElem_LeftClickButtonNovývýrobc_46_21 != null)
			{
				winElem_LeftClickButtonNovývýrobc_46_21.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovývýrobc_46_21}");
				return;
			}


			// LeftClick on Button "OK" at (37,14)
			Console.WriteLine("LeftClick on Button \"OK\" at (37,14)");
			string xpath_LeftClickButtonOK_37_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbMC_PickFirmCard\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_37_14 = root.FindByXPath(xpath_LeftClickButtonOK_37_14);
			if (winElem_LeftClickButtonOK_37_14 != null)
			{
				winElem_LeftClickButtonOK_37_14.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_37_14}");
				return;
			}


			// LeftClick on Button "Uložit" at (41,8)
			Console.WriteLine("LeftClick on Button \"Uložit\" at (41,8)");
			string xpath_LeftClickButtonUložit_41_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
			var winElem_LeftClickButtonUložit_41_8 = root.FindByXPath(xpath_LeftClickButtonUložit_41_8);
			if (winElem_LeftClickButtonUložit_41_8 != null)
			{
				winElem_LeftClickButtonUložit_41_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_41_8}");
				return;
			}


			// LeftClick on Button "Ukonèit" at (15,10)
			Console.WriteLine("LeftClick on Button \"Ukonèit\" at (15,10)");
			string xpath_LeftClickButtonUkonèit_15_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukonèit\"]";
			var winElem_LeftClickButtonUkonèit_15_10 = root.FindByXPath(xpath_LeftClickButtonUkonèit_15_10);
			if (winElem_LeftClickButtonUkonèit_15_10 != null)
			{
				winElem_LeftClickButtonUkonèit_15_10.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_15_10}");
				return;
			}


			// LeftClick on Button "Zavøít" at (73,11)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (73,11)");
			string xpath_LeftClickButtonZavøít_73_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavøít\"]";
			var winElem_LeftClickButtonZavøít_73_11 = root.FindByXPath(xpath_LeftClickButtonZavøít_73_11);
			if (winElem_LeftClickButtonZavøít_73_11 != null)
			{
				winElem_LeftClickButtonZavøít_73_11.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_73_11}");
				return;
			}
		}

		private static bool editingUnits()
		{
			// LeftClick on DataItem "Èíslo materiálu row0" at (53,6)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (53,6)");
			string xpath_LeftClickDataItemÈíslomater_53_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_53_6 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_53_6);
			if (winElem_LeftClickDataItemÈíslomater_53_6 != null)
			{
				winElem_LeftClickDataItemÈíslomater_53_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using Name: Èíslo materiálu row0");
				return false;
			}


			// LeftClick on Button "Editovat" at (17,15)
			Console.WriteLine("LeftClick on Button \"Editovat\" at (17,15)");
			string xpath_LeftClickButtonEditovat_17_15 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{winElem_LeftClickDataItemÈíslomater_53_6.Text}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
			var winElem_LeftClickButtonEditovat_17_15 = root.FindByXPath(xpath_LeftClickButtonEditovat_17_15);
			if (winElem_LeftClickButtonEditovat_17_15 != null)
			{
				winElem_LeftClickButtonEditovat_17_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_17_15}");
				return false;
			}


			// LeftClick on Button "Pøidat jednotku" at (32,18)
			Console.WriteLine("LeftClick on Button \"Pøidat jednotku\" at (32,18)");
			string xpath_LeftClickButtonPøidatjedn_32_18 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{winElem_LeftClickDataItemÈíslomater_53_6.Text}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Pøidat jednotku\"]";
			var winElem_LeftClickButtonPøidatjedn_32_18 = root.FindByXPath(xpath_LeftClickButtonPøidatjedn_32_18);
			if (winElem_LeftClickButtonPøidatjedn_32_18 != null)
			{
				winElem_LeftClickButtonPøidatjedn_32_18.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonPøidatjedn_32_18}");
				return false;
			}


			// LeftClick on Text "" at (124,0)
			Console.WriteLine("LeftClick on Text \"\" at (124,0)");
			string xpath_LeftClickText_124_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/ComboBox[@AutomationId=\"cmbName\"]/Text";
			var winElem_LeftClickText_124_0 = root.FindByXPath(xpath_LeftClickText_124_0);
			if (winElem_LeftClickText_124_0 != null)
			{
				winElem_LeftClickText_124_0.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_124_0}");
				return false;
			}


			// LeftClick on ListItem "% plochy" at (124,10)
			Console.WriteLine("LeftClick on ListItem \"% plochy\" at (124,10)");
			string xpath_LeftClickListItemplochy_124_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Window[starts-with(@ClassName,\"WindowsForms10\")]/List[starts-with(@ClassName,\"WindowsForms10\")]/ListItem[@Name=\"% plochy\"]";
			var winElem_LeftClickListItemplochy_124_10 = root.FindByXPath(xpath_LeftClickListItemplochy_124_10);
			if (winElem_LeftClickListItemplochy_124_10 != null)
			{
				winElem_LeftClickListItemplochy_124_10.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickListItemplochy_124_10}");
				return false;
			}


			// LeftClick on CheckBox "Hlavní MJ" at (9,11)
			Console.WriteLine("LeftClick on CheckBox \"Hlavní MJ\" at (9,11)");
			string xpath_LeftClickCheckBoxHlavníMJ_9_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/Pane[@AutomationId=\"panelDefinitions\"]/CheckBox[@Name=\"Hlavní MJ\"][@AutomationId=\"chbIsMainUnit\"]";
			var winElem_LeftClickCheckBoxHlavníMJ_9_11 = root.FindByXPath(xpath_LeftClickCheckBoxHlavníMJ_9_11);
			if (winElem_LeftClickCheckBoxHlavníMJ_9_11 != null)
			{
				winElem_LeftClickCheckBoxHlavníMJ_9_11.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxHlavníMJ_9_11}");
				return false;
			}


			// LeftClick on CheckBox "MJ pro tisk stavových štítkù" at (24,9)
			Console.WriteLine("LeftClick on CheckBox \"MJ pro tisk stavových štítkù\" at (24,9)");
			string xpath_LeftClickCheckBoxMJprotisks_24_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/Pane[@AutomationId=\"panelDefinitions\"]/CheckBox[@Name=\"MJ pro tisk stavových štítkù\"][@AutomationId=\"chbIsLabelUnit\"]";
			var winElem_LeftClickCheckBoxMJprotisks_24_9 = root.FindByXPath(xpath_LeftClickCheckBoxMJprotisks_24_9);
			if (winElem_LeftClickCheckBoxMJprotisks_24_9 != null)
			{
				winElem_LeftClickCheckBoxMJprotisks_24_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxMJprotisks_24_9}");
				return false;
			}


			// LeftClick on CheckBox "MJ urèená k trasování" at (29,8)
			Console.WriteLine("LeftClick on CheckBox \"MJ urèená k trasování\" at (29,8)");
			string xpath_LeftClickCheckBoxMJurèenákt_29_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/Pane[@AutomationId=\"panelDefinitions\"]/CheckBox[@Name=\"MJ urèená k trasování\"][@AutomationId=\"chbIsTraceUnit\"]";
			var winElem_LeftClickCheckBoxMJurèenákt_29_8 = root.FindByXPath(xpath_LeftClickCheckBoxMJurèenákt_29_8);
			if (winElem_LeftClickCheckBoxMJurèenákt_29_8 != null)
			{
				winElem_LeftClickCheckBoxMJurèenákt_29_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxMJurèenákt_29_8}");
				return false;
			}


			// LeftClick on Edit "" at (118,27)
			Console.WriteLine("LeftClick on Edit \"\" at (118,27)");
			string xpath_LeftClickEdit_118_27 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/Edit[@AutomationId=\"txtRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_118_27 = root.FindByXPath(xpath_LeftClickEdit_118_27);
			if (winElem_LeftClickEdit_118_27 != null)
			{
				winElem_LeftClickEdit_118_27.Click();
				winElem_LeftClickEdit_118_27.SendKeys("e");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_118_27}");
				return false;
			}


			// LeftClick on Button "OK" at (32,17)
			Console.WriteLine("LeftClick on Button \"OK\" at (32,17)");
			string xpath_LeftClickButtonOK_32_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_32_17 = root.FindByXPath(xpath_LeftClickButtonOK_32_17);
			if (winElem_LeftClickButtonOK_32_17 != null)
			{
				winElem_LeftClickButtonOK_32_17.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_32_17}");
				return false;
			}


			// LeftClick on Button "Uložit" at (23,23)
			Console.WriteLine("LeftClick on Button \"Uložit\" at (23,23)");
			string xpath_LeftClickButtonUložit_23_23 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
			var winElem_LeftClickButtonUložit_23_23 = root.FindByXPath(xpath_LeftClickButtonUložit_23_23);
			if (winElem_LeftClickButtonUložit_23_23 != null)
			{
				winElem_LeftClickButtonUložit_23_23.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_23_23}");
				return false;
			}


			// LeftClick on Button "Ukonèit" at (20,15)
			Console.WriteLine("LeftClick on Button \"Ukonèit\" at (20,15)");
			string xpath_LeftClickButtonUkonèit_20_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukonèit\"]";
			var winElem_LeftClickButtonUkonèit_20_15 = root.FindByXPath(xpath_LeftClickButtonUkonèit_20_15);
			if (winElem_LeftClickButtonUkonèit_20_15 != null)
			{
				winElem_LeftClickButtonUkonèit_20_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_20_15}");
				return false;
			}


			// LeftClick on Button "Zavøít" at (16,14)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (16,14)");
			string xpath_LeftClickButtonZavøít_16_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavøít\"]";
			var winElem_LeftClickButtonZavøít_16_14 = root.FindByXPath(xpath_LeftClickButtonZavøít_16_14);
			if (winElem_LeftClickButtonZavøít_16_14 != null)
			{
				winElem_LeftClickButtonZavøít_16_14.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_16_14}");
				return false;
			}
			return true;
		}

		private bool copyMaterializeCard()
		{
			// LeftClick on DataItem "Èíslo materiálu row0" at (61,33)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (61,33)");
			string xpath_LeftClickDataItemÈíslomater_61_33 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_61_33 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_61_33);
			if (winElem_LeftClickDataItemÈíslomater_61_33 != null)
			{
				winElem_LeftClickDataItemÈíslomater_61_33.Click();
				materialNumber = winElem_LeftClickDataItemÈíslomater_61_33.Text;
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_61_33}");
				return false;
			}

			// LeftClick on Button "Kopie" at (51,9)
			Console.WriteLine("LeftClick on Button \"Kopie\" at (51,9)");
			string xpath_LeftClickButtonKopie_51_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Kopie\"][@AutomationId=\"btnCopy_Click\"]";
			var winElem_LeftClickButtonKopie_51_9 = root.FindByName("Kopie");
			if (winElem_LeftClickButtonKopie_51_9 != null)
			{
				winElem_LeftClickButtonKopie_51_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKopie_51_9}");
				return false;
			}

			// LeftClick on Edit "PasswordTextEdit" at (30,3)
			Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (30,3)");
			string xpath_LeftClickEditPasswordTe_30_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
			var winElem_LeftClickEditPasswordTe_30_3 = root.FindByXPath(xpath_LeftClickEditPasswordTe_30_3);
			if (winElem_LeftClickEditPasswordTe_30_3 != null)
			{
				winElem_LeftClickEditPasswordTe_30_3.Click();
				winElem_LeftClickEditPasswordTe_30_3.SendKeys("mesbrno");
				winElem_LeftClickEditPasswordTe_30_3.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_30_3}");
				return false;
			}


			// LeftClick on RadioButton "rbNewCard" at (3,10)
			Console.WriteLine("LeftClick on RadioButton \"rbNewCard\" at (3,10)");
			string xpath_LeftClickRadioButtonrbNewCard_3_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Kopie materiálové karty\"][@AutomationId=\"mbMC_Copy\"]/List[@AutomationId=\"rbGroup\"]/RadioButton[@Name=\"rbNewCard\"]";
			var winElem_LeftClickRadioButtonrbNewCard_3_10 = root.FindByXPath(xpath_LeftClickRadioButtonrbNewCard_3_10);
			if (winElem_LeftClickRadioButtonrbNewCard_3_10 != null)
			{
				winElem_LeftClickRadioButtonrbNewCard_3_10.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickRadioButtonrbNewCard_3_10}");
				return false;
			}


			// LeftClick on Button "OK" at (27,10)
			Console.WriteLine("LeftClick on Button \"OK\" at (27,10)");
			string xpath_LeftClickButtonOK_27_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Kopie materiálové karty\"][@AutomationId=\"mbMC_Copy\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
			var winElem_LeftClickButtonOK_27_10 = root.FindByXPath(xpath_LeftClickButtonOK_27_10);
			if (winElem_LeftClickButtonOK_27_10 != null)
			{
				winElem_LeftClickButtonOK_27_10.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_27_10}");
				return false;
			}


			// LeftClick on Button "Zavøít" at (39,8)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (39,8)");
			string xpath_LeftClickButtonZavøít_39_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"1010009\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
			var winElem_LeftClickButtonZavøít_39_8 = root.FindByAccessibilityId("btnClose_Click");
			if (winElem_LeftClickButtonZavøít_39_8 != null)
			{
				winElem_LeftClickButtonZavøít_39_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_39_8}");
				return false;
			}

			// LeftClick on Button "Zavøít" at (39,8)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (39,8)");
			string xpath_LeftClickButtonZavøít_40_8 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
			var winElem_LeftClickButtonZavøít_40_8 = root.FindByXPath(xpath_LeftClickButtonZavøít_40_8);
			if (winElem_LeftClickButtonZavøít_40_8 != null)
			{
				winElem_LeftClickButtonZavøít_40_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_40_8}");
				return false;
			}

			return true;
		}

		private static bool editingMaterialCard()
		{
			string materialNum = "";
			// LeftClick on DataItem "Èíslo materiálu row0" at (22,27)
			Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (22,27)");
			string xpath_LeftClickDataItemÈíslomater_22_27 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
			var winElem_LeftClickDataItemÈíslomater_22_27 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_22_27);
			if (winElem_LeftClickDataItemÈíslomater_22_27 != null)
			{
				winElem_LeftClickDataItemÈíslomater_22_27.Click();
				materialNum = winElem_LeftClickDataItemÈíslomater_22_27.Text;
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_22_27}");
				return false;
			}


			// LeftClick on Button "Editovat" at (27,9)
			Console.WriteLine("LeftClick on Button \"Editovat\" at (27,9)");
			string xpath_LeftClickButtonEditovat_27_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNum}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
			var winElem_LeftClickButtonEditovat_27_9 = root.FindByXPath(xpath_LeftClickButtonEditovat_27_9);
			if (winElem_LeftClickButtonEditovat_27_9 != null)
			{
				winElem_LeftClickButtonEditovat_27_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_27_9}");
				return false;
			}


			// KeyboardInput VirtualKeys="Keys.Backspace + Keys.Backspace"kkk"" CapsLock=False NumLock=True ScrollLock=False
			Console.WriteLine("KeyboardInput VirtualKeys=\"Keys.Backspace + Keys.Backspace\"kkk\"\" CapsLock=False NumLock=True ScrollLock=False");
			System.Threading.Thread.Sleep(100);
			winElem_LeftClickButtonEditovat_27_9.SendKeys(Keys.Backspace + Keys.Backspace);
			winElem_LeftClickButtonEditovat_27_9.SendKeys("kkk");


			// LeftClick on Pane "eeedd" at (51,9)
			Console.WriteLine("LeftClick on Pane \"eeedd\" at (51,9)");
			string xpath_LeftClickPaneeeedd_51_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNum}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@Name=\"eeedd\"][@AutomationId=\"txtName\"]";
			var winElem_LeftClickPaneeeedd_51_9 = root.FindByXPath(xpath_LeftClickPaneeeedd_51_9);
			if (winElem_LeftClickPaneeeedd_51_9 != null)
			{
				winElem_LeftClickPaneeeedd_51_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPaneeeedd_51_9}");
				return false;
			}


			// KeyboardInput VirtualKeys=""ooo"" CapsLock=False NumLock=True ScrollLock=False
			Console.WriteLine("KeyboardInput VirtualKeys=\"\"ooo\"\" CapsLock=False NumLock=True ScrollLock=False");
			System.Threading.Thread.Sleep(100);
			winElem_LeftClickPaneeeedd_51_9.SendKeys("ooo");


			// LeftClick on Edit "Editovat prvek" at (0,9)
			Console.WriteLine("LeftClick on Edit \"Editovat prvek\" at (0,9)");
			string xpath_LeftClickEditEditovatpr_0_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Window[starts-with(@ClassName,\"WindowsForms10\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Table[starts-with(@ClassName,\"WindowsForms10\")]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat prvek\"]";
			var winElem_LeftClickEditEditovatpr_0_9 = root.FindByXPath(xpath_LeftClickEditEditovatpr_0_9);
			if (winElem_LeftClickEditEditovatpr_0_9 != null)
			{
				winElem_LeftClickEditEditovatpr_0_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditEditovatpr_0_9}");
				return false;
			}


			// LeftClick on Pane "e" at (36,11)
			Console.WriteLine("LeftClick on Pane \"e\" at (36,11)");
			string xpath_LeftClickPanee_36_11 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNum}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@Name=\"e\"][@AutomationId=\"txtShortName\"]";
			var winElem_LeftClickPanee_36_11 = root.FindByXPath(xpath_LeftClickPanee_36_11);
			if (winElem_LeftClickPanee_36_11 != null)
			{
				winElem_LeftClickPanee_36_11.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPanee_36_11}");
				return false;
			}


			// KeyboardInput VirtualKeys=""ooo"" CapsLock=False NumLock=True ScrollLock=False
			Console.WriteLine("KeyboardInput VirtualKeys=\"\"ooo\"\" CapsLock=False NumLock=True ScrollLock=False");
			System.Threading.Thread.Sleep(100);
			winElem_LeftClickPanee_36_11.SendKeys("ooo");


			// LeftClick on Pane "" at (515,296)
			Console.WriteLine("LeftClick on Pane \"\" at (515,296)");
			string xpath_LeftClickPane_515_296 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNum}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelCard\"]/Pane[@AutomationId=\"panelDetailCard\"]";
			var winElem_LeftClickPane_515_296 = root.FindByXPath(xpath_LeftClickPane_515_296);
			if (winElem_LeftClickPane_515_296 != null)
			{
				winElem_LeftClickPane_515_296.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_515_296}");
				return false;
			}


			// LeftClick on Button "Uložit" at (44,13)
			Console.WriteLine("LeftClick on Button \"Uložit\" at (44,13)");
			string xpath_LeftClickButtonUložit_44_13 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNum}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
			var winElem_LeftClickButtonUložit_44_13 = root.FindByXPath(xpath_LeftClickButtonUložit_44_13);
			if (winElem_LeftClickButtonUložit_44_13 != null)
			{
				winElem_LeftClickButtonUložit_44_13.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_44_13}");
				return false;
			}


			// LeftClick on Edit "kkk" at (119,7)
			Console.WriteLine("LeftClick on Edit \"kkk\" at (119,7)");
			string xpath_LeftClickEditkkk_119_7 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNum}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelCard\"]/Pane[@AutomationId=\"panelDetailCard\"]/Edit[@Name=\"kkk\"][@AutomationId=\"txtRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"kkk\"]";
			var winElem_LeftClickEditkkk_119_7 = root.FindByXPath(xpath_LeftClickEditkkk_119_7);
			if (winElem_LeftClickEditkkk_119_7 != null)
			{
				winElem_LeftClickEditkkk_119_7.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditkkk_119_7}");
				return false;
			}


			// KeyboardInput VirtualKeys=""k"" CapsLock=False NumLock=True ScrollLock=False
			Console.WriteLine("KeyboardInput VirtualKeys=\"\"k\"\" CapsLock=False NumLock=True ScrollLock=False");
			System.Threading.Thread.Sleep(100);
			winElem_LeftClickEditkkk_119_7.SendKeys("k");


			// LeftClick on Pane "" at (934,358)
			Console.WriteLine("LeftClick on Pane \"\" at (934,358)");
			string xpath_LeftClickPane_934_358 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNum}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelCard\"]/Pane[@AutomationId=\"panelDetailCard\"]";
			var winElem_LeftClickPane_934_358 = root.FindByXPath(xpath_LeftClickPane_934_358);
			if (winElem_LeftClickPane_934_358 != null)
			{
				winElem_LeftClickPane_934_358.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_934_358}");
				return false;
			}


			// LeftClick on Button "Ukonèit" at (27,15)
			Console.WriteLine("LeftClick on Button \"Ukonèit\" at (27,15)");
			string xpath_LeftClickButtonUkonèit_27_15 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNum}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
			var winElem_LeftClickButtonUkonèit_27_15 = root.FindByXPath(xpath_LeftClickButtonUkonèit_27_15);
			if (winElem_LeftClickButtonUkonèit_27_15 != null)
			{
				winElem_LeftClickButtonUkonèit_27_15.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_27_15}");
				return false;
			}


			// LeftClick on Button "&amp;Ano" at (34,12)
			Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (34,12)");
			string xpath_LeftClickButtonAno_34_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit zmìny\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
			var winElem_LeftClickButtonAno_34_12 = root.FindByXPath(xpath_LeftClickButtonAno_34_12);
			if (winElem_LeftClickButtonAno_34_12 != null)
			{
				winElem_LeftClickButtonAno_34_12.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_34_12}");
				return false;
			}


			// LeftClick on Button "Zavøít" at (29,9)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (29,9)");
			string xpath_LeftClickButtonZavøít_29_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNum}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
			var winElem_LeftClickButtonZavøít_29_9 = root.FindByXPath(xpath_LeftClickButtonZavøít_29_9);
			if (winElem_LeftClickButtonZavøít_29_9 != null)
			{
				winElem_LeftClickButtonZavøít_29_9.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_29_9}");
				return false;
			}

			return true;
		}

		private static bool createMaterialCard()
		{
			string materialNum = string.Empty;
			// LeftClick on Button "Nová karta" at (28,19)
			Console.WriteLine("LeftClick on Button \"Nová karta\" at (28,19)");
			string xpath_LeftClickButtonNovákarta_28_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová karta\"]";
			var winElem_LeftClickButtonNovákarta_28_19 = root.FindByXPath(xpath_LeftClickButtonNovákarta_28_19);
			if (winElem_LeftClickButtonNovákarta_28_19 != null)
			{
				winElem_LeftClickButtonNovákarta_28_19.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovákarta_28_19}");
				return false;
			}

			// LeftClick on Edit "" at (55,7)
			Console.WriteLine("LeftClick on Edit \"\" at (55,7)");
			string xpath_LeftClickEdit_55_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Edit[@AutomationId=\"txtMaterialNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
			var winElem_LeftClickEdit_55_7 = root.FindByXPath(xpath_LeftClickEdit_55_7);
			if (winElem_LeftClickEdit_55_7 != null)
			{
				winElem_LeftClickEdit_55_7.Click();
				winElem_LeftClickEdit_55_7.SendKeys("100");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_55_7}");
				return false;
			}

			// LeftClick on Pane "" at (6,10)
			Console.WriteLine("LeftClick on Pane \"\" at (6,10)");
			string xpath_LeftClickPane_6_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtName\"]";
			var winElem_LeftClickPane_6_10 = root.FindByXPath(xpath_LeftClickPane_6_10);
			if (winElem_LeftClickPane_6_10 != null)
			{
				winElem_LeftClickPane_6_10.Click();
				winElem_LeftClickPane_6_10.SendKeys(Keys.Shift + "a" + Keys.Shift);
				winElem_LeftClickPane_6_10.SendKeys("dame");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_6_10}");
				return false;
			}


			// LeftClick on Text "" at (136,8)
			Console.WriteLine("LeftClick on Text \"\" at (136,8)");
			string xpath_LeftClickText_136_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@AutomationId=\"cmbGroup\"]/Text";
			var winElem_LeftClickText_136_8 = root.FindByXPath(xpath_LeftClickText_136_8);
			if (winElem_LeftClickText_136_8 != null)
			{
				winElem_LeftClickText_136_8.Click();
				winElem_LeftClickText_136_8.SendKeys(Keys.ArrowDown);
				winElem_LeftClickText_136_8.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_136_8}");
				return false;
			}


			// LeftClick on Text "" at (29,11)
			Console.WriteLine("LeftClick on Text \"\" at (29,11)");
			string xpath_LeftClickText_29_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@AutomationId=\"cmbSubGroup\"]/Text";
			var winElem_LeftClickText_29_11 = root.FindByXPath(xpath_LeftClickText_29_11);
			if (winElem_LeftClickText_29_11 != null)
			{
				winElem_LeftClickText_29_11.Click();
				winElem_LeftClickText_29_11.SendKeys(Keys.ArrowDown);
				winElem_LeftClickText_29_11.SendKeys(Keys.Return);
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_29_11}");
				return false;
			}


			// LeftClick on Pane "" at (75,16)
			Console.WriteLine("LeftClick on Pane \"\" at (75,16)");
			string xpath_LeftClickPane_75_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtShortName\"]";
			var winElem_LeftClickPane_75_16 = root.FindByXPath(xpath_LeftClickPane_75_16);
			if (winElem_LeftClickPane_75_16 != null)
			{
				winElem_LeftClickPane_75_16.Click();
				winElem_LeftClickPane_75_16.SendKeys("a");
				winElem_LeftClickPane_75_16.SendKeys("e");
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_75_16}");
				return false;
			}


			// LeftClick on Button "OK" at (55,18)
			Console.WriteLine("LeftClick on Button \"OK\" at (55,18)");
			string xpath_LeftClickButtonOK_55_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
			var winElem_LeftClickButtonOK_55_18 = root.FindByXPath(xpath_LeftClickButtonOK_55_18);
			if (winElem_LeftClickButtonOK_55_18 != null)
			{
				winElem_LeftClickButtonOK_55_18.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_55_18}");
				return false;
			}


			// LeftClick on Button "&amp;Ano" at (55,14)
			Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (55,14)");
			string xpath_LeftClickButtonAno_55_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"  \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
			var winElem_LeftClickButtonAno_55_14 = root.FindByXPath(xpath_LeftClickButtonAno_55_14);
			if (winElem_LeftClickButtonAno_55_14 != null)
			{
				winElem_LeftClickButtonAno_55_14.Click();
			}

			// LeftClick on Button "Uložit" at (39,8)
			Console.WriteLine("LeftClick on Button \"Uložit\" at (39,8)");
			var winElem_LeftClickButtonUložit_39_8 = root.FindByAccessibilityId("btnSave_Click");
			if (winElem_LeftClickButtonUložit_39_8 != null)
			{
				winElem_LeftClickButtonUložit_39_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element with AccessibilityId: btnSave_Click");
				return false;
			}


			// LeftClick on Button "Ukonèit" at (30,11)
			Console.WriteLine("LeftClick on Button \"Ukonèit\" at (30,11)");
			var winElem_LeftClickButtonUkonèit_30_11 = root.FindByAccessibilityId("btnFinish_Click");
			if (winElem_LeftClickButtonUkonèit_30_11 != null)
			{
				winElem_LeftClickButtonUkonèit_30_11.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element with AccessibilityId: btnFinish_Click");
				return false;
			}


			// LeftClick on Button "Zavøít" at (38,4)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (38,4)");
			var winElem_LeftClickButtonZavøít_38_4 = root.FindByAccessibilityId("btnClose_Click");
			if (winElem_LeftClickButtonZavøít_38_4 != null)
			{
				winElem_LeftClickButtonZavøít_38_4.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element with AccessibilityId: btnClose_Click");
				return false;
			}

			return true;
		}
		[TestMethod]
		public void TestMethod3()
		{
			// Vytvoøení druhé karty... kterou by mìl zneplatnit.. je víceménì zbyteèný pokud se vyøeší problém s hlavní MJ
			// LeftClick on Button "miBasicData" at (60,19)
			Console.WriteLine("LeftClick on Button \"miBasicData\" at (60,19)");
			string xpath_LeftClickButtonmiBasicDat_60_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Group[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Pøichytit nahoru\"]/ToolBar[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[@Name=\"miBasicData\"]";
			var winElem_LeftClickButtonmiBasicDat_60_19 = root.FindByXPath(xpath_LeftClickButtonmiBasicDat_60_19);
			if (winElem_LeftClickButtonmiBasicDat_60_19 != null)
			{
				winElem_LeftClickButtonmiBasicDat_60_19.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiBasicDat_60_19}");
				return;
			}


			// LeftClick on MenuItem "miAdmServiceCards" at (53,8)
			Console.WriteLine("LeftClick on MenuItem \"miAdmServiceCards\" at (53,8)");
			string xpath_LeftClickMenuItemmiAdmServi_53_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Menu[starts-with(@ClassName,\"WindowsForms10\")]/MenuItem[@Name=\"miAdmServiceCards\"]";
			var winElem_LeftClickMenuItemmiAdmServi_53_8 = root.FindByXPath(xpath_LeftClickMenuItemmiAdmServi_53_8);
			if (winElem_LeftClickMenuItemmiAdmServi_53_8 != null)
			{
				winElem_LeftClickMenuItemmiAdmServi_53_8.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickMenuItemmiAdmServi_53_8}");
				return;
			}


			// LeftClick on DataItem "Èíslo služby row0" at (63,6)
			Console.WriteLine("LeftClick on DataItem \"Èíslo služby row0\" at (63,6)");
			string xpath_LeftClickDataItemÈísloslužb_63_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty služeb\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmServiceCardList\"]/Table[@AutomationId=\"gridServiceCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo služby row0\"]";
			var winElem_LeftClickDataItemÈísloslužb_63_6 = root.FindByXPath(xpath_LeftClickDataItemÈísloslužb_63_6);
			if (winElem_LeftClickDataItemÈísloslužb_63_6 != null)
			{
				winElem_LeftClickDataItemÈísloslužb_63_6.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈísloslužb_63_6}");
				return;
			}


			// LeftClick on Button "Zavøít" at (64,23)
			Console.WriteLine("LeftClick on Button \"Zavøít\" at (64,23)");
			string xpath_LeftClickButtonZavøít_64_23 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0001\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
			var winElem_LeftClickButtonZavøít_64_23 = root.FindByXPath(xpath_LeftClickButtonZavøít_64_23);
			if (winElem_LeftClickButtonZavøít_64_23 != null)
			{
				winElem_LeftClickButtonZavøít_64_23.Click();
			}
			else
			{
				Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_64_23}");
				return;
			}

			/*
            // LeftClick on Button "Nová karta" at (24,17)
            Console.WriteLine("LeftClick on Button \"Nová karta\" at (24,17)");
            string xpath_LeftClickButtonNovákarta_24_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty služeb\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmServiceCardList\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nová karta\"][@AutomationId=\"btnAdd_Click\"]";
            var winElem_LeftClickButtonNovákarta_24_17 = root.FindByXPath(xpath_LeftClickButtonNovákarta_24_17);
            if (winElem_LeftClickButtonNovákarta_24_17 != null)
            {
                winElem_LeftClickButtonNovákarta_24_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovákarta_24_17}");
                return;
            }


            // LeftClick on Pane "" at (72,4)
            Console.WriteLine("LeftClick on Pane \"\" at (72,4)");
            string xpath_LeftClickPane_72_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtName\"]";
            var winElem_LeftClickPane_72_4 = root.FindByXPath(xpath_LeftClickPane_72_4);
            if (winElem_LeftClickPane_72_4 != null)
            {
                winElem_LeftClickPane_72_4.Click();
                winElem_LeftClickPane_72_4.SendKeys("a");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_72_4}");
                return;
            }


            // LeftClick on Pane "" at (246,442)
            Console.WriteLine("LeftClick on Pane \"\" at (246,442)");
            string xpath_LeftClickPane_246_442 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickPane_246_442 = root.FindByXPath(xpath_LeftClickPane_246_442);
            if (winElem_LeftClickPane_246_442 != null)
            {
                winElem_LeftClickPane_246_442.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_246_442}");
                return;
            }


            // LeftClick on Pane "" at (88,6)
            Console.WriteLine("LeftClick on Pane \"\" at (88,6)");
            string xpath_LeftClickPane_88_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtShortName\"]";
            var winElem_LeftClickPane_88_6 = root.FindByXPath(xpath_LeftClickPane_88_6);
            if (winElem_LeftClickPane_88_6 != null)
            {
                winElem_LeftClickPane_88_6.Click();
                winElem_LeftClickPane_88_6.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_88_6}");
                return;
            }


            // LeftClick on Button "OK" at (55,15)
            Console.WriteLine("LeftClick on Button \"OK\" at (55,15)");
            string xpath_LeftClickButtonOK_55_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"OK\"][@AutomationId=\"btnSave_Click\"]";
            var winElem_LeftClickButtonOK_55_15 = root.FindByXPath(xpath_LeftClickButtonOK_55_15);
            if (winElem_LeftClickButtonOK_55_15 != null)
            {
                winElem_LeftClickButtonOK_55_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_55_15}");
                return;
            }


            // LeftClick on Edit "" at (274,95)
            Console.WriteLine("LeftClick on Edit \"\" at (274,95)");
            string xpath_LeftClickEdit_274_95 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"S0003\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelCard\"]/Edit[@AutomationId=\"txtRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_274_95 = root.FindByXPath(xpath_LeftClickEdit_274_95);
            if (winElem_LeftClickEdit_274_95 != null)
            {
                winElem_LeftClickEdit_274_95.Click();
                winElem_LeftClickEdit_274_95.SendKeys("a");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_274_95}");
                return;
            }


            // LeftClick on Button "Uložit" at (69,4)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (69,4)");
            string xpath_LeftClickButtonUložit_69_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"S0003\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
            var winElem_LeftClickButtonUložit_69_4 = root.FindByXPath(xpath_LeftClickButtonUložit_69_4);
            if (winElem_LeftClickButtonUložit_69_4 != null)
            {
                winElem_LeftClickButtonUložit_69_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_69_4}");
                return;
            }


            // LeftClick on Button "Ukonèit" at (16,13)
            Console.WriteLine("LeftClick on Button \"Ukonèit\" at (16,13)");
            string xpath_LeftClickButtonUkonèit_16_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"S0003\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
            var winElem_LeftClickButtonUkonèit_16_13 = root.FindByXPath(xpath_LeftClickButtonUkonèit_16_13);
            if (winElem_LeftClickButtonUkonèit_16_13 != null)
            {
                winElem_LeftClickButtonUkonèit_16_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_16_13}");
                return;
            }


            // LeftClick on Button "Zavøít" at (61,8)
            Console.WriteLine("LeftClick on Button \"Zavøít\" at (61,8)");
            string xpath_LeftClickButtonZavøít_61_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"S0003\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
            var winElem_LeftClickButtonZavøít_61_8 = root.FindByXPath(xpath_LeftClickButtonZavøít_61_8);
            if (winElem_LeftClickButtonZavøít_61_8 != null)
            {
                winElem_LeftClickButtonZavøít_61_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_61_8}");
                return;
            }
            */
			/*
            // LeftClick on DataItem "Èíslo služby row1" at (80,11)
            Console.WriteLine("LeftClick on DataItem \"Èíslo služby row1\" at (80,11)");
            string xpath_LeftClickDataItemÈísloslužb_80_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty služeb\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmServiceCardList\"]/Table[@AutomationId=\"gridServiceCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 2\"]/DataItem[@Name=\"Èíslo služby row1\"]";
            var winElem_LeftClickDataItemÈísloslužb_80_11 = root.FindByXPath(xpath_LeftClickDataItemÈísloslužb_80_11);
            if (winElem_LeftClickDataItemÈísloslužb_80_11 != null)
            {
                winElem_LeftClickDataItemÈísloslužb_80_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈísloslužb_80_11}");
                return;
            }


            // LeftClick on Button "Editovat" at (32,12)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (32,12)");
            string xpath_LeftClickButtonEditovat_32_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
            var winElem_LeftClickButtonEditovat_32_12 = root.FindByXPath(xpath_LeftClickButtonEditovat_32_12);
            if (winElem_LeftClickButtonEditovat_32_12 != null)
            {
                winElem_LeftClickButtonEditovat_32_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_32_12}");
                return;
            }


            // LeftClick on Pane "a" at (103,15)
            Console.WriteLine("LeftClick on Pane \"a\" at (103,15)");
            string xpath_LeftClickPanea_103_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@Name=\"a\"][@AutomationId=\"txtName\"]";
            var winElem_LeftClickPanea_103_15 = root.FindByXPath(xpath_LeftClickPanea_103_15);
            if (winElem_LeftClickPanea_103_15 != null)
            {
                winElem_LeftClickPanea_103_15.Click();
                winElem_LeftClickPanea_103_15.SendKeys(Keys.Tab + Keys.Tab);
                winElem_LeftClickPanea_103_15.SendKeys("a");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPanea_103_15}");
                return;
            }


            // LeftClick on Edit "" at (96,83)
            Console.WriteLine("LeftClick on Edit \"\" at (96,83)");
            string xpath_LeftClickEdit_96_83 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelCard\"]/Edit[@AutomationId=\"txtRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_96_83 = root.FindByXPath(xpath_LeftClickEdit_96_83);
            if (winElem_LeftClickEdit_96_83 != null)
            {
                winElem_LeftClickEdit_96_83.Click();
                winElem_LeftClickEdit_96_83.SendKeys("a");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_96_83}");
                return;
            }


            // LeftClick on Pane "a" at (31,18)
            Console.WriteLine("LeftClick on Pane \"a\" at (31,18)");
            string xpath_LeftClickPanea_31_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@Name=\"a\"][@AutomationId=\"txtShortName\"]";
            var winElem_LeftClickPanea_31_18 = root.FindByXPath(xpath_LeftClickPanea_31_18);
            if (winElem_LeftClickPanea_31_18 != null)
            {
                winElem_LeftClickPanea_31_18.Click();
                winElem_LeftClickPanea_31_18.SendKeys(Keys.Tab + Keys.Tab);
                winElem_LeftClickPanea_31_18.SendKeys("a");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPanea_31_18}");
                return;
            }


            // LeftClick on Button "Uložit" at (66,21)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (66,21)");
            string xpath_LeftClickButtonUložit_66_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
            var winElem_LeftClickButtonUložit_66_21 = root.FindByXPath(xpath_LeftClickButtonUložit_66_21);
            if (winElem_LeftClickButtonUložit_66_21 != null)
            {
                winElem_LeftClickButtonUložit_66_21.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_66_21}");
                return;
            }


            // LeftClick on Button "Ukonèit" at (20,16)
            Console.WriteLine("LeftClick on Button \"Ukonèit\" at (20,16)");
            string xpath_LeftClickButtonUkonèit_20_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
            var winElem_LeftClickButtonUkonèit_20_16 = root.FindByXPath(xpath_LeftClickButtonUkonèit_20_16);
            if (winElem_LeftClickButtonUkonèit_20_16 != null)
            {
                winElem_LeftClickButtonUkonèit_20_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_20_16}");
                return;
            }


            // LeftClick on DataItem " row 1" at (59,21)
            Console.WriteLine("LeftClick on DataItem \" row 1\" at (59,21)");
            string xpath_LeftClickDataItemrow1_59_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel1\"]/DataItem[@Name=\" row 1\"]";
            var winElem_LeftClickDataItemrow1_59_21 = root.FindByXPath(xpath_LeftClickDataItemrow1_59_21);
            if (winElem_LeftClickDataItemrow1_59_21 != null)
            {
                winElem_LeftClickDataItemrow1_59_21.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow1_59_21}");
                return;
            }


            // LeftClick on Button "Editovat" at (49,14)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (49,14)");
            string xpath_LeftClickButtonEditovat_49_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
            var winElem_LeftClickButtonEditovat_49_14 = root.FindByXPath(xpath_LeftClickButtonEditovat_49_14);
            if (winElem_LeftClickButtonEditovat_49_14 != null)
            {
                winElem_LeftClickButtonEditovat_49_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_49_14}");
                return;
            }


            // LeftClick on Button "Pøidat jednotku" at (50,4)
            Console.WriteLine("LeftClick on Button \"Pøidat jednotku\" at (50,4)");
            string xpath_LeftClickButtonPøidatjedn_50_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Pøidat jednotku\"][@AutomationId=\"btnAddMU_Click\"]";
            var winElem_LeftClickButtonPøidatjedn_50_4 = root.FindByXPath(xpath_LeftClickButtonPøidatjedn_50_4);
            if (winElem_LeftClickButtonPøidatjedn_50_4 != null)
            {
                winElem_LeftClickButtonPøidatjedn_50_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonPøidatjedn_50_4}");
                return;
            }


            // LeftClick on Text "" at (110,4)
            Console.WriteLine("LeftClick on Text \"\" at (110,4)");
            string xpath_LeftClickText_110_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/ComboBox[@AutomationId=\"cmbName\"]/Text";
            var winElem_LeftClickText_110_4 = root.FindByXPath(xpath_LeftClickText_110_4);
            if (winElem_LeftClickText_110_4 != null)
            {
                winElem_LeftClickText_110_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_110_4}");
                return;
            }


            // LeftClick on ListItem "% plochy" at (88,9)
            Console.WriteLine("LeftClick on ListItem \"% plochy\" at (88,9)");
            string xpath_LeftClickListItemplochy_88_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Window[starts-with(@ClassName,\"WindowsForms10\")]/List[starts-with(@ClassName,\"WindowsForms10\")]/ListItem[@Name=\"% plochy\"]";
            var winElem_LeftClickListItemplochy_88_9 = root.FindByXPath(xpath_LeftClickListItemplochy_88_9);
            if (winElem_LeftClickListItemplochy_88_9 != null)
            {
                winElem_LeftClickListItemplochy_88_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickListItemplochy_88_9}");
                return;
            }


            // LeftClick on Edit "" at (84,22)
            Console.WriteLine("LeftClick on Edit \"\" at (84,22)");
            string xpath_LeftClickEdit_84_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/Edit[@AutomationId=\"txtRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_84_22 = root.FindByXPath(xpath_LeftClickEdit_84_22);
            if (winElem_LeftClickEdit_84_22 != null)
            {
                winElem_LeftClickEdit_84_22.Click();
                winElem_LeftClickEdit_84_22.SendKeys("a");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_84_22}");
                return;
            }


            // LeftClick on Button "OK" at (32,11)
            Console.WriteLine("LeftClick on Button \"OK\" at (32,11)");
            string xpath_LeftClickButtonOK_32_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_32_11 = root.FindByXPath(xpath_LeftClickButtonOK_32_11);
            if (winElem_LeftClickButtonOK_32_11 != null)
            {
                winElem_LeftClickButtonOK_32_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_32_11}");
                return;
            }


            // LeftClick on DataItem "Mìrná jednotka row0" at (49,19)
            Console.WriteLine("LeftClick on DataItem \"Mìrná jednotka row0\" at (49,19)");
            string xpath_LeftClickDataItemMìrnájedno_49_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelMeaureUnits\"]/Table[@AutomationId=\"gridMeasureUnits\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Mìrná jednotka row0\"]";
            var winElem_LeftClickDataItemMìrnájedno_49_19 = root.FindByXPath(xpath_LeftClickDataItemMìrnájedno_49_19);
            if (winElem_LeftClickDataItemMìrnájedno_49_19 != null)
            {
                winElem_LeftClickDataItemMìrnájedno_49_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemMìrnájedno_49_19}");
                return;
            }


            // LeftClick on Button "Nahoru" at (0,3)
            Console.WriteLine("LeftClick on Button \"Nahoru\" at (0,3)");
            string xpath_LeftClickButtonNahoru_0_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"% plochy\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/Pane[@AutomationId=\"panelCoefficient\"]/Edit[@Name=\"1,0000\"][@AutomationId=\"txtCoefficient\"]/Spinner[@Name=\"Spinner\"]/Button[@Name=\"Nahoru\"]";
            var winElem_LeftClickButtonNahoru_0_3 = root.FindByXPath(xpath_LeftClickButtonNahoru_0_3);
            if (winElem_LeftClickButtonNahoru_0_3 != null)
            {
                winElem_LeftClickButtonNahoru_0_3.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNahoru_0_3}");
                return;
            }


            // LeftClick on Button "Nahoru" at (10,5)
            Console.WriteLine("LeftClick on Button \"Nahoru\" at (10,5)");
            string xpath_LeftClickButtonNahoru_10_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"% plochy\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/Pane[@AutomationId=\"panelCoefficient\"]/Edit[@Name=\"1,0000\"][@AutomationId=\"txtMainMUCoefficient\"]/Spinner[@Name=\"Spinner\"]/Button[@Name=\"Nahoru\"]";
            var winElem_LeftClickButtonNahoru_10_5 = root.FindByXPath(xpath_LeftClickButtonNahoru_10_5);
            if (winElem_LeftClickButtonNahoru_10_5 != null)
            {
                winElem_LeftClickButtonNahoru_10_5.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNahoru_10_5}");
                return;
            }


            // LeftClick on Button "OK" at (16,3)
            Console.WriteLine("LeftClick on Button \"OK\" at (16,3)");
            string xpath_LeftClickButtonOK_16_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"% plochy\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_16_3 = root.FindByXPath(xpath_LeftClickButtonOK_16_3);
            if (winElem_LeftClickButtonOK_16_3 != null)
            {
                winElem_LeftClickButtonOK_16_3.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_16_3}");
                return;
            }


            // LeftClick on DataItem " row0" at (55,8)
            Console.WriteLine("LeftClick on DataItem \" row0\" at (55,8)");
            string xpath_LeftClickDataItemrow0_55_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelMeaureUnits\"]/Table[@AutomationId=\"gridMeasureUnits\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\" row0\"]";
            var winElem_LeftClickDataItemrow0_55_8 = root.FindByXPath(xpath_LeftClickDataItemrow0_55_8);
            if (winElem_LeftClickDataItemrow0_55_8 != null)
            {
                winElem_LeftClickDataItemrow0_55_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_55_8}");
                return;
            }


            // LeftClick on Button "Uložit" at (22,18)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (22,18)");
            string xpath_LeftClickButtonUložit_22_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
            var winElem_LeftClickButtonUložit_22_18 = root.FindByXPath(xpath_LeftClickButtonUložit_22_18);
            if (winElem_LeftClickButtonUložit_22_18 != null)
            {
                winElem_LeftClickButtonUložit_22_18.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_22_18}");
                return;
            }


            // LeftClick on Button "Ukonèit" at (47,15)
            Console.WriteLine("LeftClick on Button \"Ukonèit\" at (47,15)");
            string xpath_LeftClickButtonUkonèit_47_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
            var winElem_LeftClickButtonUkonèit_47_15 = root.FindByXPath(xpath_LeftClickButtonUkonèit_47_15);
            if (winElem_LeftClickButtonUkonèit_47_15 != null)
            {
                winElem_LeftClickButtonUkonèit_47_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_47_15}");
                return;
            }


            // LeftClick on DataItem " row 2" at (60,20)
            Console.WriteLine("LeftClick on DataItem \" row 2\" at (60,20)");
            string xpath_LeftClickDataItemrow2_60_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel2\"]/DataItem[@Name=\" row 2\"]";
            var winElem_LeftClickDataItemrow2_60_20 = root.FindByXPath(xpath_LeftClickDataItemrow2_60_20);
            if (winElem_LeftClickDataItemrow2_60_20 != null)
            {
                winElem_LeftClickDataItemrow2_60_20.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow2_60_20}");
                return;
            }


            // LeftClick on Button "Editovat" at (33,12)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (33,12)");
            string xpath_LeftClickButtonEditovat_33_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
            var winElem_LeftClickButtonEditovat_33_12 = root.FindByXPath(xpath_LeftClickButtonEditovat_33_12);
            if (winElem_LeftClickButtonEditovat_33_12 != null)
            {
                winElem_LeftClickButtonEditovat_33_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_33_12}");
                return;
            }


            // LeftClick on Pane "grpSuppliers" at (62,26)
            Console.WriteLine("LeftClick on Pane \"grpSuppliers\" at (62,26)");
            string xpath_LeftClickPanegrpSupplie_62_26 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelSuppliers\"]/Pane[@Name=\"grpSuppliers\"][@AutomationId=\"grpSuppliers\"]";
            var winElem_LeftClickPanegrpSupplie_62_26 = root.FindByXPath(xpath_LeftClickPanegrpSupplie_62_26);
            if (winElem_LeftClickPanegrpSupplie_62_26 != null)
            {
                winElem_LeftClickPanegrpSupplie_62_26.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPanegrpSupplie_62_26}");
                return;
            }


            // LeftClick on Button "Nový dodavatel" at (86,15)
            Console.WriteLine("LeftClick on Button \"Nový dodavatel\" at (86,15)");
            string xpath_LeftClickButtonNovýdodava_86_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nový dodavatel\"][@AutomationId=\"btnAddSupplier_Click\"]";
            var winElem_LeftClickButtonNovýdodava_86_15 = root.FindByXPath(xpath_LeftClickButtonNovýdodava_86_15);
            if (winElem_LeftClickButtonNovýdodava_86_15 != null)
            {
                winElem_LeftClickButtonNovýdodava_86_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovýdodava_86_15}");
                return;
            }


            // LeftClick on Button "OK" at (48,15)
            Console.WriteLine("LeftClick on Button \"OK\" at (48,15)");
            string xpath_LeftClickButtonOK_48_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbSC_PickFirmCard\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_48_15 = root.FindByXPath(xpath_LeftClickButtonOK_48_15);
            if (winElem_LeftClickButtonOK_48_15 != null)
            {
                winElem_LeftClickButtonOK_48_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_48_15}");
                return;
            }


            // LeftClick on Button "Uložit" at (38,14)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (38,14)");
            string xpath_LeftClickButtonUložit_38_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
            var winElem_LeftClickButtonUložit_38_14 = root.FindByXPath(xpath_LeftClickButtonUložit_38_14);
            if (winElem_LeftClickButtonUložit_38_14 != null)
            {
                winElem_LeftClickButtonUložit_38_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_38_14}");
                return;
            }


            // LeftClick on DataItem " row 3" at (27,19)
            Console.WriteLine("LeftClick on DataItem \" row 3\" at (27,19)");
            string xpath_LeftClickDataItemrow3_27_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel3\"]/DataItem[@Name=\" row 3\"]";
            var winElem_LeftClickDataItemrow3_27_19 = root.FindByXPath(xpath_LeftClickDataItemrow3_27_19);
            if (winElem_LeftClickDataItemrow3_27_19 != null)
            {
                winElem_LeftClickDataItemrow3_27_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow3_27_19}");
                return;
            }


            // LeftClick on Button "Ukonèit" at (30,24)
            Console.WriteLine("LeftClick on Button \"Ukonèit\" at (30,24)");
            string xpath_LeftClickButtonUkonèit_30_24 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
            var winElem_LeftClickButtonUkonèit_30_24 = root.FindByXPath(xpath_LeftClickButtonUkonèit_30_24);
            if (winElem_LeftClickButtonUkonèit_30_24 != null)
            {
                winElem_LeftClickButtonUkonèit_30_24.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_30_24}");
                return;
            }


            // LeftClick on Button "Zavøít" at (35,11)
            Console.WriteLine("LeftClick on Button \"Zavøít\" at (35,11)");
            string xpath_LeftClickButtonZavøít_35_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
            var winElem_LeftClickButtonZavøít_35_11 = root.FindByXPath(xpath_LeftClickButtonZavøít_35_11);
            if (winElem_LeftClickButtonZavøít_35_11 != null)
            {
                winElem_LeftClickButtonZavøít_35_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_35_11}");
                return;
            }

            /*
            // LeftClick on DataItem "Èíslo služby row1" at (88,28)
            Console.WriteLine("LeftClick on DataItem \"Èíslo služby row1\" at (88,28)");
            string xpath_LeftClickDataItemÈísloslužb_88_28 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty služeb\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmServiceCardList\"]/Table[@AutomationId=\"gridServiceCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 2\"]/DataItem[@Name=\"Èíslo služby row1\"]";
            var winElem_LeftClickDataItemÈísloslužb_88_28 = root.FindByXPath(xpath_LeftClickDataItemÈísloslužb_88_28);
            if (winElem_LeftClickDataItemÈísloslužb_88_28 != null)
            {
                winElem_LeftClickDataItemÈísloslužb_88_28.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈísloslužb_88_28}");
                return;
            }


            // LeftClick on Button "Kopie" at (58,19)
            Console.WriteLine("LeftClick on Button \"Kopie\" at (58,19)");
            string xpath_LeftClickButtonKopie_58_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Kopie\"][@AutomationId=\"btnCopy_Click\"]";
            var winElem_LeftClickButtonKopie_58_19 = root.FindByXPath(xpath_LeftClickButtonKopie_58_19);
            if (winElem_LeftClickButtonKopie_58_19 != null)
            {
                winElem_LeftClickButtonKopie_58_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKopie_58_19}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (43,20)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (43,20)");
            string xpath_LeftClickEditPasswordTe_43_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]";
            var winElem_LeftClickEditPasswordTe_43_20 = root.FindByXPath(xpath_LeftClickEditPasswordTe_43_20);
            if (winElem_LeftClickEditPasswordTe_43_20 != null)
            {
                System.Threading.Thread.Sleep(1000);
                winElem_LeftClickEditPasswordTe_43_20.Click();
                winElem_LeftClickEditPasswordTe_43_20.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_43_20}");
                return;
            }


            // LeftClick on Button "OK" at (51,5)
            Console.WriteLine("LeftClick on Button \"OK\" at (51,5)");
            string xpath_LeftClickButtonOK_51_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_51_5 = root.FindByXPath(xpath_LeftClickButtonOK_51_5);
            if (winElem_LeftClickButtonOK_51_5 != null)
            {
                winElem_LeftClickButtonOK_51_5.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_51_5}");
                return;
            }


            // LeftClick on Button "OK" at (37,14)
            Console.WriteLine("LeftClick on Button \"OK\" at (37,14)");
            string xpath_LeftClickButtonOK_37_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Kopie karty služby\"][@AutomationId=\"mbSC_Copy\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_37_14 = root.FindByXPath(xpath_LeftClickButtonOK_37_14);
            if (winElem_LeftClickButtonOK_37_14 != null)
            {
                winElem_LeftClickButtonOK_37_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_37_14}");
                return;
            }


            // LeftClick on Button "Zavøít" at (50,14)
            Console.WriteLine("LeftClick on Button \"Zavøít\" at (50,14)");
            string xpath_LeftClickButtonZavøít_50_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0008\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
            var winElem_LeftClickButtonZavøít_50_14 = root.FindByXPath(xpath_LeftClickButtonZavøít_50_14);
            if (winElem_LeftClickButtonZavøít_50_14 != null)
            {
                winElem_LeftClickButtonZavøít_50_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_50_14}");
                return;
            }
            */
			/*      Zneplatnìní karty
            // LeftClick on DataItem "Èíslo služby row1" at (70,36)
            Console.WriteLine("LeftClick on DataItem \"Èíslo služby row1\" at (70,36)");
            string xpath_LeftClickDataItemÈísloslužb_70_36 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty služeb\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmServiceCardList\"]/Table[@AutomationId=\"gridServiceCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 2\"]/DataItem[@Name=\"Èíslo služby row1\"]";
            var winElem_LeftClickDataItemÈísloslužb_70_36 = root.FindByXPath(xpath_LeftClickDataItemÈísloslužb_70_36);
            if (winElem_LeftClickDataItemÈísloslužb_70_36 != null)
            {
                winElem_LeftClickDataItemÈísloslužb_70_36.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈísloslužb_70_36}");
                return;
            }


            // LeftClick on Button "Zneplatnit" at (33,12)
            Console.WriteLine("LeftClick on Button \"Zneplatnit\" at (33,12)");
            string xpath_LeftClickButtonZneplatnit_33_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0006\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zneplatnit\"][@AutomationId=\"btnSetInvalid_Click\"]";
            var winElem_LeftClickButtonZneplatnit_33_12 = root.FindByXPath(xpath_LeftClickButtonZneplatnit_33_12);
            if (winElem_LeftClickButtonZneplatnit_33_12 != null)
            {
                winElem_LeftClickButtonZneplatnit_33_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZneplatnit_33_12}");
                return;
            }


            // LeftClick on Button "&amp;Ano" at (65,15)
            Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (65,15)");
            string xpath_LeftClickButtonAno_65_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zneplatnìní materiálové karty\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
            var winElem_LeftClickButtonAno_65_15 = root.FindByXPath(xpath_LeftClickButtonAno_65_15);
            if (winElem_LeftClickButtonAno_65_15 != null)
            {
                winElem_LeftClickButtonAno_65_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_65_15}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (179,9)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (179,9)");
            string xpath_LeftClickEditPasswordTe_179_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_179_9 = root.FindByXPath(xpath_LeftClickEditPasswordTe_179_9);
            if (winElem_LeftClickEditPasswordTe_179_9 != null)
            {
                System.Threading.Thread.Sleep(1000);
                winElem_LeftClickEditPasswordTe_179_9.Click();
                winElem_LeftClickEditPasswordTe_179_9.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_179_9}");
                return;
            }


            // LeftClick on Button "OK" at (81,14)
            Console.WriteLine("LeftClick on Button \"OK\" at (81,14)");
            string xpath_LeftClickButtonOK_81_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_81_14 = root.FindByXPath(xpath_LeftClickButtonOK_81_14);
            if (winElem_LeftClickButtonOK_81_14 != null)
            {
                winElem_LeftClickButtonOK_81_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_81_14}");
                return;
            }
            */

			/*              Smazání karet
            // LeftClick on DataItem "Èíslo služby row1" at (47,16)
            Console.WriteLine("LeftClick on DataItem \"Èíslo služby row1\" at (47,16)");
            string xpath_LeftClickDataItemÈísloslužb_47_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty služeb\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmServiceCardList\"]/Table[@AutomationId=\"gridServiceCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 2\"]/DataItem[@Name=\"Èíslo služby row1\"]";
            var winElem_LeftClickDataItemÈísloslužb_47_16 = root.FindByXPath(xpath_LeftClickDataItemÈísloslužb_47_16);
            if (winElem_LeftClickDataItemÈísloslužb_47_16 != null)
            {
                winElem_LeftClickDataItemÈísloslužb_47_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈísloslužb_47_16}");
                return;
            }


            // LeftClick on Button "Smazat" at (29,9)
            Console.WriteLine("LeftClick on Button \"Smazat\" at (29,9)");
            string xpath_LeftClickButtonSmazat_29_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmServiceCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"S0007\"]/Pane[@AutomationId=\"ucAdmServiceCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Smazat\"][@AutomationId=\"btnDelete_Click\"]";
            var winElem_LeftClickButtonSmazat_29_9 = root.FindByXPath(xpath_LeftClickButtonSmazat_29_9);
            if (winElem_LeftClickButtonSmazat_29_9 != null)
            {
                winElem_LeftClickButtonSmazat_29_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSmazat_29_9}");
                return;
            }


            // LeftClick on Button "&amp;Ano" at (27,18)
            Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (27,18)");
            string xpath_LeftClickButtonAno_27_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Opravdu smazat?\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
            var winElem_LeftClickButtonAno_27_18 = root.FindByXPath(xpath_LeftClickButtonAno_27_18);
            if (winElem_LeftClickButtonAno_27_18 != null)
            {
                winElem_LeftClickButtonAno_27_18.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_27_18}");
                return;
            }
            */
		}

		[ClassInitialize]
		public static void ClassInitialize(TestContext context)
		{
			Setup(context, applicationPath);
		}

		[ClassCleanup]
		public static void ClassCleanup()
		{
			TearDown();
		}
	}
}
