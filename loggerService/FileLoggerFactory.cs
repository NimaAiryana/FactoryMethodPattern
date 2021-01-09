using LoggerService.Abstractions;

namespace LoggerService
{
    public sealed class FileLoggerFactory : ILoggerFactory
    {
        public FileLoggerFactory(string filePath, string fileName) => (FilePath, FileName) = (filePath, fileName);

        public string FilePath { get; }

        public string FileName { get; }

        public ILogger createLogger() => new FileLogger(FilePath, FileName);
    }
}