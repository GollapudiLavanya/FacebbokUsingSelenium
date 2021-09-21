/*
 * project = PageFactoryUsingFacebook
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Sample.Post
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

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/span[1]")]
        [CacheLookup]
        public IWebElement createPost;

        [FindsBy(How = How.XPath, Using = "//*[@class='_1mf _1mj']")]
        [CacheLookup]
        public IWebElement text;

        [FindsBy(How = How.XPath, Using = "//*[@class='dwxx2s2f dicw6rsg kady6ibp rs0gx3tq'] [1]")]
        [CacheLookup]
        public IWebElement postPhoto;

        [FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv bp9cbjyn rt8b4zig n8ej3o3l agehan2d sk4xxmp2 rq0escxv pq6dq46d taijpn5t l9j0dhe7 tdjehn4e qypqp5cg q676j6op']")]
        [CacheLookup]
        public IWebElement addPhoto;

        [FindsBy(How = How.XPath, Using = "//*[@class='rq0escxv l9j0dhe7 du4w35lb j83agx80 pfnyh3mw taijpn5t bp9cbjyn owycx6da btwxx1t3 kt9q3ron ak7q8e6j isp2s0ed ri5dt5u2 rt8b4zig n8ej3o3l agehan2d sk4xxmp2 d1544ag0 tw6a2znq s1i5eluu tv7at329']")]
        public IWebElement postButton;
    }
}
