using TestCommonLib.BrowserConfig;
using TestCommonLib.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestCommonLib.Elements;

public class TextBox: BaseElement
{
    public TextBox(By locator, string nameOfElement) : base(locator, nameOfElement)
    {
    }
    
    public void HighlightText(int percent)
    {
        LogUtils.Info($"Highlight text");
        Actions action = new Actions(Browser.GetDriver());
        action.SendKeys(Keys.Home).Build().Perform();
        double textLenghth = Browser.GetDriver().FindElement(base.locator).Text.Length*(percent*0.01);
        action.KeyDown(Keys.LeftShift).Build().Perform();
        for (int i = 0; i < textLenghth; i++)
        {
            action.SendKeys(Keys.ArrowRight);
        }
        action.KeyUp(Keys.LeftShift).Build().Perform();
    }

    public void Clear()
    {
        LogUtils.Info($"Clear text");
        Browser.GetDriver().FindElement(base.locator).Clear();
    }
}
