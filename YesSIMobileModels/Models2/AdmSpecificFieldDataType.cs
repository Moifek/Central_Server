using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmSpecificFieldDataType")]
    public partial class AdmSpecificFieldDataType
    {
        public AdmSpecificFieldDataType()
        {
            AdmSpecificFields = new HashSet<AdmSpecificField>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(AdmSpecificField.AdmSpecificFieldDataType))]
        public virtual ICollection<AdmSpecificField> AdmSpecificFields { get; set; }
    }
}
