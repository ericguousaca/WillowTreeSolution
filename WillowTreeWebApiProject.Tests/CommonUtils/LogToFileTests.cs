using Microsoft.VisualStudio.TestTools.UnitTesting;
using WillowTreeLibrary.CommonUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.CommonUtils.Tests
{
    [TestClass()]
    public class LogToFileTests
    {
        [TestMethod()]
        public void LogTest1()
        {
            LogToFile logger = new LogToFile();
            logger.Log("Test Exception", MessageType.Exception);
            logger.Log("Test Information", MessageType.Information);
            logger.Log("Test Warning", MessageType.Warning);
            Assert.IsTrue(true);
        }
    }
}