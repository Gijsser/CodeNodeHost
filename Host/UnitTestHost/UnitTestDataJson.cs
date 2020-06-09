using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Host;

namespace UnitTestHost
{
    [TestClass]
    public class UnitTestDataJson
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            int sensNr = 1;
            int instNr = 20;
            int bRet = 30;
            int[] array = { 11, 20 };
            DataJson dataJson = new DataJson(sensNr, instNr, bRet, array);
            Assert.AreEqual(dataJson.SensNr,sensNr);
            Assert.AreEqual(dataJson.InstNr, instNr);
            Assert.AreEqual(dataJson.BRet, bRet);
            Assert.AreEqual(dataJson.Data, array);
        }
    }
}
