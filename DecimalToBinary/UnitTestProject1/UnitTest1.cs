using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private DecimalBinaryConverter binaryConverter;
        public UnitTest1(DecimalBinaryConverter binaryConverter)
        {
            this.binaryConverter = binaryConverter;
        }
        [TestMethod]
        public void TestConvertToBinary()
        {
            Assert.AreEqual("100", binaryConverter.ConvertToBinary(4));
        }
    }
}
