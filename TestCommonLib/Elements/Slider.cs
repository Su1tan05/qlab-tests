using OpenQA.Selenium;
using TestCommonLib.Utils;
using OpenQA.Selenium.Interactions;
using TestCommonLib.BrowserConfig;

namespace TestCommonLib.Elements;

public class Slider : BaseElement
{
    public Slider(By locator, string nameOfElement) : base(locator, nameOfElement)
    {
    }

    public void SetSliderValue(double value)
    {
        LogUtils.Info($"Set slider value");
        Actions action = new Actions(Browser.GetDriver());
        IWebElement webElement = Browser.GetDriver().FindElement(base.locator);
        double minValue = Convert.ToDouble(webElement.GetAttribute("min").Replace(".",","));
        double maxValue = Convert.ToDouble(webElement.GetAttribute("max").Replace(".", ","));
        double sliderW = webElement.Size.Width-10;
        value -= (maxValue/2);
        action.DragAndDropToOffset(Browser.GetDriver().FindElement(base.locator), (int)(value * sliderW / (maxValue - minValue)), 0).Build().Perform();
    }
}


