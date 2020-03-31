using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2Model;

namespace Project2ObjectWCF
{
    class FileMetadata : IFileMetadata
    {
        public void AddFile(File file)
        {
            Project2API.API.FileAPI.AddFile(file);
        }

        public void DeleteFile(string filePath)
        {
            Project2API.API.FileAPI.DeleteFile(filePath);
        }

        public ICollection<File> GetFilesAndMetadata()
        {
            return Project2API.API.FileAPI.GetFilesAndMetadata();
        }

        public ICollection<File> FindFilesByFileName(string name)
        {
            return Project2API.API.FileAPI.FindByFileName(name);
        }

        public void ChangeMetadataForFile(string path, Metadata metadata)
        {
            Project2API.API.MetadataAPI.ChangeMetadataForFile(path, metadata);
        }

        public void DeleteCustomMetadata(string columnName)
        {
            Project2API.API.MetadataAPI.DeleteCustomMetadata(columnName);
        }
    }
}
