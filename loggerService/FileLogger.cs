using System.IO;
using LoggerService.Abstractions;
using FileService;

namespace LoggerService
{
    public sealed class FileLogger : ILogger, IFileLogger
    {
        public FileLogger(string filePath, string fileName) => (FilePath, FileName) = (filePath, fileName);

        public string FilePath { get; }

        public string FileName { get; }

        public void Log(ILogData logData) =>
            File.AppendAllText(new CreateFile().CreateFileIfNotExist(FilePath, FileName), logData.Data);
    }
}