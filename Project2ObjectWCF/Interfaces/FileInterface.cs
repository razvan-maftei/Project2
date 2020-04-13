using System.Collections.Generic;
using System.ServiceModel;
using Project2Model;
using Project2ObjectWCF.DTO;

namespace Project2ObjectWCF
{
    [ServiceContract]
    interface FileInterface {
        [OperationContract]
        void AddFile(FileDTO file);

        [OperationContract]
        void DeleteFile(string filePath);

        [OperationContract]
        ICollection<FileDTO> GetFilesAndMetadata();

        [OperationContract]
        ICollection<FileDTO> FindFilesByFileName(string name);
    }
}
