using OpenQA.Selenium;
using TestCommonLib.Utils;
using TestCommonLib.BrowserConfig;

namespace TestCommonLib.Elements;

public abstract class BaseElement
{
    protected By _locator;
    
    private readonly string _nameOfElement; 

    public BaseElement(By locator,string nameOfElement)
    {
        _locator = locator;
        _nameOfElement = nameOfElement;
    }

    public By GetLocator()
    {
        return _locator;
    }

    public void Click()
    {
        LogUtils.Info($"Click {_nameOfElement}");
        Browser.GetDriver().FindElement(_locator).Click();
    }

    public string GetNameOfElement()
    {
        return _nameOfElement;
    }

    public bool IsDisplayed()
    {
        LogUtils.Info($"Check is displayed {_nameOfElement}");
        return Browser.GetDriver().FindElements(_locator).Count > 0;
    }

    public bool TextIsDisplayed(string message)
    {
        LogUtils.Info($"Check is displayed text: '{message}'");
        return Browser.GetDriver().FindElement(_locator).Text.Contains(message);
    }

    public string GetText()
    {
        LogUtils.Info($"Get text of '{_nameOfElement}' element");
        return Browser.GetDriver().FindElement(_locator).Text;
    }

    public void SendKeys(string text)
    {
        LogUtils.Info($"Send key in {_nameOfElement}");
        Browser.GetDriver().FindElement(_locator).SendKeys(text);
    }
    public void WaitVisibilityOfElement()
    {
        Waits.Waiter.WaitVisibilityOfElementLocated(_locator);
    }
}
