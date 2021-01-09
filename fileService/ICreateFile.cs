using System.IO;

namespace FileService
{
    public interface ICreateFile
    {
        string CreateFileIfNotExist(string fileDirectoryPath, string fileName);
    }
}