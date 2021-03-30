using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmMailModel")]
    public partial class AdmMailModel
    {
        public AdmMailModel()
        {
            AdmMailings = new HashSet<AdmMailing>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Type { get; set; }
        [Column(TypeName = "image")]
        public byte[] ModelFile { get; set; }
        public int? Sorting { get; set; }

        [InverseProperty(nameof(AdmMailing.AdmMailModel))]
        public virtual ICollection<AdmMailing> AdmMailings { get; set; }
    }
}
