using OpenQA.Selenium;
using TestCommonLib.BrowserConfig;
using TestCommonLib.Waits;

namespace TestCommonLib.Pages;

public abstract class BasePage
{
    protected By PageLocator{ get; set;}

    protected string PageName{ get; set;}

    protected BasePage(By pageLocator, string pageName)
    {
        PageLocator = pageLocator;
        PageName = pageName;
        Waiter.WaitVisibilityOfElementLocated(PageLocator);
    }
}
