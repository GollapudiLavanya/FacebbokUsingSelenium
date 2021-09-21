/*
 * project = PageFactoryUsingFacebook
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Selenium_Sample.Post;
using System;
using System.Collections.Generic;
using System.Text;
using AutoItX3Lib;
using System.Threading;

namespace Selenium_Sample.ActionsPost
{
    public class PostActionsClass
    {
        //public static Actions notify;
       
        public static void PostaPhoto(IWebDriver driver)
        {
            PostClass post = new PostClass(driver);
            
            post.email.SendKeys("ucs17139@rmd.ac.in");
            System.Threading.Thread.Sleep(2000);

            post.password.SendKeys("123456789ABCD");
            System.Threading.Thread.Sleep(2000);

            post.loginButton.Click();
            System.Threading.Thread.Sleep(5000);

            //notify = new Actions(driver);
            //notify.SendKeys(Keys.Escape).Build().Perform();

            post.homeIcon.Click();
            System.Threading.Thread.Sleep(4000);

            //Click the create post 
            post.createPost.Click();
            System.Threading.Thread.Sleep(4000);

            //Add some text in the text field
            post.text.SendKeys("HELLO");
            System.Threading.Thread.Sleep(4000);

            //click photo icon
            post.postPhoto.Click();
            System.Threading.Thread.Sleep(5000);

            //upload a photo
            post.addPhoto.Click();
            System.Threading.Thread.Sleep(5000);
            
            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("Open");
            autoit.Send(@"C:\Users\lavanya.g\Pictures\Saved Pictures\Flower.jpg");
            Thread.Sleep(3000);
            autoit.Send("{ENTER}");
            Thread.Sleep(3000);

            post.postButton.Click();
            System.Threading.Thread.Sleep(8000);
        }
    }
}
