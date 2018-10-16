using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace ConsoleApp1.Utils
{
    class BaseComponents
    {
        [TearDown]
        public static void Exit()
        {
            Collection.driver.Quit();
        }
    }
}
