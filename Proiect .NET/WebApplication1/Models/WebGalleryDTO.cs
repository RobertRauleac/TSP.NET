using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;
using System.Runtime.Serialization;

namespace WebApplication1.Models
{
    [DataContract(IsReference = true)]
    public class WebGalleryDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Size { get; set; } 

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public string Format { get; set; }

        [DataMember]
        public string Date { get; set; }
    }
}
