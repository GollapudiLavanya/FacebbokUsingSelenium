/*
 * project = FacebookAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using AutoItX3Lib;
using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium_Sample.page;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace Selenium_Sample.Actions
{
    public class ActionsDo
    {
        public static Login_page login;
        private static readonly ILog log = LogManager.GetLogger(typeof(FbTesting));

        public static void AssertAfterLauching(IWebDriver driver)
        {
                string title1 = "Facebook – log in or sign up";
                string title = driver.Title;
                Assert.AreEqual(title1, title);
        }

        public static void NewAccount(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Selenium Sample\Selenium Sample\TestDataFiles\FacebookRegistration.xlsx");

                Registrationpage signup = new Registrationpage(driver);

                signup.CreateButton.Click();
                System.Threading.Thread.Sleep(1000);

                string expected = "Sign Up";
                string actual = signup.signupDisplay.Text;
                Assert.AreEqual(actual, expected);

                signup.FirstName.SendKeys(ExcelOperations.ReadData(1, "FIRSTNAME"));
                System.Threading.Thread.Sleep(1000);

                signup.LastName.SendKeys(ExcelOperations.ReadData(1, "LASTNAME"));
                System.Threading.Thread.Sleep(1000);

                signup.Email.SendKeys(ExcelOperations.ReadData(1, "EMAIL"));
                System.Threading.Thread.Sleep(1000);

                signup.ConfirmationEmail.SendKeys(ExcelOperations.ReadData(1, "CONFIRMATIONEMAIL"));
                System.Threading.Thread.Sleep(1000);

                signup.Password.SendKeys(ExcelOperations.ReadData(1, "PASSWORD"));
                System.Threading.Thread.Sleep(1000);

                SelectElement element = new SelectElement(signup.Date);
                element.SelectByText("1");
                System.Threading.Thread.Sleep(1000);

                SelectElement element1 = new SelectElement(signup.Month);
                element1.SelectByValue("1");
                System.Threading.Thread.Sleep(1000);

                SelectElement element2 = new SelectElement(signup.Year);
                element2.SelectByValue("2000");
                System.Threading.Thread.Sleep(1000);

                signup.Gender.Click();
                System.Threading.Thread.Sleep(1000);

                signup.Submit.Click();
                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void LoginToFacebook(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Selenium Sample\Selenium Sample\TestDataFiles\FacebookLogin.xlsx");

                login = new Login_page(driver);

                login.email.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(2000);

                login.password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(2000);

                login.loginButton.Click();
                System.Threading.Thread.Sleep(2000);

                String actualUrl = "https://www.facebook.com/?sk=welcome";
                String expectedUrl = driver.Url;
                Assert.AreEqual(actualUrl, expectedUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void PostaPhoto(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Selenium Sample\Selenium Sample\TestDataFiles\FacebookLogin.xlsx");

                PostClass post = new PostClass(driver);

                post.email.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(2000);

                post.password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(2000);

                //Click on login Button
                post.loginButton.Click();
                System.Threading.Thread.Sleep(2000);

                //Click on Home Icon
                post.homeIcon.Click();
                System.Threading.Thread.Sleep(2000);

                //Click the create post 
                post.createPost.Click();
                System.Threading.Thread.Sleep(2000);

                //validation of post Creation
                Assert.AreEqual("Create post", post.postText.Text);

                //Add some text in the text field
                post.text.SendKeys("HELLO");
                System.Threading.Thread.Sleep(2000);

                //click photo icon
                post.postPhoto.Click();
                System.Threading.Thread.Sleep(2000);

                //upload a photo
                post.addPhoto.Click();
                System.Threading.Thread.Sleep(2000);

                AutoItX3 autoit = new AutoItX3();
                autoit.WinActivate("Open");
                autoit.Send(@"C:\Users\lavanya.g\Pictures\Saved Pictures\Flower.jpg");
                Thread.Sleep(3000);
                autoit.Send("{ENTER}");
                Thread.Sleep(2000);

                post.postButton.Click();
                System.Threading.Thread.Sleep(2000);

                ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,1500)");
                System.Threading.Thread.Sleep(1000);

                //Validating whether the Text post is equal or not
                string expected = "HELLO";
                string actual = post.aboutPost.Text;
                Assert.AreEqual(actual, expected);

                //Validating whether the image is displayed
                Assert.IsTrue(post.img.Displayed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void LogoutOption(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Selenium Sample\Selenium Sample\TestDataFiles\FacebookLogin.xlsx");

                LogoutPage logout = new LogoutPage(driver);

                logout.email.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(2000);

                logout.password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(2000);

                logout.loginButton.Click();
                System.Threading.Thread.Sleep(2000);

                logout.logoutIcon.Click();
                System.Threading.Thread.Sleep(2000);

                logout.logoutBtn.Click();
                System.Threading.Thread.Sleep(2000);

                Assert.IsTrue(logout.loginDisplay.Displayed);
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InvalidPassword(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Selenium Sample\Selenium Sample\TestDataFiles\FacebookInvalidPWD.xlsx");

                InvalidData data = new InvalidData(driver);

                data.email.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(2000);

                data.password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(2000);

                data.loginButton.Click();
                System.Threading.Thread.Sleep(2000);

                Assert.IsTrue(data.Errormsg.Displayed);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
