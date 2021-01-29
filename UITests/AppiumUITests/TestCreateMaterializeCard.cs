using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using ReportManager;
using System.Windows.Forms;
using Castle.Core.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation;

namespace TestCreateMaterializeCard
{
    [TestClass]
    public class UnitTestMaterializeCard : SessionSettingClass
    {
        string materialNumber = "Nová materiálová karta";
        string materialName = "UnitTestMaterializeCard " + DateTime.Now.ToString();
        string materialGroup = "2 - Obaly";
        string materialSubGroup = "21 - Primární obaly";
        string materialShortCut = "Test";

        [TestMethod]
        public void TestCreateMaterializedCardMethod()
        {
            if (OpenMaterialCardList())
            {
                Console.WriteLine($"Failed to open Material cards list");
                return;
            }

            if (CreateMaterilizedCard(materialGroup, materialSubGroup))
            {
                Console.WriteLine($"Failed to create Material card");
                return;
            }

            if (FindAndOpenMaterialCard())
            {
                Console.WriteLine($"Failed to find or opem  Material card");
                return;
            }

            if (TestMaterialCard())
            {
                Console.WriteLine($"Failed to test information in Material card");
                return;
            }

            if (DeleteMaterialCard())
            {
                Console.WriteLine($"Failed to delete Material card");
                return;
            }
        }

        [ClassInitialize()]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context, applicationPath);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        public static string getRandNum()
        {
            Random r = new Random();
            return r.Next(999999).ToString();
        }

        //returns false if succesfull
        public bool DeleteMaterialCard()
        {
            // LeftClick on Button "Smazat" at (15,4)
            Console.WriteLine("LeftClick on Button \"Smazat\" at (15,4)");
            string xpath_LeftClickButtonSmazat_15_4 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Smazat\"][@AutomationId=\"btnDelete_Click\"]";
            var winElem_LeftClickButtonSmazat_15_4 = root.FindByXPath(xpath_LeftClickButtonSmazat_15_4);
            if (winElem_LeftClickButtonSmazat_15_4 != null)
            {
                winElem_LeftClickButtonSmazat_15_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSmazat_15_4}");
                return true;
            }

            // LeftClick on Button "&amp;Ano" at (60,9)
            Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (60,9)");
            string xpath_LeftClickButtonAno_60_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Opravdu smazat?\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
            var winElem_LeftClickButtonAno_60_9 = root.FindByXPath(xpath_LeftClickButtonAno_60_9);
            if (winElem_LeftClickButtonAno_60_9 != null)
            {
                winElem_LeftClickButtonAno_60_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_60_9}");
                return true;
            }

            return false;
        }

        //returns false if succesfull
        public bool TestMaterialCard()
        { // LeftClick on Edit "128605" at (5,5)
            Console.WriteLine("LeftClick on Edit \"128605\" at (5,5)");
            string xpath_LeftClickEdit128605_5_5 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Edit[@Name=\"{materialNumber}\"][@AutomationId=\"txtMaterialNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]";
            var winElem_LeftClickEdit128605_5_5 = root.FindByXPath(xpath_LeftClickEdit128605_5_5);
            if (winElem_LeftClickEdit128605_5_5 != null)
            {
                winElem_LeftClickEdit128605_5_5.Click();
                winElem_LeftClickEdit128605_5_5.SendKeys("test");
                Assert.AreEqual(winElem_LeftClickEdit128605_5_5.Text, materialNumber);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit128605_5_5}");
                return true;
            }
            
            // LeftClick on Text "2 - Obaly" at (105,11)
            Console.WriteLine("LeftClick on Text \"2 - Obaly\" at (105,11)");
            string xpath_LeftClickText2Obaly_105_11 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@Name=\"{materialGroup}\"][@AutomationId=\"cmbGroup\"]/Text[@Name=\"{materialGroup}\"]";
            var winElem_LeftClickText2Obaly_105_11 = root.FindByXPath(xpath_LeftClickText2Obaly_105_11);
            if (winElem_LeftClickText2Obaly_105_11 != null)
            {
                winElem_LeftClickText2Obaly_105_11.Click();
                winElem_LeftClickText2Obaly_105_11.SendKeys("test");
                Assert.AreEqual(winElem_LeftClickText2Obaly_105_11.Text, materialGroup);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText2Obaly_105_11}");
                return true;
            }

            // LeftClick on Text "205 - Etikety" at (153,13)
            Console.WriteLine("LeftClick on Text \"205 - Etikety\" at (153,13)");
            string xpath_LeftClickText205Etikety_153_13 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@Name=\"{materialSubGroup}\"][@AutomationId=\"cmbSubGroup\"]/Text[@Name=\"{materialSubGroup}\"]";
            var winElem_LeftClickText205Etikety_153_13 = root.FindByXPath(xpath_LeftClickText205Etikety_153_13);
            if (winElem_LeftClickText205Etikety_153_13 != null)
            {
                winElem_LeftClickText205Etikety_153_13.Click();
                winElem_LeftClickText205Etikety_153_13.SendKeys("test");
                Assert.AreEqual(winElem_LeftClickText205Etikety_153_13.Text, materialSubGroup);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText205Etikety_153_13}");
                return true;
            }
            return false;
        }

        //returns false if succesfull
        public bool FindAndOpenMaterialCard()
        {
            Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu filter row\" at (64,11)");
            string xpath_LeftClickDataItemÈíslomater_64_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Øádek filtru\"]/DataItem[@Name=\"Èíslo materiálu filter row\"]";
            var winElem_LeftClickDataItemÈíslomater_64_11 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_64_11);
            if (winElem_LeftClickDataItemÈíslomater_64_11 != null)
            {
                winElem_LeftClickDataItemÈíslomater_64_11.Click();
                winElem_LeftClickDataItemÈíslomater_64_11.SendKeys(materialNumber);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_64_11}");
                return true;
            }

            // LeftClick on DataItem "Èíslo materiálu row0" at (26,10)
            Console.WriteLine("LeftClick on DataItem \"Èíslo materiálu row0\" at (26,10)");
            string xpath_LeftClickDataItemÈíslomater_26_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Karty materiálù\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucAdmMaterialCardList\"]/Table[@AutomationId=\"gridMaterialCards\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 1\"]/DataItem[@Name=\"Èíslo materiálu row0\"]";
            var winElem_LeftClickDataItemÈíslomater_26_10 = root.FindByXPath(xpath_LeftClickDataItemÈíslomater_26_10);
            if (winElem_LeftClickDataItemÈíslomater_26_10 != null)
            {
                winElem_LeftClickDataItemÈíslomater_26_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemÈíslomater_26_10}");
                return true;
            }

            return false;
        }

        //returns false if succesfull
        public bool OpenMaterialCardList()
        {
            // LeftClick on Button "miProductionOrders" at (26,5)
            Console.WriteLine("LeftClick on Button \"miLIMS\" at (26,5)");
            string xpath_LeftClickButtonmiProducti_26_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Group[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Pøichytit nahoru\"]/ToolBar[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[@Name=\"miProductionOrders\"]";
            var winElem_LeftClickButtonmiProducti_26_5 = desktopSession.FindByName("miBasicData");
            if (winElem_LeftClickButtonmiProducti_26_5 != null)
            {
                winElem_LeftClickButtonmiProducti_26_5.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiProducti_26_5}");
                return true;
            }

            // LeftClick on MenuItem "miAdmMaterialCards" at (114,13)
            Console.WriteLine("LeftClick on MenuItem \"miAdmMaterialCards\" at (114,13)");
            string xpath_LeftClickMenuItemmiAdmMater_114_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Menu[starts-with(@ClassName,\"WindowsForms10\")]/MenuItem[@Name=\"miAdmMaterialCards\"]";
            var winElem_LeftClickMenuItemmiAdmMater_114_13 = root.FindByXPath(xpath_LeftClickMenuItemmiAdmMater_114_13);
            if (winElem_LeftClickMenuItemmiAdmMater_114_13 != null)
            {
                winElem_LeftClickMenuItemmiAdmMater_114_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickMenuItemmiAdmMater_114_13}");
                return true;
            }
            return false;
        }

        //returns false if succesfull
        public bool InputBAsicInfoMaterialCard(string mMaterialNumber, string mMaterialGroup, string mMaterialSubGroup)
        {
            if (!mMaterialNumber.IsNullOrEmpty())
            {
                // LeftClick on Edit "" at (14,4)
                Console.WriteLine("LeftClick on Edit \"\" at (14,4)");
                string xpath_LeftClickEdit_14_4 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"{materialNumber}\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Edit[@AutomationId=\"txtMaterialNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
                var winElem_LeftClickEdit_14_4 = root.FindByXPath(xpath_LeftClickEdit_14_4);
                if (winElem_LeftClickEdit_14_4 != null)
                {
                    winElem_LeftClickEdit_14_4.Click();
                    winElem_LeftClickEdit_14_4.SendKeys(mMaterialNumber);
                }
            }

            if (!materialName.IsNullOrEmpty())
            {
                // LeftClick on Pane "" at (344,12)
                Console.WriteLine("LeftClick on Pane \"\" at (344,12)");
                string xpath_LeftClickPane_344_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"{materialNumber}\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtName\"]";
                var winElem_LeftClickPane_344_12 = root.FindByXPath(xpath_LeftClickPane_344_12);
                if (winElem_LeftClickPane_344_12 != null)
                {
                    winElem_LeftClickPane_344_12.Click();
                    winElem_LeftClickPane_344_12.SendKeys(materialName);
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_344_12}");
                    return true;
                }
            }
            // LeftClick on Pane "panelCommonUp" at (819,28)
            Console.WriteLine("LeftClick on Pane \"panelCommonUp\" at (819,28)");
            string xpath_LeftClickPanepanelCommo_819_28 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"{materialNumber}\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]";
            var winElem_LeftClickPanepanelCommo_819_28 = root.FindByXPath(xpath_LeftClickPanepanelCommo_819_28);
            if (winElem_LeftClickPanepanelCommo_819_28 != null)
            {
                winElem_LeftClickPanepanelCommo_819_28.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPanepanelCommo_819_28}");
                return true;
            }

            if (!mMaterialGroup.IsNullOrEmpty())
            {
                // LeftClick on Text "" at (140,8)
                Console.WriteLine("LeftClick on Text \"\" at (140,8)");
                string xpath_LeftClickText_140_8 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"{materialNumber}\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@AutomationId=\"cmbGroup\"]/Text";
                var winElem_LeftClickText_140_8 = root.FindByXPath(xpath_LeftClickText_140_8);
                if (winElem_LeftClickText_140_8 != null)
                {
                    winElem_LeftClickText_140_8.Click();
                    winElem_LeftClickText_140_8.SendKeys(mMaterialGroup);
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_140_8}");
                    return true;
                }
            }

            if (!mMaterialSubGroup.IsNullOrEmpty())
            {
                // LeftClick on Text "" at (176,10)
                Console.WriteLine("LeftClick on Text \"\" at (176,10)");
                string xpath_LeftClickText_176_10 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"{materialNumber}\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/ComboBox[@AutomationId=\"cmbSubGroup\"]/Text";
                var winElem_LeftClickText_176_10 = root.FindByXPath(xpath_LeftClickText_176_10);
                if (winElem_LeftClickText_176_10 != null)
                {
                    winElem_LeftClickText_176_10.Click();
                    winElem_LeftClickText_176_10.SendKeys(mMaterialSubGroup);
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_176_10}");
                    return true;
                }
            }
            if (!materialShortCut.IsNullOrEmpty())
            {
                // LeftClick on Pane "" at (76,12)
                Console.WriteLine("LeftClick on Pane \"\" at (76,12)");
                string xpath_LeftClickPane_76_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"{materialNumber}\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"panelCommonUp\"][@AutomationId=\"panelCommonUp\"]/Pane[@AutomationId=\"txtShortName\"]";
                var winElem_LeftClickPane_76_12 = root.FindByXPath(xpath_LeftClickPane_76_12);
                if (winElem_LeftClickPane_76_12 != null)
                {
                    winElem_LeftClickPane_76_12.Click();
                    winElem_LeftClickPane_76_12.SendKeys(materialShortCut);
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_76_12}");
                    return true;
                }
            }
            return false;
        }


        //returns false if succesfull
        public bool ChangeMaterialCard(string mMaterialNumber, string mMaterialGroup, string mMaterialSubGroup)
        {
            // LeftClick on Button "Editovat" at (14,8)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (14,8)");
            string xpath_LeftClickButtonEditovat_14_8 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"{materialNumber}\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnChange_Click\"]";
            var winElem_LeftClickButtonEditovat_14_8 = root.FindByAccessibilityId("btnChange_Click");
            if (winElem_LeftClickButtonEditovat_14_8 != null)
            {
                winElem_LeftClickButtonEditovat_14_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_14_8}");
                return true;
            }

            if (!(mMaterialNumber.IsNullOrEmpty() && mMaterialGroup.IsNullOrEmpty() && mMaterialSubGroup.IsNullOrEmpty()))
            {
                if (InputBAsicInfoMaterialCard(mMaterialNumber, materialGroup, materialSubGroup))
                {
                    Console.WriteLine($"Failed to delete Material card");
                    return true;
                }

                // LeftClick on Button "Uložit" at (17,12)
                Console.WriteLine("LeftClick on Button \"Uložit\" at (17,12)");
                string xpath_LeftClickButtonUložit_17_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"{materialNumber}\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
                var winElem_LeftClickButtonUložit_17_12 = root.FindByXPath(xpath_LeftClickButtonUložit_17_12);
                if (winElem_LeftClickButtonUložit_17_12 != null)
                {
                    winElem_LeftClickButtonUložit_17_12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_17_12}");
                    return true;
                }

            }

            // LeftClick on DataItem " row 3" at (42,11)
            Console.WriteLine("LeftClick on DataItem \" row 3\" at (42,11)");
            string xpath_LeftClickDataItemrow3_42_11 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel3\"]/DataItem[@Name=\" row 3\"]";
            var winElem_LeftClickDataItemrow3_42_11 = root.FindByXPath(xpath_LeftClickDataItemrow3_42_11);
            if (winElem_LeftClickDataItemrow3_42_11 != null)
            {
                winElem_LeftClickDataItemrow3_42_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow3_42_11}");
                return true;
            }

            // LeftClick on DataItem "Hodnota row7" at(15, 12)
            Console.WriteLine("LeftClick on DataItem \"Hodnota row7\" at (15,12)");
            string xpath_LeftClickDataItemHodnotarow_15_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[starts-with(@AutomationId,\"tableLayoutPanel\")]/Pane[@Name=\"sccLR\"][@AutomationId=\"sccLR\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"panelParams\"]/Table[@AutomationId=\"gridParams\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 11\"]/DataItem[@Name=\"Hodnota row7\"]";
            var winElem_LeftClickDataItemHodnotarow_15_12 = root.FindByXPath(xpath_LeftClickDataItemHodnotarow_15_12);
            if (winElem_LeftClickDataItemHodnotarow_15_12 != null)
            {
                winElem_LeftClickDataItemHodnotarow_15_12.Click();
                winElem_LeftClickDataItemHodnotarow_15_12.SendKeys("Nedefino");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemHodnotarow_15_12}");
                return true;
            }

            // LeftClick on Button "Uložit" at (17,12)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (17,12)");
            var winElem_LeftClickButtonUložit_1_12 = root.FindByAccessibilityId("btnSave_Click");
            if (winElem_LeftClickButtonUložit_1_12 != null)
            {
                winElem_LeftClickButtonUložit_1_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element with accessibility Id: btnSave_Click");
                return true;
            }
            // LeftClick on Button "Ukonèit" at (17,4)
            Console.WriteLine("LeftClick on Button \"Ukonèit\" at (17,4)");
            var winElem_LeftClickButtonUkonèit_17_4 = root.FindByAccessibilityId("btnFinish_Click");
            if (winElem_LeftClickButtonUkonèit_17_4 != null)
            {
                winElem_LeftClickButtonUkonèit_17_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element with accessibility Id: btnFinish_Click");
                return true;
            }
            return false;
        }

        //returns false if succesfull
        public bool CreateMaterilizedCard(string mMaterialGroup, string mMaterialSubGroup)
        {
            string mMaterialNumber = getRandNum();
            materialNumber = "Nová materiálová karta";

            // LeftClick on Button "Nová karta" at (47,8)
            Console.WriteLine("LeftClick on Button \"Nová karta\" at (47,8)");
            var winElem_LeftClickButtonNovákarta_47_8 = root.FindByAccessibilityId("btnAdd_Click");
            if (winElem_LeftClickButtonNovákarta_47_8 != null)
            {
                winElem_LeftClickButtonNovákarta_47_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element by Accessibility Id: btnAdd_Click");
                return true;
            }

            if (InputBAsicInfoMaterialCard(mMaterialNumber, materialGroup, materialSubGroup))
            {
                Console.WriteLine($"Failed to delete Material card");
                return true;
            }

            // LeftClick on Button "OK" at (35,10)
            Console.WriteLine("LeftClick on Button \"OK\" at (35,10)");
            string xpath_LeftClickButtonOK_35_10 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"{materialNumber}\"][starts-with(@AutomationId,\"tp_\")]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"OK\"][@AutomationId=\"btnSave_Click\"]";
            var winElem_LeftClickButtonOK_35_10 = root.FindByXPath(xpath_LeftClickButtonOK_35_10);
            if (winElem_LeftClickButtonOK_35_10 != null)
            {
                winElem_LeftClickButtonOK_35_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_35_10}");
                return true;
            }



            materialNumber = mMaterialNumber;
            // LeftClick on Button "Ukonèit" at (17,4)
            Console.WriteLine("LeftClick on Button \"Ukonèit\" at (17,4)");
            var winElem_LeftClickButtonUkonèit_17_4 = root.FindByAccessibilityId("btnFinish_Click");
            if (winElem_LeftClickButtonUkonèit_17_4 != null)
            {
                winElem_LeftClickButtonUkonèit_17_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element with accessible Id: btnFinish_Click");
                return true;
            }

            if (ChangeMaterialCard(null, null, null))
            {
                Console.WriteLine($"Failed to delete Material card");
                return true;
            }
           

            // LeftClick on Button "Zavøít" at (43,7)
            Console.WriteLine("LeftClick on Button \"Zavøít\" at (43,7)");
            string xpath_LeftClickButtonZavøít_43_7 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmAdmMaterialCards\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{materialNumber}\"]/Pane[@AutomationId=\"ucAdmMaterialCard\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Zavøít\"][@AutomationId=\"btnClose_Click\"]";
            var winElem_LeftClickButtonZavøít_43_7 = root.FindByAccessibilityId("btnClose_Click");
            if (winElem_LeftClickButtonZavøít_43_7 != null)
            {
                winElem_LeftClickButtonZavøít_43_7.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavøít_43_7}");
                return true;
            }
            return false;
        }
    }
}
