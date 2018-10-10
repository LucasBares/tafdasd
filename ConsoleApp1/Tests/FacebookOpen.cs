using OpenQA.Selenium;
using NUnit.Framework;
using ConsoleApp1.Utils;
using System;

namespace ConsoleApp1
{
    class FacebookOpen : BaseComponents
    {
        public BaseComponents utils = new BaseComponents();

        [Test]
        public void OpenFacebook()
        {
            driver.Url = "https://www.google.com";

            driver.FindElement(By.Name("q")).SendKeys("Facebook");
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[3]/center/input[1]")).Click();

            string Title = driver.Title;

            if(Title == "Facebook - Buscar con Google")
            {
                var FUrl = driver.FindElement(By.XPath("//*[@id='rso']/div/div/div/div/div/div/a/div/cite")).Text;
                driver.Url = FUrl;
                if(Title == "Facebook - Inicia sesión o regístrate")
                {
                    Console.WriteLine("The test was successfull");
                }
                else
                {
                    Console.WriteLine("The test failed");
                }
            }
            else
            {
                Console.WriteLine("Page not found");
            }
            


            utils.Exit();
        }

    }
}
