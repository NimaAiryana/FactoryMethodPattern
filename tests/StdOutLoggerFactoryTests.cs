using LoggerService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class StdOutLoggerFactoryTests
    {
        [TestMethod]
        public void CreateLogger_ShouldReturnSameInstanceOfStdOutLogger()
        {
            var stdOutInstance = new StdOutLoggerFactory().createLogger();

            Assert.IsInstanceOfType(stdOutInstance, typeof(StdOutLogger));
        }

        [TestMethod]
        public void LogTest_ShouldWriteDataInConsole_ByFactoryMethod()
        {
            new StdOutLoggerFactory().createLogger().Log(new LogData("console log in mstest"));
        }
    }
}