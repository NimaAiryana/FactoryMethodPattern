using System;
using LoggerService.Abstractions;

namespace LoggerService
{
    public sealed class StdOutLogger : ILogger, IStdOutLogger
    {
        public void Log(ILogData logData) => Console.WriteLine(logData.Data);
    }
}