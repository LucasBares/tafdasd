using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace ConsoleApp1.Utils
{
    class BaseComponents
    {
        public IWebDriver driver;

        [SetUp]
        public void Inicializate()
        {
            driver = new ChromeDriver(@"C:\Users\lucas.mazzini\source\repos\ConsoleApp1\ConsoleApp1");
        }

        [TearDown]
        public void Exit()
        {
            driver.Quit();
        }
    }
}
