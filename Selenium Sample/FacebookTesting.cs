/*
 * project = FacebookAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using Instagram_Selenium;
using System;
using System.Collections.Generic;

namespace Selenium_Sample
{
    
    public class FbTesting : Base.BaseClass
    {
        ExtentReports report = ReportCreation.report();
        ExtentTest test;
        
        [Test, Order(0)]
        public void SignUp()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "FACEBOOKSIGNUPAUTOMATION");

            Actions.ActionsDo.AssertAfterLauching(driver);
            Actions.ActionsDo.NewAccount(driver);

            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();
        }

        [Test, Order(1)]
        public void InputEmailAndPassword()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "FACEBOOKLOGINAUTOMATION");

            Actions.ActionsDo.LoginToFacebook(driver);
            TakeScreenshotOfFacebook(driver);

            test.Info("InstaScreenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\lavanya.g\source\repos\Selenium Sample\Selenium Sample\Screenshot\.jpg").Build());
   
            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();
        }

        [Test, Order(2)]
        public void Posting()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "FACEBOOKPOSTINGAUTOMATION");

            Actions.ActionsDo.PostaPhoto(driver);

            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();
        }

        [Test, Order(3)]
        public void LogOut()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "FACEBOOKPOSTINGAUTOMATION");

            Actions.ActionsDo.LogoutOption(driver);

            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();
        }

        [Test, Order(4)]
        public void NegativeScenerio()
        {
            
            Actions.ActionsDo.InvalidPassword(driver);
            TakeScreenshotOfFacebook(driver);
        }

        [Test, Order(5)]
        public void Test_SendEmail()
        {
            Gmail.GmailClass.ReadDataFromExcel();
            Gmail.GmailClass.email_send();
        }

    }

}