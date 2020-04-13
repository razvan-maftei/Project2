using System.ServiceModel;
using Project2ObjectWCF.DTO;

namespace Project2ObjectWCF
{
    [ServiceContract]
    interface IMetadataInterface {
        [OperationContract]
        void ChangeMetadataForFile(string path, MetadataDTO metadata);
    }
}
