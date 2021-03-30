using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmSpecificFieldValue")]
    public partial class AdmSpecificFieldValue
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? AdmSpecificFieldId { get; set; }
        public Guid? NameSpaceId { get; set; }
        [StringLength(1000)]
        public string Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateValue { get; set; }
        public bool? BoolValue { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DecimalValue { get; set; }
        public int? IntValue { get; set; }
        [StringLength(255)]
        public string ComboValue { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmSpecificFieldId))]
        [InverseProperty("AdmSpecificFieldValues")]
        public virtual AdmSpecificField AdmSpecificField { get; set; }
    }
}
