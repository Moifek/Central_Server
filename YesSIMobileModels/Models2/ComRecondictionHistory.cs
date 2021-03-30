using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComRecondictionHistory")]
    public partial class ComRecondictionHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BeginDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastDate { get; set; }
        [StringLength(255)]
        public string Periodicity { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RecondictionRatio { get; set; }
        public Guid? ComFolderId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column("PriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? PriceTtc { get; set; }
        public int? GracePeriodNumber { get; set; }
        public int? AugmentationFrequency { get; set; }
        public int? PeriodicityNumber { get; set; }

        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComRecondictionHistories")]
        public virtual ComFolder ComFolder { get; set; }
    }
}
