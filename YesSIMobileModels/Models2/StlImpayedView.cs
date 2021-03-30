using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlImpayedView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgeDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public string StlCategoryDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRest { get; set; }
        public int? RntRevivalCount { get; set; }
        [StringLength(1000)]
        public string PeriodDescription { get; set; }
        public string Notes { get; set; }
        public string StkItemCode { get; set; }
        public string StkItemDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public string CfgTrancheDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? ComFolderId { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        public Guid? RntDocumentId { get; set; }
        public Guid? RntFolderId { get; set; }
        [StringLength(255)]
        public string RntFolderCode { get; set; }
        public Guid? SynFolderId { get; set; }
        [StringLength(255)]
        public string SynFolderCode { get; set; }
        public Guid? StlDocumentId { get; set; }
        [StringLength(255)]
        public string StlDocumentCode { get; set; }
        public Guid? ComDocumentId { get; set; }
        [StringLength(255)]
        public string ComDocumentDescription { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        [Column(TypeName = "image")]
        public byte[] StatusImg { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid ObjectId { get; set; }
        [Required]
        [StringLength(15)]
        public string ObjectKind { get; set; }
        [Required]
        [StringLength(28)]
        public string ObjectDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgCommercialId { get; set; }
        [StringLength(255)]
        public string CfgCommercialCode { get; set; }
        [StringLength(255)]
        public string CfgCommercialDescription { get; set; }
        public Guid? StlRecoveryFolderId { get; set; }
        [StringLength(255)]
        public string StlRecoveryFolderCode { get; set; }
        [StringLength(255)]
        public string StlRecoveryDescription { get; set; }
        public Guid? CfgDebtCollectorId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtCollectorCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtCollectorDescription { get; set; }
        public Guid? CfgDebtManagerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtManagerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtManagerDescription { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
