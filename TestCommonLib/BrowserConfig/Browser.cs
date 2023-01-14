using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCommonLib.DataProvider;
using TestCommonLib.Utils;

namespace TestCommonLib.BrowserConfig
{
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

        public static void Login(string username, string password)
        {
            LogUtils.Info($"Login_url");
            string url = $"http://{username}:{password}@{GetCurrentUrl().Replace("http://", "")}";
            GoToUrl(url);
        }

        public static void SwitchToFrame(string frameId)
        {
            GetDriver().SwitchTo().Frame(frameId);
        }

        public static void SwitchToFrame(int frameIndex)
        {
            GetDriver().SwitchTo().Frame(frameIndex);
        }

        public static void SwitchToDefault()
        {
            GetDriver().SwitchTo().DefaultContent();
        }
    }
}
