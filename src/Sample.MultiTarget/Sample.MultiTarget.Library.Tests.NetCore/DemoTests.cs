using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.MultiTarget.Library.Tests._461
{
    [TestClass]
    public class UnitTest1
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
