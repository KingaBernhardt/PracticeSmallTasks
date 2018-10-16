using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private DecimalBinaryConverter binaryConverter;
        public UnitTest1()
        {
            binaryConverter = new DecimalBinaryConverter();
        }
        [TestMethod]
        public void TestConvertToBinary()
        {
            Assert.AreEqual("100", binaryConverter.ConvertToBinary(4));
        }

        [TestMethod]
        public void TestConvertToBinaryTen()
        {
            Assert.AreEqual("1010", binaryConverter.ConvertToBinary(10));
        }
    }
}
