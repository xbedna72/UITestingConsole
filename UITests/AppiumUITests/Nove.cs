using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using UnitTestProject2;

namespace UnitTestMessages
{
    [TestClass]
    public class TestMessages : AppiumApplicationSession
    {
        [TestMethod]
        public void TestMethod1()
        {
            public void Test121()
            {

                //1.1
                /*
                // LeftClick on Button "miBasicData" at (60,19)
                Console.WriteLine("LeftClick on Button \"miBasicData\" at (60,19)");
                string xpath_LeftClickButtonmiBasicDat_60_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Group[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Pøichytit nahoru\"]/ToolBar[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[@Name=\"miBasicData\"]";
                var winElem_LeftClickButtonmiBasicDat_60_19 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonmiBasicDat_60_19);
                if (winElem_LeftClickButtonmiBasicDat_60_19 != null)
                {
                    winElem_LeftClickButtonmiBasicDat_60_19.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiBasicDat_60_19}");
                    return;
                }


                // LeftClick on MenuItem "miAdmMaterialCards" at (60,11)
                Console.WriteLine("LeftClick on MenuItem \"miAdmMaterialCards\" at (60,11)");
                string xpath_LeftClickMenuItemmiAdmMater_60_11 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Menu[starts-with(@ClassName,\"WindowsForms10\")]/MenuItem[@Name=\"miAdmMaterialCards\"]";
                var winElem_LeftClickMenuItemmiAdmMater_60_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickMenuItemmiAdmMater_60_11);
                if (winElem_LeftClickMenuItemmiAdmMater_60_11 != null)
                {
                    winElem_LeftClickMenuItemmiAdmMater_60_11.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickMenuItemmiAdmMater_60_11}");
                    return;
                }


                // LeftClick on DataItem "Èíslo materiálu row0" at (37,12)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (37,12)");
                string xpath_LeftClickDataItemÈíslomater_37_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_37_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_37_12);
                if (winElem_LeftClickDataItemÈíslomater_37_12 != null)
                {
                    winElem_LeftClickDataItemÈíslomater_37_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_37_12}");
                    return;
                }


                // LeftClick on Button "Zavøít" at (20,8)
                Console.WriteLine("LeftClick on Button \"Zavøít\" at (20,8)");
                string xpath_LeftClickButtonZavøít_20_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"102\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
                var winElem_LeftClickButtonZavøít_20_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_20_8);
                if (winElem_LeftClickButtonZavøít_20_8 != null)
                {
                    winElem_LeftClickButtonZavøít_20_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_20_8}");
                    return;
                }
                */
                /*
                //1.2


                // LeftClick on Button "Nová karta" at (58,17)
                Console.WriteLine("LeftClick on Button \"Nová karta\" at (58,17)");
                string xpath_LeftClickButtonNovákarta_58_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nová karta\"][@AutomationId=\"btnAdd_Click\"]";
                var winElem_LeftClickButtonNovákarta_58_17 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNovákarta_58_17);
                if (winElem_LeftClickButtonNovákarta_58_17 != null)
                {
                    winElem_LeftClickButtonNovákarta_58_17.Click();
                }   
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovákarta_58_17}");
                    return;
                }


                // LeftClick on Edit "" at (55,7)
                Console.WriteLine("LeftClick on Edit \"\" at (55,7)");
                string xpath_LeftClickEdit_55_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Edit[@AutomationId=\"txtMaterialNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_55_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_55_7);
                if (winElem_LeftClickEdit_55_7 != null)
                {
                    winElem_LeftClickEdit_55_7.Click();
                    winElem_LeftClickEdit_55_7.SendKeys(Keys.Shift + "1" + Keys.Shift);
                    winElem_LeftClickEdit_55_7.SendKeys(Keys.Backspace + Keys.Backspace);
                    winElem_LeftClickEdit_55_7.SendKeys("100");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_55_7}");
                    return;
                }


                // LeftClick on Pane "" at (6,10)
                Console.WriteLine("LeftClick on Pane \"\" at (6,10)");
                string xpath_LeftClickPane_6_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtName\"]";
                var winElem_LeftClickPane_6_10 = root.FindElementByAbsoluteXPath(xpath_LeftClickPane_6_10);
                if (winElem_LeftClickPane_6_10 != null)
                {
                    winElem_LeftClickPane_6_10.Click();
                    winElem_LeftClickPane_6_10.SendKeys(Keys.Shift + "a" + Keys.Shift);
                    winElem_LeftClickPane_6_10.SendKeys("dame");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_6_10}");
                    return;
                }


                // LeftClick on Button "Otevøít" at (12,8)
                Console.WriteLine("LeftClick on Button \"Otevøít\" at (12,8)");
                string xpath_LeftClickButtonOtevøít_12_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@AutomationId=\"cmbGroup\"]/Button[@Name=\"Otevøít\"]";
                var winElem_LeftClickButtonOtevøít_12_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOtevøít_12_8);
                if (winElem_LeftClickButtonOtevøít_12_8 != null)
                {
                    winElem_LeftClickButtonOtevøít_12_8.Click();
                    winElem_LeftClickButtonOtevøít_12_8.SendKeys(Keys.NumberPad1 + Keys.NumberPad1);
                    winElem_LeftClickButtonOtevøít_12_8.SendKeys("/");
                    winElem_LeftClickButtonOtevøít_12_8.SendKeys(Keys.Tab + Keys.Tab);
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOtevøít_12_8}");
                    return;
                }


                // LeftClick on Button "Otevøít" at (1,11)
                Console.WriteLine("LeftClick on Button \"Otevøít\" at (1,11)");
                string xpath_LeftClickButtonOtevøít_1_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@AutomationId=\"cmbSubGroup\"]/Button[@Name=\"Otevøít\"]";
                var winElem_LeftClickButtonOtevøít_1_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOtevøít_1_11);
                if (winElem_LeftClickButtonOtevøít_1_11 != null)
                {
                    winElem_LeftClickButtonOtevøít_1_11.Click();
                    winElem_LeftClickButtonOtevøít_1_11.SendKeys(Keys.NumberPad1 + Keys.NumberPad1);
                    winElem_LeftClickButtonOtevøít_1_11.SendKeys(Keys.NumberPad0 + Keys.NumberPad0);
                    winElem_LeftClickButtonOtevøít_1_11.SendKeys(Keys.Tab + Keys.Tab);
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOtevøít_1_11}");
                    return;
                }


                // LeftClick on Pane "" at (75,16)
                Console.WriteLine("LeftClick on Pane \"\" at (75,16)");
                string xpath_LeftClickPane_75_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtShortName\"]";
                var winElem_LeftClickPane_75_16 = root.FindElementByAbsoluteXPath(xpath_LeftClickPane_75_16);
                if (winElem_LeftClickPane_75_16 != null)
                {
                    winElem_LeftClickPane_75_16.Click();
                    winElem_LeftClickPane_75_16.SendKeys(Keys.Shift + "a" + Keys.Shift);
                    winElem_LeftClickPane_75_16.SendKeys("e");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_75_16}");
                    return;
                }


                // LeftClick on Button "OK" at (24,14)
                Console.WriteLine("LeftClick on Button \"OK\" at (24,14)");
                string xpath_LeftClickButtonOK_24_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Nová materiálová karta\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"OK\"][@AutomationId=\"btnSave_Click\"]";
                var winElem_LeftClickButtonOK_24_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_24_14);
                if (winElem_LeftClickButtonOK_24_14 != null)
                {
                    winElem_LeftClickButtonOK_24_14.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_24_14}");
                    return;
                }


                // LeftClick on Button "&amp;Ano" at (58,6)
                Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (58,6)");
                string xpath_LeftClickButtonAno_58_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
                var winElem_LeftClickButtonAno_58_6 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonAno_58_6);
                if (winElem_LeftClickButtonAno_58_6 != null)
                {
                    winElem_LeftClickButtonAno_58_6.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_58_6}");
                    return;
                }


                // LeftClick on Button "Uložit" at (41,12)
                Console.WriteLine("LeftClick on Button \"Uložit\" at (41,12)");
                string xpath_LeftClickButtonUložit_41_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"100\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
                var winElem_LeftClickButtonUložit_41_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_41_12);
                if (winElem_LeftClickButtonUložit_41_12 != null)
                {
                    winElem_LeftClickButtonUložit_41_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_41_12}");
                    return;
                }


                // LeftClick on Button "Ukonèit" at (43,9)
                Console.WriteLine("LeftClick on Button \"Ukonèit\" at (43,9)");
                string xpath_LeftClickButtonUkonèit_43_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"100\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
                var winElem_LeftClickButtonUkonèit_43_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_43_9);
                if (winElem_LeftClickButtonUkonèit_43_9 != null)
                {
                    winElem_LeftClickButtonUkonèit_43_9.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_43_9}");
                    return;
                }


                // LeftClick on Button "Zavøít" at (55,7)
                Console.WriteLine("LeftClick on Button \"Zavøít\" at (55,7)");
                string xpath_LeftClickButtonZavøít_55_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"100\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
                var winElem_LeftClickButtonZavøít_55_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_55_7);
                if (winElem_LeftClickButtonZavøít_55_7 != null)
                {
                    winElem_LeftClickButtonZavøít_55_7.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_55_7}");
                    return;
                }


                //1.3

                /*
                // LeftClick on DataItem "Èíslo materiálu row0" at (63,12)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (63,12)");
                string xpath_LeftClickDataItemÈíslomater_63_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_63_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_63_12);
                if (winElem_LeftClickDataItemÈíslomater_63_12 != null)
                {
                    winElem_LeftClickDataItemÈíslomater_63_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_63_12}");
                    return;
                }


                // LeftClick on Button "Kopie" at (61,13)
                Console.WriteLine("LeftClick on Button \"Kopie\" at (61,13)");
                string xpath_LeftClickButtonKopie_61_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Kopie\"][@AutomationId=\"btnCopy_Click\"]";
                var winElem_LeftClickButtonKopie_61_13 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonKopie_61_13);
                if (winElem_LeftClickButtonKopie_61_13 != null)
                {
                    winElem_LeftClickButtonKopie_61_13.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKopie_61_13}");
                    return;
                }

                //Nefunguje

                // LeftClick on Edit "PasswordTextEdit" at (179,12)
                Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (179,12)");
                string xpath_LeftClickEditPasswordTe_179_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
                var winElem_LeftClickEditPasswordTe_179_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_179_12);
                if (winElem_LeftClickEditPasswordTe_179_12 != null)
                {
                    winElem_LeftClickEditPasswordTe_179_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_179_12}");
                    return;
                }


                // KeyboardInput VirtualKeys=""mesbrno"" CapsLock=False NumLock=True ScrollLock=False
                Console.WriteLine("KeyboardInput VirtualKeys=\"\"mesbrno\"\" CapsLock=False NumLock=True ScrollLock=False");
                System.Threading.Thread.Sleep(100);
                winElem_LeftClickEditPasswordTe_179_12.SendKeys("mesbrno");



                // LeftClick on Button "OK" at (10,1)
                Console.WriteLine("LeftClick on Button \"OK\" at (10,1)");
                string xpath_LeftClickButtonOK_10_1 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_10_1 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_10_1);
                if (winElem_LeftClickButtonOK_10_1 != null)
                {
                    winElem_LeftClickButtonOK_10_1.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_10_1}");
                    return;
                }


                // LeftClick on RadioButton "rbNewCard" at (15,9)
                Console.WriteLine("LeftClick on RadioButton \"rbNewCard\" at (15,9)");
                string xpath_LeftClickRadioButtonrbNewCard_15_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Kopie materiálové karty\"][@AutomationId=\"mbMC_Copy\"]/List[@AutomationId=\"rbGroup\"]/RadioButton[@Name=\"rbNewCard\"]";
                var winElem_LeftClickRadioButtonrbNewCard_15_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickRadioButtonrbNewCard_15_9);
                if (winElem_LeftClickRadioButtonrbNewCard_15_9 != null)
                {
                    winElem_LeftClickRadioButtonrbNewCard_15_9.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickRadioButtonrbNewCard_15_9}");
                    return;
                }


                // LeftClick on Button "OK" at (29,22)
                Console.WriteLine("LeftClick on Button \"OK\" at (29,22)");
                string xpath_LeftClickButtonOK_29_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Kopie materiálové karty\"][@AutomationId=\"mbMC_Copy\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_29_22 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_29_22);
                if (winElem_LeftClickButtonOK_29_22 != null)
                {
                    winElem_LeftClickButtonOK_29_22.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_29_22}");
                    return;
                }
                */

                //1.4

                /*
                // LeftClick on DataItem "Èíslo materiálu row0" at (46,8)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (46,8)");
                string xpath_LeftClickDataItemÈíslomater_46_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_46_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_46_8);
                if (winElem_LeftClickDataItemÈíslomater_46_8 != null)
                {
                    winElem_LeftClickDataItemÈíslomater_46_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_46_8}");
                    return;
                }


                // LeftClick on Button "Editovat" at (26,15)
                Console.WriteLine("LeftClick on Button \"Editovat\" at (26,15)");
                string xpath_LeftClickButtonEditovat_26_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
                var winElem_LeftClickButtonEditovat_26_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_26_15);
                if (winElem_LeftClickButtonEditovat_26_15 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickButtonEditovat_26_15.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_26_15}");
                    return;
                }


                // LeftClick on Pane "Adame" at (160,14)
                Console.WriteLine("LeftClick on Pane \"Adame\" at (160,14)");
                string xpath_LeftClickPaneAdame_160_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@Name=\"Adame\"][@AutomationId=\"txtName\"]";
                var winElem_LeftClickPaneAdame_160_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickPaneAdame_160_14);
                if (winElem_LeftClickPaneAdame_160_14 != null)
                {
                    winElem_LeftClickPaneAdame_160_14.Click();
                    winElem_LeftClickPaneAdame_160_14.SendKeys(Keys.Tab + Keys.Tab);
                    winElem_LeftClickPaneAdame_160_14.SendKeys("e");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPaneAdame_160_14}");
                    return;
                }


                // LeftClick on Edit "" at (309,24)
                Console.WriteLine("LeftClick on Edit \"\" at (309,24)");
                string xpath_LeftClickEdit_309_24 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelCard\"]/Pane[@AutomationId=\"panelDetailCard\"]/Edit[@AutomationId=\"txtRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_309_24 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_309_24);
                if (winElem_LeftClickEdit_309_24 != null)
                {
                    winElem_LeftClickEdit_309_24.Click();
                    winElem_LeftClickEdit_309_24.SendKeys("e");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_309_24}");
                    return;
                }


                // LeftClick on Button "Uložit" at (66,7)
                Console.WriteLine("LeftClick on Button \"Uložit\" at (66,7)");
                string xpath_LeftClickButtonUložit_66_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
                var winElem_LeftClickButtonUložit_66_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_66_7);
                if (winElem_LeftClickButtonUložit_66_7 != null)
                {
                    winElem_LeftClickButtonUložit_66_7.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_66_7}");
                    return;
                }


                // LeftClick on Pane "Ae" at (86,2)
                Console.WriteLine("LeftClick on Pane \"Ae\" at (86,2)");
                string xpath_LeftClickPaneAe_86_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@Name=\"Ae\"][@AutomationId=\"txtShortName\"]";
                var winElem_LeftClickPaneAe_86_2 = root.FindElementByAbsoluteXPath(xpath_LeftClickPaneAe_86_2);
                if (winElem_LeftClickPaneAe_86_2 != null)
                {
                    winElem_LeftClickPaneAe_86_2.Click(); 
                    winElem_LeftClickPaneAe_86_2.SendKeys(Keys.Tab + Keys.Tab);
                    winElem_LeftClickPaneAe_86_2.SendKeys("e");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPaneAe_86_2}");
                    return;
                }


                // LeftClick on Button "Ukonèit" at (25,8)
                Console.WriteLine("LeftClick on Button \"Ukonèit\" at (25,8)");
                string xpath_LeftClickButtonUkonèit_25_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
                var winElem_LeftClickButtonUkonèit_25_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_25_8);
                if (winElem_LeftClickButtonUkonèit_25_8 != null)
                {
                    winElem_LeftClickButtonUkonèit_25_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_25_8}");
                    return;
                }



                // LeftClick on Button "&amp;Ano" at (63,15)
                Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (63,15)");
                string xpath_LeftClickButtonAno_63_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit zmìny\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
                var winElem_LeftClickButtonAno_63_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonAno_63_15);
                if (winElem_LeftClickButtonAno_63_15 != null)
                {
                    winElem_LeftClickButtonAno_63_15.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_63_15}");
                    return;
                }


                // LeftClick on DataItem " row 1" at (79,18)
                Console.WriteLine("LeftClick on DataItem \" row 1\" at (79,18)");
                string xpath_LeftClickDataItemrow1_79_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel1\"]/DataItem[@Name=\" row 1\"]";
                var winElem_LeftClickDataItemrow1_79_18 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow1_79_18);
                if (winElem_LeftClickDataItemrow1_79_18 != null)
                {
                    winElem_LeftClickDataItemrow1_79_18.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow1_79_18}");
                    return;
                }


                // LeftClick on Button "Editovat" at (31,11)
                Console.WriteLine("LeftClick on Button \"Editovat\" at (31,11)");
                string xpath_LeftClickButtonEditovat_31_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
                var winElem_LeftClickButtonEditovat_31_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_31_11);
                if (winElem_LeftClickButtonEditovat_31_11 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickButtonEditovat_31_11.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_31_11}");
                    return;
                }


                // LeftClick on Button "Pøidat jednotku" at (69,8)
                Console.WriteLine("LeftClick on Button \"Pøidat jednotku\" at (69,8)");
                string xpath_LeftClickButtonPøidatjedn_69_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Pøidat jednotku\"][@AutomationId=\"btnAddMU_Click\"]";
                var winElem_LeftClickButtonPøidatjedn_69_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonPøidatjedn_69_8);
                if (winElem_LeftClickButtonPøidatjedn_69_8 != null)
                {
                    winElem_LeftClickButtonPøidatjedn_69_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonPøidatjedn_69_8}");
                    return;
                }


                // LeftClick on Text "" at (124,0)
                Console.WriteLine("LeftClick on Text \"\" at (124,0)");
                string xpath_LeftClickText_124_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/ComboBox[@AutomationId=\"cmbName\"]/Text";
                var winElem_LeftClickText_124_0 = root.FindElementByAbsoluteXPath(xpath_LeftClickText_124_0);
                if (winElem_LeftClickText_124_0 != null)
                {
                    winElem_LeftClickText_124_0.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_124_0}");
                    return;
                }


                // LeftClick on ListItem "% plochy" at (124,10)
                Console.WriteLine("LeftClick on ListItem \"% plochy\" at (124,10)");
                string xpath_LeftClickListItemplochy_124_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Window[starts-with(@ClassName,\"WindowsForms10\")]/List[starts-with(@ClassName,\"WindowsForms10\")]/ListItem[@Name=\"% plochy\"]";
                var winElem_LeftClickListItemplochy_124_10 = root.FindElementByAbsoluteXPath(xpath_LeftClickListItemplochy_124_10);
                if (winElem_LeftClickListItemplochy_124_10 != null)
                {
                    winElem_LeftClickListItemplochy_124_10.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickListItemplochy_124_10}");
                    return;
                }


                // LeftClick on Edit "" at (118,27)
                Console.WriteLine("LeftClick on Edit \"\" at (118,27)");
                string xpath_LeftClickEdit_118_27 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@AutomationId=\"ucMB\"]/Edit[@AutomationId=\"txtRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_118_27 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_118_27);
                if (winElem_LeftClickEdit_118_27 != null)
                {
                    winElem_LeftClickEdit_118_27.Click();
                    winElem_LeftClickEdit_118_27.SendKeys("e");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_118_27}");
                    return;
                }


                // LeftClick on Button "OK" at (32,17)
                Console.WriteLine("LeftClick on Button \"OK\" at (32,17)");
                string xpath_LeftClickButtonOK_32_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Pøidat MJ\"][@AutomationId=\"mbMeassureUnit\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_32_17 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_32_17);
                if (winElem_LeftClickButtonOK_32_17 != null)
                {
                    winElem_LeftClickButtonOK_32_17.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_32_17}");
                    return;
                }


                // LeftClick on DataItem " row0" at (60,12)
                Console.WriteLine("LeftClick on DataItem \" row0\" at (60,12)");
                string xpath_LeftClickDataItemrow0_60_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelMeaureUnits\"]/Table[@AutomationId=\"gridMeasureUnits\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\" row0\"]";
                var winElem_LeftClickDataItemrow0_60_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow0_60_12);
                if (winElem_LeftClickDataItemrow0_60_12 != null)
                {
                    winElem_LeftClickDataItemrow0_60_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_60_12}");
                    return;
                }


                // LeftClick on Button "Uložit" at (16,10)
                Console.WriteLine("LeftClick on Button \"Uložit\" at (16,10)");
                string xpath_LeftClickButtonUložit_16_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
                var winElem_LeftClickButtonUložit_16_10 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_16_10);
                if (winElem_LeftClickButtonUložit_16_10 != null)
                {
                    winElem_LeftClickButtonUložit_16_10.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_16_10}");
                    return;
                }


                // LeftClick on Button "Ukonèit" at (16,16)
                Console.WriteLine("LeftClick on Button \"Ukonèit\" at (16,16)");
                string xpath_LeftClickButtonUkonèit_16_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
                var winElem_LeftClickButtonUkonèit_16_16 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_16_16);
                if (winElem_LeftClickButtonUkonèit_16_16 != null)
                {
                    winElem_LeftClickButtonUkonèit_16_16.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_16_16}");
                    return;
                }


                // LeftClick on DataItem " row 2" at (77,16)
                Console.WriteLine("LeftClick on DataItem \" row 2\" at (77,16)");
                string xpath_LeftClickDataItemrow2_77_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel2\"]/DataItem[@Name=\" row 2\"]";
                var winElem_LeftClickDataItemrow2_77_16 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow2_77_16);
                if (winElem_LeftClickDataItemrow2_77_16 != null)
                {
                    winElem_LeftClickDataItemrow2_77_16.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow2_77_16}");
                    return;
                }


                // LeftClick on Button "Editovat" at (39,13)
                Console.WriteLine("LeftClick on Button \"Editovat\" at (39,13)");
                string xpath_LeftClickButtonEditovat_39_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
                var winElem_LeftClickButtonEditovat_39_13 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_39_13);
                if (winElem_LeftClickButtonEditovat_39_13 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickButtonEditovat_39_13.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_39_13}");
                    return;
                }


                // LeftClick on CheckBox "Pøedepsaný dodavatel" at (42,8)
                Console.WriteLine("LeftClick on CheckBox \"Pøedepsaný dodavatel\" at (42,8)");
                string xpath_LeftClickCheckBoxPøedepsaný_42_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelSuppliers\"]/Pane[@Name=\"grpSuppliers\"][@AutomationId=\"grpSuppliers\"]/CheckBox[@Name=\"Pøedepsaný dodavatel\"][@AutomationId=\"chbHasSuppliers\"]";
                var winElem_LeftClickCheckBoxPøedepsaný_42_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickCheckBoxPøedepsaný_42_8);
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
                var winElem_LeftClickCheckBoxPøedepsaný_90_3 = root.FindElementByAbsoluteXPath(xpath_LeftClickCheckBoxPøedepsaný_90_3);
                if (winElem_LeftClickCheckBoxPøedepsaný_90_3 != null)
                {
                    winElem_LeftClickCheckBoxPøedepsaný_90_3.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxPøedepsaný_90_3}");
                    return;
                }


                // LeftClick on Button "Nový dodavatel" at (79,8)
                Console.WriteLine("LeftClick on Button \"Nový dodavatel\" at (79,8)");
                string xpath_LeftClickButtonNovýdodava_79_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nový dodavatel\"][@AutomationId=\"btnAddSupplier_Click\"]";
                var winElem_LeftClickButtonNovýdodava_79_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNovýdodava_79_8);
                if (winElem_LeftClickButtonNovýdodava_79_8 != null)
                {
                    winElem_LeftClickButtonNovýdodava_79_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovýdodava_79_8}");
                    return;
                }


                // LeftClick on Button "OK" at (34,14)
                Console.WriteLine("LeftClick on Button \"OK\" at (34,14)");
                string xpath_LeftClickButtonOK_34_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbMC_PickFirmCard\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_34_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_34_14);
                if (winElem_LeftClickButtonOK_34_14 != null)
                {
                    winElem_LeftClickButtonOK_34_14.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_34_14}");
                    return;
                }


                // LeftClick on Button "Nový výrobce" at (43,13)
                Console.WriteLine("LeftClick on Button \"Nový výrobce\" at (43,13)");
                string xpath_LeftClickButtonNovývýrobc_43_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nový výrobce\"][@AutomationId=\"btnAddProducer_Click\"]";
                var winElem_LeftClickButtonNovývýrobc_43_13 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNovývýrobc_43_13);
                if (winElem_LeftClickButtonNovývýrobc_43_13 != null)
                {
                    winElem_LeftClickButtonNovývýrobc_43_13.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovývýrobc_43_13}");
                    return;
                }


                // LeftClick on Button "OK" at (26,19)
                Console.WriteLine("LeftClick on Button \"OK\" at (26,19)");
                string xpath_LeftClickButtonOK_26_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbMC_PickFirmCard\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_26_19 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_26_19);
                if (winElem_LeftClickButtonOK_26_19 != null)
                {
                    winElem_LeftClickButtonOK_26_19.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_26_19}");
                    return;
                }


                // LeftClick on DataItem " row0" at (37,10)
                Console.WriteLine("LeftClick on DataItem \" row0\" at (37,10)");
                string xpath_LeftClickDataItemrow0_37_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelSuppliers\"]/Pane[@Name=\"grpSuppliers\"][@AutomationId=\"grpSuppliers\"]/Table[@AutomationId=\"gridSuppliers\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\" row0\"]";
                var winElem_LeftClickDataItemrow0_37_10 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow0_37_10);
                if (winElem_LeftClickDataItemrow0_37_10 != null)
                {
                    winElem_LeftClickDataItemrow0_37_10.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_37_10}");
                    return;
                }


                // LeftClick on DataItem " row0" at (29,12)
                Console.WriteLine("LeftClick on DataItem \" row0\" at (29,12)");
                string xpath_LeftClickDataItemrow0_29_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelProducers\"]/Pane[@Name=\"grpProducers\"][@AutomationId=\"grpProducers\"]/Table[@AutomationId=\"gridProducers\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\" row0\"]";
                var winElem_LeftClickDataItemrow0_29_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow0_29_12);
                if (winElem_LeftClickDataItemrow0_29_12 != null)
                {
                    winElem_LeftClickDataItemrow0_29_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_29_12}");
                    return;
                }


                // LeftClick on Button "Nový výrobce" at (66,14)
                Console.WriteLine("LeftClick on Button \"Nový výrobce\" at (66,14)");
                string xpath_LeftClickButtonNovývýrobc_66_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nový výrobce\"][@AutomationId=\"btnAddProducer_Click\"]";
                var winElem_LeftClickButtonNovývýrobc_66_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNovývýrobc_66_14);
                if (winElem_LeftClickButtonNovývýrobc_66_14 != null)
                {
                    winElem_LeftClickButtonNovývýrobc_66_14.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovývýrobc_66_14}");
                    return;
                }


                // LeftClick on Button "OK" at (56,20)
                Console.WriteLine("LeftClick on Button \"OK\" at (56,20)");
                string xpath_LeftClickButtonOK_56_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbMC_PickFirmCard\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_56_20 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_56_20);
                if (winElem_LeftClickButtonOK_56_20 != null)
                {
                    winElem_LeftClickButtonOK_56_20.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_56_20}");
                    return;
                }


                // LeftClick on Button "Nový dodavatel" at (98,2)
                Console.WriteLine("LeftClick on Button \"Nový dodavatel\" at (98,2)");
                string xpath_LeftClickButtonNovýdodava_98_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nový dodavatel\"][@AutomationId=\"btnAddSupplier_Click\"]";
                var winElem_LeftClickButtonNovýdodava_98_2 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNovýdodava_98_2);
                if (winElem_LeftClickButtonNovýdodava_98_2 != null)
                {
                    winElem_LeftClickButtonNovýdodava_98_2.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovýdodava_98_2}");
                    return;
                }


                // LeftClick on Button "OK" at (5,8)
                Console.WriteLine("LeftClick on Button \"OK\" at (5,8)");
                string xpath_LeftClickButtonOK_5_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vybrat firmu\"][@AutomationId=\"mbMC_PickFirmCard\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_5_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_5_8);
                if (winElem_LeftClickButtonOK_5_8 != null)
                {
                    winElem_LeftClickButtonOK_5_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_5_8}");
                    return;
                }


                // LeftClick on Button "Uložit" at (27,9)
                Console.WriteLine("LeftClick on Button \"Uložit\" at (27,9)");
                string xpath_LeftClickButtonUložit_27_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
                var winElem_LeftClickButtonUložit_27_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_27_9);
                if (winElem_LeftClickButtonUložit_27_9 != null)
                {
                    winElem_LeftClickButtonUložit_27_9.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_27_9}");
                    return;
                }


                // LeftClick on Button "Ukonèit" at (39,10)
                Console.WriteLine("LeftClick on Button \"Ukonèit\" at (39,10)");
                string xpath_LeftClickButtonUkonèit_39_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
                var winElem_LeftClickButtonUkonèit_39_10 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_39_10);
                if (winElem_LeftClickButtonUkonèit_39_10 != null)
                {
                    winElem_LeftClickButtonUkonèit_39_10.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_39_10}");
                    return;
                }


                // LeftClick on Button "Zavøít" at (42,16)
                Console.WriteLine("LeftClick on Button \"Zavøít\" at (42,16)");
                string xpath_LeftClickButtonZavøít_42_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
                var winElem_LeftClickButtonZavøít_42_16 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_42_16);
                if (winElem_LeftClickButtonZavøít_42_16 != null)
                {
                    winElem_LeftClickButtonZavøít_42_16.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_42_16}");
                    return;
                }

                /*  Funguje jen neni material
                // LeftClick on DataItem "Èíslo materiálu row0" at (63,12)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (63,12)");
                string xpath_LeftClickDataItemÈíslomater_63_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_63_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_63_12);
                if (winElem_LeftClickDataItemÈíslomater_63_12 != null)
                {
                    winElem_LeftClickDataItemÈíslomater_63_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_63_12}");
                    return;
                }


                // LeftClick on DataItem " row 2" at (56,14)
                Console.WriteLine("LeftClick on DataItem \" row 2\" at (56,14)");
                string xpath_LeftClickDataItemrow2_56_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel2\"]/DataItem[@Name=\" row 2\"]";
                var winElem_LeftClickDataItemrow2_56_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow2_56_14);
                if (winElem_LeftClickDataItemrow2_56_14 != null)
                {
                    winElem_LeftClickDataItemrow2_56_14.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow2_56_14}");
                    return;
                }


                // LeftClick on Button "Editovat" at (69,8)
                Console.WriteLine("LeftClick on Button \"Editovat\" at (69,8)");
                string xpath_LeftClickButtonEditovat_69_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
                var winElem_LeftClickButtonEditovat_69_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_69_8);
                if (winElem_LeftClickButtonEditovat_69_8 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickButtonEditovat_69_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_69_8}");
                    return;
                }


                // LeftClick on CheckBox "Pøedepsaný odbìratel" at (51,6)
                Console.WriteLine("LeftClick on CheckBox \"Pøedepsaný odbìratel\" at (51,6)");
                string xpath_LeftClickCheckBoxPøedepsaný_51_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelFirms\"]/Pane[starts-with(@AutomationId,\"flowLayoutPanel\")]/Pane[@AutomationId=\"panelClients\"]/Pane[@Name=\"grpClients\"][@AutomationId=\"grpClients\"]/CheckBox[@Name=\"Pøedepsaný odbìratel\"][@AutomationId=\"chbHasClients\"]";
                var winElem_LeftClickCheckBoxPøedepsaný_51_6 = root.FindElementByAbsoluteXPath(xpath_LeftClickCheckBoxPøedepsaný_51_6);
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
                var winElem_LeftClickButtonNovýodbìra_68_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNovýodbìra_68_14);
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
                var winElem_LeftClickButtonOK_25_22 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_25_22);
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
                var winElem_LeftClickDataItemrow0_44_20 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow0_44_20);
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
                var winElem_LeftClickCheckBoxPøedepsaný_22_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickCheckBoxPøedepsaný_22_12);
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
                var winElem_LeftClickButtonUložit_21_13 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_21_13);
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
                var winElem_LeftClickButtonUkonèit_13_16 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_13_16);
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
                var winElem_LeftClickButtonZavøít_34_16 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_34_16);
                if (winElem_LeftClickButtonZavøít_34_16 != null)
                {
                    winElem_LeftClickButtonZavøít_34_16.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_34_16}");
                    return;
                }

                */

                /*
                // LeftClick on DataItem "Èíslo materiálu row0" at (13,7)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (13,7)");
                string xpath_LeftClickDataItemÈíslomater_13_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_13_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_13_7);
                if (winElem_LeftClickDataItemÈíslomater_13_7 != null)
                {
                    winElem_LeftClickDataItemÈíslomater_13_7.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_13_7}");
                    return;
                }


                // LeftClick on DataItem " row 3" at (55,14)
                Console.WriteLine("LeftClick on DataItem \" row 3\" at (55,14)");
                string xpath_LeftClickDataItemrow3_55_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel3\"]/DataItem[@Name=\" row 3\"]";
                var winElem_LeftClickDataItemrow3_55_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow3_55_14);
                if (winElem_LeftClickDataItemrow3_55_14 != null)
                {
                    winElem_LeftClickDataItemrow3_55_14.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow3_55_14}");
                    return;
                }


                // LeftClick on Button "Editovat" at (39,22)
                Console.WriteLine("LeftClick on Button \"Editovat\" at (39,22)");
                string xpath_LeftClickButtonEditovat_39_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
                var winElem_LeftClickButtonEditovat_39_22 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_39_22);
                if (winElem_LeftClickButtonEditovat_39_22 != null)  
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickButtonEditovat_39_22.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_39_22}");
                    return;
                }


                // LeftClick on CheckBox "Hoølavá" at (8,7)
                Console.WriteLine("LeftClick on CheckBox \"Hoølavá\" at (8,7)");
                string xpath_LeftClickCheckBoxHoølavá_8_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/List[@Name=\"Hoølavá\"][@AutomationId=\"clbClassifications\"]/CheckBox[@Name=\"Hoølavá\"]";
                var winElem_LeftClickCheckBoxHoølavá_8_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickCheckBoxHoølavá_8_7);
                if (winElem_LeftClickCheckBoxHoølavá_8_7 != null)
                {
                    winElem_LeftClickCheckBoxHoølavá_8_7.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxHoølavá_8_7}");
                    return;
                }


                // LeftClick on DataItem "Hodnota row2" at (40,7)
                Console.WriteLine("LeftClick on DataItem \"Hodnota row2\" at (40,7)");
                string xpath_LeftClickDataItemHodnotarow_40_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 5\"]/DataItem[@Name=\"Hodnota row2\"]";
                var winElem_LeftClickDataItemHodnotarow_40_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemHodnotarow_40_7);
                if (winElem_LeftClickDataItemHodnotarow_40_7 != null)
                {
                    winElem_LeftClickDataItemHodnotarow_40_7.Click();
                    winElem_LeftClickDataItemHodnotarow_40_7.SendKeys(Keys.Shift + "n" + Keys.Shift);
                    winElem_LeftClickDataItemHodnotarow_40_7.SendKeys(Keys.Tab + Keys.Tab);
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_40_7}");
                    return;
                }


                // LeftClick on Button "Uložit" at (49,6)
                Console.WriteLine("LeftClick on Button \"Uložit\" at (49,6)");
                string xpath_LeftClickButtonUložit_49_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
                var winElem_LeftClickButtonUložit_49_6 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_49_6);
                if (winElem_LeftClickButtonUložit_49_6 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickButtonUložit_49_6.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_49_6}");
                    return;
                }


                // LeftClick on Button "Ukonèit" at (28,12)
                Console.WriteLine("LeftClick on Button \"Ukonèit\" at (28,12)");
                string xpath_LeftClickButtonUkonèit_28_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
                var winElem_LeftClickButtonUkonèit_28_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_28_12);
                if (winElem_LeftClickButtonUkonèit_28_12 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickButtonUkonèit_28_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_28_12}");
                    return;
                }

                // LeftClick on Button "Zavøít" at (38,9)
                Console.WriteLine("LeftClick on Button \"Zavøít\" at (38,9)");
                string xpath_LeftClickButtonZavøít_38_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
                var winElem_LeftClickButtonZavøít_38_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_38_9);
                if (winElem_LeftClickButtonZavøít_38_9 != null)
                {
                    winElem_LeftClickButtonZavøít_38_9.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_38_9}");
                    return;
                }


                // LeftClick on DataItem "Èíslo materiálu row0" at (56,7)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (56,7)");
                string xpath_LeftClickDataItemÈíslomater_56_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_56_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_56_7);
                if (winElem_LeftClickDataItemÈíslomater_56_7 != null)
                {
                    winElem_LeftClickDataItemÈíslomater_56_7.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_56_7}");
                    return;
                }


                // LeftClick on DataItem " row 4" at (66,13)
                Console.WriteLine("LeftClick on DataItem \" row 4\" at (66,13)");
                string xpath_LeftClickDataItemrow4_66_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel4\"]/DataItem[@Name=\" row 4\"]";
                var winElem_LeftClickDataItemrow4_66_13 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow4_66_13);
                if (winElem_LeftClickDataItemrow4_66_13 != null)
                {
                    winElem_LeftClickDataItemrow4_66_13.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow4_66_13}");
                    return;
                }


                // LeftClick on Button "Editovat" at (50,10)
                Console.WriteLine("LeftClick on Button \"Editovat\" at (50,10)");
                string xpath_LeftClickButtonEditovat_50_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
                var winElem_LeftClickButtonEditovat_50_10 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_50_10);
                if (winElem_LeftClickButtonEditovat_50_10 != null)
                {
                    winElem_LeftClickButtonEditovat_50_10.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_50_10}");
                    return;
                }


                // LeftClick on Edit "" at (361,8)
                Console.WriteLine("LeftClick on Edit \"\" at (361,8)");
                string xpath_LeftClickEdit_361_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelIdentification\"]/Edit[@AutomationId=\"txtChemicalName\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_361_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_361_8);
                if (winElem_LeftClickEdit_361_8 != null)
                {
                    winElem_LeftClickEdit_361_8.Click();
                    winElem_LeftClickEdit_361_8.SendKeys("a");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_361_8}");
                    return;
                }


                // LeftClick on Edit "" at (343,6)
                Console.WriteLine("LeftClick on Edit \"\" at (343,6)");
                string xpath_LeftClickEdit_343_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelIdentification\"]/Edit[@AutomationId=\"txtMoleculeDescription\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_343_6 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_343_6);
                if (winElem_LeftClickEdit_343_6 != null)
                {
                    winElem_LeftClickEdit_343_6.Click();
                    winElem_LeftClickEdit_343_6.SendKeys("a");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_343_6}");
                    return;
                }


                // LeftClick on Edit "" at (13,7)
                Console.WriteLine("LeftClick on Edit \"\" at (13,7)");
                string xpath_LeftClickEdit_13_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelIdentification\"]/Edit[@AutomationId=\"txtCAS\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_13_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_13_7);
                if (winElem_LeftClickEdit_13_7 != null)
                {
                    winElem_LeftClickEdit_13_7.Click();
                    winElem_LeftClickEdit_13_7.SendKeys("a");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_13_7}");
                    return;
                }


                // LeftClick on Edit "" at (12,7)
                Console.WriteLine("LeftClick on Edit \"\" at (12,7)");
                string xpath_LeftClickEdit_12_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelIdentification\"]/Edit[@AutomationId=\"txtMoleculeWeight\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_12_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_12_7);
                if (winElem_LeftClickEdit_12_7 != null)
                {
                    winElem_LeftClickEdit_12_7.Click();
                    winElem_LeftClickEdit_12_7.SendKeys("a");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_12_7}");
                    return;
                }


                // LeftClick on Button "Uložit" at (24,12)
                Console.WriteLine("LeftClick on Button \"Uložit\" at (24,12)");
                string xpath_LeftClickButtonUložit_24_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
                var winElem_LeftClickButtonUložit_24_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_24_12);
                if (winElem_LeftClickButtonUložit_24_12 != null)
                {
                    winElem_LeftClickButtonUložit_24_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_24_12}");
                    return;
                }


                // LeftClick on Button "Ukonèit" at (1,11)
                Console.WriteLine("LeftClick on Button \"Ukonèit\" at (1,11)");
                string xpath_LeftClickButtonUkonèit_1_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
                var winElem_LeftClickButtonUkonèit_1_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_1_11);
                if (winElem_LeftClickButtonUkonèit_1_11 != null)
                {
                    winElem_LeftClickButtonUkonèit_1_11.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_1_11}");
                    return;
                }


                // LeftClick on Button "Zavøít" at (19,15)
                Console.WriteLine("LeftClick on Button \"Zavøít\" at (19,15)");
                string xpath_LeftClickButtonZavøít_19_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
                var winElem_LeftClickButtonZavøít_19_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_19_15);
                if (winElem_LeftClickButtonZavøít_19_15 != null)
                {
                    winElem_LeftClickButtonZavøít_19_15.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_19_15}");
                    return;
                }


                // LeftClick on DataItem "Èíslo materiálu row0" at (47,8)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (47,8)");
                string xpath_LeftClickDataItemÈíslomater_47_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_47_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_47_8);
                if (winElem_LeftClickDataItemÈíslomater_47_8 != null)
                {
                    winElem_LeftClickDataItemÈíslomater_47_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_47_8}");
                    return;
                }


                // LeftClick on DataItem " row 5" at (54,13)
                Console.WriteLine("LeftClick on DataItem \" row 5\" at (54,13)");
                string xpath_LeftClickDataItemrow5_54_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel5\"]/DataItem[@Name=\" row 5\"]";
                var winElem_LeftClickDataItemrow5_54_13 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow5_54_13);
                if (winElem_LeftClickDataItemrow5_54_13 != null)
                {
                    winElem_LeftClickDataItemrow5_54_13.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow5_54_13}");
                    return;
                }


                // LeftClick on Button "Editovat" at (51,15)
                Console.WriteLine("LeftClick on Button \"Editovat\" at (51,15)");
                string xpath_LeftClickButtonEditovat_51_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
                var winElem_LeftClickButtonEditovat_51_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_51_15);
                if (winElem_LeftClickButtonEditovat_51_15 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickButtonEditovat_51_15.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_51_15}");
                    return;
                }


                // LeftClick on Edit "" at (289,0)
                Console.WriteLine("LeftClick on Edit \"\" at (289,0)");
                string xpath_LeftClickEdit_289_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Edit[@AutomationId=\"txtRegionCode\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_289_0 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_289_0);
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
                var winElem_LeftClickEdit_273_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_273_11);
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
                var winElem_LeftClickPane_12_3 = root.FindElementByAbsoluteXPath(xpath_LeftClickPane_12_3);
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
                var winElem_LeftClickPane_43_4 = root.FindElementByAbsoluteXPath(xpath_LeftClickPane_43_4);
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
                var winElem_LeftClickEdit_107_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_107_7);
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
                var winElem_LeftClickEdit_233_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_233_11);
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

                // LeftClick on Button "Nahoru" at (6,5)
                Console.WriteLine("LeftClick on Button \"Nahoru\" at (6,5)");
                string xpath_LeftClickButtonNahoru_6_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Edit[@Name=\"0\"][@AutomationId=\"txtNumberOfUnits\"]/Spinner[@Name=\"Spinner\"]/Button[@Name=\"Nahoru\"]";
                var winElem_LeftClickButtonNahoru_6_5 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNahoru_6_5);
                if (winElem_LeftClickButtonNahoru_6_5 != null)
                {
                    winElem_LeftClickButtonNahoru_6_5.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNahoru_6_5}");
                    return;
                }


                // LeftClick on Edit "" at (130,10)
                Console.WriteLine("LeftClick on Edit \"\" at (130,10)");
                string xpath_LeftClickEdit_130_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelRegistration\"]/Edit[@AutomationId=\"txtSUKLCode\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_130_10 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_130_10);
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


                // LeftClick on Button "Uložit" at (42,18)
                Console.WriteLine("LeftClick on Button \"Uložit\" at (42,18)");
                string xpath_LeftClickButtonUložit_42_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
                var winElem_LeftClickButtonUložit_42_18 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_42_18);
                if (winElem_LeftClickButtonUložit_42_18 != null)
                {
                    winElem_LeftClickButtonUložit_42_18.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_42_18}");
                    return;
                }


                // LeftClick on Button "Ukonèit" at (38,8)
                Console.WriteLine("LeftClick on Button \"Ukonèit\" at (38,8)");
                string xpath_LeftClickButtonUkonèit_38_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukonèit\"][@AutomationId=\"btnFinish_Click\"]";
                var winElem_LeftClickButtonUkonèit_38_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_38_8);
                if (winElem_LeftClickButtonUkonèit_38_8 != null)
                {
                    winElem_LeftClickButtonUkonèit_38_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkonèit_38_8}");
                    return;
                }


                // LeftClick on Button "Zavøít" at (37,10)
                Console.WriteLine("LeftClick on Button \"Zavøít\" at (37,10)");
                string xpath_LeftClickButtonZavøít_37_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
                var winElem_LeftClickButtonZavøít_37_10 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_37_10);
                if (winElem_LeftClickButtonZavøít_37_10 != null)
                {
                    winElem_LeftClickButtonZavøít_37_10.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_37_10}");
                    return;
                }


                //1.5

                // LeftClick on DataItem "Èíslo materiálu row0" at (53,7)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (53,7)");
                string xpath_LeftClickDataItemÈíslomater_53_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_53_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_53_7);
                if (winElem_LeftClickDataItemÈíslomater_53_7 != null)
                {
                    winElem_LeftClickDataItemÈíslomater_53_7.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_53_7}");
                    return;
                }


                // LeftClick on Button "Smazat" at (53,19)
                Console.WriteLine("LeftClick on Button \"Smazat\" at (53,19)");
                string xpath_LeftClickButtonSmazat_53_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Smazat\"][@AutomationId=\"btnDelete_Click\"]";
                var winElem_LeftClickButtonSmazat_53_19 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonSmazat_53_19);
                if (winElem_LeftClickButtonSmazat_53_19 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickButtonSmazat_53_19.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSmazat_53_19}");
                    return;
                }


                // LeftClick on Button "&amp;Ano" at (53,10)
                Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (53,10)");
                string xpath_LeftClickButtonAno_53_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Opravdu smazat?\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
                var winElem_LeftClickButtonAno_53_10 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonAno_53_10);
                if (winElem_LeftClickButtonAno_53_10 != null)
                {
                    winElem_LeftClickButtonAno_53_10.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_53_10}");
                    return;
                }


                //1.6

                /*
                // LeftClick on DataItem "Èíslo materiálu row8" at (53,12)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row8\" at (53,12)");
                string xpath_LeftClickDataItemÈíslomater_53_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 9\"]/DataItem[@Name=\"Èíslo materiálu row8\"]";
                var winElem_LeftClickDataItemÈíslomater_53_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_53_12);
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
                var winElem_LeftClickButtonZneplatnit_60_19 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZneplatnit_60_19);
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
                var winElem_LeftClickButtonAno_37_6 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonAno_37_6);
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
                var winElem_LeftClickEditPasswordTe_151_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_151_9);
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
                var winElem_LeftClickButtonOK_48_17 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_48_17);
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

                //1.7

                /*
                // LeftClick on DataItem "Èíslo materiálu row0" at (47,12)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (47,12)");
                string xpath_LeftClickDataItemÈíslomater_47_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_47_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_47_12);
                if (winElem_LeftClickDataItemÈíslomater_47_12 != null)
                {
                    winElem_LeftClickDataItemÈíslomater_47_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_47_12}");
                    return;
                }


                // LeftClick on Button "K ovìøení" at (43,19)
                Console.WriteLine("LeftClick on Button \"K ovìøení\" at (43,19)");
                string xpath_LeftClickButtonKovìøení_43_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"K ovìøení\"][@AutomationId=\"btnSetToVerify_Click\"]";
                var winElem_LeftClickButtonKovìøení_43_19 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonKovìøení_43_19);
                if (winElem_LeftClickButtonKovìøení_43_19 != null)
                {
                    winElem_LeftClickButtonKovìøení_43_19.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKovìøení_43_19}");
                    return;
                }


                // LeftClick on Edit "PasswordTextEdit" at (72,1)
                Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (72,1)");
                string xpath_LeftClickEditPasswordTe_72_1 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
                var winElem_LeftClickEditPasswordTe_72_1 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_72_1);
                if (winElem_LeftClickEditPasswordTe_72_1 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickEditPasswordTe_72_1.Click();
                    winElem_LeftClickEditPasswordTe_72_1.SendKeys("mesbrno");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_72_1}");
                    return;
                }


                // LeftClick on Button "OK" at (13,18)
                Console.WriteLine("LeftClick on Button \"OK\" at (13,18)");
                string xpath_LeftClickButtonOK_13_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_13_18 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_13_18);
                if (winElem_LeftClickButtonOK_13_18 != null)
                {
                    winElem_LeftClickButtonOK_13_18.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_13_18}");
                    return;
                }


                // LeftClick on Button "Zamítnout" at (45,5)
                Console.WriteLine("LeftClick on Button \"Zamítnout\" at (45,5)");
                string xpath_LeftClickButtonZamítnout_45_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zamítnout\"][@AutomationId=\"btnReject_Click\"]";
                var winElem_LeftClickButtonZamítnout_45_5 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZamítnout_45_5);
                if (winElem_LeftClickButtonZamítnout_45_5 != null)
                {
                    winElem_LeftClickButtonZamítnout_45_5.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZamítnout_45_5}");
                    return;
                }


                // LeftClick on Edit "PasswordTextEdit" at (128,4)
                Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (128,4)");
                string xpath_LeftClickEditPasswordTe_128_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
                var winElem_LeftClickEditPasswordTe_128_4 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_128_4);
                if (winElem_LeftClickEditPasswordTe_128_4 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickEditPasswordTe_128_4.Click();
                    winElem_LeftClickEditPasswordTe_128_4.SendKeys("mesbrno");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_128_4}");
                    return;
                }


                // LeftClick on Button "OK" at (89,6)
                Console.WriteLine("LeftClick on Button \"OK\" at (89,6)");
                string xpath_LeftClickButtonOK_89_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_89_6 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_89_6);
                if (winElem_LeftClickButtonOK_89_6 != null)
                {
                    winElem_LeftClickButtonOK_89_6.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_89_6}");
                    return;
                }


                // LeftClick on Button "K ovìøení" at (49,8)
                Console.WriteLine("LeftClick on Button \"K ovìøení\" at (49,8)");
                string xpath_LeftClickButtonKovìøení_49_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"K ovìøení\"][@AutomationId=\"btnSetToVerify_Click\"]";
                var winElem_LeftClickButtonKovìøení_49_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonKovìøení_49_8);
                if (winElem_LeftClickButtonKovìøení_49_8 != null)
                {
                    winElem_LeftClickButtonKovìøení_49_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKovìøení_49_8}");
                    return;
                }


                // LeftClick on Edit "PasswordTextEdit" at (31,2)
                Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (31,2)");
                string xpath_LeftClickEditPasswordTe_31_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]";
                var winElem_LeftClickEditPasswordTe_31_2 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_31_2);
                if (winElem_LeftClickEditPasswordTe_31_2 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickEditPasswordTe_31_2.Click();
                    winElem_LeftClickEditPasswordTe_31_2.SendKeys("mesbrno");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_31_2}");
                    return;
                }


                // LeftClick on Button "OK" at (4,2)
                Console.WriteLine("LeftClick on Button \"OK\" at (4,2)");
                string xpath_LeftClickButtonOK_4_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_4_2 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_4_2);
                if (winElem_LeftClickButtonOK_4_2 != null)
                {
                    winElem_LeftClickButtonOK_4_2.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_4_2}");
                    return;
                }


                // LeftClick on Button "Ovìøit" at (20,8)
                Console.WriteLine("LeftClick on Button \"Ovìøit\" at (20,8)");
                string xpath_LeftClickButtonOvìøit_20_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ovìøit\"][@AutomationId=\"btnSetVerified_Click\"]";
                var winElem_LeftClickButtonOvìøit_20_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOvìøit_20_8);
                if (winElem_LeftClickButtonOvìøit_20_8 != null)
                {
                    winElem_LeftClickButtonOvìøit_20_8.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOvìøit_20_8}");
                    return;
                }


                // LeftClick on Edit "PasswordTextEdit" at (97,5)
                Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (97,5)");
                string xpath_LeftClickEditPasswordTe_97_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
                var winElem_LeftClickEditPasswordTe_97_5 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_97_5);
                if (winElem_LeftClickEditPasswordTe_97_5 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickEditPasswordTe_97_5.Click();
                    winElem_LeftClickEditPasswordTe_97_5.SendKeys("mesbrno");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_97_5}");
                    return;
                }


                // LeftClick on Button "OK" at (67,17)
                Console.WriteLine("LeftClick on Button \"OK\" at (67,17)");
                string xpath_LeftClickButtonOK_67_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_67_17 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_67_17);
                if (winElem_LeftClickButtonOK_67_17 != null)
                {
                    winElem_LeftClickButtonOK_67_17.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_67_17}");
                    return;
                }


                // LeftClick on Button "Zamítnout" at (73,7)
                Console.WriteLine("LeftClick on Button \"Zamítnout\" at (73,7)");
                string xpath_LeftClickButtonZamítnout_73_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zamítnout\"][@AutomationId=\"btnReject_Click\"]";
                var winElem_LeftClickButtonZamítnout_73_7 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZamítnout_73_7);
                if (winElem_LeftClickButtonZamítnout_73_7 != null)
                {
                    winElem_LeftClickButtonZamítnout_73_7.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZamítnout_73_7}");
                    return;
                }


                // LeftClick on Edit "PasswordTextEdit" at (29,5)
                Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (29,5)");
                string xpath_LeftClickEditPasswordTe_29_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
                var winElem_LeftClickEditPasswordTe_29_5 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_29_5);
                if (winElem_LeftClickEditPasswordTe_29_5 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickEditPasswordTe_29_5.Click();
                    winElem_LeftClickEditPasswordTe_29_5.SendKeys("mesbrno");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_29_5}");
                    return;
                }


                // LeftClick on Button "OK" at (13,22)
                Console.WriteLine("LeftClick on Button \"OK\" at (13,22)");
                string xpath_LeftClickButtonOK_13_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_13_22 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_13_22);
                if (winElem_LeftClickButtonOK_13_22 != null)
                {
                    winElem_LeftClickButtonOK_13_22.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_13_22}");
                    return;
                }


                // LeftClick on Button "Ovìøit" at (64,6)
                Console.WriteLine("LeftClick on Button \"Ovìøit\" at (64,6)");
                string xpath_LeftClickButtonOvìøit_64_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ovìøit\"][@AutomationId=\"btnSetVerified_Click\"]";
                var winElem_LeftClickButtonOvìøit_64_6 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOvìøit_64_6);
                if (winElem_LeftClickButtonOvìøit_64_6 != null)
                {
                    winElem_LeftClickButtonOvìøit_64_6.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOvìøit_64_6}");
                    return;
                }


                // LeftClick on Edit "PasswordTextEdit" at (56,0)
                Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (56,0)");
                string xpath_LeftClickEditPasswordTe_56_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
                var winElem_LeftClickEditPasswordTe_56_0 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_56_0);
                if (winElem_LeftClickEditPasswordTe_56_0 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickEditPasswordTe_56_0.Click();
                    winElem_LeftClickEditPasswordTe_56_0.SendKeys("mesbrno");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_56_0}");
                    return;
                }


                // LeftClick on Button "OK" at (3,13)
                Console.WriteLine("LeftClick on Button \"OK\" at (3,13)");
                string xpath_LeftClickButtonOK_3_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_3_13 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_3_13);
                if (winElem_LeftClickButtonOK_3_13 != null)
                {
                    winElem_LeftClickButtonOK_3_13.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_3_13}");
                    return;
                }


                // LeftClick on Button "Schválit" at (60,9)
                Console.WriteLine("LeftClick on Button \"Schválit\" at (60,9)");
                string xpath_LeftClickButtonSchválit_60_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Schválit\"][@AutomationId=\"btnApprove_Click\"]";
                var winElem_LeftClickButtonSchválit_60_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonSchválit_60_9);
                if (winElem_LeftClickButtonSchválit_60_9 != null)
                {
                    winElem_LeftClickButtonSchválit_60_9.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSchválit_60_9}");
                    return;
                }
                // LeftClick on Edit "PasswordTextEdit" at (120,9)
                Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (120,9)");
                string xpath_LeftClickEditPasswordTe_120_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
                var winElem_LeftClickEditPasswordTe_120_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_120_9);
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
                var winElem_LeftClickButtonOK_80_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_80_14);
                if (winElem_LeftClickButtonOK_80_14 != null)
                {
                    winElem_LeftClickButtonOK_80_14.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_80_14}");
                    return;
                }


                // LeftClick on Button "Vydat" at (61,20)
                Console.WriteLine("LeftClick on Button \"Vydat\" at (61,20)");
                string xpath_LeftClickButtonVydat_61_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Vydat\"][@AutomationId=\"btnSetValid_Click\"]";
                var winElem_LeftClickButtonVydat_61_20 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonVydat_61_20);
                if (winElem_LeftClickButtonVydat_61_20 != null)
                {
                    winElem_LeftClickButtonVydat_61_20.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonVydat_61_20}");
                    return;
                }


                // LeftClick on Button "OK" at (52,12)
                Console.WriteLine("LeftClick on Button \"OK\" at (52,12)");
                string xpath_LeftClickButtonOK_52_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vydání\"][@AutomationId=\"mbDeferredValidity\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_52_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_52_12);
                if (winElem_LeftClickButtonOK_52_12 != null)
                {
                    winElem_LeftClickButtonOK_52_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_52_12}");
                    return;
                }


                // LeftClick on Edit "PasswordTextEdit" at (225,8)
                Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (225,8)");
                string xpath_LeftClickEditPasswordTe_225_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
                var winElem_LeftClickEditPasswordTe_225_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_225_8);
                if (winElem_LeftClickEditPasswordTe_225_8 != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    winElem_LeftClickEditPasswordTe_225_8.Click();
                    winElem_LeftClickEditPasswordTe_225_8.SendKeys("mesbrno");
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_225_8}");
                    return;
                }


                // LeftClick on Button "OK" at (35,11)
                Console.WriteLine("LeftClick on Button \"OK\" at (35,11)");
                string xpath_LeftClickButtonOK_35_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Autorizace\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
                var winElem_LeftClickButtonOK_35_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_35_11);
                if (winElem_LeftClickButtonOK_35_11 != null)
                {
                    winElem_LeftClickButtonOK_35_11.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_35_11}");
                    return;
                }


                // LeftClick on Button "Zavøít" at (41,21)
                Console.WriteLine("LeftClick on Button \"Zavøít\" at (41,21)");
                string xpath_LeftClickButtonZavøít_41_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"100\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
                var winElem_LeftClickButtonZavøít_41_21 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_41_21);
                if (winElem_LeftClickButtonZavøít_41_21 != null)
                {
                    winElem_LeftClickButtonZavøít_41_21.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_41_21}");
                    return;
                }

                //1.8

                // LeftClick on DataItem "Èíslo materiálu row0" at (22,17)
                Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (22,17)");
                string xpath_LeftClickDataItemÈíslomater_22_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
                var winElem_LeftClickDataItemÈíslomater_22_17 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈíslomater_22_17);
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
                var winElem_LeftClickDataItemrow6_59_25 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow6_59_25);
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
                var winElem_LeftClickDataItemrow0_54_13 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow0_54_13);
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
                var winElem_LeftClickButtonZavøít_24_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_24_12);
                if (winElem_LeftClickButtonZavøít_24_12 != null)
                {
                    winElem_LeftClickButtonZavøít_24_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_24_12}");
                    return;
                }
                */
            }
            public void Test2()
            {

                // LeftClick on Button "miBasicData" at (60,19)
                Console.WriteLine("LeftClick on Button \"miBasicData\" at (60,19)");
                string xpath_LeftClickButtonmiBasicDat_60_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Group[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Pøichytit nahoru\"]/ToolBar[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[@Name=\"miBasicData\"]";
                var winElem_LeftClickButtonmiBasicDat_60_19 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonmiBasicDat_60_19);
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
                var winElem_LeftClickMenuItemmiAdmServi_53_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickMenuItemmiAdmServi_53_8);
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
                var winElem_LeftClickDataItemÈísloslužb_63_6 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈísloslužb_63_6);
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
                var winElem_LeftClickButtonZavøít_64_23 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_64_23);
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
                var winElem_LeftClickButtonNovákarta_24_17 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNovákarta_24_17);
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
                var winElem_LeftClickPane_72_4 = root.FindElementByAbsoluteXPath(xpath_LeftClickPane_72_4);
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
                var winElem_LeftClickPane_246_442 = root.FindElementByAbsoluteXPath(xpath_LeftClickPane_246_442);
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
                var winElem_LeftClickPane_88_6 = root.FindElementByAbsoluteXPath(xpath_LeftClickPane_88_6);
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
                var winElem_LeftClickButtonOK_55_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_55_15);
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
                var winElem_LeftClickEdit_274_95 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_274_95);
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
                var winElem_LeftClickButtonUložit_69_4 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_69_4);
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
                var winElem_LeftClickButtonUkonèit_16_13 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_16_13);
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
                var winElem_LeftClickButtonZavøít_61_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_61_8);
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
                var winElem_LeftClickDataItemÈísloslužb_80_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈísloslužb_80_11);
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
                var winElem_LeftClickButtonEditovat_32_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_32_12);
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
                var winElem_LeftClickPanea_103_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickPanea_103_15);
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
                var winElem_LeftClickEdit_96_83 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_96_83);
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
                var winElem_LeftClickPanea_31_18 = root.FindElementByAbsoluteXPath(xpath_LeftClickPanea_31_18);
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
                var winElem_LeftClickButtonUložit_66_21 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_66_21);
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
                var winElem_LeftClickButtonUkonèit_20_16 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_20_16);
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
                var winElem_LeftClickDataItemrow1_59_21 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow1_59_21);
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
                var winElem_LeftClickButtonEditovat_49_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_49_14);
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
                var winElem_LeftClickButtonPøidatjedn_50_4 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonPøidatjedn_50_4);
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
                var winElem_LeftClickText_110_4 = root.FindElementByAbsoluteXPath(xpath_LeftClickText_110_4);
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
                var winElem_LeftClickListItemplochy_88_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickListItemplochy_88_9);
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
                var winElem_LeftClickEdit_84_22 = root.FindElementByAbsoluteXPath(xpath_LeftClickEdit_84_22);
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
                var winElem_LeftClickButtonOK_32_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_32_11);
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
                var winElem_LeftClickDataItemMìrnájedno_49_19 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemMìrnájedno_49_19);
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
                var winElem_LeftClickButtonNahoru_0_3 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNahoru_0_3);
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
                var winElem_LeftClickButtonNahoru_10_5 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNahoru_10_5);
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
                var winElem_LeftClickButtonOK_16_3 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_16_3);
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
                var winElem_LeftClickDataItemrow0_55_8 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow0_55_8);
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
                var winElem_LeftClickButtonUložit_22_18 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_22_18);
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
                var winElem_LeftClickButtonUkonèit_47_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_47_15);
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
                var winElem_LeftClickDataItemrow2_60_20 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow2_60_20);
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
                var winElem_LeftClickButtonEditovat_33_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonEditovat_33_12);
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
                var winElem_LeftClickPanegrpSupplie_62_26 = root.FindElementByAbsoluteXPath(xpath_LeftClickPanegrpSupplie_62_26);
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
                var winElem_LeftClickButtonNovýdodava_86_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonNovýdodava_86_15);
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
                var winElem_LeftClickButtonOK_48_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_48_15);
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
                var winElem_LeftClickButtonUložit_38_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUložit_38_14);
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
                var winElem_LeftClickDataItemrow3_27_19 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemrow3_27_19);
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
                var winElem_LeftClickButtonUkonèit_30_24 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonUkonèit_30_24);
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
                var winElem_LeftClickButtonZavøít_35_11 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_35_11);
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
                var winElem_LeftClickDataItemÈísloslužb_88_28 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈísloslužb_88_28);
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
                var winElem_LeftClickButtonKopie_58_19 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonKopie_58_19);
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
                var winElem_LeftClickEditPasswordTe_43_20 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_43_20);
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
                var winElem_LeftClickButtonOK_51_5 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_51_5);
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
                var winElem_LeftClickButtonOK_37_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_37_14);
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
                var winElem_LeftClickButtonZavøít_50_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZavøít_50_14);
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
                var winElem_LeftClickDataItemÈísloslužb_70_36 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈísloslužb_70_36);
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
                var winElem_LeftClickButtonZneplatnit_33_12 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonZneplatnit_33_12);
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
                var winElem_LeftClickButtonAno_65_15 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonAno_65_15);
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
                var winElem_LeftClickEditPasswordTe_179_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickEditPasswordTe_179_9);
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
                var winElem_LeftClickButtonOK_81_14 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonOK_81_14);
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
                var winElem_LeftClickDataItemÈísloslužb_47_16 = root.FindElementByAbsoluteXPath(xpath_LeftClickDataItemÈísloslužb_47_16);
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
                var winElem_LeftClickButtonSmazat_29_9 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonSmazat_29_9);
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
                var winElem_LeftClickButtonAno_27_18 = root.FindElementByAbsoluteXPath(xpath_LeftClickButtonAno_27_18);
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


        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }
    }
}
