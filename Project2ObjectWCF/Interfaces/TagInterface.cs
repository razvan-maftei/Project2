using System.Collections.Generic;
using System.ServiceModel;
using Project2ObjectWCF.DTO;

namespace Project2ObjectWCF.Interfaces
{
    [ServiceContract]
    interface TagInterface {
        [OperationContract]
        void AddTag(TagDTO tag);

        [OperationContract]
        void DeleteCustomTag(string tag);
        [OperationContract]
        List<FileDTO> GetFilesByTagKey(string key);
    }
}
