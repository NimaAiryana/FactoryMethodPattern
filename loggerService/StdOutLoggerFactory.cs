using LoggerService.Abstractions;

namespace LoggerService
{
    public sealed class StdOutLoggerFactory : ILoggerFactory
    {
        public ILogger createLogger() => new StdOutLogger();
    }
}