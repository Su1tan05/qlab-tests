using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCommonLib.BrowserConfig;

namespace Mail.RU.Tests.Base
{
    [TestClass]
    public class NewMSTest : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Browser.GetDriver().Navigate().GoToUrl("https://mail.ru");
        }
    }
}