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
            Initialize("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App", @"C:\Tools"); //Initialize(context);
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
            int methodsNumber = 1;
            int testCases = 8;

            // LeftClick on Button "Sedm" at (68,24)
            desktopSession.Note("LeftClick on Button \"Sedm\" at (68,24)");
            Console.WriteLine("LeftClick on Button \"Sedm\" at (68,24)");
            string xpath_LeftClickButtonSedm_68_24 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Kalkulačka\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Kalkulačka\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Číselná klávesnice\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"Sedm\"][@AutomationId=\"num7Button\"]";
            var winElem_LeftClickButtonSedm_68_24 = desktopSession.FindByXPath(xpath_LeftClickButtonSedm_68_24);
            if (winElem_LeftClickButtonSedm_68_24 != null)
            {
                winElem_LeftClickButtonSedm_68_24.Click();
            }
            else
            {
                desktopSession.Note($"Failed to find element using xpath: {xpath_LeftClickButtonSedm_68_24}");
                return;
            }

            // LeftClick on Text "Zobrazuje se 0" at (501,40)
            desktopSession.Note("LeftClick on Text \"Zobrazuje se 0\" at (501,40)");
            string xpath_LeftClickTextZobrazujes_501_40 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Kalkulačka\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Kalkulačka\"]/Group[@ClassName=\"LandmarkTarget\"]/Text[@Name=\"Zobrazuje se 0\"][@AutomationId=\"CalculatorResults\"]";
            var winElem_LeftClickTextZobrazujes_501_40 = desktopSession.FindByXPath(xpath_LeftClickTextZobrazujes_501_40);
            if (winElem_LeftClickTextZobrazujes_501_40 != null)
            {
                winElem_LeftClickTextZobrazujes_501_40.Click();
            }
            else
            {
                desktopSession.Note($"Failed to find element using xpath: {xpath_LeftClickTextZobrazujes_501_40}");
                return;
            }

            // LeftClick on Button "Devět" at (64,26)
            desktopSession.Note("LeftClick on Button \"Devět\" at (64,26)");
            string xpath_LeftClickButtonDevět_64_26 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Kalkulačka\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Kalkulačka\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Číselná klávesnice\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"Devět\"][@AutomationId=\"num9Button\"]";
            var winElem_LeftClickButtonDevět_64_26 = desktopSession.FindByXPath(xpath_LeftClickButtonDevět_64_26);
            if (winElem_LeftClickButtonDevět_64_26 != null)
            {
                winElem_LeftClickButtonDevět_64_26.Click();
            }
            else
            {
                desktopSession.Note($"Failed to find element using xpath: {xpath_LeftClickButtonDevět_64_26}");
                return;
            }


            // LeftClick on Button "Tři" at (24,32)
            desktopSession.Note("LeftClick on Button \"Tři\" at (24,32)");
            string xpath_LeftClickButtonTři_24_32 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Kalkulačka\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Kalkulačka\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Číselná klávesnice\"][@AutomationId=\"NumberPad\"]/Button[@Name=\"Tři\"][@AutomationId=\"num3Button\"]";
            var winElem_LeftClickButtonTři_24_32 = desktopSession.FindByXPath(xpath_LeftClickButtonTři_24_32);
            if (winElem_LeftClickButtonTři_24_32 != null)
            {
                winElem_LeftClickButtonTři_24_32.Click();
            }
            else
            {
                desktopSession.Note($"Failed to find element using xpath: {xpath_LeftClickButtonTři_24_32}");
                return;
            }


            // LeftClick on Button "Rovná se" at (114,28)
            desktopSession.Note("LeftClick on Button \"Rovná se\" at (114,28)");
            string xpath_LeftClickButtonRovnáse_114_28 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@ClassName=\"ApplicationFrameWindow\"][@Name=\"Kalkulačka\"]/Window[@ClassName=\"Windows.UI.Core.CoreWindow\"][@Name=\"Kalkulačka\"]/Group[@ClassName=\"LandmarkTarget\"]/Group[@Name=\"Standardní operátory\"][@AutomationId=\"StandardOperators\"]/Button[@Name=\"Rovná se\"][@AutomationId=\"equalButton\"]";
            var winElem_LeftClickButtonRovnáse_114_28 = desktopSession.FindByXPath(xpath_LeftClickButtonRovnáse_114_28);
            if (winElem_LeftClickButtonRovnáse_114_28 != null)
            {
                winElem_LeftClickButtonRovnáse_114_28.Click();
            }
            else
            {
                desktopSession.Note($"Failed to find element using xpath: {xpath_LeftClickButtonRovnáse_114_28}");
                return;
            }

            Assert.AreEqual(ActualReportModel.methods.Count, methodsNumber);
            Assert.AreEqual(ActualReportModel.methods[0].cases.Count, testCases);
        }
    }
}
