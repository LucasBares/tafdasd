using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum ElementsTypes
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName,
        XPath
    }

    class Collection
    {
        public static IWebDriver driver { get; set; }
    }
}
