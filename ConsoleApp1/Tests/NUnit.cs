using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using ConsoleApp1.Utils;

namespace ConsoleApp1.Test
{
    class NUnit : BaseComponents
    {
        [Test]
        public void OpenAppTest()
        {
            driver.Url = "https://www.google.com";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("lst-ib")).SendKeys("Hola");

            driver.FindElement(By.Name("btnK")).Click();

            string Title = driver.Title;
            if (Title == "Hola - Buscar con Google")
            {
                Console.WriteLine("El titulo es: " + Title);
            }
        }
    }
}
