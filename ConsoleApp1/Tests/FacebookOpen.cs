using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ConsoleApp1.Utils;
using System;
using OpenQA.Selenium.Support;

namespace ConsoleApp1
{
    class FacebookOpen : BaseComponents
    {
        [SetUp]
        public void Inicializate()
        {
            Collection.driver = new ChromeDriver(@"C:\Users\lucas.mazzini\source\repos\ConsoleApp1\ConsoleApp1");
        }

        [Test]
        public void OpenFacebook()
        {
            Collection.driver.Url = "https://www.google.com";

            SearchObject search = new SearchObject();

            search.SearchBox.SendKeys("Facebook");
            search.SearchBox.SendKeys(Keys.Enter);

            string Title = Collection.driver.Title;

            var FUrl = Collection.driver.FindElement(By.ClassName("iUh30")).Text;

            Collection.driver.Url = FUrl;

            FacebookObject page = new FacebookObject();

            page.Login("username","password");

            Exit();
        }
    }
}
