﻿/*
 * project = PageFactoryUsingFacebook
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_Sample.Driver
{
    public class DriverClass
    {
        public static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("--disable-notifications");
            driver = new ChromeDriver(chromeOptions);
            //driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

            //Implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8000);

            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
            driver.Quit();
        }
    }
}
