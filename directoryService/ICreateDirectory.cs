using System.IO;

namespace DirectoryService
{
    public interface ICreateDirectory
    {
        DirectoryInfo CreateNewDirectory(string directoryPath);
    }
}