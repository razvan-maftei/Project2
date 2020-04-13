using System.Collections.Generic;
using AutoMapper;
using Project2Model;
using Project2ObjectWCF.DTO;

namespace Project2ObjectWCF
{
    public class FileService : IFileMetadataTag {
        private readonly MapperConfiguration config;
        private readonly IMapper iMapper;

        FileService()
        {
            config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<File, FileDTO>();
                    cfg.CreateMap<FileDTO, File>();
                    cfg.CreateMap<Metadata, MetadataDTO>();
                    cfg.CreateMap<MetadataDTO, Metadata>();
                    cfg.CreateMap<Tag, TagDTO>();
                    cfg.CreateMap<TagDTO, Tag>();
                });
            iMapper = config.CreateMapper();
        }

        public void AddFile(FileDTO file)
        {
            var _file = iMapper.Map<FileDTO, File>(file);
            Project2API.API.FileAPI.AddFile(_file);
        }

        public void DeleteFile(string filePath)
        {
            Project2API.API.FileAPI.DeleteFile(filePath);
        }

        public ICollection<FileDTO> GetFilesAndMetadata()
        {
            var files = new List<FileDTO>();
            foreach (File file in Project2API.API.FileAPI.GetFilesAndMetadata())
            {
                files.Add(iMapper.Map<File, FileDTO>(file));
            }

            return files;
        }

        public ICollection<FileDTO> FindFilesByFileName(string name)
        {
            var files = new List<FileDTO>();
            foreach (File file in Project2API.API.FileAPI.GetFilesAndMetadata())
            {
                if (file.Path.Contains(name))
                    files.Add(iMapper.Map<File, FileDTO>(file));
            }

            return files;
        }

        public void ChangeMetadataForFile(string path, Metadata metadata)
        {
            Project2API.API.MetadataAPI.ChangeMetadataForFile(path, metadata);
        }

        public void ChangeMetadataForFile(string path, MetadataDTO metadata)
        {
            var _metadata = iMapper.Map<MetadataDTO, Metadata>(metadata);
            Project2API.API.MetadataAPI.ChangeMetadataForFile(path, _metadata);
        }

        public void AddTag(TagDTO tag)
        {
            var _tag = iMapper.Map<TagDTO, Tag>(tag);
            Project2API.API.MetadataAPI.AddTag(_tag);
        }

        public void DeleteCustomTag(string tag)
        {
            Project2API.API.MetadataAPI.DeleteCustomTag(tag);
        }

        public List<FileDTO> GetFilesByTagKey(string key)
        {
            var fileList = Project2API.API.MetadataAPI.GetFilesByTagKey(key);
            return fileList.ConvertAll(f => iMapper.Map<File, FileDTO>(f));
        }
    }
}
