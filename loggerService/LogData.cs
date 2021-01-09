using LoggerService.Abstractions;

namespace LoggerService
{
    public sealed class LogData : ILogData
    {
        public LogData(string data) => Data = data;

        public string Data { get; set; }
    }
}