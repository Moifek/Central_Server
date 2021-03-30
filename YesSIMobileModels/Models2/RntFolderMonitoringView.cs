using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class RntFolderMonitoringView
    {
        [Column("PKey")]
        public Guid? Pkey { get; set; }
        [StringLength(255)]
        public string RntFolderCode { get; set; }
        public Guid? RntFolderStatusId { get; set; }
        [StringLength(255)]
        public string RntFolderStatusDescription { get; set; }
        [Column(TypeName = "image")]
        public byte[] RntFolderStatusImage { get; set; }
        public Guid StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public string UnderItemsDescription { get; set; }
        [StringLength(255)]
        public string StkItemCategoryDescription { get; set; }
        [StringLength(255)]
        public string StkItemTypeDescription { get; set; }
        [StringLength(255)]
        public string StkPresentationTypeDescription { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [Required]
        [StringLength(30)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualPeriodicityBeginDate { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        [StringLength(255)]
        public string RntPeriodicityDescription { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualPeriodicityEndDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PeriodicityReconductionRatio { get; set; }
        public int? PeriodicityReconductionFrequency { get; set; }
        [Column("ActualRentPeriodAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? ActualRentPeriodAmountHt { get; set; }
        [Column("ActualRentPeriodAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? ActualRentPeriodAmountTtc { get; set; }
        [Column("ActualSyndicPeriodAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? ActualSyndicPeriodAmountHt { get; set; }
        [Column("ActualSyndicPeriodAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? ActualSyndicPeriodAmountTtc { get; set; }
        [Column("ActualEcheancePeriodAmountHT", TypeName = "decimal(27, 6)")]
        public decimal? ActualEcheancePeriodAmountHt { get; set; }
        [Column("ActualEcheancePeriodAmountTTC", TypeName = "decimal(27, 6)")]
        public decimal? ActualEcheancePeriodAmountTtc { get; set; }
        public int? TotalEcheanceNumber { get; set; }
        public int? TotalEcheanceNumberSettled { get; set; }
        public int? TotalEcheanceNumberRest { get; set; }
        public int? ActualTotalEcheanceNumber { get; set; }
        public int? ActualTotalEcheanceNumberSettled { get; set; }
        public int? ActualTotalEcheanceNumberRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalEcheanceRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ActualTotalEcheanceRest { get; set; }
        [Required]
        [StringLength(255)]
        public string ComProspectionCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ComProspectionDocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextAugmentationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementDate1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementDate2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDateReal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementSavingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InsuranceDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LawyerTransmissionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartContentiousDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLetterOfIncreaseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AlertDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NextReconductionDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastReconductionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FuturAugmentationDate { get; set; }
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
        [StringLength(255)]
        public string Contact { get; set; }
        [StringLength(255)]
        public string Usage { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid StkVocationId { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal TotalInvoicedTilToday { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal TotalInvoicedSettledTilToday { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalInvoicedRestTilToday { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalInvoicedSettledPointedTilToday { get; set; }
    }
}
