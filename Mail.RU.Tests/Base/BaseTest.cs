using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.ClientProtocol;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCommonLib.BrowserConfig;
using TestCommonLib.DataProvider;

namespace Mail.RU.Tests.Base
{
    public class BaseTest
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            Browser.GoToUrl(TestContext.Properties["url"].ToString());
            Browser.MaximizeWindow();
        }


        [TestCleanup]
        public void DoAfterAllTest()
        {
            Browser.GetDriver().Quit();
        }
    }
}
