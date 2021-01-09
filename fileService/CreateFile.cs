using System.IO;
using DirectoryService;

namespace FileService
{
    public sealed class CreateFile : ICreateFile
    {
        public string CreateFileIfNotExist(string fileDirectoryPath, string fileName)
        {
            new CreateDirectory().CreateNewDirectory(fileDirectoryPath);

            var filePath = Path.Combine(fileDirectoryPath, fileName);

            if (!File.Exists(filePath))
            {
                var file = File.Create(filePath);
                file.Close();
            }

            return filePath;
        }
    }
}