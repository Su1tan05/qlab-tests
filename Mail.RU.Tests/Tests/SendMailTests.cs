using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mail.RU.Tests.Enums;

namespace Mail.RU.Tests.Tests
{
    [TestClass]
    public class SendMailTests : BaseTest
    {
        [TestMethod]
        public void CanSendMail()
        {
            var inboxPage = base.OpenInboxPage(User.DefaultUser);
            inboxPage.WriteMail().Send($"sultan_tadjibov@mail.ru", "Test mail", "EEEE Можно спать!!!\n\n Test mail body");

            Assert.IsTrue(true);
        }
    }
}