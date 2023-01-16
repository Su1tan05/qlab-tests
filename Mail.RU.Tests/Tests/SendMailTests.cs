using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mail.RU.Tests.Enums;
using Mail.RU.Tests.Models;
using TestCommonLib.Utils.RandomUtils;

namespace Mail.RU.Tests.Tests
{
    [TestClass]
    public class SendMailTests : BaseTest
    {
        [TestMethod]
        public void CanSendMail()
        {
            var inboxPage = base.OpenInboxPage(User.DefaultUser);
            var mailData = new MailData(){
                To = "s.mosaleva@quality-lab.ru",
                Subject = $"Test task: {RandomUtils.GenerateRandomString(10)}",
                Body = $"Github: https://github.com/Su1tan05/qlab-tests \n\n{RandomUtils.GenerateRandomString(100)}"
            };

            Assert.AreEqual(inboxPage.WriteMail().Send(mailData).GetInfo(), "Письмо отправлено");
        }
    }
}