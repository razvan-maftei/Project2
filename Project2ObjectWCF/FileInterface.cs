using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Project2Model;

namespace Project2ObjectWCF
{
    [ServiceContract]
    interface FileInterface {
        [OperationContract]
        void AddFile(File file);

        [OperationContract]
        void DeleteFile(string filePath);

        [OperationContract]
        ICollection<File> GetFilesAndMetadata();

        [OperationContract]
        ICollection<File> FindFilesByFileName(string name);
    }
}
