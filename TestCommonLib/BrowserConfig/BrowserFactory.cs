using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestCommonLib.DataProvider;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TestCommonLib.Utils;

namespace TestCommonLib.BrowserConfig;

public static class BrowserFactory
{
    public static IWebDriver GetBrowser(string browserName)
    {
        browserName = browserName.ToLower();
        string browserLanguage = ConfigDataProvider.GetData().BrowserLanguage;
        switch (browserName)
        {
            case "chrome":
                LogUtils.Info($"Chose {browserName} browser");
                return GetChromeInstance(browserLanguage);
            case "firefox":
                LogUtils.Info($"Chose {browserName} browser");
                return GetFirefoxInstance(browserLanguage);
            default:
                throw new Exception($"Input correct browser name! (Examples: Chrome, Firefox)");
        }
    }
    
    private static FirefoxDriver GetFirefoxInstance(string language)
    {
        new DriverManager().SetUpDriver(new FirefoxConfig());
        FirefoxOptions firefoxOptions = new FirefoxOptions();
        firefoxOptions.AddArgument(language);
        return new FirefoxDriver(firefoxOptions);
    }

    private static ChromeDriver GetChromeInstance(string language)
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        ChromeOptions chromeoptions = new ChromeOptions();
        chromeoptions.AddArgument(language);
        return new ChromeDriver(chromeoptions);
    }
}
