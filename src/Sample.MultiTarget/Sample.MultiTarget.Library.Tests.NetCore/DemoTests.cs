using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.MultiTarget.Library.Tests.NetCore
{
    [TestClass]
    public class DemoTests
    {
        [TestMethod]
        public void GetVersion_Success()
        {
            Demo demo = new Demo();
            var actual = demo.GetVersion();
            string expected = "Target Framework is .Net Core";

            Assert.AreEqual(expected, actual);
        }
    }
}
