using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ActExpenseLineView
    {
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DiscountRatio { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [Column("UnitPriceHTNet", TypeName = "decimal(38, 6)")]
        public decimal? UnitPriceHtnet { get; set; }
        [Column("TotalHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("TotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? TotalVat { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [Column("TotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? TotalTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? VentilatedQuantity { get; set; }
        [Column("VentilatedTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? VentilatedTotalHt { get; set; }
        [Column("VentilatedTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? VentilatedTotalTtc { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        public bool? StlCategoryIsCharge { get; set; }
        public bool? StlCategoryIsCredit { get; set; }
        public int? StlCategorySorting { get; set; }
        public Guid? ActAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountDescription { get; set; }
        public bool? ActAccountIsTierAccountMandatory { get; set; }
        public Guid? ActAccountTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountTypeDescription { get; set; }
        public Guid? ActAccountForPaymentId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountForPaymentCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountForPaymentDescription { get; set; }
        public bool? ActAccountForPaymentIsTierAccountMandatory { get; set; }
        public Guid? BuyDocumentId { get; set; }
        [StringLength(255)]
        public string BuyDocumentCode { get; set; }
        [StringLength(255)]
        public string BuyDocumentDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public int? DocDateYear { get; set; }
        public int? DocDateMonth { get; set; }
        [StringLength(255)]
        public string BuyDocumentDocType { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public bool? StrEntityIsCharge { get; set; }
        [StringLength(255)]
        public string StrEntityActDefaultAccountCode { get; set; }
        public Guid ObjectId { get; set; }
        [StringLength(255)]
        public string ObjectCode { get; set; }
        [StringLength(255)]
        public string ObjectDescription { get; set; }
        [Required]
        [StringLength(41)]
        public string ObjectNameSpace { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierCodeCountable { get; set; }
        public Guid? AdmModuleId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? PrjProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Coefficient { get; set; }
        public Guid? BuyLoanId { get; set; }
        public Guid? BuyLoanScheduleId { get; set; }
        public Guid? BuyConsultationLineId { get; set; }
        public Guid? BuyConsultationOfferId { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? VentilationRate { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
    }
}
