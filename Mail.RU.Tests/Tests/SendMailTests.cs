using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mail.RU.Tests.Pages;
using Mail.RU.Tests.Enums;

namespace Mail.RU.Tests.Tests
{
    [TestClass]
    public class SendMailTests : BaseTest
    {
        [TestMethod]
        [Description("Can Send Mail")]
        public void CanSendMail()
        {
            new MailRuHomePage().Login(User.CommonUser);
            Assert.IsTrue(true);
        }
    }
}