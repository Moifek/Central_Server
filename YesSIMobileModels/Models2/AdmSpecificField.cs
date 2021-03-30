using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmSpecificField")]
    public partial class AdmSpecificField
    {
        public AdmSpecificField()
        {
            AdmSpecificFieldValues = new HashSet<AdmSpecificFieldValue>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? AdmSpecificFieldEntityId { get; set; }
        [StringLength(255)]
        public string Category { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Caption { get; set; }
        public Guid? AdmSpecificFieldDataTypeId { get; set; }
        [StringLength(255)]
        public string DefaultValue { get; set; }
        public bool? Required { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateValue { get; set; }
        public bool? BoolValue { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DecimalValue { get; set; }
        public int? IntValue { get; set; }
        public int? CategorySorting { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string ComboValue { get; set; }

        [ForeignKey(nameof(AdmSpecificFieldDataTypeId))]
        [InverseProperty("AdmSpecificFields")]
        public virtual AdmSpecificFieldDataType AdmSpecificFieldDataType { get; set; }
        [ForeignKey(nameof(AdmSpecificFieldEntityId))]
        [InverseProperty("AdmSpecificFields")]
        public virtual AdmSpecificFieldEntity AdmSpecificFieldEntity { get; set; }
        [InverseProperty(nameof(AdmSpecificFieldValue.AdmSpecificField))]
        public virtual ICollection<AdmSpecificFieldValue> AdmSpecificFieldValues { get; set; }
    }
}
