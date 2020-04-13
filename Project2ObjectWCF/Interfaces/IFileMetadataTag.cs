using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Project2ObjectWCF.Interfaces;

namespace Project2ObjectWCF
{
    [ServiceContract]
    interface IFileMetadataTag : FileInterface, IMetadataInterface, TagInterface
    {
    }
}
