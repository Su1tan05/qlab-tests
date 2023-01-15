using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCommonLib.BrowserConfig;
using Mail.RU.Tests.Models;
using TestCommonLib.DataProvider;
using Mail.RU.Tests.Enums;
using Mail.RU.Tests.Pages;

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

        protected InboxMailsPage OpenInboxPage(User user) =>
            new MailRuHomePage().LoginPopup().AuthorizeUser(user);
    }
}
