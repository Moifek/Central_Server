using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class RntFolderView
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
        public bool? IsRentSyndicGroupping { get; set; }
        public bool? IsSynPricing { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CautionMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CautionVatRatio { get; set; }
        [Column("CautionAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? CautionAmountHt { get; set; }
        [Column("CautionAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? CautionAmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CautionAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CautionAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CautionAmountRest { get; set; }
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
        public decimal? RentVatRatio { get; set; }
        [Column("RentMonthAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentMonthAmountHt { get; set; }
        [Column("RentMonthAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? RentMonthAmountTtc { get; set; }
        [Column("RentPeriodAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentPeriodAmountHt { get; set; }
        [Column("RentPeriodAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? RentPeriodAmountTtc { get; set; }
        [Column("RentYearAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentYearAmountHt { get; set; }
        [Column("RentYearAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? RentYearAmountTtc { get; set; }
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
        [Column("EcheanceMonthAmountHT", TypeName = "decimal(27, 6)")]
        public decimal? EcheanceMonthAmountHt { get; set; }
        [Column("EcheanceMonthAmountTTC", TypeName = "decimal(27, 6)")]
        public decimal? EcheanceMonthAmountTtc { get; set; }
        [Column("EcheancePeriodAmountHT", TypeName = "decimal(27, 6)")]
        public decimal? EcheancePeriodAmountHt { get; set; }
        [Column("EcheancePeriodAmountTTC", TypeName = "decimal(27, 6)")]
        public decimal? EcheancePeriodAmountTtc { get; set; }
        [Column("EcheanceYearAmountHT", TypeName = "decimal(27, 6)")]
        public decimal? EcheanceYearAmountHt { get; set; }
        [Column("EcheanceYearAmountTTC", TypeName = "decimal(27, 6)")]
        public decimal? EcheanceYearAmountTtc { get; set; }
        public int? TotalEcheanceNumber { get; set; }
        public int? TotalEcheanceNumberSettled { get; set; }
        public int? TotalEcheanceNumberRest { get; set; }
        [Column("TotalRentAgreementHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalRentAgreementHt { get; set; }
        [Column("TotalRentAdjustmentHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalRentAdjustmentHt { get; set; }
        [Column("TotalRentHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalRentHt { get; set; }
        [Column("TotalRentTTC", TypeName = "decimal(38, 6)")]
        public decimal? TotalRentTtc { get; set; }
        [Column("TotalSyndicAgreementHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalSyndicAgreementHt { get; set; }
        [Column("TotalSyndicAdjustmentHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalSyndicAdjustmentHt { get; set; }
        [Column("TotalSyndicHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalSyndicHt { get; set; }
        [Column("TotalSyndicTTC", TypeName = "decimal(38, 6)")]
        public decimal? TotalSyndicTtc { get; set; }
        [Column("TotalEcheanceAgreementHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceAgreementHt { get; set; }
        [Column("TotalEcheanceAdjustmentHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceAdjustmentHt { get; set; }
        [Column("TotalEcheanceHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceHt { get; set; }
        [Column("TotalEcheanceTTC", TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceTtc { get; set; }
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
        public decimal? ActualRentVatRatio { get; set; }
        [Column("ActualRentMonthAmountHT", TypeName = "decimal(37, 17)")]
        public decimal? ActualRentMonthAmountHt { get; set; }
        [Column("ActualRentMonthAmountTTC", TypeName = "decimal(37, 17)")]
        public decimal? ActualRentMonthAmountTtc { get; set; }
        [Column("ActualRentPeriodAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? ActualRentPeriodAmountHt { get; set; }
        [Column("ActualRentPeriodAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? ActualRentPeriodAmountTtc { get; set; }
        [Column("ActualRentYearAmountHT", TypeName = "decimal(38, 15)")]
        public decimal? ActualRentYearAmountHt { get; set; }
        [Column("ActualRentYearAmountTTC", TypeName = "decimal(38, 15)")]
        public decimal? ActualRentYearAmountTtc { get; set; }
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
        [Column("ActualEcheanceMonthAmountHT", TypeName = "decimal(38, 17)")]
        public decimal? ActualEcheanceMonthAmountHt { get; set; }
        [Column("ActualEcheanceMonthAmountTTC", TypeName = "decimal(38, 17)")]
        public decimal? ActualEcheanceMonthAmountTtc { get; set; }
        [Column("ActualEcheancePeriodAmountHT", TypeName = "decimal(27, 6)")]
        public decimal? ActualEcheancePeriodAmountHt { get; set; }
        [Column("ActualEcheancePeriodAmountTTC", TypeName = "decimal(27, 6)")]
        public decimal? ActualEcheancePeriodAmountTtc { get; set; }
        [Column("ActualEcheanceYearAmountHT", TypeName = "decimal(38, 15)")]
        public decimal? ActualEcheanceYearAmountHt { get; set; }
        [Column("ActualEcheanceYearAmountTTC", TypeName = "decimal(38, 15)")]
        public decimal? ActualEcheanceYearAmountTtc { get; set; }
        public int? ActualTotalEcheanceNumber { get; set; }
        public int? ActualTotalEcheanceNumberSettled { get; set; }
        public int? ActualTotalEcheanceNumberRest { get; set; }
        [Column("ActualTotalRentAgreementHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalRentAgreementHt { get; set; }
        [Column("ActualTotalRentAdjustmentHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalRentAdjustmentHt { get; set; }
        [Column("ActualTotalRentHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalRentHt { get; set; }
        [Column("ActualTotalRentTTC", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalRentTtc { get; set; }
        [Column("ActualTotalSyndicAgreementHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalSyndicAgreementHt { get; set; }
        [Column("ActualTotalSyndicAdjustmentHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalSyndicAdjustmentHt { get; set; }
        [Column("ActualTotalSyndicHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalSyndicHt { get; set; }
        [Column("ActualTotalSyndicTTC", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalSyndicTtc { get; set; }
        [Column("ActualTotalEcheanceAgreementHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceAgreementHt { get; set; }
        [Column("ActualTotalEcheanceAdjustmentHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceAdjustmentHt { get; set; }
        [Column("ActualTotalEcheanceHT", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceHt { get; set; }
        [Column("ActualTotalEcheanceTTC", TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceTtc { get; set; }
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
        public Guid? ComProspectionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ComProspectionDocDate { get; set; }
        [Required]
        [StringLength(255)]
        public string ComProspectionCode { get; set; }
        public Guid RntFolderStatusId { get; set; }
        [StringLength(255)]
        public string RntFolderStatusCode { get; set; }
        [StringLength(255)]
        public string RntFolderStatusDescription { get; set; }
        [StringLength(255)]
        public string RntFolderStatusColorName { get; set; }
        public int? RntFolderStatusSorting { get; set; }
        [Column("IsARent")]
        public bool? IsArent { get; set; }
        public bool? IsCancellation { get; set; }
        public bool? IsClosing { get; set; }
        public bool? IsAvailableForProspection { get; set; }
        [Column(TypeName = "image")]
        public byte[] RntFolderStatusImage { get; set; }
        public Guid? StkItemId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemArea { get; set; }
        [Column("StkItemRentHT", TypeName = "decimal(26, 6)")]
        public decimal? StkItemRentHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemRentVatRatio { get; set; }
        [Column("StkItemRentTTC", TypeName = "decimal(26, 6)")]
        public decimal? StkItemRentTtc { get; set; }
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
        public bool? IsImported { get; set; }
    }
}
