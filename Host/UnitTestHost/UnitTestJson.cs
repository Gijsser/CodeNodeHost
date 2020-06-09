using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Host;
using System.IO.Ports;
using Moq;

namespace UnitTestHost
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTestJson
    {
        public UnitTestJson()
        {
            //
            // TODO: Add constructor logic here
            //
        }       

        [TestMethod]
        public void TestReadJson()
        {
            var sensNr = 1;
            var instNr = 20;
            var bRet = 30;
            var data0 = 123456;
            var data1 = 654321;


            Json json = new Json();
            //Serial serial = new Serial();
            Mock<ISerialPort> port = new Mock<ISerialPort>();
            //serial.GetPort().Open();
            port.Setup(p => p.ReadLine()).Returns("{\"sensNr\":" + sensNr + ",\"instNr\":" + instNr + ",\"bRet\":" + bRet + ",\"data\":[" + data0 + ", " + data1 + "]}");

            var result = json.ReadJson(port.Object);
            Assert.AreEqual(result.SensNr, sensNr);
            Assert.AreEqual(result.InstNr, instNr);
            Assert.AreEqual(result.BRet, bRet);
            Assert.AreEqual(result.Data[0], data0);
            Assert.AreEqual(result.Data[1], data1);
            //
            // TODO: Add test logic here
            //
        }
    }
}
