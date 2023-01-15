using OpenQA.Selenium;
using TestCommonLib.BrowserConfig;

namespace TestCommonLib.Elements;

public class Link : BaseElement
{
    public Link(By locator, string nameOfElement) : base(locator, nameOfElement)
    {
    }

    public string Href()
    {
        return Browser.GetDriver().FindElement(base.locator)?.GetAttribute("href");
    }
}
