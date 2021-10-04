/*
 * project = FacebookAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Sample.page
{
    public class LogoutPage
    {
        public LogoutPage(IWebDriver driver)
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

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[4]/div[1]/span[1]/div[1]/div[1]/i[1]")]
        [CacheLookup]
        public IWebElement logoutIcon;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Log Out')]")]
        [CacheLookup]
        public IWebElement logoutBtn;

        [FindsBy(How = How.XPath, Using = "//*[@class='_8e63 _ihd _6s']")]
        [CacheLookup]
        public IWebElement loginDisplay;
    }
}
