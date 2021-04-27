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
using System.Security.Cryptography.X509Certificates;
using ReportManager;

namespace TestEditMaterializeCard
{
    [TestClass]
    public class CalculatorTests : ReportManager.ReportManager
    {
        [AssemblyInitialize()]
        public static void AssemblyInitialize(TestContext context)
        {
            Initialize(context); //Initialize(@"C:\Users\MayBee\Desktop", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            FinalTasks();
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
            // LeftClick on Button "Sedm" at (68,24)
            Console.WriteLine("LeftClick on Button \"Sedm\" at (68,24)");
            string xpath_LeftClickButtonSedm_68_24 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Kalkulačka\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Kalkulačka\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Číselná klávesnice\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"Sedm\"][@AutomationId=\"num7Button\"]";
            var winElem_LeftClickButtonSedm_68_24 = desktopSession.FindElementByXPath(xpath_LeftClickButtonSedm_68_24);
            if (winElem_LeftClickButtonSedm_68_24 != null)
            {
                winElem_LeftClickButtonSedm_68_24.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSedm_68_24}");
                return;
            }

            // LeftClick on Button "Devět" at (64,26)
            Console.WriteLine("LeftClick on Button \"Devět\" at (64,26)");
            string xpath_LeftClickButtonDevět_64_26 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Kalkulačka\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Kalkulačka\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Číselná klávesnice\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"Devět\"][@AutomationId=\"num9Button\"]";
            var winElem_LeftClickButtonDevět_64_26 = desktopSession.FindElementByXPath(xpath_LeftClickButtonDevět_64_26);
            if (winElem_LeftClickButtonDevět_64_26 != null)
            {
                winElem_LeftClickButtonDevět_64_26.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonDevět_64_26}");
                return;
            }


            // LeftClick on Button "Tři" at (24,32)
            Console.WriteLine("LeftClick on Button \"Tři\" at (24,32)");
            string xpath_LeftClickButtonTři_24_32 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Kalkulačka\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Kalkulačka\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Číselná klávesnice\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"Tři\"][@AutomationId=\"num3Button\"]";
            var winElem_LeftClickButtonTři_24_32 = desktopSession.FindElementByXPath(xpath_LeftClickButtonTři_24_32);
            if (winElem_LeftClickButtonTři_24_32 != null)
            {
                winElem_LeftClickButtonTři_24_32.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonTři_24_32}");
                return;
            }


            // LeftClick on Button "Rovná se" at (114,28)
            Console.WriteLine("LeftClick on Button \"Rovná se\" at (114,28)");
            string xpath_LeftClickButtonRovnáse_114_28 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Kalkulačka\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Kalkulačka\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Standardní operátory\"][@AutomationId=\"StandardOperators\"]/Button[@Name=\"Rovná se\"][@AutomationId=\"equalButton\"]";
            var winElem_LeftClickButtonRovnáse_114_28 = desktopSession.FindElementByXPath(xpath_LeftClickButtonRovnáse_114_28);
            if (winElem_LeftClickButtonRovnáse_114_28 != null)
            {
                winElem_LeftClickButtonRovnáse_114_28.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonRovnáse_114_28}");
                return;
            }

            // LeftClick on Button "One" at (39,29)
            Console.WriteLine("LeftClick on Button \"One\" at (39,29)");
            string xpath_LeftClickButtonOne_39_29 = "/Pane[@ClassName=\"#32769\"][@Name=\"Počítač 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Calculator\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Calculator\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Number pad\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"One\"][@AutomationId=\"num1Button\"]";
            var winElem_LeftClickButtonOne_39_29 = desktopSession.FindElementByXPath(xpath_LeftClickButtonOne_39_29);
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
            var winElem_LeftClickButtonFive_24_40 = desktopSession.FindElementByXPath(xpath_LeftClickButtonFive_24_40);
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
            var winElem_LeftClickButtonPlus_19_21 = desktopSession.FindElementByXPath(xpath_LeftClickButtonPlus_19_21);
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
            var winElem_LeftClickButtonNine_52_31 = desktopSession.FindElementByXPath(xpath_LeftClickButtonNine_52_31);
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
            var winElem_LeftClickButtonEquals_57_25 = desktopSession.FindElementByXPath(xpath_LeftClickButtonEquals_57_25);
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
            var winElem_LeftClickTextDisplayis2_291_45 = desktopSession.FindElementByXPath(xpath_LeftClickTextDisplayis2_291_45);
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
