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
    interface MetadataInterface {
        [OperationContract]
        void ChangeMetadataForFile(string path, Metadata metadata);

        [OperationContract]
        void DeleteCustomMetadata(string columnName);
    }
}
