using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComDocumentPaymentMethod")]
    public partial class ComDocumentPaymentMethod
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 16)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DiscountRatio { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? VatRatio { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 16)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? Amount { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? ComSettlementCategoryId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ComDocumentPaymentMethods")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComDocumentPaymentMethods")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(ComSettlementCategoryId))]
        [InverseProperty("ComDocumentPaymentMethods")]
        public virtual ComSettlementCategory ComSettlementCategory { get; set; }
    }
}
