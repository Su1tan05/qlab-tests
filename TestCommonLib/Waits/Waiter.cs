﻿using OpenQA.Selenium.Support.UI;
using TestCommonLib.BrowserConfig;
using TestCommonLib.Utils;
using OpenQA.Selenium;
using TestCommonLib.DataProvider;

namespace TestCommonLib.Waits
{
    public class Waiter
    {
        private readonly static WebDriverWait wait = new WebDriverWait(Browser.GetDriver(), TestDataProvider.BrowserSettings.ExplicitWaitTimeout);

        public static void WaitVisibilityOfElementLocated(By locator)
        {
            LogUtils.Info($"Wait_Visibility_Of_Elements");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static void WaitElementToBeClicable(By locator)
        {
            LogUtils.Info($"Wait_Element_To_Be_Clicable");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
