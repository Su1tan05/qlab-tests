using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCommonLib.BrowserConfig;
using Mail.RU.Tests.Models;
using TestCommonLib.DataProvider;

namespace Mail.RU.Tests.Tests
{
    public class BaseTest
    {
        protected TestData Data = TestDataProvider.GetData<TestData>("TestData.json");

        [TestInitialize]
        public void TestInitialize()
        {
            Browser.GoToUrl(this.Data.BaseUrl);
            Browser.GetDriver().Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Browser.GetDriver().Quit();
        }
    }
}
