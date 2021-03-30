using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhPaySlipModelLine")]
    public partial class GrhPaySlipModelLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Credit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Debit { get; set; }
        public Guid? GrhPaySlipModelUnityId { get; set; }
        public Guid? GrhPaySlipModelId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(GrhPaySlipModelId))]
        [InverseProperty("GrhPaySlipModelLines")]
        public virtual GrhPaySlipModel GrhPaySlipModel { get; set; }
        [ForeignKey(nameof(GrhPaySlipModelUnityId))]
        [InverseProperty("GrhPaySlipModelLines")]
        public virtual GrhPaySlipModelUnity GrhPaySlipModelUnity { get; set; }
    }
}
