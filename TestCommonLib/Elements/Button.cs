using OpenQA.Selenium;
using TestCommonLib.Base;

namespace TestCommonLib.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator, string nameOfElement) : base(locator, nameOfElement)
        {
        }
    }
}
