using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class SynFolderView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public bool? IsInvoiceCustomerGroupping { get; set; }
        public bool? IsSynPricing { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseAmountRest { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CancelDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CancelAmount { get; set; }
        [StringLength(255)]
        public string CancelDescription { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CancelAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CancelAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CancelAmountRest { get; set; }
        [StringLength(255)]
        public string Usage { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        [StringLength(255)]
        public string RntPeriodicityCode { get; set; }
        [StringLength(255)]
        public string RntPeriodicityDescription { get; set; }
        public int? RntPeriodicityMonthNumber { get; set; }
        public int? RntPeriodicitySorting { get; set; }
        [StringLength(255)]
        public string RntPeriodicityUnity { get; set; }
        public int? PeriodicityNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PeriodicityReconductionRatio { get; set; }
        public int? PeriodicityReconductionFrequency { get; set; }
        public Guid? RntReconductionTypeId { get; set; }
        [StringLength(255)]
        public string RntReconductionTypeCode { get; set; }
        [StringLength(255)]
        public string RntReconductionTypeDescription { get; set; }
        public bool? RntReconductionTypeIsAuto { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodicityBeginDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodicityEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextAugmentationDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicVatRatio { get; set; }
        [Column("SyndicMonthAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? SyndicMonthAmountHt { get; set; }
        [Column("SyndicMonthAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? SyndicMonthAmountTtc { get; set; }
        [Column("SyndicPeriodAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? SyndicPeriodAmountHt { get; set; }
        [Column("SyndicPeriodAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? SyndicPeriodAmountTtc { get; set; }
        [Column("SyndicYearAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? SyndicYearAmountHt { get; set; }
        [Column("SyndicYearAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? SyndicYearAmountTtc { get; set; }
        public int? TotalEcheanceNumber { get; set; }
        public int? TotalEcheanceNumberSettled { get; set; }
        public int? TotalEcheanceNumberRest { get; set; }
        [Column("TotalSyndicAgreementHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalSyndicAgreementHt { get; set; }
        [Column("TotalSyndicAdjustmentHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalSyndicAdjustmentHt { get; set; }
        [Column("TotalSyndicHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalSyndicHt { get; set; }
        [Column("TotalSyndicTTC", TypeName = "decimal(38, 6)")]
        public decimal? TotalSyndicTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceFiscalStamp { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceRest { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualPeriodicityBeginDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualPeriodicityEndDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ActualSyndicVatRatio { get; set; }
        [Column("ActualSyndicMonthAmountHT", TypeName = "decimal(37, 17)")]
        public decimal? ActualSyndicMonthAmountHt { get; set; }
        [Column("ActualSyndicMonthAmountTTC", TypeName = "decimal(37, 17)")]
        public decimal? ActualSyndicMonthAmountTtc { get; set; }
        [Column("ActualSyndicPeriodAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? ActualSyndicPeriodAmountHt { get; set; }
        [Column("ActualSyndicPeriodAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? ActualSyndicPeriodAmountTtc { get; set; }
        [Column("ActualSyndicYearAmountHT", TypeName = "decimal(38, 15)")]
        public decimal? ActualSyndicYearAmountHt { get; set; }
        [Column("ActualSyndicYearAmountTTC", TypeName = "decimal(38, 15)")]
        public decimal? ActualSyndicYearAmountTtc { get; set; }
        public int? ActualTotalEcheanceNumber { get; set; }
        public int? ActualTotalEcheanceNumberSettled { get; set; }
        public int? ActualTotalEcheanceNumberRest { get; set; }
        [Column("ActualTotalSyndicAgreementHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalSyndicAgreementHt { get; set; }
        [Column("ActualTotalSyndicAdjustmentHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalSyndicAdjustmentHt { get; set; }
        [Column("ActualTotalSyndicHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalSyndicHt { get; set; }
        [Column("ActualTotalSyndicTTC", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalSyndicTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceFiscalStamp { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalRest { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementDate1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementSavingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDateReal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InsuranceDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LawyerTransmissionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartContentiousDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLetterOfIncreaseDate { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [Required]
        [StringLength(30)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone { get; set; }
        [Required]
        [Column("EMail")]
        [StringLength(100)]
        public string Email { get; set; }
        public Guid? CfgCommercialId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCommercialCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCommercialDescription { get; set; }
        public Guid? CfgLawyerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgLawyerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgLawyerDescription { get; set; }
        public Guid? CfgTierBailiffId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierBailiffCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierBailiffDescription { get; set; }
        public Guid? RntFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string RntFolderCode { get; set; }
        public Guid? ComFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        public Guid SynFolderStatusId { get; set; }
        [StringLength(255)]
        public string SynFolderStatusCode { get; set; }
        [StringLength(255)]
        public string SynFolderStatusDescription { get; set; }
        [StringLength(255)]
        public string SynFolderStatusColorName { get; set; }
        public int? SynFolderStatusSorting { get; set; }
        [Column("IsASyndic")]
        public bool? IsAsyndic { get; set; }
        public bool? IsCancellation { get; set; }
        public bool? IsClosing { get; set; }
        [Column(TypeName = "image")]
        public byte[] SynFolderStatusImage { get; set; }
        public Guid? StkItemId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemArea { get; set; }
        [Column("StkItemSyndicHT", TypeName = "decimal(26, 6)")]
        public decimal? StkItemSyndicHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemSyndicVatRatio { get; set; }
        [Column("StkItemSyndicTTC", TypeName = "decimal(26, 6)")]
        public decimal? StkItemSyndicTtc { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public bool? IsUnderItem { get; set; }
        public Guid? ParentId { get; set; }
        [StringLength(255)]
        public string StkParentCode { get; set; }
        [StringLength(255)]
        public string StkParentDescription { get; set; }
        public string UnderItemsDescription { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        [StringLength(255)]
        public string StkItemCategoryCode { get; set; }
        [StringLength(255)]
        public string StkItemCategoryDescription { get; set; }
        public Guid? StkItemTypeId { get; set; }
        [StringLength(255)]
        public string StkItemTypeCode { get; set; }
        [StringLength(255)]
        public string StkItemTypeDescription { get; set; }
        public Guid? StkPresentationTypeId { get; set; }
        [StringLength(255)]
        public string StkPresentationTypeCode { get; set; }
        [StringLength(255)]
        public string StkPresentationTypeDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? StkVocationId { get; set; }
        [StringLength(255)]
        public string StkVocationCode { get; set; }
        [StringLength(255)]
        public string StkVocationDecsription { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
    }
}
