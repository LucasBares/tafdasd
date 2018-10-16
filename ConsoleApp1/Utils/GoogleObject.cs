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
    class SearchObject
    {
        public SearchObject()
        {
               PageFactory.InitElements(Collection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchBox { get; set; }

    }
}
