using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SynFolderClauseRntDocument")]
    public partial class SynFolderClauseRntDocument
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
        public Guid? SynFolderId { get; set; }
        public Guid? RntFolderId { get; set; }
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
        public Guid? CfgCompanyId { get; set; }
        public Guid? AdmModuleId { get; set; }
        public Guid? StlDocumentId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? RntReconductionHistoryId { get; set; }
        public Guid? SynFolderClauseId { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        public Guid? RntDocumentId { get; set; }

        [ForeignKey(nameof(RntPeriodicityId))]
        [InverseProperty("SynFolderClauseRntDocuments")]
        public virtual RntPeriodicity RntPeriodicity { get; set; }
        [ForeignKey(nameof(SynFolderClauseId))]
        [InverseProperty("SynFolderClauseRntDocuments")]
        public virtual SynFolderClause SynFolderClause { get; set; }
    }
}
