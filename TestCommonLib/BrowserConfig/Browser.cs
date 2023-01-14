using OpenQA.Selenium;
using TestCommonLib.DataProvider;
using TestCommonLib.Utils;

namespace TestCommonLib.BrowserConfig;

public static class Browser
{
    private static IWebDriver driver;

    public static IWebDriver GetDriver() 
    {
        if (driver == null) 
        {
            driver = BrowserFactory.GetBrowser(ConfigDataProvider.GetData().Browser);
        }
        return driver;
    }

    public static string GetCurrentUrl()
    {
        LogUtils.Info($"Get current url");
        return GetDriver().Url;
    }

    public static void GoToUrl(string url)
    {
        LogUtils.Info($"Go to url: {url}");
        GetDriver().Navigate().GoToUrl(url);
    }

    public static void MaximizeWindow()
    {
        LogUtils.Info($"Maximize window");
        GetDriver().Manage().Window.Maximize();
    }
}
