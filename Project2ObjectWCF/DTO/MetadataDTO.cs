using System.Runtime.Serialization;

namespace Project2ObjectWCF.DTO
{
    [DataContract(IsReference = true)]
    public partial class MetadataDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public System.DateTime CreationDate { get; set; }
        [DataMember]
        public virtual FileDTO File { get; set; }
    }
}
