using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntRevival")]
    public partial class RntRevival
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? RntDocumentId { get; set; }
        public Guid? StlDocumentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRest { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComDocumentId { get; set; }

        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("RntRevivals")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(ComDocumentId))]
        [InverseProperty("RntRevivals")]
        public virtual ComDocument ComDocument { get; set; }
        [ForeignKey(nameof(RntDocumentId))]
        [InverseProperty("RntRevivals")]
        public virtual RntDocument RntDocument { get; set; }
        [ForeignKey(nameof(StlDocumentId))]
        [InverseProperty("RntRevivals")]
        public virtual StlDocument StlDocument { get; set; }
    }
}
