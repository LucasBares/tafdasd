using OpenQA.Selenium;
using NUnit.Framework;
using ConsoleApp1.Utils;

namespace ConsoleApp1
{
    class FacebookOpen : BaseComponents
    {
        public BaseComponents salir = new BaseComponents();
        [Test]
        public void OpenFacebook()
        {
            driver.Url = "https://www.google.com";
            salir.Exit();
        }

    }
}
