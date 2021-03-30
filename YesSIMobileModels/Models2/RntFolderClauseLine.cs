using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntFolderClauseLine")]
    public partial class RntFolderClauseLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string PeriodDescription { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        public int? DayNumber { get; set; }
        public int? VatExonorationNumber { get; set; }
        [Column("RentAgreementAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentAgreementAmountHt { get; set; }
        [Column("RentAdjustmentAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentAdjustmentAmountHt { get; set; }
        [Column("RentAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentAmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RentVatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RentAmountVat { get; set; }
        [Column("RentAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? RentAmountTtc { get; set; }
        [Column("SyndicAgreementAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? SyndicAgreementAmountHt { get; set; }
        [Column("SyndicAdjustmentAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? SyndicAdjustmentAmountHt { get; set; }
        [Column("SyndicAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicVatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountVat { get; set; }
        [Column("SyndicAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountTtc { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStamp { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? RntSettlementCategoryId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? RntFolderClauseId { get; set; }
        public Guid? RntPeriodicityId { get; set; }

        [ForeignKey(nameof(RntFolderClauseId))]
        [InverseProperty("RntFolderClauseLines")]
        public virtual RntFolderClause RntFolderClause { get; set; }
        [ForeignKey(nameof(RntPeriodicityId))]
        [InverseProperty("RntFolderClauseLines")]
        public virtual RntPeriodicity RntPeriodicity { get; set; }
        [ForeignKey(nameof(RntSettlementCategoryId))]
        [InverseProperty("RntFolderClauseLines")]
        public virtual RntSettlementCategory RntSettlementCategory { get; set; }
    }
}
