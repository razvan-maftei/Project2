using System.Runtime.Serialization;

namespace Project2ObjectWCF.DTO
{
    [DataContract(IsReference = true)]
    public partial class TagDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Key { get; set; }
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public int FileId { get; set; }
        [DataMember]
        public virtual FileDTO File { get; set; }
    }
}
