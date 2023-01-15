using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mail.RU.Tests.Base
{
    [TestClass]
    public class NewTest2 : BaseTest
    {
        [TestMethod]
        [DataRow("https://mail.ru")]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }
    }
}