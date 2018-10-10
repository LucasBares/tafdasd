using OpenQA.Selenium;
using NUnit.Framework;
using ConsoleApp1.Utils;

namespace ConsoleApp1
{
    class FacebookOpen : BaseComponents
    {
        [Test]
        public void OpenFacebook()
        {
            Utils.BaseComponents.Equal
            driver.Url = "https://www.google.com";
        }

    }
}
