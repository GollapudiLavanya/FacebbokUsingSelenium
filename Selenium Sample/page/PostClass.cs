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
    public class PostClass
    {
        public PostClass(IWebDriver driver)
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

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")]
        [CacheLookup]
        public IWebElement homeIcon;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Photo/Video')]")]
        [CacheLookup]
        public IWebElement createPost;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div/div/div[1]/div[1]/div/div[1]/h2/span/span")]
        [CacheLookup]
        public IWebElement postText;

        [FindsBy(How = How.XPath, Using = "//*[@class='_1mf _1mj']")]
        [CacheLookup]
        public IWebElement text;

        [FindsBy(How = How.XPath, Using = "//*[@class='dwxx2s2f dicw6rsg kady6ibp rs0gx3tq'] [1]")]
        [CacheLookup]
        public IWebElement postPhoto;

        [FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv bp9cbjyn rt8b4zig n8ej3o3l agehan2d sk4xxmp2 rq0escxv pq6dq46d taijpn5t l9j0dhe7 tdjehn4e qypqp5cg q676j6op']")]
        [CacheLookup]
        public IWebElement addPhoto;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[2]/div[1]/div[1]")]
        public IWebElement postButton;

        [FindsBy(How = How.XPath, Using = "  //*[@class='kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x c1et5uql ii04i59q']")]
        [CacheLookup]
        public IWebElement aboutPost;

        [FindsBy(How = How.XPath, Using = "  //*[@class='i09qtzwb n7fi1qx3 datstx6m pmk7jnqg j9ispegn kr520xx4 k4urcfbm bixrwtb6']")]
        [CacheLookup]
        public IWebElement img;
    }
}
