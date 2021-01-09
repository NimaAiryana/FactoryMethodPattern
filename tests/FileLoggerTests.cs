using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoggerService;

namespace tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void LogTest_ShouldWriteDataToFile()
        {
            string testDirectoryPath = "/home/nima/Work/cslang/designpattern/factorymethodincsharp/tests";

            string fileName = "2021-01-09.log";

            new FileLogger(testDirectoryPath, fileName).Log(new LogData("set log data from mstest\n"));
        }

        [TestMethod]
        public void LogTest_ShouldWriteDataToFile_ByLoggerFactory()
        {
            string testDirectoryPath = "/home/nima/Work/cslang/designpattern/factorymethodincsharp/tests";

            string fileName = "2021-01-09.log";

            new FileLoggerFactory(testDirectoryPath, fileName).createLogger().Log(new LogData("set log data from mstest by logger factory\n"));
        }
    }
}
