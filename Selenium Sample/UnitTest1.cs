/*
 * project = PageFactoryUsingFacebook
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Selenium_Sample
{
    
    public class Tests1 : Driver.DriverClass
    {
        [Test, Order(0)]
        public void RegistrationOfFb()
        {
            Registration.Registrationpage.AssertForNewAccount(driver);

            Registration.Registrationpage.CreateNewAccount(driver);
        }

        [Test, Order(1)]
        public void InputEmailAndPassword()
        {
            Actions.ActionsDone.AssertAfterLauching(driver);

            Actions.ActionsDone.LoginToFacebook(driver);

        }
    }
}