using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCommonLib.BrowserConfig;
using Mail.RU.Tests.Models;
using TestCommonLib.DataProvider;

namespace Mail.RU.Tests.Base
{
    public class BaseTest
    {
        [TestInitialize]
        public void Setup()
        {
            var testUrl = TestDataProvider.GetData<TestData>("TestData.json").Url;
            Browser.GoToUrl(testUrl);
        }


        [TestCleanup]
        public void DoAfterAllTest()
        {
            Browser.GetDriver().Quit();
        }
    }
}
