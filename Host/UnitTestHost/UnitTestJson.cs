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
            var sensNr = 35;
            Json json = new Json();
            //Serial serial = new Serial();
            Mock<SerialPort> port;
            port = new Mock<SerialPort>();
            //serial.GetPort().Open();
            port.Setup(p => p.ReadLine()).Returns("{'\"sensNr\":" + sensNr + ",\"instNr\":13,\"bRet\":20,\"data\":[48.756080,2.302038]}");

            var result = json.ReadJson(port.Object);
            Assert.AreEqual(result.SensNr, sensNr);
            //
            // TODO: Add test logic here
            //
        }
    }
}
