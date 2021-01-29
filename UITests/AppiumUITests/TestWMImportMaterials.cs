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

namespace TestEditMaterializeCard
{
    [TestClass]
    public class UnitTestWMImportMaterials : SessionSettingClass
    {
        string deliveryDocNumber = "2008";
        string DeliveryNumber = "666";
        string deliveryDocumentNo;
        #region import material

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

        [TestMethod]
        public void TestMethod1()
        {
            // LeftClick on Button "miWM" at (44,7)
            Console.WriteLine("LeftClick on Button \"miWM\" at (44,7)");
            string xpath_LeftClickButtonmiWM_44_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Group[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Přichytit nahoru\"]/ToolBar[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[@Name=\"miWM\"]";
            var winElem_LeftClickButtonmiWM_44_7 = root.FindByXPath(xpath_LeftClickButtonmiWM_44_7);
            if (winElem_LeftClickButtonmiWM_44_7 != null)
            {
                winElem_LeftClickButtonmiWM_44_7.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiWM_44_7}");
                return;
            }


            // LeftClick on MenuItem "miWMImport" at (45,11)
            Console.WriteLine("LeftClick on MenuItem \"miWMImport\" at (45,11)");
            string xpath_LeftClickMenuItemmiWMImport_45_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Menu[starts-with(@ClassName,\"WindowsForms10\")]/MenuItem[@Name=\"miWMImport\"]";
            var winElem_LeftClickMenuItemmiWMImport_45_11 = root.FindByXPath(xpath_LeftClickMenuItemmiWMImport_45_11);
            if (winElem_LeftClickMenuItemmiWMImport_45_11 != null)
            {
                winElem_LeftClickMenuItemmiWMImport_45_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickMenuItemmiWMImport_45_11}");
                return;
            }


            // LeftClick on MenuItem "miWMImportMaterial" at (161,14)
            Console.WriteLine("LeftClick on MenuItem \"miWMImportMaterial\" at (161,14)");
            string xpath_LeftClickMenuItemmiWMImport_161_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Menu[starts-with(@ClassName,\"WindowsForms10\")]/MenuItem[@Name=\"miWMImportMaterial\"]";
            var winElem_LeftClickMenuItemmiWMImport_161_14 = root.FindByXPath(xpath_LeftClickMenuItemmiWMImport_161_14);
            if (winElem_LeftClickMenuItemmiWMImport_161_14 != null)
            {
                winElem_LeftClickMenuItemmiWMImport_161_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickMenuItemmiWMImport_161_14}");
                return;
            }


            // LeftClick on DataItem "Číslo dokladu row0" at (39,9)
            Console.WriteLine("LeftClick on DataItem \"Číslo dokladu row0\" at (39,9)");
            string xpath_LeftClickDataItemČíslodokla_39_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Řádek 1\"]/DataItem[@Name=\"Číslo dokladu row0\"]";
            var winElem_LeftClickDataItemČíslodokla_39_9 = root.FindByXPath(xpath_LeftClickDataItemČíslodokla_39_9);
            if (winElem_LeftClickDataItemČíslodokla_39_9 != null)
            {
                winElem_LeftClickDataItemČíslodokla_39_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslodokla_39_9}");
                return;
            }


            // LeftClick on Button "Zavřít" at (7,13)
            Console.WriteLine("LeftClick on Button \"Zavřít\" at (7,13)");
            string xpath_LeftClickButtonZavřít_7_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2120000004\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavřít\"]";
            var winElem_LeftClickButtonZavřít_7_13 = root.FindByXPath(xpath_LeftClickButtonZavřít_7_13);
            if (winElem_LeftClickButtonZavřít_7_13 != null)
            {
                winElem_LeftClickButtonZavřít_7_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavřít_7_13}");
                return;
            }


            filteringWM();

            createNewWMImport();

            editingWM();


            createWMMaterial();


            createWMMaterial2();


            printing();

        }

        private static void editingWM()
        {
            // LeftClick on DataItem "Číslo dokladu row0" at (110,10)
            Console.WriteLine("LeftClick on DataItem \"Číslo dokladu row0\" at (110,10)");
            string xpath_LeftClickDataItemČíslodokla_110_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Řádek 1\"]/DataItem[@Name=\"Číslo dokladu row0\"]";
            var winElem_LeftClickDataItemČíslodokla_110_10 = root.FindByXPath(xpath_LeftClickDataItemČíslodokla_110_10);
            if (winElem_LeftClickDataItemČíslodokla_110_10 != null)
            {
                winElem_LeftClickDataItemČíslodokla_110_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslodokla_110_10}");
                return;
            }



            // LeftClick on Button "Editovat" at (43,7)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (43,7)");
            string xpath_LeftClickButtonEditovat_43_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_43_7 = root.FindByXPath(xpath_LeftClickButtonEditovat_43_7);
            if (winElem_LeftClickButtonEditovat_43_7 != null)
            {
                winElem_LeftClickButtonEditovat_43_7.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_43_7}");
                return;
            }


            // LeftClick on Edit "" at (127,113)
            Console.WriteLine("LeftClick on Edit \"\" at (127,113)");
            string xpath_LeftClickEdit_127_113 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Edit[@AutomationId=\"memoRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_127_113 = root.FindByXPath(xpath_LeftClickEdit_127_113);
            if (winElem_LeftClickEdit_127_113 != null)
            {
                winElem_LeftClickEdit_127_113.Click();
                winElem_LeftClickEdit_127_113.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_127_113}");
                return;
            }


            // LeftClick on Button "Uložit" at (15,15)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (15,15)");
            string xpath_LeftClickButtonUložit_15_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_15_15 = root.FindByXPath(xpath_LeftClickButtonUložit_15_15);
            if (winElem_LeftClickButtonUložit_15_15 != null)
            {
                winElem_LeftClickButtonUložit_15_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_15_15}");
                return;
            }


            // LeftClick on Button "Ukončit" at (37,17)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (37,17)");
            string xpath_LeftClickButtonUkončit_37_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_37_17 = root.FindByXPath(xpath_LeftClickButtonUkončit_37_17);
            if (winElem_LeftClickButtonUkončit_37_17 != null)
            {
                winElem_LeftClickButtonUkončit_37_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_37_17}");
                return;
            }


            // LeftClick on Button "Editovat" at (28,15)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (28,15)");
            string xpath_LeftClickButtonEditovat_28_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_28_15 = root.FindByXPath(xpath_LeftClickButtonEditovat_28_15);
            if (winElem_LeftClickButtonEditovat_28_15 != null)
            {
                winElem_LeftClickButtonEditovat_28_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_28_15}");
                return;
            }


            // LeftClick on Button "Načíst objednávky" at (74,19)
            Console.WriteLine("LeftClick on Button \"Načíst objednávky\" at (74,19)");
            string xpath_LeftClickButtonNačístobje_74_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Načíst objednávky\"]";
            var winElem_LeftClickButtonNačístobje_74_19 = root.FindByXPath(xpath_LeftClickButtonNačístobje_74_19);
            if (winElem_LeftClickButtonNačístobje_74_19 != null)
            {
                winElem_LeftClickButtonNačístobje_74_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNačístobje_74_19}");
                return;
            }


            // LeftClick on Button "Storno" at (50,15)
            Console.WriteLine("LeftClick on Button \"Storno\" at (50,15)");
            string xpath_LeftClickButtonStorno_50_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Načíst objednávky\"][@AutomationId=\"mbWMOrdersFromINTF\"]/Pane[@Name=\"panelControl1\"][starts-with(@AutomationId,\"panelControl\")]/Button[@Name=\"Storno\"][@AutomationId=\"btnStorno\"]";
            var winElem_LeftClickButtonStorno_50_15 = root.FindByXPath(xpath_LeftClickButtonStorno_50_15);
            if (winElem_LeftClickButtonStorno_50_15 != null)
            {
                winElem_LeftClickButtonStorno_50_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_50_15}");
                return;
            }


            // LeftClick on Button "Ukončit" at (55,22)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (55,22)");
            string xpath_LeftClickButtonUkončit_55_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_55_22 = root.FindByXPath(xpath_LeftClickButtonUkončit_55_22);
            if (winElem_LeftClickButtonUkončit_55_22 != null)
            {
                winElem_LeftClickButtonUkončit_55_22.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_55_22}");
                return;
            }


            // LeftClick on Button "Editovat" at (35,10)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (35,10)");
            string xpath_LeftClickButtonEditovat_35_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_35_10 = root.FindByXPath(xpath_LeftClickButtonEditovat_35_10);
            if (winElem_LeftClickButtonEditovat_35_10 != null)
            {
                winElem_LeftClickButtonEditovat_35_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_35_10}");
                return;
            }


            // LeftClick on Edit "" at (47,11)
            Console.WriteLine("LeftClick on Edit \"\" at (47,11)");
            string xpath_LeftClickEdit_47_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelHeader\"][@AutomationId=\"panelHeader\"]/Pane[@AutomationId=\"ucWMImportMaterial\"]/Edit[@AutomationId=\"txtDeliveryNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_47_11 = root.FindByXPath(xpath_LeftClickEdit_47_11);
            if (winElem_LeftClickEdit_47_11 != null)
            {
                winElem_LeftClickEdit_47_11.Click();
                winElem_LeftClickEdit_47_11.SendKeys(Keys.NumberPad1);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_47_11}");
                return;
            }


            // LeftClick on DataItem "Příjemka row 1" at (27,15)
            Console.WriteLine("LeftClick on DataItem \"Příjemka row 1\" at (27,15)");
            string xpath_LeftClickDataItemPříjemkaro_27_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeOverview\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node1\"]/DataItem[@Name=\"Příjemka row 1\"]";
            var winElem_LeftClickDataItemPříjemkaro_27_15 = root.FindByXPath(xpath_LeftClickDataItemPříjemkaro_27_15);
            if (winElem_LeftClickDataItemPříjemkaro_27_15 != null)
            {
                winElem_LeftClickDataItemPříjemkaro_27_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemPříjemkaro_27_15}");
                return;
            }
        }

        private static void filteringWM()
        {
            // LeftClick on Button "Parametry výběru" at (7,68)
            Console.WriteLine("LeftClick on Button \"Parametry výběru\" at (7,68)");
            string xpath_LeftClickButtonParametryv_7_68 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"AutoHideContainer Left\"][@AutomationId=\"hideContainerLeft\"]/Button[@Name=\"Parametry výběru\"]";
            var winElem_LeftClickButtonParametryv_7_68 = root.FindByXPath(xpath_LeftClickButtonParametryv_7_68);
            if (winElem_LeftClickButtonParametryv_7_68 != null)
            {
                winElem_LeftClickButtonParametryv_7_68.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonParametryv_7_68}");
                return;
            }


            // LeftClick on CheckBox "Zobrazit doklady 61 a 65" at (11,7)
            Console.WriteLine("LeftClick on CheckBox \"Zobrazit doklady 61 a 65\" at (11,7)");
            string xpath_LeftClickCheckBoxZobrazitdo_11_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@Name=\"Parametry výběru\"][@AutomationId=\"dpFilter\"]/Pane[@AutomationId=\"dockPanel1_Container\"]/CheckBox[@Name=\"Zobrazit doklady 61 a 65\"][@AutomationId=\"chbInventoryMoves\"]";
            var winElem_LeftClickCheckBoxZobrazitdo_11_7 = root.FindByXPath(xpath_LeftClickCheckBoxZobrazitdo_11_7);
            if (winElem_LeftClickCheckBoxZobrazitdo_11_7 != null)
            {
                winElem_LeftClickCheckBoxZobrazitdo_11_7.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxZobrazitdo_11_7}");
                return;
            }


            // LeftClick on CheckBox "Zobrazit stornované doklady" at (23,10)
            Console.WriteLine("LeftClick on CheckBox \"Zobrazit stornované doklady\" at (23,10)");
            string xpath_LeftClickCheckBoxZobrazitst_23_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@Name=\"Parametry výběru\"][@AutomationId=\"dpFilter\"]/Pane[@AutomationId=\"dockPanel1_Container\"]/CheckBox[@Name=\"Zobrazit stornované doklady\"][@AutomationId=\"chbShowStorno\"]";
            var winElem_LeftClickCheckBoxZobrazitst_23_10 = root.FindByXPath(xpath_LeftClickCheckBoxZobrazitst_23_10);
            if (winElem_LeftClickCheckBoxZobrazitst_23_10 != null)
            {
                winElem_LeftClickCheckBoxZobrazitst_23_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxZobrazitst_23_10}");
                return;
            }


            // LeftClick on Text "2020" at (115,9)
            Console.WriteLine("LeftClick on Text \"2020\" at (115,9)");
            string xpath_LeftClickText2020_115_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@Name=\"Parametry výběru\"][@AutomationId=\"dpFilter\"]/Pane[@AutomationId=\"dockPanel1_Container\"]/ComboBox[@Name=\"2020\"][@AutomationId=\"cmbFiscalYear\"]/Text[@Name=\"2020\"]";
            var winElem_LeftClickText2020_115_9 = root.FindByXPath(xpath_LeftClickText2020_115_9);
            if (winElem_LeftClickText2020_115_9 != null)
            {
                winElem_LeftClickText2020_115_9.Click();
                winElem_LeftClickText2020_115_9.SendKeys(Keys.NumberPad2 + Keys.NumberPad0);
                winElem_LeftClickText2020_115_9.SendKeys(Keys.NumberPad1);
                winElem_LeftClickText2020_115_9.SendKeys(Keys.NumberPad9);
                winElem_LeftClickText2020_115_9.SendKeys(Keys.Tab);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText2020_115_9}");
                return;
            }


            // LeftClick on Button "Obnovit" at (38,12)
            Console.WriteLine("LeftClick on Button \"Obnovit\" at (38,12)");
            string xpath_LeftClickButtonObnovit_38_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@Name=\"Parametry výběru\"][@AutomationId=\"dpFilter\"]/Pane[@AutomationId=\"dockPanel1_Container\"]/Button[@Name=\"Obnovit\"][@AutomationId=\"btnApply\"]";
            var winElem_LeftClickButtonObnovit_38_12 = root.FindByXPath(xpath_LeftClickButtonObnovit_38_12);
            if (winElem_LeftClickButtonObnovit_38_12 != null)
            {
                winElem_LeftClickButtonObnovit_38_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonObnovit_38_12}");
                return;
            }


            // LeftClick on TabItem "Seznam dokladů" at (75,10)
            Console.WriteLine("LeftClick on TabItem \"Seznam dokladů\" at (75,10)");
            string xpath_LeftClickTabItemSeznamdokl_75_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/TabItem[@Name=\"Seznam dokladů\"]";
            var winElem_LeftClickTabItemSeznamdokl_75_10 = root.FindByXPath(xpath_LeftClickTabItemSeznamdokl_75_10);
            if (winElem_LeftClickTabItemSeznamdokl_75_10 != null)
            {
                winElem_LeftClickTabItemSeznamdokl_75_10.Click();
                winElem_LeftClickTabItemSeznamdokl_75_10.Click();
                winElem_LeftClickTabItemSeznamdokl_75_10.Click();
                winElem_LeftClickTabItemSeznamdokl_75_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickTabItemSeznamdokl_75_10}");
                return;
            }
        }

        private static void printing()
        {
            // LeftClick on Header "Stav" at (89,9)
            Console.WriteLine("LeftClick on Header \"Stav\" at (89,9)");
            string xpath_LeftClickHeaderStav_89_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Panel záhlaví\"]/Header[@Name=\"Stav\"]";
            var winElem_LeftClickHeaderStav_89_9 = root.FindByXPath(xpath_LeftClickHeaderStav_89_9);
            if (winElem_LeftClickHeaderStav_89_9 != null)
            {
                winElem_LeftClickHeaderStav_89_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickHeaderStav_89_9}");
                return;
            }


            // LeftClick on Header "Stav" at (41,25)
            Console.WriteLine("LeftClick on Header \"Stav\" at (41,25)");
            string xpath_LeftClickHeaderStav_41_25 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Panel záhlaví\"]/Header[@Name=\"Stav\"]";
            var winElem_LeftClickHeaderStav_41_25 = root.FindByXPath(xpath_LeftClickHeaderStav_41_25);
            if (winElem_LeftClickHeaderStav_41_25 != null)
            {
                winElem_LeftClickHeaderStav_41_25.Click();
                winElem_LeftClickHeaderStav_41_25.SendKeys(Keys.PageUp + Keys.PageUp);
                winElem_LeftClickHeaderStav_41_25.SendKeys(Keys.PageUp + Keys.PageUp);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickHeaderStav_41_25}");
                return;
            }



            // LeftClick on DataItem "Číslo dokladu row0" at (77,9)
            Console.WriteLine("LeftClick on DataItem \"Číslo dokladu row0\" at (77,9)");
            string xpath_LeftClickDataItemČíslodokla_77_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Řádek 1\"]/DataItem[@Name=\"Číslo dokladu row0\"]";
            var winElem_LeftClickDataItemČíslodokla_77_9 = root.FindByXPath(xpath_LeftClickDataItemČíslodokla_77_9);
            if (winElem_LeftClickDataItemČíslodokla_77_9 != null)
            {
                winElem_LeftClickDataItemČíslodokla_77_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslodokla_77_9}");
                return;
            }


            // LeftClick on DataItem "Příjemka row 1" at (51,11)
            Console.WriteLine("LeftClick on DataItem \"Příjemka row 1\" at (51,11)");
            string xpath_LeftClickDataItemPříjemkaro_51_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000008\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeOverview\"]/Group[@Name=\"Datový Panel\"]/TreeItem[@Name=\"Uzel1\"]/DataItem[@Name=\"Příjemka row 1\"]";
            var winElem_LeftClickDataItemPříjemkaro_51_11 = root.FindByXPath(xpath_LeftClickDataItemPříjemkaro_51_11);
            if (winElem_LeftClickDataItemPříjemkaro_51_11 != null)
            {
                winElem_LeftClickDataItemPříjemkaro_51_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemPříjemkaro_51_11}");
                return;
            }


            // LeftClick on DataItem "Číslo materiálu row0" at (76,18)
            Console.WriteLine("LeftClick on DataItem \"Číslo materiálu row0\" at (76,18)");
            string xpath_LeftClickDataItemČíslomater_76_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000008\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[@Name=\"Seznam položek\"][@AutomationId=\"tabPageGridMaterials\"]/Table[@AutomationId=\"gridMaterials\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Řádek 1\"]/DataItem[@Name=\"Číslo materiálu row0\"]";
            var winElem_LeftClickDataItemČíslomater_76_18 = root.FindByXPath(xpath_LeftClickDataItemČíslomater_76_18);
            if (winElem_LeftClickDataItemČíslomater_76_18 != null)
            {
                winElem_LeftClickDataItemČíslomater_76_18.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslomater_76_18}");
                return;
            }


            // LeftClick on Button "Tisk štítků" at (46,14)
            Console.WriteLine("LeftClick on Button \"Tisk štítků\" at (46,14)");
            string xpath_LeftClickButtonTiskštítků_46_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000008\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Tisk štítků\"]";
            var winElem_LeftClickButtonTiskštítků_46_14 = root.FindByXPath(xpath_LeftClickButtonTiskštítků_46_14);
            if (winElem_LeftClickButtonTiskštítků_46_14 != null)
            {
                winElem_LeftClickButtonTiskštítků_46_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonTiskštítků_46_14}");
                return;
            }


            // LeftClick on Button "Zrušit" at (29,9)
            Console.WriteLine("LeftClick on Button \"Zrušit\" at (29,9)");
            string xpath_LeftClickButtonZrušit_29_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@ClassName=\"#32770\"][@Name=\"Tisk\"]/Button[@ClassName=\"Button\"][@Name=\"Zrušit\"]";
            var winElem_LeftClickButtonZrušit_29_9 = root.FindByXPath(xpath_LeftClickButtonZrušit_29_9);
            if (winElem_LeftClickButtonZrušit_29_9 != null)
            {
                winElem_LeftClickButtonZrušit_29_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZrušit_29_9}");
                return;
            }


            // LeftClick on Button "Zavřít" at (48,17)
            Console.WriteLine("LeftClick on Button \"Zavřít\" at (48,17)");
            string xpath_LeftClickButtonZavřít_48_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000008\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavřít\"]";
            var winElem_LeftClickButtonZavřít_48_17 = root.FindByXPath(xpath_LeftClickButtonZavřít_48_17);
            if (winElem_LeftClickButtonZavřít_48_17 != null)
            {
                winElem_LeftClickButtonZavřít_48_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavřít_48_17}");
                return;
            }


            // LeftClick on Button "Zavřít" at (39,21)
            Console.WriteLine("LeftClick on Button \"Zavřít\" at (39,21)");
            string xpath_LeftClickButtonZavřít_39_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000008\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavřít\"]";
            var winElem_LeftClickButtonZavřít_39_21 = root.FindByXPath(xpath_LeftClickButtonZavřít_39_21);
            if (winElem_LeftClickButtonZavřít_39_21 != null)
            {
                winElem_LeftClickButtonZavřít_39_21.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavřít_39_21}");
                return;
            }
        }

        private void createWMMaterial2()
        {
            // LeftClick on Button "Nová položka" at (42,17)
            Console.WriteLine("LeftClick on Button \"Nová položka\" at (42,17)");
            string xpath_LeftClickButtonNovápoložk_42_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová položka\"]";
            var winElem_LeftClickButtonNovápoložk_42_17 = root.FindByXPath(xpath_LeftClickButtonNovápoložk_42_17);
            if (winElem_LeftClickButtonNovápoložk_42_17 != null)
            {
                winElem_LeftClickButtonNovápoložk_42_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovápoložk_42_17}");
                return;
            }


            // LeftClick on DataItem "Číslo materiálu row4" at (112,7)
            Console.WriteLine("LeftClick on DataItem \"Číslo materiálu row4\" at (112,7)");
            string xpath_LeftClickDataItemČíslomater_112_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Přidat materiál\"][@AutomationId=\"mbWMAddMaterialToTransferItem\"]/Table[@AutomationId=\"gridMaterialSelect\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 5\"]/DataItem[@Name=\"Číslo materiálu row4\"]";
            var winElem_LeftClickDataItemČíslomater_112_7 = root.FindByXPath(xpath_LeftClickDataItemČíslomater_112_7);
            if (winElem_LeftClickDataItemČíslomater_112_7 != null)
            {
                winElem_LeftClickDataItemČíslomater_112_7.Click();
                winElem_LeftClickDataItemČíslomater_112_7.SendKeys(Keys.Space);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslomater_112_7}");
                return;
            }


            TestMethodFunction1();


            // LeftClick on Edit "" at (76,15)
            Console.WriteLine("LeftClick on Edit \"\" at (76,15)");
            string xpath_LeftClickEdit_76_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtDeliveredAmount\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_76_15 = root.FindByXPath(xpath_LeftClickEdit_76_15);
            if (winElem_LeftClickEdit_76_15 != null)
            {
                winElem_LeftClickEdit_76_15.Click();
                winElem_LeftClickEdit_76_15.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_76_15}");
                return;
            }


            // LeftClick on Edit "0" at (66,3)
            Console.WriteLine("LeftClick on Edit \"0\" at (66,3)");
            string xpath_LeftClickEdit0_66_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@Name=\"0\"][@AutomationId=\"spinWrapUnitsCount\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0\"]";
            var winElem_LeftClickEdit0_66_3 = root.FindByXPath(xpath_LeftClickEdit0_66_3);
            if (winElem_LeftClickEdit0_66_3 != null)
            {
                winElem_LeftClickEdit0_66_3.Click();
                System.Threading.Thread.Sleep(100);
                winElem_LeftClickEdit0_66_3.SendKeys(Keys.NumberPad2);
                winElem_LeftClickEdit0_66_3.SendKeys(Keys.Delete);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit0_66_3}");
                return;
            }


            // LeftClick on Button "" at (8,4)
            Console.WriteLine("LeftClick on Button \"\" at (8,4)");
            string xpath_LeftClickButton_8_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@AutomationId=\"btnWrapUnitsOk\"]";
            var winElem_LeftClickButton_8_4 = root.FindByXPath(xpath_LeftClickButton_8_4);
            if (winElem_LeftClickButton_8_4 != null)
            {
                winElem_LeftClickButton_8_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_8_4}");
                return;
            }


            TestMethodFunction2();

            // LeftClick on Button "Open" at (15,8)
            Console.WriteLine("LeftClick on Button \"Open\" at (15,8)");
            string xpath_LeftClickButtonOpen_15_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@Name=\"Sklad příjmu\"][@AutomationId=\"peSelectTargetLocation\"]/Button[@Name=\"Open\"]";
            var winElem_LeftClickButtonOpen_15_8 = root.FindByXPath(xpath_LeftClickButtonOpen_15_8);
            if (winElem_LeftClickButtonOpen_15_8 != null)
            {
                winElem_LeftClickButtonOpen_15_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOpen_15_8}");
                return;
            }


            // LeftClick on Button "Uložit" at (20,12)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (20,12)");
            string xpath_LeftClickButtonUložit_20_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_20_12 = root.FindByXPath(xpath_LeftClickButtonUložit_20_12);
            if (winElem_LeftClickButtonUložit_20_12 != null)
            {
                winElem_LeftClickButtonUložit_20_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_20_12}");
                return;
            }


            // LeftClick on Button "Ukončit" at (56,12)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (56,12)");
            string xpath_LeftClickButtonUkončit_56_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_56_12 = root.FindByXPath(xpath_LeftClickButtonUkončit_56_12);
            if (winElem_LeftClickButtonUkončit_56_12 != null)
            {
                winElem_LeftClickButtonUkončit_56_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_56_12}");
                return;
            }


            // LeftClick on Button "Editovat" at (57,23)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (57,23)");
            string xpath_LeftClickButtonEditovat_57_23 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_57_23 = root.FindByXPath(xpath_LeftClickButtonEditovat_57_23);
            if (winElem_LeftClickButtonEditovat_57_23 != null)
            {
                winElem_LeftClickButtonEditovat_57_23.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_57_23}");
                return;
            }


            // LeftClick on Button "" at (19,14)
            Console.WriteLine("LeftClick on Button \"\" at (19,14)");
            string xpath_LeftClickButton_19_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@AutomationId=\"btnWrapUnitsOk\"]";
            var winElem_LeftClickButton_19_14 = root.FindByXPath(xpath_LeftClickButton_19_14);
            if (winElem_LeftClickButton_19_14 != null)
            {
                winElem_LeftClickButton_19_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_19_14}");
                return;
            }


            // LeftClick on ListItem "&quot; P O K O R N Ý, spol. s r.o.&quot;" at (413,21)
            Console.WriteLine("LeftClick on ListItem \"&quot; P O K O R N Ý, spol. s r.o.&quot;\" at (413,21)");
            string xpath_LeftClickListItemPOKORNÝspo_413_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/ComboBox[@AutomationId=\"cmbProducer\"]/List[position()=3]/ListItem[@Name=\"&quot; P O K O R N Ý, spol. s r.o.&quot;\"]";
            var winElem_LeftClickListItemPOKORNÝspo_413_21 = root.FindByXPath(xpath_LeftClickListItemPOKORNÝspo_413_21);
            if (winElem_LeftClickListItemPOKORNÝspo_413_21 != null)
            {
                winElem_LeftClickListItemPOKORNÝspo_413_21.Click();
                winElem_LeftClickListItemPOKORNÝspo_413_21.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickListItemPOKORNÝspo_413_21}");
                return;
            }


            // LeftClick on Button "Uložit" at (41,9)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (41,9)");
            string xpath_LeftClickButtonUložit_41_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_41_9 = root.FindByXPath(xpath_LeftClickButtonUložit_41_9);
            if (winElem_LeftClickButtonUložit_41_9 != null)
            {
                winElem_LeftClickButtonUložit_41_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_41_9}");
                return;
            }


            // LeftClick on Button "Ukončit" at (5,10)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (5,10)");
            string xpath_LeftClickButtonUkončit_5_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_5_10 = root.FindByXPath(xpath_LeftClickButtonUkončit_5_10);
            if (winElem_LeftClickButtonUkončit_5_10 != null)
            {
                winElem_LeftClickButtonUkončit_5_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_5_10}");
                return;
            }


            // LeftClick on TabItem "103" at (10,6)
            Console.WriteLine("LeftClick on TabItem \"103\" at (10,6)");
            string xpath_LeftClickTabItem103_10_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/TabItem[@Name=\"103\"]";
            var winElem_LeftClickTabItem103_10_6 = root.FindByXPath(xpath_LeftClickTabItem103_10_6);
            if (winElem_LeftClickTabItem103_10_6 != null)
            {
                winElem_LeftClickTabItem103_10_6.Click();
                winElem_LeftClickTabItem103_10_6.SendKeys(Keys.Tab + Keys.Tab);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickTabItem103_10_6}");
                return;
            }


            TestMethodFunction3();


            // LeftClick on TabItem "Seznam dokladů" at (76,3)
            Console.WriteLine("LeftClick on TabItem \"Seznam dokladů\" at (76,3)");
            string xpath_LeftClickTabItemSeznamdokl_76_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/TabItem[@Name=\"Seznam dokladů\"]";
            var winElem_LeftClickTabItemSeznamdokl_76_3 = root.FindByXPath(xpath_LeftClickTabItemSeznamdokl_76_3);
            if (winElem_LeftClickTabItemSeznamdokl_76_3 != null)
            {
                winElem_LeftClickTabItemSeznamdokl_76_3.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickTabItemSeznamdokl_76_3}");
                return;
            }


            // LeftClick on Header "Stav" at (46,24)
            Console.WriteLine("LeftClick on Header \"Stav\" at (46,24)");
            string xpath_LeftClickHeaderStav_46_24 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Header Panel\"]/Header[@Name=\"Stav\"]";
            var winElem_LeftClickHeaderStav_46_24 = root.FindByXPath(xpath_LeftClickHeaderStav_46_24);
            if (winElem_LeftClickHeaderStav_46_24 != null)
            {
                winElem_LeftClickHeaderStav_46_24.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickHeaderStav_46_24}");
                return;
            }


            // LeftClick on DataItem "Číslo dokladu row29" at (41,8)
            Console.WriteLine("LeftClick on DataItem \"Číslo dokladu row29\" at (41,8)");
            string xpath_LeftClickDataItemČíslodokla_41_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 30\"]/DataItem[@Name=\"Číslo dokladu row29\"]";
            var winElem_LeftClickDataItemČíslodokla_41_8 = root.FindByXPath(xpath_LeftClickDataItemČíslodokla_41_8);
            if (winElem_LeftClickDataItemČíslodokla_41_8 != null)
            {
                winElem_LeftClickDataItemČíslodokla_41_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslodokla_41_8}");
                return;
            }


            // LeftClick on Button "Storno" at (7,9)
            Console.WriteLine("LeftClick on Button \"Storno\" at (7,9)");
            string xpath_LeftClickButtonStorno_7_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000004\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Storno\"]";
            var winElem_LeftClickButtonStorno_7_9 = root.FindByXPath(xpath_LeftClickButtonStorno_7_9);
            if (winElem_LeftClickButtonStorno_7_9 != null)
            {
                winElem_LeftClickButtonStorno_7_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_7_9}");
                return;
            }


            // LeftClick on Button "&amp;Ano" at (44,18)
            Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (44,18)");
            string xpath_LeftClickButtonAno_44_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
            var winElem_LeftClickButtonAno_44_18 = root.FindByXPath(xpath_LeftClickButtonAno_44_18);
            if (winElem_LeftClickButtonAno_44_18 != null)
            {
                winElem_LeftClickButtonAno_44_18.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_44_18}");
                return;
            }


            // LeftClick on Header "Stav" at (67,17)
            Console.WriteLine("LeftClick on Header \"Stav\" at (67,17)");
            string xpath_LeftClickHeaderStav_67_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Header Panel\"]/Header[@Name=\"Stav\"]";
            var winElem_LeftClickHeaderStav_67_17 = root.FindByXPath(xpath_LeftClickHeaderStav_67_17);
            if (winElem_LeftClickHeaderStav_67_17 != null)
            {
                winElem_LeftClickHeaderStav_67_17.Click();
                winElem_LeftClickHeaderStav_67_17.SendKeys(Keys.PageUp + Keys.PageUp + Keys.PageUp);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickHeaderStav_67_17}");
                return;
            }


            // LeftClick on DataItem "Číslo dokladu row0" at (66,12)
            Console.WriteLine("LeftClick on DataItem \"Číslo dokladu row0\" at (66,12)");
            string xpath_LeftClickDataItemČíslodokla_66_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Číslo dokladu row0\"]";
            var winElem_LeftClickDataItemČíslodokla_66_12 = root.FindByXPath(xpath_LeftClickDataItemČíslodokla_66_12);
            if (winElem_LeftClickDataItemČíslodokla_66_12 != null)
            {
                winElem_LeftClickDataItemČíslodokla_66_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslodokla_66_12}");
                return;
            }


            // LeftClick on Button "Tisk dokladu" at (62,9)
            Console.WriteLine("LeftClick on Button \"Tisk dokladu\" at (62,9)");
            string xpath_LeftClickButtonTiskdoklad_62_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000008\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Tisk dokladu\"]";
            var winElem_LeftClickButtonTiskdoklad_62_9 = root.FindByXPath(xpath_LeftClickButtonTiskdoklad_62_9);
            if (winElem_LeftClickButtonTiskdoklad_62_9 != null)
            {
                winElem_LeftClickButtonTiskdoklad_62_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonTiskdoklad_62_9}");
                return;
            }


            // LeftClick on Button "Close" at (3250,572)
            Console.WriteLine("LeftClick on Button \"Close\" at (3250,572)");
            string xpath_LeftClickButtonClose_3250_572 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Button[@Name=\"Close\"][@AutomationId=\"Light Dismiss\"]";
            var winElem_LeftClickButtonClose_3250_572 = root.FindByXPath(xpath_LeftClickButtonClose_3250_572);
            if (winElem_LeftClickButtonClose_3250_572 != null)
            {
                winElem_LeftClickButtonClose_3250_572.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonClose_3250_572}");
                return;
            }


            // LeftClick on Button "Zavřít" at (36,15)
            Console.WriteLine("LeftClick on Button \"Zavřít\" at (36,15)");
            string xpath_LeftClickButtonZavřít_36_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000008\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavřít\"]";
            var winElem_LeftClickButtonZavřít_36_15 = root.FindByXPath(xpath_LeftClickButtonZavřít_36_15);
            if (winElem_LeftClickButtonZavřít_36_15 != null)
            {
                winElem_LeftClickButtonZavřít_36_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavřít_36_15}");
                return;
            }
        }
        private void createNewWMImport()
        {
            // LeftClick on Button "Nová příjemka" at (10,18)
            Console.WriteLine("LeftClick on Button \"Nová příjemka\" at (10,18)");
            string xpath_LeftClickButtonNovápříjem_10_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nová příjemka\"][@AutomationId=\"btnAdd_Click\"]";
            var winElem_LeftClickButtonNovápříjem_10_18 = root.FindByXPath(xpath_LeftClickButtonNovápříjem_10_18);
            if (winElem_LeftClickButtonNovápříjem_10_18 != null)
            {
                winElem_LeftClickButtonNovápříjem_10_18.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovápříjem_10_18}");
                return;
            }

            // LeftClick on Button "Storno" at (26,11)
            Console.WriteLine("LeftClick on Button \"Storno\" at (26,11)");
            string xpath_LeftClickButtonStorno_26_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Příjem vstupního materiálu\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Storno\"][@AutomationId=\"btnStorno_Click\"]";
            var winElem_LeftClickButtonStorno_26_11 = root.FindByXPath(xpath_LeftClickButtonStorno_26_11);
            if (winElem_LeftClickButtonStorno_26_11 != null)
            {
                winElem_LeftClickButtonStorno_26_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_26_11}");
                return;
            }

            // LeftClick on Button "Nová příjemka" at (10,19)
            Console.WriteLine("LeftClick on Button \"Nová příjemka\" at (10,18)");
            string xpath_LeftClickButtonNovápříjem_10_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Nová příjemka\"][@AutomationId=\"btnAdd_Click\"]";
            var winElem_LeftClickButtonNovápříjem_10_19 = root.FindByXPath(xpath_LeftClickButtonNovápříjem_10_18);
            if (winElem_LeftClickButtonNovápříjem_10_19 != null)
            {
                winElem_LeftClickButtonNovápříjem_10_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovápříjem_10_19}");
                return;
            }

            // LeftClick on Text "" at (100,7)
            Console.WriteLine("LeftClick on Text \"\" at (100,7)");
            string xpath_LeftClickText_100_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Příjem vstupního materiálu\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelHeader\"][@AutomationId=\"panelHeader\"]/Pane[@AutomationId=\"ucWMImportMaterial\"]/ComboBox[@AutomationId=\"cmbSupplier\"]/Text";
            var winElem_LeftClickText_100_7 = root.FindByXPath(xpath_LeftClickText_100_7);
            if (winElem_LeftClickText_100_7 != null)
            {
                winElem_LeftClickText_100_7.Click();
                winElem_LeftClickText_100_7.SendKeys("AHA");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_100_7}");
                return;
            }
            

            // LeftClick on Edit "" at (69,3)
            Console.WriteLine("LeftClick on Edit \"\" at (69,3)");
            string xpath_LeftClickEdit_69_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Příjem vstupního materiálu\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelHeader\"][@AutomationId=\"panelHeader\"]/Pane[@AutomationId=\"ucWMImportMaterial\"]/Edit[@AutomationId=\"txtDeliveryNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_69_3 = root.FindByXPath(xpath_LeftClickEdit_69_3);
            if (winElem_LeftClickEdit_69_3 != null)
            {
                winElem_LeftClickEdit_69_3.Click();
                winElem_LeftClickEdit_69_3.SendKeys(DeliveryNumber);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_69_3}");
                return;
            }

            // LeftClick on Button "OK" at (13,17)
            Console.WriteLine("LeftClick on Button \"OK\" at (13,17)");
            string xpath_LeftClickButtonOK_13_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Příjem vstupního materiálu\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"OK\"][@AutomationId=\"btnOK_Click\"]";
            var winElem_LeftClickButtonOK_13_17 = root.FindByXPath(xpath_LeftClickButtonOK_13_17);
            if (winElem_LeftClickButtonOK_13_17 != null)
            {
                winElem_LeftClickButtonOK_13_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_13_17}");
                return;
            }


            // LeftClick on Edit "2120000024" at (100,4)
            Console.WriteLine("LeftClick on Edit \"2120000024\" at (100,4)");
            var winElem_LeftClickEdit2120000024_100_4 = desktopSession.FindByAccessibilityId("txtDocumentNo");
            if (winElem_LeftClickEdit2120000024_100_4 != null)
            {
                winElem_LeftClickEdit2120000024_100_4.Click();
                deliveryDocumentNo = winElem_LeftClickEdit2120000024_100_4.Text;
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: Couldn't find txtDocumentNo box");
                return;
            }

            // LeftClick on Button "Ukončit" at (45,15)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (45,15)");
            string xpath_LeftClickButtonUkončit_45_15 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocumentNo}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukončit\"][@AutomationId=\"btnFinish_Click\"]";
            var winElem_LeftClickButtonUkončit_45_15 = root.FindByXPath(xpath_LeftClickButtonUkončit_45_15);
            if (winElem_LeftClickButtonUkončit_45_15 != null)
            {
                winElem_LeftClickButtonUkončit_45_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_45_15}");
                return;
            }

            // LeftClick on Button "Editovat" at (9,22)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (9,22)");
            string xpath_LeftClickButtonEditovat_9_22 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocumentNo}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Editovat\"][@AutomationId=\"btnEdit_Click\"]";
            var winElem_LeftClickButtonEditovat_9_22 = root.FindByXPath(xpath_LeftClickButtonEditovat_9_22);
            if (winElem_LeftClickButtonEditovat_9_22 != null)
            {
                winElem_LeftClickButtonEditovat_9_22.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_9_22}");
                return;
            }
            // LeftClick on Button "Uložit" at (2,9)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (2,9)");
            string xpath_LeftClickButtonUložit_2_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocumentNo}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Uložit\"][@AutomationId=\"btnSave_Click\"]";
            var winElem_LeftClickButtonUložit_2_9 = root.FindByXPath(xpath_LeftClickButtonUložit_2_9);
            if (winElem_LeftClickButtonUložit_2_9 != null)
            {
                winElem_LeftClickButtonUložit_2_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_2_9}");
                return;
            }

            // LeftClick on Edit "" at (141,26)
            Console.WriteLine("LeftClick on Edit \"\" at (141,26)");
            string xpath_LeftClickEdit_141_26 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocumentNo}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Edit[@AutomationId=\"memoRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_141_26 = root.FindByXPath(xpath_LeftClickEdit_141_26);
            if (winElem_LeftClickEdit_141_26 != null)
            {
                winElem_LeftClickEdit_141_26.Click();
                winElem_LeftClickEdit_141_26.SendKeys("Super cool message");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_141_26}");
                return;
            }

            // LeftClick on Button "Ukončit" at (46,15)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (46,15)");
            string xpath_LeftClickButtonUkončit_46_15 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocumentNo}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukončit\"][@AutomationId=\"btnFinish_Click\"]";
            var winElem_LeftClickButtonUkončit_46_15 = root.FindByXPath(xpath_LeftClickButtonUkončit_45_15);
            if (winElem_LeftClickButtonUkončit_46_15 != null)
            {
                winElem_LeftClickButtonUkončit_46_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_46_15}");
                return;
            }

            // LeftClick on Button "&amp;Storno" at (35,11)
            Console.WriteLine("LeftClick on Button \"&amp;Storno\" at (35,11)");
            string xpath_LeftClickButtonStorno_35_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit změny\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Storno\"]";
            var winElem_LeftClickButtonStorno_35_11 = root.FindByXPath(xpath_LeftClickButtonStorno_35_11);
            if (winElem_LeftClickButtonStorno_35_11 != null)
            {
                winElem_LeftClickButtonStorno_35_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_35_11}");
                return;
            }

            // LeftClick on Button "Ukončit" at (47,15)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (47,15)");
            string xpath_LeftClickButtonUkončit_47_15 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocumentNo}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukončit\"][@AutomationId=\"btnFinish_Click\"]";
            var winElem_LeftClickButtonUkončit_47_15 = root.FindByXPath(xpath_LeftClickButtonUkončit_45_15);
            if (winElem_LeftClickButtonUkončit_47_15 != null)
            {
                winElem_LeftClickButtonUkončit_47_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_47_15}");
                return;
            }

            // LeftClick on Button "&amp;Ano" at (37,16)
            Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (37,16)");
            string xpath_LeftClickButtonAno_37_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit změny\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
            var winElem_LeftClickButtonAno_37_16 = root.FindByXPath(xpath_LeftClickButtonAno_37_16);
            if (winElem_LeftClickButtonAno_37_16 != null)
            {
                winElem_LeftClickButtonAno_37_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_37_16}");
                return;
            }








            // LeftClick on Button "Storno" at (33,6)
            Console.WriteLine("LeftClick on Button \"Storno\" at (33,6)");
            string xpath_LeftClickButtonStorno_33_6 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocumentNo}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Storno\"][@AutomationId=\"btnCancel_Click\"]";
            var winElem_LeftClickButtonStorno_33_6 = root.FindByXPath(xpath_LeftClickButtonStorno_33_6);
            if (winElem_LeftClickButtonStorno_33_6 != null)
            {
                winElem_LeftClickButtonStorno_33_6.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_33_6}");
                return;
            }

            // LeftClick on Button "&amp;Ano" at (67,9)
            Console.WriteLine("LeftClick on Button \"&amp;Ano\" at (67,9)");
            string xpath_LeftClickButtonAno_67_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Ano\"]";
            var winElem_LeftClickButtonAno_67_9 = root.FindByXPath(xpath_LeftClickButtonAno_67_9);
            if (winElem_LeftClickButtonAno_67_9 != null)
            {
                winElem_LeftClickButtonAno_67_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonAno_67_9}");
                return;
            }


        }

        private void editAndReadOnlyMode()
        {
            // LeftClick on Button "Ukončit" at (49,23)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (49,23)");
            string xpath_LeftClickButtonUkončit_49_23 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2120000024\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@Name=\"Ukončit\"][@AutomationId=\"btnFinish_Click\"]";
            var winElem_LeftClickButtonUkončit_49_23 = root.FindByXPath(xpath_LeftClickButtonUkončit_49_23);
            if (winElem_LeftClickButtonUkončit_49_23 != null)
            {
                winElem_LeftClickButtonUkončit_49_23.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_49_23}");
                return;
            }


        }
        private void createWMMaterial()
        {
            


            // LeftClick on DataItem "  row4" at (12,8)
            Console.WriteLine("LeftClick on DataItem \"  row4\" at (12,8)");
            string xpath_LeftClickDataItemrow4_12_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Přidat materiál\"][@AutomationId=\"mbWMAddMaterialToTransferItem\"]/Table[@AutomationId=\"gridMaterialSelect\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 5\"]/DataItem[@Name=\"  row4\"]";
            var winElem_LeftClickDataItemrow4_12_8 = root.FindByXPath(xpath_LeftClickDataItemrow4_12_8);
            if (winElem_LeftClickDataItemrow4_12_8 != null)
            {
                winElem_LeftClickDataItemrow4_12_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow4_12_8}");
                return;
            }


            TestMethodFunction1();

            // LeftClick on Edit "" at (86,9)
            Console.WriteLine("LeftClick on Edit \"\" at (86,9)");
            string xpath_LeftClickEdit_86_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtDeliveredAmount\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_86_9 = root.FindByXPath(xpath_LeftClickEdit_86_9);
            if (winElem_LeftClickEdit_86_9 != null)
            {
                winElem_LeftClickEdit_86_9.Click();
                winElem_LeftClickEdit_86_9.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_86_9}");
                return;
            }


            // LeftClick on Button "Up" at (7,5)
            Console.WriteLine("LeftClick on Button \"Up\" at (7,5)");
            string xpath_LeftClickButtonUp_7_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@Name=\"0\"][@AutomationId=\"spinWrapUnitsCount\"]/Spinner[@Name=\"Spinner\"]/Button[@Name=\"Up\"]";
            var winElem_LeftClickButtonUp_7_5 = root.FindByXPath(xpath_LeftClickButtonUp_7_5);
            if (winElem_LeftClickButtonUp_7_5 != null)
            {
                winElem_LeftClickButtonUp_7_5.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUp_7_5}");
                return;
            }


            TestMethodFunction2();


            // LeftClick on Text "Sklad příjmu" at (46,1)
            Console.WriteLine("LeftClick on Text \"Sklad příjmu\" at (46,1)");
            string xpath_LeftClickTextSkladpříjm_46_1 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@Name=\"Sklad příjmu\"][@AutomationId=\"peSelectTargetLocation\"]/Text[@Name=\"Sklad příjmu\"]";
            var winElem_LeftClickTextSkladpříjm_46_1 = root.FindByXPath(xpath_LeftClickTextSkladpříjm_46_1);
            if (winElem_LeftClickTextSkladpříjm_46_1 != null)
            {
                winElem_LeftClickTextSkladpříjm_46_1.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickTextSkladpříjm_46_1}");
                return;
            }


            // LeftClick on Text "" at (284,3)
            Console.WriteLine("LeftClick on Text \"\" at (284,3)");
            string xpath_LeftClickText_284_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/ComboBox[@AutomationId=\"cmbProducer\"]/Text";
            var winElem_LeftClickText_284_3 = root.FindByXPath(xpath_LeftClickText_284_3);
            if (winElem_LeftClickText_284_3 != null)
            {
                winElem_LeftClickText_284_3.Click();
                winElem_LeftClickText_284_3.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_284_3}");
                return;
            }


            // LeftClick on Button "" at (17,17)
            Console.WriteLine("LeftClick on Button \"\" at (17,17)");
            string xpath_LeftClickButton_17_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@AutomationId=\"btnWrapUnitsOk\"]";
            var winElem_LeftClickButton_17_17 = root.FindByXPath(xpath_LeftClickButton_17_17);
            if (winElem_LeftClickButton_17_17 != null)
            {
                winElem_LeftClickButton_17_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_17_17}");
                return;
            }


            // LeftClick on DataItem "Označení dodavatele row0" at (137,10)
            Console.WriteLine("LeftClick on DataItem \"Označení dodavatele row0\" at (137,10)");
            string xpath_LeftClickDataItemOznačenído_137_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Table[@AutomationId=\"gridWrapUnits\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Označení dodavatele row0\"]";
            var winElem_LeftClickDataItemOznačenído_137_10 = root.FindByXPath(xpath_LeftClickDataItemOznačenído_137_10);
            if (winElem_LeftClickDataItemOznačenído_137_10 != null)
            {
                winElem_LeftClickDataItemOznačenído_137_10.Click();
                winElem_LeftClickDataItemOznačenído_137_10.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemOznačenído_137_10}");
                return;
            }


            // LeftClick on Button "Uložit" at (62,21)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (62,21)");
            string xpath_LeftClickButtonUložit_62_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_62_21 = root.FindByXPath(xpath_LeftClickButtonUložit_62_21);
            if (winElem_LeftClickButtonUložit_62_21 != null)
            {
                winElem_LeftClickButtonUložit_62_21.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_62_21}");
                return;
            }


            // LeftClick on Button "Ukončit" at (19,16)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (19,16)");
            string xpath_LeftClickButtonUkončit_19_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_19_16 = root.FindByXPath(xpath_LeftClickButtonUkončit_19_16);
            if (winElem_LeftClickButtonUkončit_19_16 != null)
            {
                winElem_LeftClickButtonUkončit_19_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_19_16}");
                return;
            }


            // LeftClick on DataItem " row 1" at (58,17)
            Console.WriteLine("LeftClick on DataItem \" row 1\" at (58,17)");
            string xpath_LeftClickDataItemrow1_58_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeListMenu\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node1\"]/DataItem[@Name=\" row 1\"]";
            var winElem_LeftClickDataItemrow1_58_17 = root.FindByXPath(xpath_LeftClickDataItemrow1_58_17);
            if (winElem_LeftClickDataItemrow1_58_17 != null)
            {
                winElem_LeftClickDataItemrow1_58_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow1_58_17}");
                return;
            }


            TestMethodFunction3();

            // LeftClick on Button "Smazat" at (47,21)
            Console.WriteLine("LeftClick on Button \"Smazat\" at (47,21)");
            string xpath_LeftClickButtonSmazat_47_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Smazat\"]";
            var winElem_LeftClickButtonSmazat_47_21 = root.FindByXPath(xpath_LeftClickButtonSmazat_47_21);
            if (winElem_LeftClickButtonSmazat_47_21 != null)
            {
                winElem_LeftClickButtonSmazat_47_21.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSmazat_47_21}");
                return;
            }


            // LeftClick on Button "&amp;Yes" at (63,4)
            Console.WriteLine("LeftClick on Button \"&amp;Yes\" at (63,4)");
            string xpath_LeftClickButtonYes_63_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Opravdu smazat?\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Yes\"]";
            var winElem_LeftClickButtonYes_63_4 = root.FindByXPath(xpath_LeftClickButtonYes_63_4);
            if (winElem_LeftClickButtonYes_63_4 != null)
            {
                winElem_LeftClickButtonYes_63_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonYes_63_4}");
                return;
            }
        }
        private static void TestMethodFunction1()
        {
            // LeftClick on Button "OK" at (66,19)
            Console.WriteLine("LeftClick on Button \"OK\" at (66,19)");
            string xpath_LeftClickButtonOK_66_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Přidat materiál\"][@AutomationId=\"mbWMAddMaterialToTransferItem\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
            var winElem_LeftClickButtonOK_66_19 = root.FindByXPath(xpath_LeftClickButtonOK_66_19);
            if (winElem_LeftClickButtonOK_66_19 != null)
            {
                winElem_LeftClickButtonOK_66_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_66_19}");
                return;
            }


            // LeftClick on Button "Uložit" at (59,9)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (59,9)");
            string xpath_LeftClickButtonUložit_59_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_59_9 = root.FindByXPath(xpath_LeftClickButtonUložit_59_9);
            if (winElem_LeftClickButtonUložit_59_9 != null)
            {
                winElem_LeftClickButtonUložit_59_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_59_9}");
                return;
            }


            // LeftClick on Button "Ukončit" at (34,8)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (34,8)");
            string xpath_LeftClickButtonUkončit_34_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_34_8 = root.FindByXPath(xpath_LeftClickButtonUkončit_34_8);
            if (winElem_LeftClickButtonUkončit_34_8 != null)
            {
                winElem_LeftClickButtonUkončit_34_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_34_8}");
                return;
            }


            // LeftClick on DataItem "Číslo materiálu row0" at (40,12)
            Console.WriteLine("LeftClick on DataItem \"Číslo materiálu row0\" at (40,12)");
            string xpath_LeftClickDataItemČíslomater_40_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[@Name=\"Seznam položek\"][@AutomationId=\"tabPageGridMaterials\"]/Table[@AutomationId=\"gridMaterials\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Číslo materiálu row0\"]";
            var winElem_LeftClickDataItemČíslomater_40_12 = root.FindByXPath(xpath_LeftClickDataItemČíslomater_40_12);
            if (winElem_LeftClickDataItemČíslomater_40_12 != null)
            {
                winElem_LeftClickDataItemČíslomater_40_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslomater_40_12}");
                return;
            }


            // LeftClick on Button "Editovat" at (22,16)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (22,16)");
            string xpath_LeftClickButtonEditovat_22_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_22_16 = root.FindByXPath(xpath_LeftClickButtonEditovat_22_16);
            if (winElem_LeftClickButtonEditovat_22_16 != null)
            {
                winElem_LeftClickButtonEditovat_22_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_22_16}");
                return;
            }



            // LeftClick on Edit "" at (105,5)
            Console.WriteLine("LeftClick on Edit \"\" at (105,5)");
            string xpath_LeftClickEdit_105_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtCatalogueNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_105_5 = root.FindByXPath(xpath_LeftClickEdit_105_5);
            if (winElem_LeftClickEdit_105_5 != null)
            {
                winElem_LeftClickEdit_105_5.Click();
                winElem_LeftClickEdit_105_5.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_105_5}");
                return;
            }


            // LeftClick on Edit "" at (146,7)
            Console.WriteLine("LeftClick on Edit \"\" at (146,7)");
            string xpath_LeftClickEdit_146_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtSupplierMaterialName\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_146_7 = root.FindByXPath(xpath_LeftClickEdit_146_7);
            if (winElem_LeftClickEdit_146_7 != null)
            {
                winElem_LeftClickEdit_146_7.Click();
                winElem_LeftClickEdit_146_7.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_146_7}");
                return;
            }


            // LeftClick on Edit "" at (18,8)
            Console.WriteLine("LeftClick on Edit \"\" at (18,8)");
            string xpath_LeftClickEdit_18_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtOrderNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_18_8 = root.FindByXPath(xpath_LeftClickEdit_18_8);
            if (winElem_LeftClickEdit_18_8 != null)
            {
                winElem_LeftClickEdit_18_8.Click();
                winElem_LeftClickEdit_18_8.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_18_8}");
                return;
            }


            // LeftClick on Edit "" at (23,5)
            Console.WriteLine("LeftClick on Edit \"\" at (23,5)");
            string xpath_LeftClickEdit_23_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtOrderLine\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_23_5 = root.FindByXPath(xpath_LeftClickEdit_23_5);
            if (winElem_LeftClickEdit_23_5 != null)
            {
                winElem_LeftClickEdit_23_5.Click();
                winElem_LeftClickEdit_23_5.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_23_5}");
                return;
            }


            // LeftClick on Edit "" at (53,5)
            Console.WriteLine("LeftClick on Edit \"\" at (53,5)");
            string xpath_LeftClickEdit_53_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtProducerBatchNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_53_5 = root.FindByXPath(xpath_LeftClickEdit_53_5);
            if (winElem_LeftClickEdit_53_5 != null)
            {
                winElem_LeftClickEdit_53_5.Click();
                winElem_LeftClickEdit_53_5.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_53_5}");
                return;
            }
        }
        private static void TestMethodFunction2()
        {
            // LeftClick on Pane "" at (126,14)
            Console.WriteLine("LeftClick on Pane \"\" at (126,14)");
            string xpath_LeftClickPane_126_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"cmbTransportUnit\"]";
            var winElem_LeftClickPane_126_14 = root.FindByXPath(xpath_LeftClickPane_126_14);
            if (winElem_LeftClickPane_126_14 != null)
            {
                winElem_LeftClickPane_126_14.Click();
                winElem_LeftClickPane_126_14.SendKeys(Keys.ArrowDown);
                winElem_LeftClickPane_126_14.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_126_14}");
                return;
            }


            // LeftClick on Pane "" at (81,9)
            Console.WriteLine("LeftClick on Pane \"\" at (81,9)");
            string xpath_LeftClickPane_81_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"103\"]/Pane[@AutomationId=\"ucWMImportDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"dateExpiration\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickPane_81_9 = root.FindByXPath(xpath_LeftClickPane_81_9);
            if (winElem_LeftClickPane_81_9 != null)
            {
                winElem_LeftClickPane_81_9.Click();
                winElem_LeftClickPane_81_9.SendKeys(Keys.ArrowUp);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_81_9}");
                return;
            }
        }
        private void TestMethodFunction3()
        {
            // LeftClick on Button "Editovat" at (43,8)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (43,8)");
            string xpath_LeftClickButtonEditovat_43_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_43_8 = root.FindByXPath(xpath_LeftClickButtonEditovat_43_8);
            if (winElem_LeftClickButtonEditovat_43_8 != null)
            {
                winElem_LeftClickButtonEditovat_43_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_43_8}");
                return;
            }


            // LeftClick on Button "Vše splňuje" at (51,9)
            Console.WriteLine("LeftClick on Button \"Vše splňuje\" at (51,9)");
            string xpath_LeftClickButtonVšesplňuje_51_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Vše splňuje\"]";
            var winElem_LeftClickButtonVšesplňuje_51_9 = root.FindByXPath(xpath_LeftClickButtonVšesplňuje_51_9);
            if (winElem_LeftClickButtonVšesplňuje_51_9 != null)
            {
                winElem_LeftClickButtonVšesplňuje_51_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonVšesplňuje_51_9}");
                return;
            }


            // LeftClick on Button "Uložit" at (70,11)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (70,11)");
            string xpath_LeftClickButtonUložit_70_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_70_11 = root.FindByXPath(xpath_LeftClickButtonUložit_70_11);
            if (winElem_LeftClickButtonUložit_70_11 != null)
            {
                winElem_LeftClickButtonUložit_70_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_70_11}");
                return;
            }


            // LeftClick on Button "Ukončit" at (4,10)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (4,10)");
            string xpath_LeftClickButtonUkončit_4_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportMaterial\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2119000001\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_4_10 = root.FindByXPath(xpath_LeftClickButtonUkončit_4_10);
            if (winElem_LeftClickButtonUkončit_4_10 != null)
            {
                winElem_LeftClickButtonUkončit_4_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_4_10}");
                return;
            }
        }
        #endregion

        #region import product
        [TestMethod]
        public void TestMethod2()
        {
            //Rozbije se kvůli vygenerovanému číslu dokladu.. Pokud se propíšou proměnné místo Name tak by zbytek měl fungovat
            // LeftClick on Button "miWM" at (32,9)
            Console.WriteLine("LeftClick on Button \"miWM\" at (32,9)");
            string xpath_LeftClickButtonmiWM_32_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Group[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Dock Top\"]/ToolBar[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[@Name=\"miWM\"]";
            var winElem_LeftClickButtonmiWM_32_9 = root.FindByXPath(xpath_LeftClickButtonmiWM_32_9);
            if (winElem_LeftClickButtonmiWM_32_9 != null)
            {
                winElem_LeftClickButtonmiWM_32_9.Click();
                winElem_LeftClickButtonmiWM_32_9.SendKeys(Keys.Tab);
                winElem_LeftClickButtonmiWM_32_9.SendKeys(Keys.Tab);
                winElem_LeftClickButtonmiWM_32_9.SendKeys(Keys.Space);
                winElem_LeftClickButtonmiWM_32_9.SendKeys(Keys.Tab);
                winElem_LeftClickButtonmiWM_32_9.SendKeys(Keys.Tab);
                winElem_LeftClickButtonmiWM_32_9.SendKeys(Keys.Space);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiWM_32_9}");
                return;
            }


            // LeftClick on DataItem "Číslo dokladu row0" at (61,9)
            Console.WriteLine("LeftClick on DataItem \"Číslo dokladu row0\" at (61,9)");
            string xpath_LeftClickDataItemČíslodokla_61_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Číslo dokladu row0\"]";
            var winElem_LeftClickDataItemČíslodokla_61_9 = root.FindByXPath(xpath_LeftClickDataItemČíslodokla_61_9);
            if (winElem_LeftClickDataItemČíslodokla_61_9 != null)
            {
                winElem_LeftClickDataItemČíslodokla_61_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslodokla_61_9}");
                return;
            }


            // LeftClick on Button "Zavřít" at (38,17)
            Console.WriteLine("LeftClick on Button \"Zavřít\" at (38,17)");
            string xpath_LeftClickButtonZavřít_38_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2420000015\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavřít\"]";
            var winElem_LeftClickButtonZavřít_38_17 = root.FindByXPath(xpath_LeftClickButtonZavřít_38_17);
            if (winElem_LeftClickButtonZavřít_38_17 != null)
            {
                winElem_LeftClickButtonZavřít_38_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavřít_38_17}");
                return;
            }


            createProduct1();

            
            // get docnumber
            
            

            createProduct();

            printingWM();



        }

        private static void printingWM()
        {

            // LeftClick on Header "Stav" at (42,22)
            Console.WriteLine("LeftClick on Header \"Stav\" at (42,22)");
            string xpath_LeftClickHeaderStav_42_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Header Panel\"]/Header[@Name=\"Stav\"]";
            var winElem_LeftClickHeaderStav_42_22 = root.FindByXPath(xpath_LeftClickHeaderStav_42_22);
            if (winElem_LeftClickHeaderStav_42_22 != null)
            {
                winElem_LeftClickHeaderStav_42_22.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickHeaderStav_42_22}");
                return;
            }


            // LeftClick on DataItem "Číslo dokladu row0" at (57,16)
            Console.WriteLine("LeftClick on DataItem \"Číslo dokladu row0\" at (57,16)");
            string xpath_LeftClickDataItemČíslodokla_57_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"panelTab\"][@AutomationId=\"panelTab\"]/Table[@AutomationId=\"gridDocuments\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Číslo dokladu row0\"]";
            var winElem_LeftClickDataItemČíslodokla_57_16 = root.FindByXPath(xpath_LeftClickDataItemČíslodokla_57_16);
            if (winElem_LeftClickDataItemČíslodokla_57_16 != null)
            {
                winElem_LeftClickDataItemČíslodokla_57_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslodokla_57_16}");
                return;
            }


            // LeftClick on DataItem "Příjemka row 1" at (48,14)
            Console.WriteLine("LeftClick on DataItem \"Příjemka row 1\" at (48,14)");
            string xpath_LeftClickDataItemPříjemkaro_48_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2420000003\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeOverview\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node1\"]/DataItem[@Name=\"Příjemka row 1\"]";
            var winElem_LeftClickDataItemPříjemkaro_48_14 = root.FindByXPath(xpath_LeftClickDataItemPříjemkaro_48_14);
            if (winElem_LeftClickDataItemPříjemkaro_48_14 != null)
            {
                winElem_LeftClickDataItemPříjemkaro_48_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemPříjemkaro_48_14}");
                return;
            }


            // LeftClick on DataItem "Číslo produktu row0" at (26,10)
            Console.WriteLine("LeftClick on DataItem \"Číslo produktu row0\" at (26,10)");
            string xpath_LeftClickDataItemČísloprodu_26_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2420000003\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[@Name=\"Seznam položek\"][@AutomationId=\"tabPageGridMaterials\"]/Table[@AutomationId=\"gridMaterials\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Číslo produktu row0\"]";
            var winElem_LeftClickDataItemČísloprodu_26_10 = root.FindByXPath(xpath_LeftClickDataItemČísloprodu_26_10);
            if (winElem_LeftClickDataItemČísloprodu_26_10 != null)
            {
                winElem_LeftClickDataItemČísloprodu_26_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČísloprodu_26_10}");
                return;
            }


            // LeftClick on Button "Tisk štítků" at (51,19)
            Console.WriteLine("LeftClick on Button \"Tisk štítků\" at (51,19)");
            string xpath_LeftClickButtonTiskštítků_51_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2420000003\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Tisk štítků\"]";
            var winElem_LeftClickButtonTiskštítků_51_19 = root.FindByXPath(xpath_LeftClickButtonTiskštítků_51_19);
            if (winElem_LeftClickButtonTiskštítků_51_19 != null)
            {
                winElem_LeftClickButtonTiskštítků_51_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonTiskštítků_51_19}");
                return;
            }


            // LeftClick on Button "Cancel" at (30,14)
            Console.WriteLine("LeftClick on Button \"Cancel\" at (30,14)");
            string xpath_LeftClickButtonCancel_30_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@ClassName=\"#32770\"][@Name=\"Print\"]/Button[@ClassName=\"Button\"][@Name=\"Cancel\"]";
            var winElem_LeftClickButtonCancel_30_14 = root.FindByXPath(xpath_LeftClickButtonCancel_30_14);
            if (winElem_LeftClickButtonCancel_30_14 != null)
            {
                winElem_LeftClickButtonCancel_30_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonCancel_30_14}");
                return;
            }


            // LeftClick on Button "Zavřít" at (32,17)
            Console.WriteLine("LeftClick on Button \"Zavřít\" at (32,17)");
            string xpath_LeftClickButtonZavřít_32_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2420000003\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavřít\"]";
            var winElem_LeftClickButtonZavřít_32_17 = root.FindByXPath(xpath_LeftClickButtonZavřít_32_17);
            if (winElem_LeftClickButtonZavřít_32_17 != null)
            {
                winElem_LeftClickButtonZavřít_32_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavřít_32_17}");
                return;
            }


            // LeftClick on Button "Zavřít" at (30,11)
            Console.WriteLine("LeftClick on Button \"Zavřít\" at (30,11)");
            string xpath_LeftClickButtonZavřít_30_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2420000003\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavřít\"]";
            var winElem_LeftClickButtonZavřít_30_11 = root.FindByXPath(xpath_LeftClickButtonZavřít_30_11);
            if (winElem_LeftClickButtonZavřít_30_11 != null)
            {
                winElem_LeftClickButtonZavřít_30_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavřít_30_11}");
                return;
            }
        }

        private void createProduct1()
        {
            // LeftClick on Button "Nová položka" at (58,18)
            Console.WriteLine("LeftClick on Button \"Nová položka\" at (58,18)");
            string xpath_LeftClickButtonNovápoložk_58_18 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová položka\"]";
            var winElem_LeftClickButtonNovápoložk_58_18 = root.FindByXPath(xpath_LeftClickButtonNovápoložk_58_18);
            if (winElem_LeftClickButtonNovápoložk_58_18 != null)
            {
                winElem_LeftClickButtonNovápoložk_58_18.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovápoložk_58_18}");
                return;
            }


            // LeftClick on DataItem "  row0" at (19,11)
            Console.WriteLine("LeftClick on DataItem \"  row0\" at (19,11)");
            string xpath_LeftClickDataItemrow0_19_11 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Přidat materiál\"][@AutomationId=\"mbWMAddMaterialToTransferItem\"]/Table[@AutomationId=\"gridMaterialSelect\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"  row0\"]";
            var winElem_LeftClickDataItemrow0_19_11 = root.FindByXPath(xpath_LeftClickDataItemrow0_19_11);
            if (winElem_LeftClickDataItemrow0_19_11 != null)
            {
                winElem_LeftClickDataItemrow0_19_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_19_11}");
                return;
            }


            // LeftClick on Button "OK" at (54,12)
            Console.WriteLine("LeftClick on Button \"OK\" at (54,12)");
            string xpath_LeftClickButtonOK_54_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Přidat materiál\"][@AutomationId=\"mbWMAddMaterialToTransferItem\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
            var winElem_LeftClickButtonOK_54_12 = root.FindByXPath(xpath_LeftClickButtonOK_54_12);
            if (winElem_LeftClickButtonOK_54_12 != null)
            {
                winElem_LeftClickButtonOK_54_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_54_12}");
                return;
            }


            // LeftClick on DataItem "Číslo produktu row0" at (38,14)
            Console.WriteLine("LeftClick on DataItem \"Číslo produktu row0\" at (38,14)");
            string xpath_LeftClickDataItemČísloprodu_38_14 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[@Name=\"Seznam položek\"][@AutomationId=\"tabPageGridMaterials\"]/Table[@AutomationId=\"gridMaterials\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Číslo produktu row0\"]";
            var winElem_LeftClickDataItemČísloprodu_38_14 = root.FindByXPath(xpath_LeftClickDataItemČísloprodu_38_14);
            if (winElem_LeftClickDataItemČísloprodu_38_14 != null)
            {
                winElem_LeftClickDataItemČísloprodu_38_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČísloprodu_38_14}");
                return;
            }


            // LeftClick on Button "Editovat" at (72,16)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (72,16)");
            string xpath_LeftClickButtonEditovat_72_16 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_72_16 = root.FindByXPath(xpath_LeftClickButtonEditovat_72_16);
            if (winElem_LeftClickButtonEditovat_72_16 != null)
            {
                winElem_LeftClickButtonEditovat_72_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_72_16}");
                return;
            }


            // LeftClick on Edit "" at (86,15)
            Console.WriteLine("LeftClick on Edit \"\" at (86,15)");
            string xpath_LeftClickEdit_86_15 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtContractNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_86_15 = root.FindByXPath(xpath_LeftClickEdit_86_15);
            if (winElem_LeftClickEdit_86_15 != null)
            {
                winElem_LeftClickEdit_86_15.Click();
                winElem_LeftClickEdit_86_15.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_86_15}");
                return;
            }


            // LeftClick on Edit "" at (163,1)
            Console.WriteLine("LeftClick on Edit \"\" at (163,1)");
            string xpath_LeftClickEdit_163_1 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtOrderNumber\"]";
            var winElem_LeftClickEdit_163_1 = root.FindByXPath(xpath_LeftClickEdit_163_1);
            if (winElem_LeftClickEdit_163_1 != null)
            {
                winElem_LeftClickEdit_163_1.Click();
                winElem_LeftClickEdit_163_1.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_163_1}");
                return;
            }


            // LeftClick on Edit "" at (129,11)
            Console.WriteLine("LeftClick on Edit \"\" at (129,11)");
            string xpath_LeftClickEdit_129_11 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtBatchNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_129_11 = root.FindByXPath(xpath_LeftClickEdit_129_11);
            if (winElem_LeftClickEdit_129_11 != null)
            {
                winElem_LeftClickEdit_129_11.Click();
                winElem_LeftClickEdit_129_11.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_129_11}");
                return;
            }


            // LeftClick on Edit "" at (119,11)
            Console.WriteLine("LeftClick on Edit \"\" at (119,11)");
            string xpath_LeftClickEdit_119_11 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtCustomerBatchNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_119_11 = root.FindByXPath(xpath_LeftClickEdit_119_11);
            if (winElem_LeftClickEdit_119_11 != null)
            {
                winElem_LeftClickEdit_119_11.Click();
                winElem_LeftClickEdit_119_11.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_119_11}");
                return;
            }


            // LeftClick on Text "" at (107,0)
            Console.WriteLine("LeftClick on Text \"\" at (107,0)");
            string xpath_LeftClickText_107_0 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/ComboBox[@AutomationId=\"cmbContractType\"]/Text";
            var winElem_LeftClickText_107_0 = root.FindByXPath(xpath_LeftClickText_107_0);
            if (winElem_LeftClickText_107_0 != null)
            {
                winElem_LeftClickText_107_0.Click();
                winElem_LeftClickText_107_0.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_107_0}");
                return;
            }


            // LeftClick on Pane "" at (83,4)
            Console.WriteLine("LeftClick on Pane \"\" at (83,4)");
            string xpath_LeftClickPane_83_4 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"cmbTransportUnit\"]";
            var winElem_LeftClickPane_83_4 = root.FindByXPath(xpath_LeftClickPane_83_4);
            if (winElem_LeftClickPane_83_4 != null)
            {
                winElem_LeftClickPane_83_4.Click();
                winElem_LeftClickPane_83_4.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_83_4}");
                return;
            }


            // LeftClick on Button "Up" at (11,6)
            Console.WriteLine("LeftClick on Button \"Up\" at (11,6)");
            string xpath_LeftClickButtonUp_11_6 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@Name=\"0\"][@AutomationId=\"spinWrapUnitsCount\"]/Spinner[@Name=\"Spinner\"]/Button[@Name=\"Up\"]";
            var winElem_LeftClickButtonUp_11_6 = root.FindByXPath(xpath_LeftClickButtonUp_11_6);
            if (winElem_LeftClickButtonUp_11_6 != null)
            {
                winElem_LeftClickButtonUp_11_6.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUp_11_6}");
                return;
            }


            // LeftClick on CheckBox "Přeskladnit šarži" at (89,5)
            Console.WriteLine("LeftClick on CheckBox \"Přeskladnit šarži\" at (89,5)");
            string xpath_LeftClickCheckBoxPřeskladni_89_5 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/CheckBox[@Name=\"Přeskladnit šarži\"][@AutomationId=\"chcTransferBatch\"]";
            var winElem_LeftClickCheckBoxPřeskladni_89_5 = root.FindByXPath(xpath_LeftClickCheckBoxPřeskladni_89_5);
            if (winElem_LeftClickCheckBoxPřeskladni_89_5 != null)
            {
                winElem_LeftClickCheckBoxPřeskladni_89_5.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxPřeskladni_89_5}");
                return;
            }


            // LeftClick on Text "" at (45,8)
            Console.WriteLine("LeftClick on Text \"\" at (45,8)");
            string xpath_LeftClickText_45_8 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/ComboBox[@AutomationId=\"cmbTargetWarehouse\"]/Text";
            var winElem_LeftClickText_45_8 = root.FindByXPath(xpath_LeftClickText_45_8);
            if (winElem_LeftClickText_45_8 != null)
            {
                winElem_LeftClickText_45_8.Click();
                winElem_LeftClickText_45_8.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_45_8}");
                return;
            }


            // LeftClick on Button "" at (8,9)
            Console.WriteLine("LeftClick on Button \"\" at (8,9)");
            string xpath_LeftClickButton_8_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@AutomationId=\"btnWrapUnitsOk\"]";
            var winElem_LeftClickButton_8_9 = root.FindByXPath(xpath_LeftClickButton_8_9);
            if (winElem_LeftClickButton_8_9 != null)
            {
                winElem_LeftClickButton_8_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_8_9}");
                return;
            }


            // LeftClick on Pane "" at (124,6)
            Console.WriteLine("LeftClick on Pane \"\" at (124,6)");
            string xpath_LeftClickPane_124_6 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"cmbTransportUnit\"]";
            var winElem_LeftClickPane_124_6 = root.FindByXPath(xpath_LeftClickPane_124_6);
            if (winElem_LeftClickPane_124_6 != null)
            {
                winElem_LeftClickPane_124_6.Click();
                winElem_LeftClickPane_124_6.SendKeys(Keys.ArrowDown);
                winElem_LeftClickPane_124_6.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_124_6}");
                return;
            }


            // LeftClick on Button "" at (18,14)
            Console.WriteLine("LeftClick on Button \"\" at (18,14)");
            string xpath_LeftClickButton_18_14 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@AutomationId=\"btnWrapUnitsOk\"]";
            var winElem_LeftClickButton_18_14 = root.FindByXPath(xpath_LeftClickButton_18_14);
            if (winElem_LeftClickButton_18_14 != null)
            {
                winElem_LeftClickButton_18_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_18_14}");
                return;
            }


            // LeftClick on Button "Uložit" at (48,16)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (48,16)");
            string xpath_LeftClickButtonUložit_48_16 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_48_16 = root.FindByXPath(xpath_LeftClickButtonUložit_48_16);
            if (winElem_LeftClickButtonUložit_48_16 != null)
            {
                winElem_LeftClickButtonUložit_48_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_48_16}");
                return;
            }


            // LeftClick on Button "Ukončit" at (14,17)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (14,17)");
            string xpath_LeftClickButtonUkončit_14_17 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_14_17 = root.FindByXPath(xpath_LeftClickButtonUkončit_14_17);
            if (winElem_LeftClickButtonUkončit_14_17 != null)
            {
                winElem_LeftClickButtonUkončit_14_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_14_17}");
                return;
            }
        }

        private void createProduct()
        {
            // LeftClick on Button "Nová příjemka" at (72,10)
            Console.WriteLine("LeftClick on Button \"Nová příjemka\" at (72,10)");
            string xpath_LeftClickButtonNovápříjem_72_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam dokladů\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucWMDocuments\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová příjemka\"]";
            var winElem_LeftClickButtonNovápříjem_72_10 = root.FindByXPath(xpath_LeftClickButtonNovápříjem_72_10);
            if (winElem_LeftClickButtonNovápříjem_72_10 != null)
            {
                winElem_LeftClickButtonNovápříjem_72_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovápříjem_72_10}");
                return;
            }


            // LeftClick on Edit "" at (584,9)
            Console.WriteLine("LeftClick on Edit \"\" at (584,9)");
            string xpath_LeftClickEdit_584_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Příjem produktu/meziproduktu\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelHeader\"][@AutomationId=\"panelHeader\"]/Pane[@AutomationId=\"ucWMDocumentHeaderTemplate\"]/Edit[@AutomationId=\"txtDocumentName\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_584_9 = root.FindByXPath(xpath_LeftClickEdit_584_9);
            if (winElem_LeftClickEdit_584_9 != null)
            {
                winElem_LeftClickEdit_584_9.Click();
                winElem_LeftClickEdit_584_9.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_584_9}");
                return;
            }


            // LeftClick on Edit "" at (517,43)
            Console.WriteLine("LeftClick on Edit \"\" at (517,43)");
            string xpath_LeftClickEdit_517_43 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Příjem produktu/meziproduktu\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Edit[@AutomationId=\"memoRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_517_43 = root.FindByXPath(xpath_LeftClickEdit_517_43);
            if (winElem_LeftClickEdit_517_43 != null)
            {
                winElem_LeftClickEdit_517_43.Click();
                winElem_LeftClickEdit_517_43.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_517_43}");
                return;
            }

            // get docnumber

            // LeftClick on Edit "2420000050" at (97,6)
            Console.WriteLine("LeftClick on Edit \"2420000050\" at (97,6)");
            string xpath_LeftClickEdit2420000050_97_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2420000050\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelHeader\"][@AutomationId=\"panelHeader\"]/Pane[@AutomationId=\"ucWMDocumentHeaderTemplate\"]/Edit[@Name=\"2420000050\"][@AutomationId=\"txtDocumentNo\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2420000050\"]";
            var winElem_LeftClickEdit2420000050_97_6 = desktopSession.FindByXPath(xpath_LeftClickEdit2420000050_97_6);
            if (winElem_LeftClickEdit2420000050_97_6 != null)
            {
                winElem_LeftClickEdit2420000050_97_6.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit2420000050_97_6}");
                return;
            }


            // LeftClick on DataItem "Příjemka row 0" at (39,16)
            Console.WriteLine("LeftClick on DataItem \"Příjemka row 0\" at (39,16)");
            string xpath_LeftClickDataItemPříjemkaro_39_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2420000050\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeOverview\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node0\"]/DataItem[@Name=\"Příjemka row 0\"]";
            var winElem_LeftClickDataItemPříjemkaro_39_16 = desktopSession.FindByXPath(xpath_LeftClickDataItemPříjemkaro_39_16);
            if (winElem_LeftClickDataItemPříjemkaro_39_16 != null)
            {
                winElem_LeftClickDataItemPříjemkaro_39_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemPříjemkaro_39_16}");
                return;
            }



            string xpath_LeftClickEdit_65_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Příjem produktu/meziproduktu\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelHeader\"][@AutomationId=\"panelHeader\"]/Pane[@AutomationId=\"ucWMDocumentHeaderTemplate\"]/Edit[@AutomationId=\"txtDocumentNo\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit2420000043_89_8 = root.FindByXPath(xpath_LeftClickEdit_65_7);
            string txnumberid = winElem_LeftClickEdit2420000043_89_8.Id;


            // LeftClick on Button "OK" at (32,9)
            Console.WriteLine("LeftClick on Button \"OK\" at (32,9)");
            string xpath_LeftClickButtonOK_32_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Příjem produktu/meziproduktu\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
            var winElem_LeftClickButtonOK_32_9 = root.FindByXPath(xpath_LeftClickButtonOK_32_9);
            if (winElem_LeftClickButtonOK_32_9 != null)
            {
                winElem_LeftClickButtonOK_32_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_32_9}");
                return;
            }


            winElem_LeftClickEdit2420000043_89_8 = root.FindByAccessibilityId(txnumberid);
            if (winElem_LeftClickEdit2420000043_89_8 != null)
            {
                deliveryDocNumber = winElem_LeftClickEdit2420000043_89_8.Text;
            }


            // LeftClick on Button "Uložit" at (48,14)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (48,14)");
            string xpath_LeftClickButtonUložit_48_14 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_48_14 = root.FindByXPath(xpath_LeftClickButtonUložit_48_14);
            if (winElem_LeftClickButtonUložit_48_14 != null)
            {
                winElem_LeftClickButtonUložit_48_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_48_14}");
                return;
            }


            // LeftClick on Button "Ukončit" at (47,20)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (47,20)");
            string xpath_LeftClickButtonUkončit_47_20 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_47_20 = root.FindByXPath(xpath_LeftClickButtonUkončit_47_20);
            if (winElem_LeftClickButtonUkončit_47_20 != null)
            {
                winElem_LeftClickButtonUkončit_47_20.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_47_20}");
                return;
            }


            // LeftClick on Button "Zavřít" at (31,9)
            Console.WriteLine("LeftClick on Button \"Zavřít\" at (31,9)");
            string xpath_LeftClickButtonZavřít_31_9 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavřít\"]";
            var winElem_LeftClickButtonZavřít_31_9 = root.FindByXPath(xpath_LeftClickButtonZavřít_31_9);
            if (winElem_LeftClickButtonZavřít_31_9 != null)
            {
                winElem_LeftClickButtonZavřít_31_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavřít_31_9}");
                return;
            }


            // LeftClick on Button "Editovat" at (38,16)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (38,16)");
            string xpath_LeftClickButtonEditovat_38_16 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_38_16 = root.FindByXPath(xpath_LeftClickButtonEditovat_38_16);
            if (winElem_LeftClickButtonEditovat_38_16 != null)
            {
                winElem_LeftClickButtonEditovat_38_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_38_16}");
                return;
            }


            // LeftClick on Edit "e" at (571,56)
            Console.WriteLine("LeftClick on Edit \"e\" at (571,56)");
            string xpath_LeftClickEdite_571_56 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Edit[@Name=\"e\"][@AutomationId=\"memoRemark\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"e\"]";
            var winElem_LeftClickEdite_571_56 = root.FindByXPath(xpath_LeftClickEdite_571_56);
            if (winElem_LeftClickEdite_571_56 != null)
            {
                winElem_LeftClickEdite_571_56.Click();
                winElem_LeftClickEdite_571_56.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdite_571_56}");
                return;
            }


            // LeftClick on Button "Ukončit" at (41,17)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (41,17)");
            string xpath_LeftClickButtonUkončit_41_17 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_41_17 = root.FindByXPath(xpath_LeftClickButtonUkončit_41_17);
            if (winElem_LeftClickButtonUkončit_41_17 != null)
            {
                winElem_LeftClickButtonUkončit_41_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_41_17}");
                return;
            }


            // LeftClick on Button "&amp;Yes" at (49,8)
            Console.WriteLine("LeftClick on Button \"&amp;Yes\" at (49,8)");
            string xpath_LeftClickButtonYes_49_8 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit změny\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Yes\"]";
            var winElem_LeftClickButtonYes_49_8 = root.FindByXPath(xpath_LeftClickButtonYes_49_8);
            if (winElem_LeftClickButtonYes_49_8 != null)
            {
                winElem_LeftClickButtonYes_49_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonYes_49_8}");
                return;
            }


            // LeftClick on DataItem "Příjemka row 1" at (47,10)
            Console.WriteLine("LeftClick on DataItem \"Příjemka row 1\" at (47,10)");
            string xpath_LeftClickDataItemPříjemkaro_47_10 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"treeOverview\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node1\"]/DataItem[@Name=\"Příjemka row 1\"]";
            var winElem_LeftClickDataItemPříjemkaro_47_10 = root.FindByXPath(xpath_LeftClickDataItemPříjemkaro_47_10);
            if (winElem_LeftClickDataItemPříjemkaro_47_10 != null)
            {
                winElem_LeftClickDataItemPříjemkaro_47_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemPříjemkaro_47_10}");
                return;
            }


            // LeftClick on Button "Editovat" at (36,10)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (36,10)");
            string xpath_LeftClickButtonEditovat_36_10 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_36_10 = root.FindByXPath(xpath_LeftClickButtonEditovat_36_10);
            if (winElem_LeftClickButtonEditovat_36_10 != null)
            {
                winElem_LeftClickButtonEditovat_36_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_36_10}");
                return;
            }


            // LeftClick on Button "Nová položka" at (39,14)
            Console.WriteLine("LeftClick on Button \"Nová položka\" at (39,14)");
            string xpath_LeftClickButtonNovápoložk_39_14 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová položka\"]";
            var winElem_LeftClickButtonNovápoložk_39_14 = root.FindByXPath(xpath_LeftClickButtonNovápoložk_39_14);
            if (winElem_LeftClickButtonNovápoložk_39_14 != null)
            {
                winElem_LeftClickButtonNovápoložk_39_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovápoložk_39_14}");
                return;
            }


            // LeftClick on DataItem "  row0" at (15,12)
            Console.WriteLine("LeftClick on DataItem \"  row0\" at (15,12)");
            string xpath_LeftClickDataItemrow0_15_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Přidat materiál\"][@AutomationId=\"mbWMAddMaterialToTransferItem\"]/Table[@AutomationId=\"gridMaterialSelect\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"  row0\"]";
            var winElem_LeftClickDataItemrow0_15_12 = root.FindByXPath(xpath_LeftClickDataItemrow0_15_12);
            if (winElem_LeftClickDataItemrow0_15_12 != null)
            {
                winElem_LeftClickDataItemrow0_15_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_15_12}");
                return;
            }


            // LeftClick on Button "OK" at (35,12)
            Console.WriteLine("LeftClick on Button \"OK\" at (35,12)");
            string xpath_LeftClickButtonOK_35_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Přidat materiál\"][@AutomationId=\"mbWMAddMaterialToTransferItem\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
            var winElem_LeftClickButtonOK_35_12 = root.FindByXPath(xpath_LeftClickButtonOK_35_12);
            if (winElem_LeftClickButtonOK_35_12 != null)
            {
                winElem_LeftClickButtonOK_35_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_35_12}");
                return;
            }


            // LeftClick on DataItem "Číslo produktu row0" at (87,2)
            Console.WriteLine("LeftClick on DataItem \"Číslo produktu row0\" at (87,2)");
            string xpath_LeftClickDataItemČísloprodu_87_2 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[@Name=\"Seznam položek\"][@AutomationId=\"tabPageGridMaterials\"]/Table[@AutomationId=\"gridMaterials\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Číslo produktu row0\"]";
            var winElem_LeftClickDataItemČísloprodu_87_2 = root.FindByXPath(xpath_LeftClickDataItemČísloprodu_87_2);
            if (winElem_LeftClickDataItemČísloprodu_87_2 != null)
            {
                winElem_LeftClickDataItemČísloprodu_87_2.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČísloprodu_87_2}");
                return;
            }


            // LeftClick on Button "Editovat" at (23,11)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (23,11)");
            string xpath_LeftClickButtonEditovat_23_11 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_23_11 = root.FindByXPath(xpath_LeftClickButtonEditovat_23_11);
            if (winElem_LeftClickButtonEditovat_23_11 != null)
            {
                winElem_LeftClickButtonEditovat_23_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_23_11}");
                return;
            }


            // LeftClick on Edit "" at (86,4)
            Console.WriteLine("LeftClick on Edit \"\" at (86,4)");
            string xpath_LeftClickEdit_86_4 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtContractNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_86_4 = root.FindByXPath(xpath_LeftClickEdit_86_4);
            if (winElem_LeftClickEdit_86_4 != null)
            {
                winElem_LeftClickEdit_86_4.Click();
                winElem_LeftClickEdit_86_4.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_86_4}");
                return;
            }


            // LeftClick on Edit "" at (106,3)
            Console.WriteLine("LeftClick on Edit \"\" at (106,3)");
            string xpath_LeftClickEdit_106_3 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtOrderNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_106_3 = root.FindByXPath(xpath_LeftClickEdit_106_3);
            if (winElem_LeftClickEdit_106_3 != null)
            {
                winElem_LeftClickEdit_106_3.Click();
                winElem_LeftClickEdit_106_3.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_106_3}");
                return;
            }


            // LeftClick on Edit "" at (51,5)
            Console.WriteLine("LeftClick on Edit \"\" at (51,5)");
            string xpath_LeftClickEdit_51_5 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtCustomerBatchNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_51_5 = root.FindByXPath(xpath_LeftClickEdit_51_5);
            if (winElem_LeftClickEdit_51_5 != null)
            {
                winElem_LeftClickEdit_51_5.Click();
                winElem_LeftClickEdit_51_5.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_51_5}");
                return;
            }


            // LeftClick on Edit "" at (31,4)
            Console.WriteLine("LeftClick on Edit \"\" at (31,4)");
            string xpath_LeftClickEdit_31_4 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@AutomationId=\"txtBatchNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_31_4 = root.FindByXPath(xpath_LeftClickEdit_31_4);
            if (winElem_LeftClickEdit_31_4 != null)
            {
                winElem_LeftClickEdit_31_4.Click();
                winElem_LeftClickEdit_31_4.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_31_4}");
                return;
            }


            // LeftClick on Pane "" at (157,13)
            Console.WriteLine("LeftClick on Pane \"\" at (157,13)");
            string xpath_LeftClickPane_157_13 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"cmbTransportUnit\"]";
            var winElem_LeftClickPane_157_13 = root.FindByXPath(xpath_LeftClickPane_157_13);
            if (winElem_LeftClickPane_157_13 != null)
            {
                winElem_LeftClickPane_157_13.Click();
                winElem_LeftClickPane_157_13.SendKeys(Keys.ArrowDown);
                winElem_LeftClickPane_157_13.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_157_13}");
                return;
            }


            // LeftClick on Button "Open" at (6,13)
            Console.WriteLine("LeftClick on Button \"Open\" at (6,13)");
            string xpath_LeftClickButtonOpen_6_13 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/ComboBox[@AutomationId=\"cmbContractType\"]/Button[@Name=\"Open\"]";
            var winElem_LeftClickButtonOpen_6_13 = root.FindByXPath(xpath_LeftClickButtonOpen_6_13);
            if (winElem_LeftClickButtonOpen_6_13 != null)
            {
                winElem_LeftClickButtonOpen_6_13.Click();
                winElem_LeftClickButtonOpen_6_13.SendKeys(Keys.ArrowDown);
                winElem_LeftClickButtonOpen_6_13.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOpen_6_13}");
                return;
            }


            // LeftClick on Button "Up" at (6,7)
            Console.WriteLine("LeftClick on Button \"Up\" at (6,7)");
            string xpath_LeftClickButtonUp_6_7 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Edit[@Name=\"0\"][@AutomationId=\"spinWrapUnitsCount\"]/Spinner[@Name=\"Spinner\"]/Button[@Name=\"Up\"]";
            var winElem_LeftClickButtonUp_6_7 = root.FindByXPath(xpath_LeftClickButtonUp_6_7);
            if (winElem_LeftClickButtonUp_6_7 != null)
            {
                winElem_LeftClickButtonUp_6_7.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUp_6_7}");
                return;
            }


            // LeftClick on Button "" at (16,8)
            Console.WriteLine("LeftClick on Button \"\" at (16,8)");
            string xpath_LeftClickButton_16_8 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[@AutomationId=\"btnWrapUnitsOk\"]";
            var winElem_LeftClickButton_16_8 = root.FindByXPath(xpath_LeftClickButton_16_8);
            if (winElem_LeftClickButton_16_8 != null)
            {
                winElem_LeftClickButton_16_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_16_8}");
                return;
            }


            // LeftClick on DataItem "Číslo plomby row0" at (50,16)
            Console.WriteLine("LeftClick on DataItem \"Číslo plomby row0\" at (50,16)");
            string xpath_LeftClickDataItemČísloplomb_50_16 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@Name=\"groupWrapUnits\"][@AutomationId=\"groupWrapUnits\"]/Table[@AutomationId=\"gridWrapUnits\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Číslo plomby row0\"]";
            var winElem_LeftClickDataItemČísloplomb_50_16 = root.FindByXPath(xpath_LeftClickDataItemČísloplomb_50_16);
            if (winElem_LeftClickDataItemČísloplomb_50_16 != null)
            {
                winElem_LeftClickDataItemČísloplomb_50_16.Click();
                winElem_LeftClickDataItemČísloplomb_50_16.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČísloplomb_50_16}");
                return;
            }


            // LeftClick on CheckBox "Přeskladnit šarži" at (30,13)
            Console.WriteLine("LeftClick on CheckBox \"Přeskladnit šarži\" at (30,13)");
            string xpath_LeftClickCheckBoxPřeskladni_30_13 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/CheckBox[@Name=\"Přeskladnit šarži\"][@AutomationId=\"chcTransferBatch\"]";
            var winElem_LeftClickCheckBoxPřeskladni_30_13 = root.FindByXPath(xpath_LeftClickCheckBoxPřeskladni_30_13);
            if (winElem_LeftClickCheckBoxPřeskladni_30_13 != null)
            {
                winElem_LeftClickCheckBoxPřeskladni_30_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickCheckBoxPřeskladni_30_13}");
                return;
            }


            // LeftClick on Button "Open" at (5,15)
            Console.WriteLine("LeftClick on Button \"Open\" at (5,15)");
            string xpath_LeftClickButtonOpen_5_15 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/ComboBox[@AutomationId=\"cmbTargetWarehouse\"]/Button[@Name=\"Open\"]";
            var winElem_LeftClickButtonOpen_5_15 = root.FindByXPath(xpath_LeftClickButtonOpen_5_15);
            if (winElem_LeftClickButtonOpen_5_15 != null)
            {
                winElem_LeftClickButtonOpen_5_15.Click();
                winElem_LeftClickButtonOpen_5_15.SendKeys(Keys.ArrowDown);
                winElem_LeftClickButtonOpen_5_15.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOpen_5_15}");
                return;
            }


            // LeftClick on Button "Uložit" at (42,10)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (42,10)");
            string xpath_LeftClickButtonUložit_42_10 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_42_10 = root.FindByXPath(xpath_LeftClickButtonUložit_42_10);
            if (winElem_LeftClickButtonUložit_42_10 != null)
            {
                winElem_LeftClickButtonUložit_42_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_42_10}");
                return;
            }


            // LeftClick on Button "Ukončit" at (32,12)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (32,12)");
            string xpath_LeftClickButtonUkončit_32_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_32_12 = root.FindByXPath(xpath_LeftClickButtonUkončit_32_12);
            if (winElem_LeftClickButtonUkončit_32_12 != null)
            {
                winElem_LeftClickButtonUkončit_32_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_32_12}");
                return;
            }


            // LeftClick on Button "Editovat" at (66,24)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (66,24)");
            string xpath_LeftClickButtonEditovat_66_24 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_66_24 = root.FindByXPath(xpath_LeftClickButtonEditovat_66_24);
            if (winElem_LeftClickButtonEditovat_66_24 != null)
            {
                winElem_LeftClickButtonEditovat_66_24.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_66_24}");
                return;
            }


            // LeftClick on Button "Potvrdit položku" at (43,16)
            Console.WriteLine("LeftClick on Button \"Potvrdit položku\" at (43,16)");
            string xpath_LeftClickButtonPotvrditpo_43_16 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Potvrdit položku\"]";
            var winElem_LeftClickButtonPotvrditpo_43_16 = root.FindByXPath(xpath_LeftClickButtonPotvrditpo_43_16);
            if (winElem_LeftClickButtonPotvrditpo_43_16 != null)
            {
                winElem_LeftClickButtonPotvrditpo_43_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonPotvrditpo_43_16}");
                return;
            }


            // LeftClick on DataItem "Číslo OJ row1" at (15,12)
            Console.WriteLine("LeftClick on DataItem \"Číslo OJ row1\" at (15,12)");
            string xpath_LeftClickDataItemČísloOJrow_15_12 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"panelMain\"][@AutomationId=\"panelMain\"]/Tab[@AutomationId=\"tabControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"0001\"]/Pane[@AutomationId=\"ucWMImportProductDetail\"]/Pane[@Name=\"splitContainer\"][@AutomationId=\"splitContainer\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@Name=\"groupWrapUnits\"][@AutomationId=\"groupWrapUnits\"]/Table[@AutomationId=\"gridWrapUnits\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 2\"]/DataItem[@Name=\"Číslo OJ row1\"]";
            var winElem_LeftClickDataItemČísloOJrow_15_12 = root.FindByXPath(xpath_LeftClickDataItemČísloOJrow_15_12);
            if (winElem_LeftClickDataItemČísloOJrow_15_12 != null)
            {
                winElem_LeftClickDataItemČísloOJrow_15_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČísloOJrow_15_12}");
                return;
            }


            // LeftClick on Button "Smazat" at (59,10)
            Console.WriteLine("LeftClick on Button \"Smazat\" at (59,10)");
            string xpath_LeftClickButtonSmazat_59_10 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmWMImportProduct\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{deliveryDocNumber}\"]/Pane[@AutomationId=\"ucWMImportOverview\"]/Pane[@Name=\"splitControl\"][@AutomationId=\"splitControl\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucWMImport\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Smazat\"]";
            var winElem_LeftClickButtonSmazat_59_10 = root.FindByXPath(xpath_LeftClickButtonSmazat_59_10);
            if (winElem_LeftClickButtonSmazat_59_10 != null)
            {
                winElem_LeftClickButtonSmazat_59_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSmazat_59_10}");
                return;
            }


            // LeftClick on Button "&amp;Yes" at (49,13)
            Console.WriteLine("LeftClick on Button \"&amp;Yes\" at (49,13)");
            string xpath_LeftClickButtonYes_49_13 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Opravdu smazat?\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Yes\"]";
            var winElem_LeftClickButtonYes_49_13 = root.FindByXPath(xpath_LeftClickButtonYes_49_13);
            if (winElem_LeftClickButtonYes_49_13 != null)
            {
                winElem_LeftClickButtonYes_49_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonYes_49_13}");
                return;
            }
        }
        #endregion
    }
}
