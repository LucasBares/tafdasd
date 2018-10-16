using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ConsoleApp1
{
    class FacebookObject
    {
        public FacebookObject()
        {
            PageFactory.InitElements(Collection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "pass")]
        public IWebElement contra { get; set; }

        [FindsBy(How = How.Id, Using = "loginbutton")]
        public IWebElement loginbutton { get; set; }

        public FacebookObject Login(string userName, string pass)
        {
            email.SendKeys(userName);
            contra.SendKeys(pass);
            loginbutton.Click();

            return FacebookObject();
        }

        private FacebookObject FacebookObject()
        {
            throw new NotImplementedException();
        }
    }
}
