using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Project2ObjectWCF.DTO
{
    [DataContract(IsReference = true)]
    public partial class FileDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileDTO()
        {
            this.Tags = new HashSet<TagDTO>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }
        [DataMember]
        public virtual MetadataDTO Metadata { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<TagDTO> Tags { get; set; }
    }
}
