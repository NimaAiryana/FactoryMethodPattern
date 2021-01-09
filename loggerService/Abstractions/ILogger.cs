namespace LoggerService.Abstractions
{
    public interface ILogger
    {
        void Log(ILogData logData);
    }
}