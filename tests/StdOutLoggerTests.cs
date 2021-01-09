using LoggerService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class StdOutLoggerTests
    {
        [TestMethod]
        public void LogTest_ShouldWriteDataInConsole()
        {
            new StdOutLogger().Log(new LogData("console log in mstest"));
        }
    }
}