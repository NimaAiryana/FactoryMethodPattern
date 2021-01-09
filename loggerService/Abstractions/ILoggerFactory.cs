namespace LoggerService.Abstractions
{
    public interface ILoggerFactory
    {
        ILogger createLogger();
    }
}