using System.IO;

namespace DirectoryService
{
    public sealed class CreateDirectory : ICreateDirectory
    {
        public DirectoryInfo CreateNewDirectory(string directoryPath) => 
            Directory.CreateDirectory(directoryPath);
    }
}