using OpenQA.Selenium;
using TestCommonLib.Utils;
using TestCommonLib.BrowserConfig;
using System.Data;

namespace TestCommonLib.Elements;

public abstract class BaseElement
{
    protected By locator;
    
    private readonly string nameOfElement; 

    public BaseElement(By locator,string nameOfElement)
    {
        this.locator = locator;
        this.nameOfElement = nameOfElement;
    }

    public By GetLocator()
    {
        return this.locator;
    }

    public void Click()
    {
        LogUtils.Info($"Click {this.nameOfElement}");
        Browser.GetDriver().FindElement(locator).Click();
    }

    public void ClickAndWait(By locator)
    {
        LogUtils.Info($"Click {this.nameOfElement} and wait");
        Browser.GetDriver().FindElement(this.locator).Click();
        Waits.Waiter.WaitVisibilityOfElementLocated(locator);
    }

    public string GetNameOfElement()
    {
        return nameOfElement;
    }

    public bool IsDisplayed()
    {
        LogUtils.Info($"Check is displayed {this.nameOfElement}");
        return Browser.GetDriver().FindElements(locator).Count > 0;
    }

    public bool TextIsDisplayed(string message)
    {
        LogUtils.Info($"Check is displayed text: '{message}'");
        return Browser.GetDriver().FindElement(locator).Text.Contains(message);
    }

    public string GetText()
    {
        LogUtils.Info($"Get text of '{this.nameOfElement}' element");
        return Browser.GetDriver().FindElement(locator).Text;
    }

    public void SendKeys(string text)
    {
        LogUtils.Info($"Send key in {this.nameOfElement}");
        Browser.GetDriver().FindElement(locator).SendKeys(text);
    }

    public void WaitVisibilityOfElement()
    {
        Waits.Waiter.WaitVisibilityOfElementLocated(locator);
    }

    public void WaitElementDisappear()
    {
        LogUtils.Info($"Wait until {this.nameOfElement} disappear");
        Waits.Waiter.WaitElementDisappear(locator);
    }
}
