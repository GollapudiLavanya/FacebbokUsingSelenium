/*
 * project = FacebookAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 03/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Selenium_Sample.page
{
    public class InvalidData
    {
        public InvalidData(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//input[@id='pass']")]
        [CacheLookup]
        public IWebElement PWD;
        
        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginBtn;

        [FindsBy(How = How.XPath, Using = "//*[@class='_9ay7']")]
        [CacheLookup]
        public IWebElement Errormsg;
    }
}
