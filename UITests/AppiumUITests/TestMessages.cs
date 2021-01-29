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
using ReportManager;

namespace UnitTestMessages
{
    [TestClass]
    public class TestMessages : SessionSettingClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testingUser = "Lokální Jouda";
            string sendingUser = "mwAdmin";
            string testingSubject = "Testík";
            string testingMessage = "Yo bro //n How you doin?";
            string sendingrPriority = "Nízká";

            // LeftClick on Button "miLIMS" at (48,12)
            Console.WriteLine("LeftClick on Button \"miLIMS\" at (48,12)");
            string xpath_LeftClickButtonmiLIMS_48_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Group[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Pøichytit nahoru\"]/ToolBar[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[@Name=\"miLIMS\"]";
            var winElem_LeftClickButtonmiLIMS_48_12 = desktopSession.FindByAccessibilityId("fmMainBase");
            if (winElem_LeftClickButtonmiLIMS_48_12 != null)
            {
                winElem_LeftClickButtonmiLIMS_48_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_btnMyMessages = desktopSession.FindByAccessibilityId("btnMyMessages");
            if (winElem_LeftClickButtonmiLIMS_btnMyMessages != null)
            {
                winElem_LeftClickButtonmiLIMS_btnMyMessages.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_btnNewMessage = desktopSession.FindByAccessibilityId("btnNewMessage");
            if (winElem_LeftClickButtonmiLIMS_btnNewMessage != null)
            {
                winElem_LeftClickButtonmiLIMS_btnNewMessage.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_cbRecipient = desktopSession.FindByAccessibilityId("cbRecipient");
            if (winElem_LeftClickButtonmiLIMS_cbRecipient != null)
            {
                winElem_LeftClickButtonmiLIMS_cbRecipient.Click();
                winElem_LeftClickButtonmiLIMS_cbRecipient.SendKeys(testingUser);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_txtFrom = desktopSession.FindByAccessibilityId("txtFrom");
            if (winElem_LeftClickButtonmiLIMS_txtFrom != null)
            {
                winElem_LeftClickButtonmiLIMS_txtFrom.Click();
                winElem_LeftClickButtonmiLIMS_txtFrom.SendKeys(sendingUser);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_txtSubject = desktopSession.FindByAccessibilityId("txtSubject");
            if (winElem_LeftClickButtonmiLIMS_txtSubject != null)
            {
                winElem_LeftClickButtonmiLIMS_txtSubject.Click();
                winElem_LeftClickButtonmiLIMS_txtSubject.SendKeys(testingSubject);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_txtText = desktopSession.FindByAccessibilityId("txtText");
            if (winElem_LeftClickButtonmiLIMS_txtText != null)
            {
                winElem_LeftClickButtonmiLIMS_txtText.Click();
                winElem_LeftClickButtonmiLIMS_txtText.SendKeys(testingMessage);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_cbPriority = desktopSession.FindByAccessibilityId("cbPriority");
            if (winElem_LeftClickButtonmiLIMS_cbPriority != null)
            {
                winElem_LeftClickButtonmiLIMS_cbPriority.Click();
                winElem_LeftClickButtonmiLIMS_cbPriority.SendKeys(sendingrPriority);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_btnSave = desktopSession.FindByAccessibilityId("btnSave");
            if (winElem_LeftClickButtonmiLIMS_btnSave != null)
            {
                winElem_LeftClickButtonmiLIMS_btnSave.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_btnReloadUC = desktopSession.FindByAccessibilityId("btnReloadUC");
            if (winElem_LeftClickButtonmiLIMS_btnReloadUC != null)
            {
                winElem_LeftClickButtonmiLIMS_btnReloadUC.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            var winElem_LeftClickButtonmiLIMS_ucUserMessageDetailFormated = desktopSession.FindByAccessibilityId("gcUserMessages");
            if (winElem_LeftClickButtonmiLIMS_ucUserMessageDetailFormated != null)
            {
                winElem_LeftClickButtonmiLIMS_ucUserMessageDetailFormated.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            string mess_LeftClickButtonmiLIMS_gcUserMessage = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmUserMessage\"]/Tab[@AutomationId=\"tcUsers\"]/Pane[@Name=\"Seznam zpráv\"][@AutomationId=\"tpUserList\"]/Pane[@AutomationId=\"ucUserMessageList\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Table[@AutomationId=\"gcUserMessages\"]/Custom[@Name=\"Datový Panel\"]/Custom[@Name=\"Øádek 2\"]/DataItem[@Name=\"Pøíjemce row0\"]";
            var winElem_LeftClickButtonmiLIMS_gcUserMessages = root.FindByXPath(mess_LeftClickButtonmiLIMS_gcUserMessage);
            if (winElem_LeftClickButtonmiLIMS_gcUserMessages != null)
            {
                winElem_LeftClickButtonmiLIMS_gcUserMessages.Click();
                //Assert.AreEqual(winElem_LeftClickButtonmiLIMS_gcUserMessages.Click, testingUser);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiLIMS_48_12}");
                return;
            }

            // LeftClick on Text "Yo bro --n How zou doin?" at (133,6)
            string xpath_LeftClickTextYobronHowz_133_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Poèítaè 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmUserMessage\"]/Tab[@AutomationId=\"tcUsers\"]/Pane[@Name=\"Seznam zpráv\"][@AutomationId=\"tpUserList\"]/Pane[@AutomationId=\"ucUserMessageList\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucUserMessageDetailFormated\"]/Text[@Name=\"Yo bro --n How zou doin?\"][@AutomationId=\"txtText\"]";
            var winElem_LeftClickTextYobronHowz_133_6 = desktopSession.FindByAccessibilityId("txtText");
            if (winElem_LeftClickTextYobronHowz_133_6 != null)
            {
                winElem_LeftClickTextYobronHowz_133_6.Click();
                Assert.AreEqual(winElem_LeftClickTextYobronHowz_133_6.Text, testingMessage, true);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickTextYobronHowz_133_6}");
                return;
            }

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
