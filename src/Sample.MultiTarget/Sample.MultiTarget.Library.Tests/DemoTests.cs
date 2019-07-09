using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.MultiTarget.Library.Tests
{
    [TestClass]
    public class DemoTests
    {
        [TestMethod]
        public void GetVersion_Success()
        {
            Demo demo = new Demo();
            var actual = demo.GetVersion();
#if NETFRAMEWORK
            string expected = "Target Framework is .Net Framework";
#elif NETCOREAPP
            string expected = "Target Framework is .Net Core";
#endif
            Assert.AreEqual(expected, actual);
        }
    }
}
