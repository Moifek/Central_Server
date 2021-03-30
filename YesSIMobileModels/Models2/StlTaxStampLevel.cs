using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlTaxStampLevel")]
    public partial class StlTaxStampLevel
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValidationDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountMin { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountMax { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountStamp { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StlSettlementTypeId))]
        [InverseProperty("StlTaxStampLevels")]
        public virtual StlSettlementType StlSettlementType { get; set; }
    }
}
