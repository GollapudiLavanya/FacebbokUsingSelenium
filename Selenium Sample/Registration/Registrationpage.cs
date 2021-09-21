/*
 * project = PageFactoryUsingFacebook
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_Sample.Registration
{
    public class Registrationpage
    {
        public static void AssertForNewAccount(IWebDriver driver)
        {
            string title1 = "Facebook – log in or sign up";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void CreateNewAccount(IWebDriver driver)
        {
            IWebElement CreateButton = driver.FindElement(By.XPath("//*[text()='Create New Account']"));
            CreateButton.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement firstname = driver.FindElement(By.Name("firstname"));
            firstname.SendKeys("Mahesh");
            System.Threading.Thread.Sleep(1000);

            IWebElement lastname = driver.FindElement(By.Name("lastname"));
            lastname.SendKeys("A");
            System.Threading.Thread.Sleep(1000);

            IWebElement reg_email__ = driver.FindElement(By.Name("reg_email__"));
            reg_email__.SendKeys("ucs17139@rmd.ac.in");
            System.Threading.Thread.Sleep(1000);

            IWebElement ReEnterEmail = driver.FindElement(By.Name("reg_email_confirmation__"));
            ReEnterEmail.SendKeys("ucs17139@rmd.ac.in");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Name("reg_passwd__")).SendKeys("hello@2000");
            System.Threading.Thread.Sleep(1000);

            SelectElement element = new SelectElement(driver.FindElement(By.Name("birthday_day")));
            element.SelectByText("1");
            System.Threading.Thread.Sleep(1000);

            SelectElement element1 = new SelectElement(driver.FindElement(By.Id("month")));
            element1.SelectByValue("1");
            System.Threading.Thread.Sleep(1000);

            SelectElement element2 = new SelectElement(driver.FindElement(By.Id("year")));
            element2.SelectByValue("2000");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Name("sex")).Click();
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Name("websubmit")).Click();
            System.Threading.Thread.Sleep(2000);

        }
    }
}
