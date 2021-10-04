/*
 * project = FacebookAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Sample.page
{
    public class Registrationpage
    {
        public static IWebDriver driver;
        public Registrationpage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        public static void AssertForNewAccount(IWebDriver driver)
        {
            string title1 = "Facebook – log in or sign up";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        [FindsBy(How = How.XPath, Using = "//*[text()='Create New Account']")]
        [CacheLookup]
        public IWebElement CreateButton;

        [FindsBy(How = How.XPath, Using = "//*[@class='mbs _52lq fsl fwb fcb']")]
        [CacheLookup]
        public IWebElement signupDisplay;

        [FindsBy(How = How.Name, Using = "firstname")]
        [CacheLookup]
        public IWebElement FirstName;

        [FindsBy(How = How.Name, Using = "lastname")]
        [CacheLookup]
        public IWebElement LastName;

        [FindsBy(How = How.Name, Using = "reg_email__")]
        [CacheLookup]
        public IWebElement Email;

        [FindsBy(How = How.Name, Using = "reg_email_confirmation__")]
        [CacheLookup]
        public IWebElement ConfirmationEmail;

        [FindsBy(How = How.Name, Using = "reg_passwd__")]
        [CacheLookup]
        public IWebElement Password;

        [FindsBy(How = How.Name, Using = "birthday_day")]
        [CacheLookup]
        public IWebElement Date;

        [FindsBy(How = How.Id, Using = "month")]
        [CacheLookup]
        public IWebElement Month;

        [FindsBy(How = How.Id, Using = "year")]
        [CacheLookup]
        public IWebElement Year;

        [FindsBy(How = How.Name, Using = "sex")]
        [CacheLookup]
        public IWebElement Gender;

        [FindsBy(How = How.Name, Using = "websubmit")]
        [CacheLookup]
        public IWebElement Submit;
    }
}
