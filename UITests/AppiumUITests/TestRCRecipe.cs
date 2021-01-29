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
    public class UnitTestRecept : SessionSettingClass
    {

        string docNumber = "2008";
        [TestMethod]
        public void TestMethod()
        {
            // V systému existuje starší verze receptury ve stavu Scvhálená, tato verze bude automaticky zneplatněna
            // Potom cokoli co obsahuje vygenerovanou verzi tak nefunguje protože neumím určit tu proměnnou tak aby to fungovalo 
            // LeftClick on Button "miProductionRecipes" at (46,17)
            Console.WriteLine("LeftClick on Button \"miProductionRecipes\" at (46,17)");
            string xpath_LeftClickButtonmiProducti_46_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Group[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Dock Top\"]/ToolBar[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[@Name=\"miProductionRecipes\"]";
            var winElem_LeftClickButtonmiProducti_46_17 = root.FindByXPath(xpath_LeftClickButtonmiProducti_46_17);
            if (winElem_LeftClickButtonmiProducti_46_17 != null)
            {
                winElem_LeftClickButtonmiProducti_46_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonmiProducti_46_17}");
                return;
            }


            // LeftClick on MenuItem "miPdRecipes" at (78,16)
            Console.WriteLine("LeftClick on MenuItem \"miPdRecipes\" at (78,16)");
            string xpath_LeftClickMenuItemmiPdRecipe_78_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Menu[starts-with(@ClassName,\"WindowsForms10\")]/MenuItem[@Name=\"miPdRecipes\"]";
            var winElem_LeftClickMenuItemmiPdRecipe_78_16 = root.FindByXPath(xpath_LeftClickMenuItemmiPdRecipe_78_16);
            if (winElem_LeftClickMenuItemmiPdRecipe_78_16 != null)
            {
                winElem_LeftClickMenuItemmiPdRecipe_78_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickMenuItemmiPdRecipe_78_16}");
                return;
            }


            // LeftClick on DataItem "Číslo receptury row0" at (54,14)
            Console.WriteLine("LeftClick on DataItem \"Číslo receptury row0\" at (54,14)");
            string xpath_LeftClickDataItemČíslorecep_54_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam receptur\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucPdRecipeList\"]/Table[@AutomationId=\"gridRecipes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"Číslo receptury row0\"]";
            var winElem_LeftClickDataItemČíslorecep_54_14 = root.FindByXPath(xpath_LeftClickDataItemČíslorecep_54_14);
            if (winElem_LeftClickDataItemČíslorecep_54_14 != null)
            {
                winElem_LeftClickDataItemČíslorecep_54_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemČíslorecep_54_14}");
                return;
            }


            // LeftClick on Button "Zavřít" at (42,16)
            Console.WriteLine("LeftClick on Button \"Zavřít\" at (42,16)");
            string xpath_LeftClickButtonZavřít_42_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"__200\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zavřít\"]";
            var winElem_LeftClickButtonZavřít_42_16 = root.FindByXPath(xpath_LeftClickButtonZavřít_42_16);
            if (winElem_LeftClickButtonZavřít_42_16 != null)
            {
                winElem_LeftClickButtonZavřít_42_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZavřít_42_16}");
                return;
            }


            createRecipe();

            string recipeNumber = "2-2";

            createRecipe2();

            recipeModify();

            recipeModify2();
        }

        private void recipeModify2()
        {
            // LeftClick on Button "Kopie" at (43,8)
            Console.WriteLine("LeftClick on Button \"Kopie\" at (43,8)");
            string xpath_LeftClickButtonKopie_43_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Kopie\"]";
            var winElem_LeftClickButtonKopie_43_8 = root.FindByXPath(xpath_LeftClickButtonKopie_43_8);
            if (winElem_LeftClickButtonKopie_43_8 != null)
            {
                winElem_LeftClickButtonKopie_43_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKopie_43_8}");
                return;
            }


            // LeftClick on Button "OK" at (50,13)
            Console.WriteLine("LeftClick on Button \"OK\" at (50,13)");
            string xpath_LeftClickButtonOK_50_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Kopie receptury\"][@AutomationId=\"mbPdRecipeCopy\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_50_13 = root.FindByXPath(xpath_LeftClickButtonOK_50_13);
            if (winElem_LeftClickButtonOK_50_13 != null)
            {
                winElem_LeftClickButtonOK_50_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_50_13}");
                return;
            }


            // LeftClick on Edit "" at (102,7)
            Console.WriteLine("LeftClick on Edit \"\" at (102,7)");
            string xpath_LeftClickEdit_102_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Kopie 2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@Name=\"510011\"][@AutomationId=\"teNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_102_7 = root.FindByXPath(xpath_LeftClickEdit_102_7);
            if (winElem_LeftClickEdit_102_7 != null)
            {
                winElem_LeftClickEdit_102_7.Click();
                winElem_LeftClickEdit_102_7.SendKeys(Keys.Backspace);
                winElem_LeftClickEdit_102_7.SendKeys(Keys.Backspace);
                winElem_LeftClickEdit_102_7.SendKeys(Keys.Backspace);
                winElem_LeftClickEdit_102_7.SendKeys(Keys.Backspace);
                winElem_LeftClickEdit_102_7.SendKeys(Keys.Backspace);
                winElem_LeftClickEdit_102_7.SendKeys(Keys.Backspace);
                winElem_LeftClickEdit_102_7.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_102_7}");
                return;
            }


            // LeftClick on Button "OK" at (18,11)
            Console.WriteLine("LeftClick on Button \"OK\" at (18,11)");
            string xpath_LeftClickButtonOK_18_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Kopie 2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
            var winElem_LeftClickButtonOK_18_11 = root.FindByXPath(xpath_LeftClickButtonOK_18_11);
            if (winElem_LeftClickButtonOK_18_11 != null)
            {
                winElem_LeftClickButtonOK_18_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_18_11}");
                return;
            }


            // LeftClick on Button "Ukončit" at (49,17)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (49,17)");
            string xpath_LeftClickButtonUkončit_49_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_49_17 = root.FindByXPath(xpath_LeftClickButtonUkončit_49_17);
            if (winElem_LeftClickButtonUkončit_49_17 != null)
            {
                winElem_LeftClickButtonUkončit_49_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_49_17}");
                return;
            }

            //recipeMaterial();

            // LeftClick on Button "K ověření" at (53,6)
            Console.WriteLine("LeftClick on Button \"K ověření\" at (53,6)");
            string xpath_LeftClickButtonKověření_53_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"K ověření\"]";
            var winElem_LeftClickButtonKověření_53_6 = root.FindByXPath(xpath_LeftClickButtonKověření_53_6);
            if (winElem_LeftClickButtonKověření_53_6 != null)
            {
                winElem_LeftClickButtonKověření_53_6.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKověření_53_6}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (45,10)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (45,10)");
            string xpath_LeftClickEditPasswordTe_45_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"K ověření\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_45_10 = root.FindByXPath(xpath_LeftClickEditPasswordTe_45_10);
            if (winElem_LeftClickEditPasswordTe_45_10 != null)
            {
                winElem_LeftClickEditPasswordTe_45_10.Click();
                winElem_LeftClickEditPasswordTe_45_10.SendKeys("mesbrno");
                winElem_LeftClickEditPasswordTe_45_10.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_45_10}");
                return;
            }


            // LeftClick on Button "Ověřit" at (37,21)
            Console.WriteLine("LeftClick on Button \"Ověřit\" at (37,21)");
            string xpath_LeftClickButtonOvěřit_37_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ověřit\"]";
            var winElem_LeftClickButtonOvěřit_37_21 = root.FindByXPath(xpath_LeftClickButtonOvěřit_37_21);
            if (winElem_LeftClickButtonOvěřit_37_21 != null)
            {
                winElem_LeftClickButtonOvěřit_37_21.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOvěřit_37_21}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (122,11)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (122,11)");
            string xpath_LeftClickEditPasswordTe_122_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Ověřit\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_122_11 = root.FindByXPath(xpath_LeftClickEditPasswordTe_122_11);
            if (winElem_LeftClickEditPasswordTe_122_11 != null)
            {
                winElem_LeftClickEditPasswordTe_122_11.Click();
                winElem_LeftClickEditPasswordTe_122_11.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_122_11}");
                return;
            }


            // LeftClick on Button "OK" at (62,14)
            Console.WriteLine("LeftClick on Button \"OK\" at (62,14)");
            string xpath_LeftClickButtonOK_62_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Ověřit\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_62_14 = root.FindByXPath(xpath_LeftClickButtonOK_62_14);
            if (winElem_LeftClickButtonOK_62_14 != null)
            {
                winElem_LeftClickButtonOK_62_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_62_14}");
                return;
            }


            // LeftClick on Button "Schválit" at (31,21)
            Console.WriteLine("LeftClick on Button \"Schválit\" at (31,21)");
            string xpath_LeftClickButtonSchválit_31_21 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Schválit\"]";
            var winElem_LeftClickButtonSchválit_31_21 = root.FindByXPath(xpath_LeftClickButtonSchválit_31_21);
            if (winElem_LeftClickButtonSchválit_31_21 != null)
            {
                winElem_LeftClickButtonSchválit_31_21.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSchválit_31_21}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (28,1)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (28,1)");
            string xpath_LeftClickEditPasswordTe_28_1 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Schválit\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_28_1 = root.FindByXPath(xpath_LeftClickEditPasswordTe_28_1);
            if (winElem_LeftClickEditPasswordTe_28_1 != null)
            {
                winElem_LeftClickEditPasswordTe_28_1.Click();
                winElem_LeftClickEditPasswordTe_28_1.SendKeys("mesbrno");
                winElem_LeftClickEditPasswordTe_28_1.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_28_1}");
                return;
            }


            string txtversionid = null;

            string xpath_LeftClickPane_22_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"teVersion\"]";
            var winElem_LeftClickPane_22_0 = desktopSession.FindByXPath(xpath_LeftClickPane_22_0);
            if (winElem_LeftClickPane_22_0 != null)
            {
                txtversionid = winElem_LeftClickPane_22_0.Id;
            }


            string fullRcNumber = null;
            var winElem_LeftClickEditPasswordTe_22ver_1 = root.FindByAccessibilityId(txtversionid);
            if (winElem_LeftClickEditPasswordTe_22ver_1 != null)
            {
                fullRcNumber = GetFullRecipeNumber("2-2", winElem_LeftClickEditPasswordTe_22ver_1.Text);
            }


            // LeftClick on Button "Zneplatnit" at (40,4)
            Console.WriteLine("LeftClick on Button \"Zneplatnit\" at (40,4)");
            string xpath_LeftClickButtonZneplatnit_40_4 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{fullRcNumber}\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zneplatnit\"]";
            var winElem_LeftClickButtonZneplatnit_40_4 = root.FindByXPath(xpath_LeftClickButtonZneplatnit_40_4);
            if (winElem_LeftClickButtonZneplatnit_40_4 != null)
            {
                winElem_LeftClickButtonZneplatnit_40_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZneplatnit_40_4}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (18,6)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (18,6)");
            string xpath_LeftClickEditPasswordTe_18_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Zneplatnění receptury\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_18_6 = root.FindByXPath(xpath_LeftClickEditPasswordTe_18_6);
            if (winElem_LeftClickEditPasswordTe_18_6 != null)
            {
                winElem_LeftClickEditPasswordTe_18_6.Click();
                winElem_LeftClickEditPasswordTe_18_6.SendKeys("mesbrno");
                winElem_LeftClickEditPasswordTe_18_6.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_18_6}");
                return;
            }


            // LeftClick on Button "Close" at (12,9)
            Console.WriteLine("LeftClick on Button \"Close\" at (12,9)");
            string xpath_LeftClickButtonClose_12_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/TabItem[@Name=\"2-2, ver. 14\"]/Button[@Name=\"Close\"]";
            var winElem_LeftClickButtonClose_12_9 = root.FindByXPath(xpath_LeftClickButtonClose_12_9);
            if (winElem_LeftClickButtonClose_12_9 != null)
            {
                winElem_LeftClickButtonClose_12_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonClose_12_9}");
                return;
            }


            // LeftClick on Button "Schválit" at (41,9)
            Console.WriteLine("LeftClick on Button \"Schválit\" at (41,9)");
            string xpath_LeftClickButtonSchválit_41_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Schválit\"]";
            var winElem_LeftClickButtonSchválit_41_9 = root.FindByXPath(xpath_LeftClickButtonSchválit_41_9);
            if (winElem_LeftClickButtonSchválit_41_9 != null)
            {
                winElem_LeftClickButtonSchválit_41_9.Click();
                winElem_LeftClickButtonSchválit_41_9.SendKeys(Keys.Tab);
                winElem_LeftClickButtonSchválit_41_9.SendKeys("mesbrno");
                winElem_LeftClickButtonSchválit_41_9.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSchválit_41_9}");
                return;
            }


            // LeftClick on Button "Vydat" at (58,20)
            Console.WriteLine("LeftClick on Button \"Vydat\" at (58,20)");
            string xpath_LeftClickButtonVydat_58_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2, ver. 15\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Vydat\"]";
            var winElem_LeftClickButtonVydat_58_20 = root.FindByXPath(xpath_LeftClickButtonVydat_58_20);
            if (winElem_LeftClickButtonVydat_58_20 != null)
            {
                winElem_LeftClickButtonVydat_58_20.Click();
                winElem_LeftClickButtonVydat_58_20.SendKeys(Keys.Tab);
                winElem_LeftClickButtonVydat_58_20.SendKeys("mesbrno");
                winElem_LeftClickButtonVydat_58_20.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonVydat_58_20}");
                return;
            }


            // LeftClick on Button "Vydat" at (43,6)
            Console.WriteLine("LeftClick on Button \"Vydat\" at (43,6)");
            string xpath_LeftClickButtonVydat_43_6 = $"/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"{docNumber}\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Vydat\"]";
            var winElem_LeftClickButtonVydat_43_6 = root.FindByXPath(xpath_LeftClickButtonVydat_43_6);
            if (winElem_LeftClickButtonVydat_43_6 != null)
            {
                winElem_LeftClickButtonVydat_43_6.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonVydat_43_6}");
                return;
            }


            // LeftClick on Button "Storno" at (29,10)
            Console.WriteLine("LeftClick on Button \"Storno\" at (29,10)");
            string xpath_LeftClickButtonStorno_29_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vydání receptury\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"Storno\"][@AutomationId=\"btnCancel\"]";
            var winElem_LeftClickButtonStorno_29_10 = root.FindByXPath(xpath_LeftClickButtonStorno_29_10);
            if (winElem_LeftClickButtonStorno_29_10 != null)
            {
                winElem_LeftClickButtonStorno_29_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_29_10}");
                return;
            }


            // LeftClick on Button "Vydat" at (34,7)
            Console.WriteLine("LeftClick on Button \"Vydat\" at (34,7)");
            string xpath_LeftClickButtonVydat_34_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2, ver. 7\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Vydat\"]";
            var winElem_LeftClickButtonVydat_34_7 = root.FindByXPath(xpath_LeftClickButtonVydat_34_7);
            if (winElem_LeftClickButtonVydat_34_7 != null)
            {
                winElem_LeftClickButtonVydat_34_7.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonVydat_34_7}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (25,4)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (25,4)");
            string xpath_LeftClickEditPasswordTe_25_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vydání receptury\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_25_4 = root.FindByXPath(xpath_LeftClickEditPasswordTe_25_4);
            if (winElem_LeftClickEditPasswordTe_25_4 != null)
            {
                winElem_LeftClickEditPasswordTe_25_4.Click();
                winElem_LeftClickEditPasswordTe_25_4.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_25_4}");
                return;
            }


            // LeftClick on Button "OK" at (4,2)
            Console.WriteLine("LeftClick on Button \"OK\" at (4,2)");
            string xpath_LeftClickButtonOK_4_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Vydání receptury\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_4_2 = root.FindByXPath(xpath_LeftClickButtonOK_4_2);
            if (winElem_LeftClickButtonOK_4_2 != null)
            {
                winElem_LeftClickButtonOK_4_2.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_4_2}");
                return;
            }
        }

        private static void recipeModify()
        {
            // LeftClick on Button "K ověření" at (13,10)
            Console.WriteLine("LeftClick on Button \"K ověření\" at (13,10)");
            string xpath_LeftClickButtonKověření_13_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"K ověření\"]";
            var winElem_LeftClickButtonKověření_13_10 = root.FindByXPath(xpath_LeftClickButtonKověření_13_10);
            if (winElem_LeftClickButtonKověření_13_10 != null)
            {
                winElem_LeftClickButtonKověření_13_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKověření_13_10}");
                return;
            }


            // LeftClick on Button "Storno" at (58,3)
            Console.WriteLine("LeftClick on Button \"Storno\" at (58,3)");
            string xpath_LeftClickButtonStorno_58_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"K ověření\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"Storno\"][@AutomationId=\"btnCancel\"]";
            var winElem_LeftClickButtonStorno_58_3 = root.FindByXPath(xpath_LeftClickButtonStorno_58_3);
            if (winElem_LeftClickButtonStorno_58_3 != null)
            {
                winElem_LeftClickButtonStorno_58_3.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_58_3}");
                return;
            }


            // LeftClick on Button "K ověření" at (61,9)
            Console.WriteLine("LeftClick on Button \"K ověření\" at (61,9)");
            string xpath_LeftClickButtonKověření_61_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"K ověření\"]";
            var winElem_LeftClickButtonKověření_61_9 = root.FindByXPath(xpath_LeftClickButtonKověření_61_9);
            if (winElem_LeftClickButtonKověření_61_9 != null)
            {
                winElem_LeftClickButtonKověření_61_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKověření_61_9}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (75,14)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (75,14)");
            string xpath_LeftClickEditPasswordTe_75_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"K ověření\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_75_14 = root.FindByXPath(xpath_LeftClickEditPasswordTe_75_14);
            if (winElem_LeftClickEditPasswordTe_75_14 != null)
            {
                winElem_LeftClickEditPasswordTe_75_14.Click();
                winElem_LeftClickEditPasswordTe_75_14.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_75_14}");
                return;
            }


            // LeftClick on Button "OK" at (27,8)
            Console.WriteLine("LeftClick on Button \"OK\" at (27,8)");
            string xpath_LeftClickButtonOK_27_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"K ověření\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_27_8 = root.FindByXPath(xpath_LeftClickButtonOK_27_8);
            if (winElem_LeftClickButtonOK_27_8 != null)
            {
                winElem_LeftClickButtonOK_27_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_27_8}");
                return;
            }


            // LeftClick on Button "Zamítnout" at (50,18)
            Console.WriteLine("LeftClick on Button \"Zamítnout\" at (50,18)");
            string xpath_LeftClickButtonZamítnout_50_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zamítnout\"]";
            var winElem_LeftClickButtonZamítnout_50_18 = root.FindByXPath(xpath_LeftClickButtonZamítnout_50_18);
            if (winElem_LeftClickButtonZamítnout_50_18 != null)
            {
                winElem_LeftClickButtonZamítnout_50_18.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZamítnout_50_18}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (82,12)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (82,12)");
            string xpath_LeftClickEditPasswordTe_82_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Zamítnout\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_82_12 = root.FindByXPath(xpath_LeftClickEditPasswordTe_82_12);
            if (winElem_LeftClickEditPasswordTe_82_12 != null)
            {
                winElem_LeftClickEditPasswordTe_82_12.Click();
                winElem_LeftClickEditPasswordTe_82_12.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_82_12}");
                return;
            }


            // LeftClick on Button "OK" at (28,4)
            Console.WriteLine("LeftClick on Button \"OK\" at (28,4)");
            string xpath_LeftClickButtonOK_28_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Zamítnout\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_28_4 = root.FindByXPath(xpath_LeftClickButtonOK_28_4);
            if (winElem_LeftClickButtonOK_28_4 != null)
            {
                winElem_LeftClickButtonOK_28_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_28_4}");
                return;
            }


            // LeftClick on Button "K ověření" at (23,19)
            Console.WriteLine("LeftClick on Button \"K ověření\" at (23,19)");
            string xpath_LeftClickButtonKověření_23_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"K ověření\"]";
            var winElem_LeftClickButtonKověření_23_19 = root.FindByXPath(xpath_LeftClickButtonKověření_23_19);
            if (winElem_LeftClickButtonKověření_23_19 != null)
            {
                winElem_LeftClickButtonKověření_23_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonKověření_23_19}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (46,0)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (46,0)");
            string xpath_LeftClickEditPasswordTe_46_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"K ověření\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]";
            var winElem_LeftClickEditPasswordTe_46_0 = root.FindByXPath(xpath_LeftClickEditPasswordTe_46_0);
            if (winElem_LeftClickEditPasswordTe_46_0 != null)
            {
                winElem_LeftClickEditPasswordTe_46_0.Click();
                winElem_LeftClickEditPasswordTe_46_0.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_46_0}");
                return;
            }


            // LeftClick on Button "OK" at (5,6)
            Console.WriteLine("LeftClick on Button \"OK\" at (5,6)");
            string xpath_LeftClickButtonOK_5_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"K ověření\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_5_6 = root.FindByXPath(xpath_LeftClickButtonOK_5_6);
            if (winElem_LeftClickButtonOK_5_6 != null)
            {
                winElem_LeftClickButtonOK_5_6.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_5_6}");
                return;
            }


            // LeftClick on Button "Ověřit" at (8,19)
            Console.WriteLine("LeftClick on Button \"Ověřit\" at (8,19)");
            string xpath_LeftClickButtonOvěřit_8_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ověřit\"]";
            var winElem_LeftClickButtonOvěřit_8_19 = root.FindByXPath(xpath_LeftClickButtonOvěřit_8_19);
            if (winElem_LeftClickButtonOvěřit_8_19 != null)
            {
                winElem_LeftClickButtonOvěřit_8_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOvěřit_8_19}");
                return;
            }


            // LeftClick on Button "Storno" at (19,0)
            Console.WriteLine("LeftClick on Button \"Storno\" at (19,0)");
            string xpath_LeftClickButtonStorno_19_0 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Ověřit\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"Storno\"][@AutomationId=\"btnCancel\"]";
            var winElem_LeftClickButtonStorno_19_0 = root.FindByXPath(xpath_LeftClickButtonStorno_19_0);
            if (winElem_LeftClickButtonStorno_19_0 != null)
            {
                winElem_LeftClickButtonStorno_19_0.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_19_0}");
                return;
            }


            // LeftClick on Button "Ověřit" at (40,24)
            Console.WriteLine("LeftClick on Button \"Ověřit\" at (40,24)");
            string xpath_LeftClickButtonOvěřit_40_24 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ověřit\"]";
            var winElem_LeftClickButtonOvěřit_40_24 = root.FindByXPath(xpath_LeftClickButtonOvěřit_40_24);
            if (winElem_LeftClickButtonOvěřit_40_24 != null)
            {
                winElem_LeftClickButtonOvěřit_40_24.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOvěřit_40_24}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (113,8)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (113,8)");
            string xpath_LeftClickEditPasswordTe_113_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Ověřit\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_113_8 = root.FindByXPath(xpath_LeftClickEditPasswordTe_113_8);
            if (winElem_LeftClickEditPasswordTe_113_8 != null)
            {
                winElem_LeftClickEditPasswordTe_113_8.Click();
                winElem_LeftClickEditPasswordTe_113_8.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_113_8}");
                return;
            }


            // LeftClick on Button "OK" at (55,15)
            Console.WriteLine("LeftClick on Button \"OK\" at (55,15)");
            string xpath_LeftClickButtonOK_55_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Ověřit\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
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


            // LeftClick on Button "Zamítnout" at (23,19)
            Console.WriteLine("LeftClick on Button \"Zamítnout\" at (23,19)");
            string xpath_LeftClickButtonZamítnout_23_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Zamítnout\"]";
            var winElem_LeftClickButtonZamítnout_23_19 = root.FindByXPath(xpath_LeftClickButtonZamítnout_23_19);
            if (winElem_LeftClickButtonZamítnout_23_19 != null)
            {
                winElem_LeftClickButtonZamítnout_23_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonZamítnout_23_19}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (71,10)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (71,10)");
            string xpath_LeftClickEditPasswordTe_71_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Zamítnout\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_71_10 = root.FindByXPath(xpath_LeftClickEditPasswordTe_71_10);
            if (winElem_LeftClickEditPasswordTe_71_10 != null)
            {
                winElem_LeftClickEditPasswordTe_71_10.Click();
                winElem_LeftClickEditPasswordTe_71_10.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_71_10}");
                return;
            }


            // LeftClick on Button "OK" at (21,14)
            Console.WriteLine("LeftClick on Button \"OK\" at (21,14)");
            string xpath_LeftClickButtonOK_21_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Zamítnout\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_21_14 = root.FindByXPath(xpath_LeftClickButtonOK_21_14);
            if (winElem_LeftClickButtonOK_21_14 != null)
            {
                winElem_LeftClickButtonOK_21_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_21_14}");
                return;
            }


            // LeftClick on Button "Ověřit" at (41,9)
            Console.WriteLine("LeftClick on Button \"Ověřit\" at (41,9)");
            string xpath_LeftClickButtonOvěřit_41_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ověřit\"]";
            var winElem_LeftClickButtonOvěřit_41_9 = root.FindByXPath(xpath_LeftClickButtonOvěřit_41_9);
            if (winElem_LeftClickButtonOvěřit_41_9 != null)
            {
                winElem_LeftClickButtonOvěřit_41_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOvěřit_41_9}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (226,2)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (226,2)");
            string xpath_LeftClickEditPasswordTe_226_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Ověřit\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]";
            var winElem_LeftClickEditPasswordTe_226_2 = root.FindByXPath(xpath_LeftClickEditPasswordTe_226_2);
            if (winElem_LeftClickEditPasswordTe_226_2 != null)
            {
                winElem_LeftClickEditPasswordTe_226_2.Click();
                winElem_LeftClickEditPasswordTe_226_2.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_226_2}");
                return;
            }


            // LeftClick on Button "OK" at (69,1)
            Console.WriteLine("LeftClick on Button \"OK\" at (69,1)");
            string xpath_LeftClickButtonOK_69_1 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Ověřit\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_69_1 = root.FindByXPath(xpath_LeftClickButtonOK_69_1);
            if (winElem_LeftClickButtonOK_69_1 != null)
            {
                winElem_LeftClickButtonOK_69_1.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_69_1}");
                return;
            }

            /*
            // LeftClick on Button "Schválit" at (58,19)
            Console.WriteLine("LeftClick on Button \"Schválit\" at (58,19)");
            string xpath_LeftClickButtonSchválit_58_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Schválit\"]";
            var winElem_LeftClickButtonSchválit_58_19 = root.FindByXPath(xpath_LeftClickButtonSchválit_58_19);
            if (winElem_LeftClickButtonSchválit_58_19 != null)
            {
                winElem_LeftClickButtonSchválit_58_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSchválit_58_19}");
                return;
            }


            // LeftClick on Button "&amp;Yes" at (55,13)
            Console.WriteLine("LeftClick on Button \"&amp;Yes\" at (55,13)");
            string xpath_LeftClickButtonYes_55_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Yes\"]";
            var winElem_LeftClickButtonYes_55_13 = root.FindByXPath(xpath_LeftClickButtonYes_55_13);
            if (winElem_LeftClickButtonYes_55_13 != null)
            {
                winElem_LeftClickButtonYes_55_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonYes_55_13}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (176,20)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (176,20)");
            string xpath_LeftClickEditPasswordTe_176_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Schválit\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]";
            var winElem_LeftClickEditPasswordTe_176_20 = root.FindByXPath(xpath_LeftClickEditPasswordTe_176_20);
            if (winElem_LeftClickEditPasswordTe_176_20 != null)
            {
                winElem_LeftClickEditPasswordTe_176_20.Click();
                winElem_LeftClickEditPasswordTe_176_20.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_176_20}");
                return;
            }


            // LeftClick on Button "OK" at (26,5)
            Console.WriteLine("LeftClick on Button \"OK\" at (26,5)");
            string xpath_LeftClickButtonOK_26_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Schválit\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_26_5 = root.FindByXPath(xpath_LeftClickButtonOK_26_5);
            if (winElem_LeftClickButtonOK_26_5 != null)
            {
                winElem_LeftClickButtonOK_26_5.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_26_5}");
                return;
            }
            */


        }

        private static void createRecipe2()
        {
            // LeftClick on Button "Nová receptura" at (75,9)
            Console.WriteLine("LeftClick on Button \"Nová receptura\" at (75,9)");
            string xpath_LeftClickButtonNovárecept_75_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam receptur\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucPdRecipeList\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]";
            var winElem_LeftClickButtonNovárecept_75_9 = root.FindByXPath(xpath_LeftClickButtonNovárecept_75_9);
            if (winElem_LeftClickButtonNovárecept_75_9 != null)
            {
                winElem_LeftClickButtonNovárecept_75_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovárecept_75_9}");
                return;
            }


            // LeftClick on Pane "" at (57,19)
            Console.WriteLine("LeftClick on Pane \"\" at (57,19)");
            string xpath_LeftClickPane_57_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"teNumber\"]";
            var winElem_LeftClickPane_57_19 = root.FindByXPath(xpath_LeftClickPane_57_19);
            if (winElem_LeftClickPane_57_19 != null)
            {
                winElem_LeftClickPane_57_19.Click();
                winElem_LeftClickPane_57_19.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_57_19}");
                return;
            }


            // LeftClick on Edit "" at (49,12)
            Console.WriteLine("LeftClick on Edit \"\" at (49,12)");
            string xpath_LeftClickEdit_49_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"teVariant\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_49_12 = root.FindByXPath(xpath_LeftClickEdit_49_12);
            if (winElem_LeftClickEdit_49_12 != null)
            {
                winElem_LeftClickEdit_49_12.Click();
                winElem_LeftClickEdit_49_12.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_49_12}");
                return;
            }


            // LeftClick on Edit "" at (10,13)
            Console.WriteLine("LeftClick on Edit \"\" at (10,13)");
            string xpath_LeftClickEdit_10_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"teSpecificationNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_10_13 = root.FindByXPath(xpath_LeftClickEdit_10_13);
            if (winElem_LeftClickEdit_10_13 != null)
            {
                winElem_LeftClickEdit_10_13.Click();
                winElem_LeftClickEdit_10_13.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_10_13}");
                return;
            }


            // LeftClick on Edit "" at (8,3)
            Console.WriteLine("LeftClick on Edit \"\" at (8,3)");
            string xpath_LeftClickEdit_8_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"teSpecificationVersion\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_8_3 = root.FindByXPath(xpath_LeftClickEdit_8_3);
            if (winElem_LeftClickEdit_8_3 != null)
            {
                winElem_LeftClickEdit_8_3.Click();
                winElem_LeftClickEdit_8_3.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_8_3}");
                return;
            }


            // LeftClick on Edit "" at (28,7)
            Console.WriteLine("LeftClick on Edit \"\" at (28,7)");
            string xpath_LeftClickEdit_28_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"seShelfTime\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_28_7 = root.FindByXPath(xpath_LeftClickEdit_28_7);
            if (winElem_LeftClickEdit_28_7 != null)
            {
                winElem_LeftClickEdit_28_7.Click();
                winElem_LeftClickEdit_28_7.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_28_7}");
                return;
            }


            // LeftClick on Text "" at (87,10)
            Console.WriteLine("LeftClick on Text \"\" at (87,10)");
            string xpath_LeftClickText_87_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/ComboBox[@AutomationId=\"cbPriority\"]/Text";
            var winElem_LeftClickText_87_10 = root.FindByXPath(xpath_LeftClickText_87_10);
            if (winElem_LeftClickText_87_10 != null)
            {
                winElem_LeftClickText_87_10.Click();
                winElem_LeftClickText_87_10.SendKeys(Keys.ArrowDown);
                winElem_LeftClickText_87_10.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_87_10}");
                return;
            }


            // LeftClick on Text "" at (72,8)
            Console.WriteLine("LeftClick on Text \"\" at (72,8)");
            string xpath_LeftClickText_72_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/ComboBox[@AutomationId=\"cbResponsibleUser\"]/Text";
            var winElem_LeftClickText_72_8 = root.FindByXPath(xpath_LeftClickText_72_8);
            if (winElem_LeftClickText_72_8 != null)
            {
                winElem_LeftClickText_72_8.Click();
                winElem_LeftClickText_72_8.SendKeys(Keys.ArrowDown);
                winElem_LeftClickText_72_8.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_72_8}");
                return;
            }


            // LeftClick on Button "Open" at (8,15)
            Console.WriteLine("LeftClick on Button \"Open\" at (8,15)");
            string xpath_LeftClickButtonOpen_8_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelLocation\"]/Pane[@Name=\"groupLocation\"][@AutomationId=\"groupLocation\"]/ComboBox[@AutomationId=\"cbPlant\"]/Button[@Name=\"Open\"]";
            var winElem_LeftClickButtonOpen_8_15 = root.FindByXPath(xpath_LeftClickButtonOpen_8_15);
            if (winElem_LeftClickButtonOpen_8_15 != null)
            {
                winElem_LeftClickButtonOpen_8_15.Click();
                winElem_LeftClickButtonOpen_8_15.SendKeys(Keys.ArrowDown);
                winElem_LeftClickButtonOpen_8_15.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOpen_8_15}");
                return;
            }


            // LeftClick on Edit "" at (43,5)
            Console.WriteLine("LeftClick on Edit \"\" at (43,5)");
            string xpath_LeftClickEdit_43_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@Name=\" \"][@AutomationId=\"seNormBatchSize\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_43_5 = root.FindByXPath(xpath_LeftClickEdit_43_5);
            if (winElem_LeftClickEdit_43_5 != null)
            {
                winElem_LeftClickEdit_43_5.Click();
                winElem_LeftClickEdit_43_5.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_43_5}");
                return;
            }


            // LeftClick on Edit "" at (65,7)
            Console.WriteLine("LeftClick on Edit \"\" at (65,7)");
            string xpath_LeftClickEdit_65_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@AutomationId=\"seNormLoss\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_65_7 = root.FindByXPath(xpath_LeftClickEdit_65_7);
            if (winElem_LeftClickEdit_65_7 != null)
            {
                winElem_LeftClickEdit_65_7.Click();
                winElem_LeftClickEdit_65_7.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_65_7}");
                return;
            }


            // LeftClick on Edit "" at (53,4)
            Console.WriteLine("LeftClick on Edit \"\" at (53,4)");
            string xpath_LeftClickEdit_53_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@AutomationId=\"tsNormProcessTime\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_53_4 = root.FindByXPath(xpath_LeftClickEdit_53_4);
            if (winElem_LeftClickEdit_53_4 != null)
            {
                winElem_LeftClickEdit_53_4.Click();
                winElem_LeftClickEdit_53_4.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_53_4}");
                return;
            }


            // LeftClick on Edit "" at (50,10)
            Console.WriteLine("LeftClick on Edit \"\" at (50,10)");
            string xpath_LeftClickEdit_50_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@AutomationId=\"tsNormWorkingTime\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_50_10 = root.FindByXPath(xpath_LeftClickEdit_50_10);
            if (winElem_LeftClickEdit_50_10 != null)
            {
                winElem_LeftClickEdit_50_10.Click();
                winElem_LeftClickEdit_50_10.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_50_10}");
                return;
            }


            // LeftClick on Header " " at (60,6)
            Console.WriteLine("LeftClick on Header \" \" at (60,6)");
            string xpath_LeftClickHeader_60_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Header Panel\"]/Header[@Name=\" \"]";
            var winElem_LeftClickHeader_60_6 = root.FindByXPath(xpath_LeftClickHeader_60_6);
            if (winElem_LeftClickHeader_60_6 != null)
            {
                winElem_LeftClickHeader_60_6.Click();
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Return);
                winElem_LeftClickHeader_60_6.SendKeys("t");
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Return);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Tab);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.NumberPad2);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Return);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Tab);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.NumberPad2);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Return);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Tab);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.NumberPad2);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Return);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Tab);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.NumberPad2);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Return);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Tab);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.NumberPad2);
                winElem_LeftClickHeader_60_6.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickHeader_60_6}");
                return;
            }


            // LeftClick on Edit "" at (366,48)
            Console.WriteLine("LeftClick on Edit \"\" at (366,48)");
            string xpath_LeftClickEdit_366_48 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"memoNote\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_366_48 = root.FindByXPath(xpath_LeftClickEdit_366_48);
            if (winElem_LeftClickEdit_366_48 != null)
            {
                winElem_LeftClickEdit_366_48.Click();
                winElem_LeftClickEdit_366_48.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_366_48}");
                return;
            }


            // LeftClick on Button "..." at (13,12)
            Console.WriteLine("LeftClick on Button \"...\" at (13,12)");
            string xpath_LeftClickButton_13_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"psProduct\"]/Button[@Name=\"...\"][@AutomationId=\"buttonSelection\"]";
            var winElem_LeftClickButton_13_12 = root.FindByXPath(xpath_LeftClickButton_13_12);
            if (winElem_LeftClickButton_13_12 != null)
            {
                winElem_LeftClickButton_13_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_13_12}");
                return;
            }


            // LeftClick on Button "OK" at (54,9)
            Console.WriteLine("LeftClick on Button \"OK\" at (54,9)");
            string xpath_LeftClickButtonOK_54_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Výběr produktu\"][@AutomationId=\"mbPdSelectMaterial\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"buttonOK\"]";
            var winElem_LeftClickButtonOK_54_9 = root.FindByXPath(xpath_LeftClickButtonOK_54_9);
            if (winElem_LeftClickButtonOK_54_9 != null)
            {
                winElem_LeftClickButtonOK_54_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_54_9}");
                return;
            }


            // LeftClick on Pane "" at (609,28)
            Console.WriteLine("LeftClick on Pane \"\" at (609,28)");
            string xpath_LeftClickPane_609_28 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickPane_609_28 = root.FindByXPath(xpath_LeftClickPane_609_28);
            if (winElem_LeftClickPane_609_28 != null)
            {
                winElem_LeftClickPane_609_28.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_609_28}");
                return;
            }


            // LeftClick on Button "OK" at (35,11)
            Console.WriteLine("LeftClick on Button \"OK\" at (35,11)");
            string xpath_LeftClickButtonOK_35_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
            var winElem_LeftClickButtonOK_35_11 = root.FindByXPath(xpath_LeftClickButtonOK_35_11);
            if (winElem_LeftClickButtonOK_35_11 != null)
            {
                winElem_LeftClickButtonOK_35_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_35_11}");
                return;
            }


            // LeftClick on Button "Uložit" at (54,17)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (54,17)");
            string xpath_LeftClickButtonUložit_54_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_54_17 = root.FindByXPath(xpath_LeftClickButtonUložit_54_17);
            if (winElem_LeftClickButtonUložit_54_17 != null)
            {
                winElem_LeftClickButtonUložit_54_17.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_54_17}");
                return;
            }


            // LeftClick on Button "Ukončit" at (29,11)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (29,11)");
            string xpath_LeftClickButtonUkončit_29_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_29_11 = root.FindByXPath(xpath_LeftClickButtonUkončit_29_11);
            if (winElem_LeftClickButtonUkončit_29_11 != null)
            {
                winElem_LeftClickButtonUkončit_29_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_29_11}");
                return;
            }
        }

        private static void recipeMaterial()
        {
            // LeftClick on DataItem " row 1" at (31,11)
            Console.WriteLine("LeftClick on DataItem \" row 1\" at (31,11)");
            string xpath_LeftClickDataItemrow1_31_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"tlMenu\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node1\"]/DataItem[@Name=\" row 1\"]";
            var winElem_LeftClickDataItemrow1_31_11 = root.FindByXPath(xpath_LeftClickDataItemrow1_31_11);
            if (winElem_LeftClickDataItemrow1_31_11 != null)
            {
                winElem_LeftClickDataItemrow1_31_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow1_31_11}");
                return;
            }


            // LeftClick on Button "Přidat materiál" at (72,16)
            Console.WriteLine("LeftClick on Button \"Přidat materiál\" at (72,16)");
            string xpath_LeftClickButtonPřidatmate_72_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedListLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Přidat materiál\"]";
            var winElem_LeftClickButtonPřidatmate_72_16 = root.FindByXPath(xpath_LeftClickButtonPřidatmate_72_16);
            if (winElem_LeftClickButtonPřidatmate_72_16 != null)
            {
                winElem_LeftClickButtonPřidatmate_72_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonPřidatmate_72_16}");
                return;
            }


            // LeftClick on Edit "" at (218,7)
            Console.WriteLine("LeftClick on Edit \"\" at (218,7)");
            string xpath_LeftClickEdit_218_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNote\"]/Pane[@AutomationId=\"memoNote\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_218_7 = root.FindByXPath(xpath_LeftClickEdit_218_7);
            if (winElem_LeftClickEdit_218_7 != null)
            {
                winElem_LeftClickEdit_218_7.Click();
                winElem_LeftClickEdit_218_7.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_218_7}");
                return;
            }


            // LeftClick on Pane "0" at (78,19)
            Console.WriteLine("LeftClick on Pane \"0\" at (78,19)");
            string xpath_LeftClickPane0_78_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNormsAndAttributes\"][@AutomationId=\"groupNormsAndAttributes\"]/Pane[@Name=\"0\"][@AutomationId=\"seNormQty\"]";
            var winElem_LeftClickPane0_78_19 = root.FindByXPath(xpath_LeftClickPane0_78_19);
            if (winElem_LeftClickPane0_78_19 != null)
            {
                winElem_LeftClickPane0_78_19.Click();
                winElem_LeftClickPane0_78_19.SendKeys(Keys.ArrowUp);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane0_78_19}");
                return;
            }


            // LeftClick on Edit "" at (75,5)
            Console.WriteLine("LeftClick on Edit \"\" at (75,5)");
            string xpath_LeftClickEdit_75_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNormsAndAttributes\"][@AutomationId=\"groupNormsAndAttributes\"]/Pane[@Name=\"0\"][@AutomationId=\"seNormLoss\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_75_5 = root.FindByXPath(xpath_LeftClickEdit_75_5);
            if (winElem_LeftClickEdit_75_5 != null)
            {
                winElem_LeftClickEdit_75_5.Click();
                winElem_LeftClickEdit_75_5.SendKeys(Keys.ArrowUp);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_75_5}");
                return;
            }


            // LeftClick on Pane "0" at (72,2)
            Console.WriteLine("LeftClick on Pane \"0\" at (72,2)");
            string xpath_LeftClickPane0_72_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNormsAndAttributes\"][@AutomationId=\"groupNormsAndAttributes\"]/Pane[@Name=\"0\"][@AutomationId=\"seNormReserve\"]";
            var winElem_LeftClickPane0_72_2 = root.FindByXPath(xpath_LeftClickPane0_72_2);
            if (winElem_LeftClickPane0_72_2 != null)
            {
                winElem_LeftClickPane0_72_2.Click();
                winElem_LeftClickPane0_72_2.SendKeys(Keys.ArrowUp);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane0_72_2}");
                return;
            }


            // LeftClick on Edit "" at (60,5)
            Console.WriteLine("LeftClick on Edit \"\" at (60,5)");
            string xpath_LeftClickEdit_60_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNormsAndAttributes\"][@AutomationId=\"groupNormsAndAttributes\"]/Pane[@Name=\"0\"][@AutomationId=\"seNormTolerance\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_60_5 = root.FindByXPath(xpath_LeftClickEdit_60_5);
            if (winElem_LeftClickEdit_60_5 != null)
            {
                winElem_LeftClickEdit_60_5.Click();
                winElem_LeftClickEdit_60_5.SendKeys(Keys.ArrowUp);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_60_5}");
                return;
            }


            // LeftClick on DataItem "  row0" at (77,14)
            Console.WriteLine("LeftClick on DataItem \"  row0\" at (77,14)");
            string xpath_LeftClickDataItemrow0_77_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"  row0\"]";
            var winElem_LeftClickDataItemrow0_77_14 = root.FindByXPath(xpath_LeftClickDataItemrow0_77_14);
            if (winElem_LeftClickDataItemrow0_77_14 != null)
            {
                winElem_LeftClickDataItemrow0_77_14.Click();
                winElem_LeftClickDataItemrow0_77_14.SendKeys(Keys.Space);



            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_77_14}");
                return;
            }


            // LeftClick on DataItem "  row1" at (74,11)
            Console.WriteLine("LeftClick on DataItem \"  row1\" at (74,11)");
            string xpath_LeftClickDataItemrow1_74_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 2\"]/DataItem[@Name=\"  row1\"]";
            var winElem_LeftClickDataItemrow1_74_11 = root.FindByXPath(xpath_LeftClickDataItemrow1_74_11);
            if (winElem_LeftClickDataItemrow1_74_11 != null)
            {
                winElem_LeftClickDataItemrow1_74_11.Click();
                winElem_LeftClickDataItemrow1_74_11.SendKeys(Keys.Space);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow1_74_11}");
                return;
            }


            // LeftClick on DataItem "  row2" at (73,9)
            Console.WriteLine("LeftClick on DataItem \"  row2\" at (73,9)");
            string xpath_LeftClickDataItemrow2_73_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 3\"]/DataItem[@Name=\"  row2\"]";
            var winElem_LeftClickDataItemrow2_73_9 = root.FindByXPath(xpath_LeftClickDataItemrow2_73_9);
            if (winElem_LeftClickDataItemrow2_73_9 != null)
            {
                winElem_LeftClickDataItemrow2_73_9.Click();
                winElem_LeftClickDataItemrow2_73_9.SendKeys(Keys.Space);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow2_73_9}");
                return;
            }


            // LeftClick on DataItem "  row3" at (73,4)
            Console.WriteLine("LeftClick on DataItem \"  row3\" at (73,4)");
            string xpath_LeftClickDataItemrow3_73_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 4\"]/DataItem[@Name=\"  row3\"]";
            var winElem_LeftClickDataItemrow3_73_4 = root.FindByXPath(xpath_LeftClickDataItemrow3_73_4);
            if (winElem_LeftClickDataItemrow3_73_4 != null)
            {
                winElem_LeftClickDataItemrow3_73_4.Click();
                winElem_LeftClickDataItemrow3_73_4.SendKeys(Keys.Space);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow3_73_4}");
                return;
            }


            // LeftClick on Text "" at (41,7)
            Console.WriteLine("LeftClick on Text \"\" at (41,7)");
            string xpath_LeftClickText_41_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/ComboBox[@AutomationId=\"cbMU\"]/Text";
            var winElem_LeftClickText_41_7 = root.FindByXPath(xpath_LeftClickText_41_7);
            if (winElem_LeftClickText_41_7 != null)
            {
                winElem_LeftClickText_41_7.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_41_7}");
                return;
            }


            // LeftClick on Button "OK" at (30,11)
            Console.WriteLine("LeftClick on Button \"OK\" at (30,11)");
            string xpath_LeftClickButtonOK_30_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
            var winElem_LeftClickButtonOK_30_11 = root.FindByXPath(xpath_LeftClickButtonOK_30_11);
            if (winElem_LeftClickButtonOK_30_11 != null)
            {
                winElem_LeftClickButtonOK_30_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_30_11}");
                return;
            }


            // LeftClick on Button "&amp;OK" at (44,8)
            Console.WriteLine("LeftClick on Button \"&amp;OK\" at (44,8)");
            string xpath_LeftClickButtonOK_44_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;OK\"]";
            var winElem_LeftClickButtonOK_44_8 = root.FindByXPath(xpath_LeftClickButtonOK_44_8);
            if (winElem_LeftClickButtonOK_44_8 != null)
            {
                winElem_LeftClickButtonOK_44_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_44_8}");
                return;
            }


            // LeftClick on Button "..." at (21,7)
            Console.WriteLine("LeftClick on Button \"...\" at (21,7)");
            string xpath_LeftClickButton_21_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"psMaterial\"]/Button[@Name=\"...\"][@AutomationId=\"buttonSelection\"]";
            var winElem_LeftClickButton_21_7 = root.FindByXPath(xpath_LeftClickButton_21_7);
            if (winElem_LeftClickButton_21_7 != null)
            {
                winElem_LeftClickButton_21_7.Click();
                winElem_LeftClickButton_21_7.SendKeys(Keys.ArrowDown);
                winElem_LeftClickButton_21_7.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_21_7}");
                return;
            }


            // LeftClick on Button "..." at (7,13)
            Console.WriteLine("LeftClick on Button \"...\" at (7,13)");
            string xpath_LeftClickButton_7_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"psMaterial\"]/Button[@Name=\"...\"][@AutomationId=\"buttonSelection\"]";
            var winElem_LeftClickButton_7_13 = root.FindByXPath(xpath_LeftClickButton_7_13);
            if (winElem_LeftClickButton_7_13 != null)
            {
                winElem_LeftClickButton_7_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_7_13}");
                return;
            }


            // LeftClick on Button "OK" at (11,11)
            Console.WriteLine("LeftClick on Button \"OK\" at (11,11)");
            string xpath_LeftClickButtonOK_11_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Výběr materiálu\"][@AutomationId=\"mbPdSelectMaterial\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"buttonOK\"]";
            var winElem_LeftClickButtonOK_11_11 = root.FindByXPath(xpath_LeftClickButtonOK_11_11);
            if (winElem_LeftClickButtonOK_11_11 != null)
            {
                winElem_LeftClickButtonOK_11_11.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_11_11}");
                return;
            }


            // LeftClick on Button "Storno" at (26,5)
            Console.WriteLine("LeftClick on Button \"Storno\" at (26,5)");
            string xpath_LeftClickButtonStorno_26_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Storno\"]";
            var winElem_LeftClickButtonStorno_26_5 = root.FindByXPath(xpath_LeftClickButtonStorno_26_5);
            if (winElem_LeftClickButtonStorno_26_5 != null)
            {
                winElem_LeftClickButtonStorno_26_5.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonStorno_26_5}");
                return;
            }


            // LeftClick on Button "&amp;Yes" at (35,7)
            Console.WriteLine("LeftClick on Button \"&amp;Yes\" at (35,7)");
            string xpath_LeftClickButtonYes_35_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit změny\"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Yes\"]";
            var winElem_LeftClickButtonYes_35_7 = root.FindByXPath(xpath_LeftClickButtonYes_35_7);
            if (winElem_LeftClickButtonYes_35_7 != null)
            {
                winElem_LeftClickButtonYes_35_7.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonYes_35_7}");
                return;
            }


            // LeftClick on Button "Uložit" at (62,5)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (62,5)");
            string xpath_LeftClickButtonUložit_62_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_62_5 = root.FindByXPath(xpath_LeftClickButtonUložit_62_5);
            if (winElem_LeftClickButtonUložit_62_5 != null)
            {
                winElem_LeftClickButtonUložit_62_5.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_62_5}");
                return;
            }


            // LeftClick on Button "Ukončit" at (24,6)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (24,6)");
            string xpath_LeftClickButtonUkončit_24_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_24_6 = root.FindByXPath(xpath_LeftClickButtonUkončit_24_6);
            if (winElem_LeftClickButtonUkončit_24_6 != null)
            {
                winElem_LeftClickButtonUkončit_24_6.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_24_6}");
                return;
            }


            // LeftClick on Button "Editovat" at (4,23)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (4,23)");
            string xpath_LeftClickButtonEditovat_4_23 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_4_23 = root.FindByXPath(xpath_LeftClickButtonEditovat_4_23);
            if (winElem_LeftClickButtonEditovat_4_23 != null)
            {
                winElem_LeftClickButtonEditovat_4_23.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_4_23}");
                return;
            }


            // LeftClick on Edit "" at (689,13)
            Console.WriteLine("LeftClick on Edit \"\" at (689,13)");
            string xpath_LeftClickEdit_689_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNote\"]/Pane[@Name=\"e\"][@AutomationId=\"memoNote\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_689_13 = root.FindByXPath(xpath_LeftClickEdit_689_13);
            if (winElem_LeftClickEdit_689_13 != null)
            {
                winElem_LeftClickEdit_689_13.Click();
                winElem_LeftClickEdit_689_13.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_689_13}");
                return;
            }


            // LeftClick on Edit "" at (75,8)
            Console.WriteLine("LeftClick on Edit \"\" at (75,8)");
            string xpath_LeftClickEdit_75_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNormsAndAttributes\"][@AutomationId=\"groupNormsAndAttributes\"]/Pane[@Name=\"0.00\"][@AutomationId=\"seNormQty\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_75_8 = root.FindByXPath(xpath_LeftClickEdit_75_8);
            if (winElem_LeftClickEdit_75_8 != null)
            {
                winElem_LeftClickEdit_75_8.Click();
                winElem_LeftClickEdit_75_8.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_75_8}");
                return;
            }


            // LeftClick on Edit "" at (94,9)
            Console.WriteLine("LeftClick on Edit \"\" at (94,9)");
            string xpath_LeftClickEdit_94_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNormsAndAttributes\"][@AutomationId=\"groupNormsAndAttributes\"]/Pane[@Name=\"0.00\"][@AutomationId=\"seNormLoss\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_94_9 = root.FindByXPath(xpath_LeftClickEdit_94_9);
            if (winElem_LeftClickEdit_94_9 != null)
            {
                winElem_LeftClickEdit_94_9.Click();
                winElem_LeftClickEdit_94_9.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_94_9}");
                return;
            }


            // LeftClick on Edit "" at (94,6)
            Console.WriteLine("LeftClick on Edit \"\" at (94,6)");
            string xpath_LeftClickEdit_94_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNormsAndAttributes\"][@AutomationId=\"groupNormsAndAttributes\"]/Pane[@Name=\"0.00\"][@AutomationId=\"seNormReserve\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_94_6 = root.FindByXPath(xpath_LeftClickEdit_94_6);
            if (winElem_LeftClickEdit_94_6 != null)
            {
                winElem_LeftClickEdit_94_6.Click();
                winElem_LeftClickEdit_94_6.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_94_6}");
                return;
            }


            // LeftClick on Edit "" at (89,3)
            Console.WriteLine("LeftClick on Edit \"\" at (89,3)");
            string xpath_LeftClickEdit_89_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNormsAndAttributes\"][@AutomationId=\"groupNormsAndAttributes\"]/Pane[@Name=\"0.00\"][@AutomationId=\"seNormTolerance\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_89_3 = root.FindByXPath(xpath_LeftClickEdit_89_3);
            if (winElem_LeftClickEdit_89_3 != null)
            {
                winElem_LeftClickEdit_89_3.Click();
                winElem_LeftClickEdit_89_3.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_89_3}");
                return;
            }


            // LeftClick on DataItem "  row0" at (72,13)
            Console.WriteLine("LeftClick on DataItem \"  row0\" at (72,13)");
            string xpath_LeftClickDataItemrow0_72_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"  row0\"]";
            var winElem_LeftClickDataItemrow0_72_13 = root.FindByXPath(xpath_LeftClickDataItemrow0_72_13);
            if (winElem_LeftClickDataItemrow0_72_13 != null)
            {
                winElem_LeftClickDataItemrow0_72_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_72_13}");
                return;
            }


            // LeftClick on DataItem "  row1" at (73,10)
            Console.WriteLine("LeftClick on DataItem \"  row1\" at (73,10)");
            string xpath_LeftClickDataItemrow1_73_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 2\"]/DataItem[@Name=\"  row1\"]";
            var winElem_LeftClickDataItemrow1_73_10 = root.FindByXPath(xpath_LeftClickDataItemrow1_73_10);
            if (winElem_LeftClickDataItemrow1_73_10 != null)
            {
                winElem_LeftClickDataItemrow1_73_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow1_73_10}");
                return;
            }


            // LeftClick on DataItem "  row2" at (74,8)
            Console.WriteLine("LeftClick on DataItem \"  row2\" at (74,8)");
            string xpath_LeftClickDataItemrow2_74_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 3\"]/DataItem[@Name=\"  row2\"]";
            var winElem_LeftClickDataItemrow2_74_8 = root.FindByXPath(xpath_LeftClickDataItemrow2_74_8);
            if (winElem_LeftClickDataItemrow2_74_8 != null)
            {
                winElem_LeftClickDataItemrow2_74_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow2_74_8}");
                return;
            }


            // LeftClick on DataItem "  row3" at (74,8)
            Console.WriteLine("LeftClick on DataItem \"  row3\" at (74,8)");
            string xpath_LeftClickDataItemrow3_74_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 4\"]/DataItem[@Name=\"  row3\"]";
            var winElem_LeftClickDataItemrow3_74_8 = root.FindByXPath(xpath_LeftClickDataItemrow3_74_8);
            if (winElem_LeftClickDataItemrow3_74_8 != null)
            {
                winElem_LeftClickDataItemrow3_74_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow3_74_8}");
                return;
            }


            // LeftClick on Button "Uložit" at (62,22)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (62,22)");
            string xpath_LeftClickButtonUložit_62_22 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_62_22 = root.FindByXPath(xpath_LeftClickButtonUložit_62_22);
            if (winElem_LeftClickButtonUložit_62_22 != null)
            {
                winElem_LeftClickButtonUložit_62_22.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_62_22}");
                return;
            }


            // LeftClick on Button "Ukončit" at (32,14)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (32,14)");
            string xpath_LeftClickButtonUkončit_32_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_32_14 = root.FindByXPath(xpath_LeftClickButtonUkončit_32_14);
            if (winElem_LeftClickButtonUkončit_32_14 != null)
            {
                winElem_LeftClickButtonUkončit_32_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_32_14}");
                return;
            }


            // LeftClick on Button "Smazat" at (53,19)
            Console.WriteLine("LeftClick on Button \"Smazat\" at (53,19)");
            string xpath_LeftClickButtonSmazat_53_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Smazat\"]";
            var winElem_LeftClickButtonSmazat_53_19 = root.FindByXPath(xpath_LeftClickButtonSmazat_53_19);
            if (winElem_LeftClickButtonSmazat_53_19 != null)
            {
                winElem_LeftClickButtonSmazat_53_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSmazat_53_19}");
                return;
            }


            // LeftClick on Button "&amp;No" at (6,12)
            Console.WriteLine("LeftClick on Button \"&amp;No\" at (6,12)");
            string xpath_LeftClickButtonNo_6_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;No\"]";
            var winElem_LeftClickButtonNo_6_12 = root.FindByXPath(xpath_LeftClickButtonNo_6_12);
            if (winElem_LeftClickButtonNo_6_12 != null)
            {
                winElem_LeftClickButtonNo_6_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNo_6_12}");
                return;
            }


            // LeftClick on Button "Smazat" at (26,15)
            Console.WriteLine("LeftClick on Button \"Smazat\" at (26,15)");
            string xpath_LeftClickButtonSmazat_26_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRcMaterialNeedDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Smazat\"]";
            var winElem_LeftClickButtonSmazat_26_15 = root.FindByXPath(xpath_LeftClickButtonSmazat_26_15);
            if (winElem_LeftClickButtonSmazat_26_15 != null)
            {
                winElem_LeftClickButtonSmazat_26_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSmazat_26_15}");
                return;
            }


            // LeftClick on Button "&amp;Yes" at (28,19)
            Console.WriteLine("LeftClick on Button \"&amp;Yes\" at (28,19)");
            string xpath_LeftClickButtonYes_28_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;Yes\"]";
            var winElem_LeftClickButtonYes_28_19 = root.FindByXPath(xpath_LeftClickButtonYes_28_19);
            if (winElem_LeftClickButtonYes_28_19 != null)
            {
                winElem_LeftClickButtonYes_28_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonYes_28_19}");
                return;
            }


            // LeftClick on DataItem " row 0" at (9,4)
            Console.WriteLine("LeftClick on DataItem \" row 0\" at (9,4)");
            string xpath_LeftClickDataItemrow0_9_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Tree[@AutomationId=\"tlMenu\"]/Group[@Name=\"Data Panel\"]/TreeItem[@Name=\"Node0\"]/DataItem[@Name=\" row 0\"]";
            var winElem_LeftClickDataItemrow0_9_4 = root.FindByXPath(xpath_LeftClickDataItemrow0_9_4);
            if (winElem_LeftClickDataItemrow0_9_4 != null)
            {
                winElem_LeftClickDataItemrow0_9_4.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_9_4}");
                return;
            }
        }

        private static void createRecipe()
        {
            
            // LeftClick on Button "Nová receptura" at (51,8)
            Console.WriteLine("LeftClick on Button \"Nová receptura\" at (51,8)");
            string xpath_LeftClickButtonNovárecept_51_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[@Name=\"Seznam receptur\"][@AutomationId=\"tpList\"]/Pane[@AutomationId=\"ucPdRecipeList\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]";
            var winElem_LeftClickButtonNovárecept_51_8 = root.FindByXPath(xpath_LeftClickButtonNovárecept_51_8);
            if (winElem_LeftClickButtonNovárecept_51_8 != null)
            {
                winElem_LeftClickButtonNovárecept_51_8.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonNovárecept_51_8}");
                return;
            }


            // LeftClick on Edit "" at (97,3)
            Console.WriteLine("LeftClick on Edit \"\" at (97,3)");
            string xpath_LeftClickEdit_97_3 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"teNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_97_3 = root.FindByXPath(xpath_LeftClickEdit_97_3);
            if (winElem_LeftClickEdit_97_3 != null)
            {
                winElem_LeftClickEdit_97_3.Click();
                winElem_LeftClickEdit_97_3.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_97_3}");
                return;
            }


            // LeftClick on Edit "" at (21,8)
            Console.WriteLine("LeftClick on Edit \"\" at (21,8)");
            string xpath_LeftClickEdit_21_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"teVariant\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_21_8 = root.FindByXPath(xpath_LeftClickEdit_21_8);
            if (winElem_LeftClickEdit_21_8 != null)
            {
                winElem_LeftClickEdit_21_8.Click();
                winElem_LeftClickEdit_21_8.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_21_8}");
                return;
            }


            // LeftClick on Pane "" at (88,12)
            Console.WriteLine("LeftClick on Pane \"\" at (88,12)");
            string xpath_LeftClickPane_88_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"leProductName\"]";
            var winElem_LeftClickPane_88_12 = root.FindByXPath(xpath_LeftClickPane_88_12);
            if (winElem_LeftClickPane_88_12 != null)
            {
                winElem_LeftClickPane_88_12.Click();
                winElem_LeftClickPane_88_12.SendKeys(Keys.LeftShift + "a" + Keys.LeftShift);
                winElem_LeftClickPane_88_12.SendKeys("m");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_88_12}");
                return;
            }


            // LeftClick on Edit "" at (59,7)
            Console.WriteLine("LeftClick on Edit \"\" at (59,7)");
            string xpath_LeftClickEdit_59_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"teSpecificationNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_59_7 = root.FindByXPath(xpath_LeftClickEdit_59_7);
            if (winElem_LeftClickEdit_59_7 != null)
            {
                winElem_LeftClickEdit_59_7.Click();
                winElem_LeftClickEdit_59_7.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_59_7}");
                return;
            }


            // LeftClick on Edit "" at (31,10)
            Console.WriteLine("LeftClick on Edit \"\" at (31,10)");
            string xpath_LeftClickEdit_31_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"teSpecificationVersion\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_31_10 = root.FindByXPath(xpath_LeftClickEdit_31_10);
            if (winElem_LeftClickEdit_31_10 != null)
            {
                winElem_LeftClickEdit_31_10.Click();
                winElem_LeftClickEdit_31_10.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_31_10}");
                return;
            }


            // LeftClick on ListItem "1 - Přednostní" at (114,1)
            Console.WriteLine("LeftClick on ListItem \"1 - Přednostní\" at (114,1)");
            string xpath_LeftClickListItem1Přednostn_114_1 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/ComboBox[@AutomationId=\"cbPriority\"]/List[position()=3]/ListItem[@Name=\"1 - Přednostní\"]";
            var winElem_LeftClickListItem1Přednostn_114_1 = root.FindByXPath(xpath_LeftClickListItem1Přednostn_114_1);
            if (winElem_LeftClickListItem1Přednostn_114_1 != null)
            {
                winElem_LeftClickListItem1Přednostn_114_1.Click();
                winElem_LeftClickListItem1Přednostn_114_1.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickListItem1Přednostn_114_1}");
                return;
            }


            // LeftClick on Button "Open" at (7,12)
            Console.WriteLine("LeftClick on Button \"Open\" at (7,12)");
            string xpath_LeftClickButtonOpen_7_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/ComboBox[@AutomationId=\"cbResponsibleUser\"]/Button[@Name=\"Open\"]";
            var winElem_LeftClickButtonOpen_7_12 = root.FindByXPath(xpath_LeftClickButtonOpen_7_12);
            if (winElem_LeftClickButtonOpen_7_12 != null)
            {
                winElem_LeftClickButtonOpen_7_12.Click();
                winElem_LeftClickButtonOpen_7_12.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOpen_7_12}");
                return;
            }


            // LeftClick on Pane "" at (70,2)
            Console.WriteLine("LeftClick on Pane \"\" at (70,2)");
            string xpath_LeftClickPane_70_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"seShelfTime\"]";
            var winElem_LeftClickPane_70_2 = root.FindByXPath(xpath_LeftClickPane_70_2);
            if (winElem_LeftClickPane_70_2 != null)
            {
                winElem_LeftClickPane_70_2.Click();
                winElem_LeftClickPane_70_2.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_70_2}");
                return;
            }


            // LeftClick on Text "" at (147,6)
            Console.WriteLine("LeftClick on Text \"\" at (147,6)");
            string xpath_LeftClickText_147_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelLocation\"]/Pane[@Name=\"groupLocation\"][@AutomationId=\"groupLocation\"]/ComboBox[@AutomationId=\"cbPlant\"]/Text";
            var winElem_LeftClickText_147_6 = root.FindByXPath(xpath_LeftClickText_147_6);
            if (winElem_LeftClickText_147_6 != null)
            {
                winElem_LeftClickText_147_6.Click();
                winElem_LeftClickText_147_6.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_147_6}");
                return;
            }


            // LeftClick on Text "" at (96,8)
            Console.WriteLine("LeftClick on Text \"\" at (96,8)");
            string xpath_LeftClickText_96_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelLocation\"]/Pane[@Name=\"groupLocation\"][@AutomationId=\"groupLocation\"]/ComboBox[@AutomationId=\"cbUnit\"]/Text";
            var winElem_LeftClickText_96_8 = root.FindByXPath(xpath_LeftClickText_96_8);
            if (winElem_LeftClickText_96_8 != null)
            {
                winElem_LeftClickText_96_8.Click();
                winElem_LeftClickText_96_8.SendKeys(Keys.ArrowDown);

            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText_96_8}");
                return;
            }


            // LeftClick on Pane " " at (152,7)
            Console.WriteLine("LeftClick on Pane \" \" at (152,7)");
            string xpath_LeftClickPane_152_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@Name=\" \"][@AutomationId=\"seNormBatchSize\"]";
            var winElem_LeftClickPane_152_7 = root.FindByXPath(xpath_LeftClickPane_152_7);
            if (winElem_LeftClickPane_152_7 != null)
            {
                winElem_LeftClickPane_152_7.Click();
                winElem_LeftClickPane_152_7.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane_152_7}");
                return;
            }


            // LeftClick on Edit "" at (106,10)
            Console.WriteLine("LeftClick on Edit \"\" at (106,10)");
            string xpath_LeftClickEdit_106_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@AutomationId=\"seNormLoss\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_106_10 = root.FindByXPath(xpath_LeftClickEdit_106_10);
            if (winElem_LeftClickEdit_106_10 != null)
            {
                winElem_LeftClickEdit_106_10.Click();
                winElem_LeftClickEdit_106_10.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_106_10}");
                return;
            }


            // LeftClick on Edit "" at (82,10)
            Console.WriteLine("LeftClick on Edit \"\" at (82,10)");
            string xpath_LeftClickEdit_82_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@AutomationId=\"tsNormProcessTime\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_82_10 = root.FindByXPath(xpath_LeftClickEdit_82_10);
            if (winElem_LeftClickEdit_82_10 != null)
            {
                winElem_LeftClickEdit_82_10.Click();
                winElem_LeftClickEdit_82_10.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_82_10}");
                return;
            }


            // LeftClick on Edit "" at (33,4)
            Console.WriteLine("LeftClick on Edit \"\" at (33,4)");
            string xpath_LeftClickEdit_33_4 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@AutomationId=\"tsNormWorkingTime\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_33_4 = root.FindByXPath(xpath_LeftClickEdit_33_4);
            if (winElem_LeftClickEdit_33_4 != null)
            {
                winElem_LeftClickEdit_33_4.Click();
                winElem_LeftClickEdit_33_4.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_33_4}");
                return;
            }


            // LeftClick on Edit "" at (207,19)
            Console.WriteLine("LeftClick on Edit \"\" at (207,19)");
            string xpath_LeftClickEdit_207_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"memoNote\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_207_19 = root.FindByXPath(xpath_LeftClickEdit_207_19);
            if (winElem_LeftClickEdit_207_19 != null)
            {
                winElem_LeftClickEdit_207_19.Click();
                winElem_LeftClickEdit_207_19.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_207_19}");
                return;
            }


            // LeftClick on DataItem "  row0" at (66,12)
            Console.WriteLine("LeftClick on DataItem \"  row0\" at (66,12)");
            string xpath_LeftClickDataItemrow0_66_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"  row0\"]";
            var winElem_LeftClickDataItemrow0_66_12 = root.FindByXPath(xpath_LeftClickDataItemrow0_66_12);
            if (winElem_LeftClickDataItemrow0_66_12 != null)
            {
                winElem_LeftClickDataItemrow0_66_12.Click();
                winElem_LeftClickDataItemrow0_66_12.SendKeys(Keys.ArrowDown);
                winElem_LeftClickDataItemrow0_66_12.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_66_12}");
                return;
            }


            // LeftClick on DataItem "  row1" at (51,9)
            Console.WriteLine("LeftClick on DataItem \"  row1\" at (51,9)");
            string xpath_LeftClickDataItemrow1_51_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 2\"]/DataItem[@Name=\"  row1\"]";
            var winElem_LeftClickDataItemrow1_51_9 = root.FindByXPath(xpath_LeftClickDataItemrow1_51_9);
            if (winElem_LeftClickDataItemrow1_51_9 != null)
            {
                winElem_LeftClickDataItemrow1_51_9.Click();
                winElem_LeftClickDataItemrow1_51_9.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow1_51_9}");
                return;
            }


            // LeftClick on DataItem "  row3" at (26,6)
            Console.WriteLine("LeftClick on DataItem \"  row3\" at (26,6)");
            string xpath_LeftClickDataItemrow3_26_6 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 4\"]/DataItem[@Name=\"  row3\"]";
            var winElem_LeftClickDataItemrow3_26_6 = root.FindByXPath(xpath_LeftClickDataItemrow3_26_6);
            if (winElem_LeftClickDataItemrow3_26_6 != null)
            {
                winElem_LeftClickDataItemrow3_26_6.Click();
                winElem_LeftClickDataItemrow3_26_6.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow3_26_6}");
                return;
            }


            // LeftClick on DataItem "  row4" at (39,12)
            Console.WriteLine("LeftClick on DataItem \"  row4\" at (39,12)");
            string xpath_LeftClickDataItemrow4_39_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 5\"]/DataItem[@Name=\"  row4\"]";
            var winElem_LeftClickDataItemrow4_39_12 = root.FindByXPath(xpath_LeftClickDataItemrow4_39_12);
            if (winElem_LeftClickDataItemrow4_39_12 != null)
            {
                winElem_LeftClickDataItemrow4_39_12.Click();
                winElem_LeftClickDataItemrow4_39_12.SendKeys(Keys.NumberPad2);
                winElem_LeftClickDataItemrow4_39_12.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow4_39_12}");
                return;
            }


            // LeftClick on DataItem "  row5" at (32,7)
            Console.WriteLine("LeftClick on DataItem \"  row5\" at (32,7)");
            string xpath_LeftClickDataItemrow5_32_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 6\"]/DataItem[@Name=\"  row5\"]";
            var winElem_LeftClickDataItemrow5_32_7 = root.FindByXPath(xpath_LeftClickDataItemrow5_32_7);
            if (winElem_LeftClickDataItemrow5_32_7 != null)
            {
                winElem_LeftClickDataItemrow5_32_7.Click();
                winElem_LeftClickDataItemrow5_32_7.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow5_32_7}");
                return;
            }


            // LeftClick on Button "OK" at (31,16)
            Console.WriteLine("LeftClick on Button \"OK\" at (31,16)");
            string xpath_LeftClickButtonOK_31_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
            var winElem_LeftClickButtonOK_31_16 = root.FindByXPath(xpath_LeftClickButtonOK_31_16);
            if (winElem_LeftClickButtonOK_31_16 != null)
            {
                winElem_LeftClickButtonOK_31_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_31_16}");
                return;
            }


            // LeftClick on Button "&amp;OK" at (43,12)
            Console.WriteLine("LeftClick on Button \"&amp;OK\" at (43,12)");
            string xpath_LeftClickButtonOK_43_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[starts-with(@ClassName,\"WindowsForms10\")][@Name=\" \"]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"&amp;OK\"]";
            var winElem_LeftClickButtonOK_43_12 = root.FindByXPath(xpath_LeftClickButtonOK_43_12);
            if (winElem_LeftClickButtonOK_43_12 != null)
            {
                winElem_LeftClickButtonOK_43_12.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_43_12}");
                return;
            }


            // LeftClick on Button "..." at (15,9)
            Console.WriteLine("LeftClick on Button \"...\" at (15,9)");
            string xpath_LeftClickButton_15_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@AutomationId=\"psProduct\"]/Button[@Name=\"...\"][@AutomationId=\"buttonSelection\"]";
            var winElem_LeftClickButton_15_9 = root.FindByXPath(xpath_LeftClickButton_15_9);
            if (winElem_LeftClickButton_15_9 != null)
            {
                winElem_LeftClickButton_15_9.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButton_15_9}");
                return;
            }


            // LeftClick on Button "OK" at (50,14)
            Console.WriteLine("LeftClick on Button \"OK\" at (50,14)");
            string xpath_LeftClickButtonOK_50_14 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Výběr produktu\"][@AutomationId=\"mbPdSelectMaterial\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"buttonOK\"]";
            var winElem_LeftClickButtonOK_50_14 = root.FindByXPath(xpath_LeftClickButtonOK_50_14);
            if (winElem_LeftClickButtonOK_50_14 != null)
            {
                winElem_LeftClickButtonOK_50_14.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_50_14}");
                return;
            }


            // LeftClick on Button "OK" at (58,20)
            Console.WriteLine("LeftClick on Button \"OK\" at (58,20)");
            string xpath_LeftClickButtonOK_58_20 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Nová receptura\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"OK\"]";
            var winElem_LeftClickButtonOK_58_20 = root.FindByXPath(xpath_LeftClickButtonOK_58_20);
            if (winElem_LeftClickButtonOK_58_20 != null)
            {
                winElem_LeftClickButtonOK_58_20.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_58_20}");
                return;
            }


            // LeftClick on Button "Ukončit" at (11,19)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (11,19)");
            string xpath_LeftClickButtonUkončit_11_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_11_19 = root.FindByXPath(xpath_LeftClickButtonUkončit_11_19);
            if (winElem_LeftClickButtonUkončit_11_19 != null)
            {
                winElem_LeftClickButtonUkončit_11_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_11_19}");
                return;
            }


            // LeftClick on Button "Editovat" at (63,16)
            Console.WriteLine("LeftClick on Button \"Editovat\" at (63,16)");
            string xpath_LeftClickButtonEditovat_63_16 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Editovat\"]";
            var winElem_LeftClickButtonEditovat_63_16 = root.FindByXPath(xpath_LeftClickButtonEditovat_63_16);
            if (winElem_LeftClickButtonEditovat_63_16 != null)
            {
                winElem_LeftClickButtonEditovat_63_16.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonEditovat_63_16}");
                return;
            }


            // LeftClick on Edit "" at (32,11)
            Console.WriteLine("LeftClick on Edit \"\" at (32,11)");
            string xpath_LeftClickEdit_32_11 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@Name=\"2\"][@AutomationId=\"teVariant\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_32_11 = root.FindByXPath(xpath_LeftClickEdit_32_11);
            if (winElem_LeftClickEdit_32_11 != null)
            {
                winElem_LeftClickEdit_32_11.Click();
                winElem_LeftClickEdit_32_11.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_32_11}");
                return;
            }


            // LeftClick on Edit "" at (19,8)
            Console.WriteLine("LeftClick on Edit \"\" at (19,8)");
            string xpath_LeftClickEdit_19_8 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/Pane[@Name=\"2\"][@AutomationId=\"teSpecificationNumber\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_19_8 = root.FindByXPath(xpath_LeftClickEdit_19_8);
            if (winElem_LeftClickEdit_19_8 != null)
            {
                winElem_LeftClickEdit_19_8.Click();
                winElem_LeftClickEdit_19_8.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_19_8}");
                return;
            }


            // LeftClick on Text "2 - Vysoká" at (117,9)
            Console.WriteLine("LeftClick on Text \"2 - Vysoká\" at (117,9)");
            string xpath_LeftClickText2Vysoká_117_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/ComboBox[@Name=\"2 - Vysoká\"][@AutomationId=\"cbPriority\"]/Text[@Name=\"2 - Vysoká\"]";
            var winElem_LeftClickText2Vysoká_117_9 = root.FindByXPath(xpath_LeftClickText2Vysoká_117_9);
            if (winElem_LeftClickText2Vysoká_117_9 != null)
            {
                winElem_LeftClickText2Vysoká_117_9.Click();
                winElem_LeftClickText2Vysoká_117_9.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText2Vysoká_117_9}");
                return;
            }


            // LeftClick on Text "f046b675-7f9c-469e-9290-3c16dc2d483f" at (107,9)
            Console.WriteLine("LeftClick on Text \"f046b675-7f9c-469e-9290-3c16dc2d483f\" at (107,9)");
            string xpath_LeftClickTextf046b6757f_107_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelContent\"]/Pane[@Name=\"groupContent\"][@AutomationId=\"groupContent\"]/ComboBox[@Name=\"f046b675-7f9c-469e-9290-3c16dc2d483f\"][@AutomationId=\"cbResponsibleUser\"]/Text[@Name=\"f046b675-7f9c-469e-9290-3c16dc2d483f\"]";
            var winElem_LeftClickTextf046b6757f_107_9 = root.FindByXPath(xpath_LeftClickTextf046b6757f_107_9);
            if (winElem_LeftClickTextf046b6757f_107_9 != null)
            {
                winElem_LeftClickTextf046b6757f_107_9.Click();
                winElem_LeftClickTextf046b6757f_107_9.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickTextf046b6757f_107_9}");
                return;
            }


            // LeftClick on Text "01 - 001" at (55,9)
            Console.WriteLine("LeftClick on Text \"01 - 001\" at (55,9)");
            string xpath_LeftClickText01001_55_9 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelLocation\"]/Pane[@Name=\"groupLocation\"][@AutomationId=\"groupLocation\"]/ComboBox[@Name=\"01 - 001\"][@AutomationId=\"cbPlant\"]/Text[@Name=\"01 - 001\"]";
            var winElem_LeftClickText01001_55_9 = root.FindByXPath(xpath_LeftClickText01001_55_9);
            if (winElem_LeftClickText01001_55_9 != null)
            {
                winElem_LeftClickText01001_55_9.Click();
                winElem_LeftClickText01001_55_9.SendKeys(Keys.ArrowDown);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickText01001_55_9}");
                return;
            }


            // LeftClick on Edit "" at (72,10)
            Console.WriteLine("LeftClick on Edit \"\" at (72,10)");
            string xpath_LeftClickEdit_72_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@Name=\"2,000\"][@AutomationId=\"seNormBatchSize\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_72_10 = root.FindByXPath(xpath_LeftClickEdit_72_10);
            if (winElem_LeftClickEdit_72_10 != null)
            {
                winElem_LeftClickEdit_72_10.Click();
                winElem_LeftClickEdit_72_10.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_72_10}");
                return;
            }


            // LeftClick on Pane "2,000" at (72,2)
            Console.WriteLine("LeftClick on Pane \"2,000\" at (72,2)");
            string xpath_LeftClickPane2000_72_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@Name=\"2,000\"][@AutomationId=\"seNormLoss\"]";
            var winElem_LeftClickPane2000_72_2 = root.FindByXPath(xpath_LeftClickPane2000_72_2);
            if (winElem_LeftClickPane2000_72_2 != null)
            {
                winElem_LeftClickPane2000_72_2.Click();
                winElem_LeftClickPane2000_72_2.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickPane2000_72_2}");
                return;
            }


            // LeftClick on Edit "" at (72,7)
            Console.WriteLine("LeftClick on Edit \"\" at (72,7)");
            string xpath_LeftClickEdit_72_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@Name=\"02:00\"][@AutomationId=\"tsNormProcessTime\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_72_7 = root.FindByXPath(xpath_LeftClickEdit_72_7);
            if (winElem_LeftClickEdit_72_7 != null)
            {
                winElem_LeftClickEdit_72_7.Click();
                winElem_LeftClickEdit_72_7.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_72_7}");
                return;
            }


            // LeftClick on Edit "" at (73,2)
            Console.WriteLine("LeftClick on Edit \"\" at (73,2)");
            string xpath_LeftClickEdit_73_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"groupNorms\"][@AutomationId=\"groupNorms\"]/Pane[@Name=\"02:00\"][@AutomationId=\"tsNormWorkingTime\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_73_2 = root.FindByXPath(xpath_LeftClickEdit_73_2);
            if (winElem_LeftClickEdit_73_2 != null)
            {
                winElem_LeftClickEdit_73_2.Click();
                winElem_LeftClickEdit_73_2.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_73_2}");
                return;
            }


            // LeftClick on DataItem "  row0" at (56,12)
            Console.WriteLine("LeftClick on DataItem \"  row0\" at (56,12)");
            string xpath_LeftClickDataItemrow0_56_12 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 1\"]/DataItem[@Name=\"  row0\"]";
            var winElem_LeftClickDataItemrow0_56_12 = root.FindByXPath(xpath_LeftClickDataItemrow0_56_12);
            if (winElem_LeftClickDataItemrow0_56_12 != null)
            {
                winElem_LeftClickDataItemrow0_56_12.Click();
                winElem_LeftClickDataItemrow0_56_12.SendKeys(Keys.ArrowDown);
                winElem_LeftClickDataItemrow0_56_12.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow0_56_12}");
                return;
            }


            // LeftClick on DataItem "  row1" at (43,2)
            Console.WriteLine("LeftClick on DataItem \"  row1\" at (43,2)");
            string xpath_LeftClickDataItemrow1_43_2 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 2\"]/DataItem[@Name=\"  row1\"]";
            var winElem_LeftClickDataItemrow1_43_2 = root.FindByXPath(xpath_LeftClickDataItemrow1_43_2);
            if (winElem_LeftClickDataItemrow1_43_2 != null)
            {
                winElem_LeftClickDataItemrow1_43_2.Click();
                winElem_LeftClickDataItemrow1_43_2.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow1_43_2}");
                return;
            }


            // LeftClick on DataItem "  row2" at (31,7)
            Console.WriteLine("LeftClick on DataItem \"  row2\" at (31,7)");
            string xpath_LeftClickDataItemrow2_31_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 3\"]/DataItem[@Name=\"  row2\"]";
            var winElem_LeftClickDataItemrow2_31_7 = root.FindByXPath(xpath_LeftClickDataItemrow2_31_7);
            if (winElem_LeftClickDataItemrow2_31_7 != null)
            {
                winElem_LeftClickDataItemrow2_31_7.Click();
                winElem_LeftClickDataItemrow2_31_7.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow2_31_7}");
                return;
            }


            // LeftClick on DataItem "  row3" at (28,7)
            Console.WriteLine("LeftClick on DataItem \"  row3\" at (28,7)");
            string xpath_LeftClickDataItemrow3_28_7 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 4\"]/DataItem[@Name=\"  row3\"]";
            var winElem_LeftClickDataItemrow3_28_7 = root.FindByXPath(xpath_LeftClickDataItemrow3_28_7);
            if (winElem_LeftClickDataItemrow3_28_7 != null)
            {
                winElem_LeftClickDataItemrow3_28_7.Click();
                winElem_LeftClickDataItemrow3_28_7.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow3_28_7}");
                return;
            }


            // LeftClick on DataItem "  row4" at (28,5)
            Console.WriteLine("LeftClick on DataItem \"  row4\" at (28,5)");
            string xpath_LeftClickDataItemrow4_28_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 5\"]/DataItem[@Name=\"  row4\"]";
            var winElem_LeftClickDataItemrow4_28_5 = root.FindByXPath(xpath_LeftClickDataItemrow4_28_5);
            if (winElem_LeftClickDataItemrow4_28_5 != null)
            {
                winElem_LeftClickDataItemrow4_28_5.Click();
                winElem_LeftClickDataItemrow4_28_5.SendKeys(Keys.ArrowDown);
                winElem_LeftClickDataItemrow4_28_5.SendKeys(Keys.Return);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow4_28_5}");
                return;
            }


            // LeftClick on DataItem "  row5" at (29,18)
            Console.WriteLine("LeftClick on DataItem \"  row5\" at (29,18)");
            string xpath_LeftClickDataItemrow5_29_18 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@AutomationId=\"ucAttributes\"]/Table[@AutomationId=\"gridAttributes\"]/Custom[@Name=\"Data Panel\"]/Custom[@Name=\"Row 6\"]/DataItem[@Name=\"  row5\"]";
            var winElem_LeftClickDataItemrow5_29_18 = root.FindByXPath(xpath_LeftClickDataItemrow5_29_18);
            if (winElem_LeftClickDataItemrow5_29_18 != null)
            {
                winElem_LeftClickDataItemrow5_29_18.Click();
                winElem_LeftClickDataItemrow5_29_18.SendKeys(Keys.NumberPad2);
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickDataItemrow5_29_18}");
                return;
            }


            // LeftClick on Edit "" at (212,17)
            Console.WriteLine("LeftClick on Edit \"\" at (212,17)");
            string xpath_LeftClickEdit_212_17 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@AutomationId=\"panelNormsAndAttributes\"]/Pane[@Name=\"e\"][@AutomationId=\"memoNote\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")]";
            var winElem_LeftClickEdit_212_17 = root.FindByXPath(xpath_LeftClickEdit_212_17);
            if (winElem_LeftClickEdit_212_17 != null)
            {
                winElem_LeftClickEdit_212_17.Click();
                winElem_LeftClickEdit_212_17.SendKeys("e");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEdit_212_17}");
                return;
            }


            // LeftClick on Button "Uložit" at (69,19)
            Console.WriteLine("LeftClick on Button \"Uložit\" at (69,19)");
            string xpath_LeftClickButtonUložit_69_19 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-2\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Uložit\"]";
            var winElem_LeftClickButtonUložit_69_19 = root.FindByXPath(xpath_LeftClickButtonUložit_69_19);
            if (winElem_LeftClickButtonUložit_69_19 != null)
            {
                winElem_LeftClickButtonUložit_69_19.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUložit_69_19}");
                return;
            }


            // LeftClick on Button "Ukončit" at (10,13)
            Console.WriteLine("LeftClick on Button \"Ukončit\" at (10,13)");
            string xpath_LeftClickButtonUkončit_10_13 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-22\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Ukončit\"]";
            var winElem_LeftClickButtonUkončit_10_13 = root.FindByXPath(xpath_LeftClickButtonUkončit_10_13);
            if (winElem_LeftClickButtonUkončit_10_13 != null)
            {
                winElem_LeftClickButtonUkončit_10_13.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonUkončit_10_13}");
                return;
            }


            // LeftClick on Button "Smazat" at (41,10)
            Console.WriteLine("LeftClick on Button \"Smazat\" at (41,10)");
            string xpath_LeftClickButtonSmazat_41_10 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Testovací verze\"]/Window[@AutomationId=\"fmPdRecipes\"]/Tab[@AutomationId=\"tcList\"]/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"2-22\"]/Pane[@AutomationId=\"ucPdRecipeTreeDetail\"]/Pane[@Name=\"splitContainerControl1\"][starts-with(@AutomationId,\"splitContainerControl\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Pane[@AutomationId=\"ucPdRecipeDetailLite\"]/Pane[@Name=\"buttonsContainer1\"][starts-with(@AutomationId,\"buttonsContainer\")]/Pane[starts-with(@ClassName,\"WindowsForms10\")]/Button[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"Smazat\"]";
            var winElem_LeftClickButtonSmazat_41_10 = root.FindByXPath(xpath_LeftClickButtonSmazat_41_10);
            if (winElem_LeftClickButtonSmazat_41_10 != null)
            {
                winElem_LeftClickButtonSmazat_41_10.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonSmazat_41_10}");
                return;
            }


            // LeftClick on Edit "PasswordTextEdit" at (233,5)
            Console.WriteLine("LeftClick on Edit \"PasswordTextEdit\" at (233,5)");
            string xpath_LeftClickEditPasswordTe_233_5 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Smazání receptury\"][@AutomationId=\"mbAuthorization\"]/Edit[@Name=\"PasswordTextEdit\"][@AutomationId=\"txtPassword\"]/Edit[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"PasswordTextEdit\"]";
            var winElem_LeftClickEditPasswordTe_233_5 = root.FindByXPath(xpath_LeftClickEditPasswordTe_233_5);
            if (winElem_LeftClickEditPasswordTe_233_5 != null)
            {
                winElem_LeftClickEditPasswordTe_233_5.Click();
                winElem_LeftClickEditPasswordTe_233_5.SendKeys("mesbrno");
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickEditPasswordTe_233_5}");
                return;
            }


            // LeftClick on Button "OK" at (63,15)
            Console.WriteLine("LeftClick on Button \"OK\" at (63,15)");
            string xpath_LeftClickButtonOK_63_15 = "/Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]/Window[@Name=\"Production Management System\"][@AutomationId=\"fmMainBase\"]/Window[@Name=\"Smazání receptury\"][@AutomationId=\"mbAuthorization\"]/Pane[@Name=\"panelButtons\"][@AutomationId=\"panelButtons\"]/Button[@Name=\"OK\"][@AutomationId=\"btnOk\"]";
            var winElem_LeftClickButtonOK_63_15 = root.FindByXPath(xpath_LeftClickButtonOK_63_15);
            if (winElem_LeftClickButtonOK_63_15 != null)
            {
                winElem_LeftClickButtonOK_63_15.Click();
            }
            else
            {
                Console.WriteLine($"Failed to find element using xpath: {xpath_LeftClickButtonOK_63_15}");
                return;
            }
        }

        private string GetFullRecipeNumber(string recipeNumber, string recipeVersion)
        {
            return $"{recipeNumber}, ver. {recipeVersion}";
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
