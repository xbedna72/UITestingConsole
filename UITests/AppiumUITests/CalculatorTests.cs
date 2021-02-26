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
    public class CalculatorTests : SessionSettingClass
    {
        [AssemblyInitialize()]
        public static void AssemblyInitialize(TestContext context)
        {
            GetContextParameters(context);
		}

        [ClassInitialize()]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            TearDown();
        }

        [TestMethod]
        public void MainTestMethod()
        {
            // LeftClick on Window "Calculator" at (106,15)
            Console.WriteLine("LeftClick on Window \"Calculator\" at (106,15)");
            string xpath_LeftClickWindowCalculator_106_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Calculator\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Calculator\"]";
            var winElem_LeftClickWindowCalculator_106_15 = root.FindByXPath(xpath_LeftClickWindowCalculator_106_15);
            if (winElem_LeftClickWindowCalculator_106_15 != null)
            {
                winElem_LeftClickWindowCalculator_106_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickWindowCalculator_106_15}");
                return;
            }

            // LeftClick on Button "One" at (39,29)
            Console.WriteLine("LeftClick on Button \"One\" at (39,29)");
            string xpath_LeftClickButtonOne_39_29 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Calculator\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Calculator\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Number pad\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"One\"][@AutomationId=\"num1Button\"]";
            var winElem_LeftClickButtonOne_39_29 = root.FindByXPath(xpath_LeftClickButtonOne_39_29);
            if (winElem_LeftClickButtonOne_39_29 != null)
            {
                winElem_LeftClickButtonOne_39_29.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOne_39_29}");
                return;
            }


            // LeftClick on Button "Five" at (24,40)
            Console.WriteLine("LeftClick on Button \"Five\" at (24,40)");
            string xpath_LeftClickButtonFive_24_40 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Calculator\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Calculator\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Number pad\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"Five\"][@AutomationId=\"num5Button\"]";
            var winElem_LeftClickButtonFive_24_40 = root.FindByXPath(xpath_LeftClickButtonFive_24_40);
            if (winElem_LeftClickButtonFive_24_40 != null)
            {
                winElem_LeftClickButtonFive_24_40.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonFive_24_40}");
                return;
            }


            // LeftClick on Button "Plus" at (19,21)
            Console.WriteLine("LeftClick on Button \"Plus\" at (19,21)");
            string xpath_LeftClickButtonPlus_19_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Calculator\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Calculator\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Standard operators\"][@AutomationId=\"StandardOperators\"]/Button[@Name=\"Plus\"][@AutomationId=\"plusButton\"]";
            var winElem_LeftClickButtonPlus_19_21 = root.FindByXPath(xpath_LeftClickButtonPlus_19_21);
            if (winElem_LeftClickButtonPlus_19_21 != null)
            {
                winElem_LeftClickButtonPlus_19_21.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonPlus_19_21}");
                return;
            }


            // LeftClick on Button "Nine" at (52,31)
            Console.WriteLine("LeftClick on Button \"Nine\" at (52,31)");
            string xpath_LeftClickButtonNine_52_31 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Calculator\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Calculator\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Number pad\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"Nine\"][@AutomationId=\"num9Button\"]";
            var winElem_LeftClickButtonNine_52_31 = root.FindByXPath(xpath_LeftClickButtonNine_52_31);
            if (winElem_LeftClickButtonNine_52_31 != null)
            {
                winElem_LeftClickButtonNine_52_31.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNine_52_31}");
                return;
            }


            // LeftClick on Button "Equals" at (57,25)
            Console.WriteLine("LeftClick on Button \"Equals\" at (57,25)");
            string xpath_LeftClickButtonEquals_57_25 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Calculator\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Calculator\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Standard operators\"][@AutomationId=\"StandardOperators\"]/Button[@Name=\"Equals\"][@AutomationId=\"equalButton\"]";
            var winElem_LeftClickButtonEquals_57_25 = root.FindByXPath(xpath_LeftClickButtonEquals_57_25);
            if (winElem_LeftClickButtonEquals_57_25 != null)
            {
                winElem_LeftClickButtonEquals_57_25.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEquals_57_25}");
                return;
            }


            // LeftClick on Text "Display is 24" at (291,45)
            Console.WriteLine("LeftClick on Text \"Display is 24\" at (291,45)");
            string xpath_LeftClickTextDisplayis2_291_45 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Calculator\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Calculator\"]/Group[@ClassName=\"LandmarkTarget\"]/Text[@Name=\"Display is 24\"][@AutomationId=\"CalculatorResults\"]";
            var winElem_LeftClickTextDisplayis2_291_45 = root.FindByXPath(xpath_LeftClickTextDisplayis2_291_45);
            if (winElem_LeftClickTextDisplayis2_291_45 != null)
            {
                winElem_LeftClickTextDisplayis2_291_45.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickTextDisplayis2_291_45}");
                return;
            }
        }

    }
}
