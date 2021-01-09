namespace LoggerService.Abstractions
{
    public interface IFileLogger
    {
        string FilePath { get; }

        string FileName { get; }
    }
}