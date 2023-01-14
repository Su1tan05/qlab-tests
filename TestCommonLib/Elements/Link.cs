using OpenQA.Selenium;
using TestCommonLib.Base;
using TestCommonLib.BrowserConfig;
using System;

namespace TestCommonLib.Elements
{
    public class Link : BaseElement
    {
        public Link(By locator, string nameOfElement) : base(locator, nameOfElement)
        {
        }
        public string Href()
        {
            return Browser.GetDriver().FindElement(_locator)?.GetAttribute("href");
        }

    }
}
