using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntFolder")]
    [Index(nameof(Pkey), Name = "_dta_index_RntFolder_5_1298155720__K1")]
    [Index(nameof(CfgCustomerId), nameof(RntFolderStatusId), Name = "_dta_index_RntFolder_5_1298155720__K14_K6_K5_1_54")]
    [Index(nameof(Pkey), nameof(CfgCustomerId), nameof(RntFolderStatusId), nameof(RntReconductionTypeId), nameof(StkItemId), Name = "_dta_index_RntFolder_5_1298155720__K1_K6_K5_K25_K7_2_3_4_24_62")]
    [Index(nameof(Pkey), nameof(StkItemId), Name = "_dta_index_RntFolder_5_1298155720__K1_K7")]
    [Index(nameof(RntReconductionTypeId), nameof(Pkey), nameof(RntFolderStatusId), nameof(StkItemId), nameof(CfgCustomerId), Name = "_dta_index_RntFolder_5_1298155720__K25_K1_K5_K7_K6_2_3_4_24_62")]
    [Index(nameof(RntFolderStatusId), nameof(RntReconductionTypeId), nameof(StkItemId), nameof(CfgCustomerId), nameof(Pkey), Name = "_dta_index_RntFolder_5_1298155720__K5_K25_K7_K6_K1")]
    [Index(nameof(RntFolderStatusId), nameof(CfgCustomerId), nameof(Pkey), nameof(StkItemId), nameof(RntPeriodicityId), nameof(IsInvoiceCustomerGroupping), nameof(IsSynPricing), Name = "_dta_index_RntFolder_5_1298155720__K5_K6_K1_K7_K17_K13_K69_2")]
    [Index(nameof(RntFolderStatusId), nameof(StkItemId), nameof(CfgCustomerId), nameof(Pkey), nameof(RntReconductionTypeId), Name = "_dta_index_RntFolder_5_1298155720__K5_K7_K6_K1_K25_2_3_24_62")]
    [Index(nameof(CfgCustomerId), Name = "_dta_index_RntFolder_5_1298155720__K6")]
    [Index(nameof(StkItemId), nameof(Pkey), nameof(RntPeriodicityId), nameof(RntFolderStatusId), nameof(CfgCustomerId), Name = "_dta_index_RntFolder_5_1298155720__K7_K1_K17_K14_K5_K6_2_4_15_16_23_24_34_35_45_46_54_55_56_57_58_62_63_64_65_66_70")]
    [Index(nameof(StkItemId), nameof(Pkey), nameof(RntPeriodicityId), nameof(CfgCustomerId), nameof(RntFolderStatusId), Name = "_dta_index_RntFolder_5_1298155720__K7_K1_K17_K14_K6_K5_2_4_15_16_23_24_29_34_35_45_46_54_55_56_57_58_62_63_64_65_66_70")]
    [Index(nameof(StkItemId), nameof(Pkey), nameof(StrEntityId), nameof(RntPeriodicityId), nameof(RntFolderStatusId), nameof(CfgCustomerId), nameof(Code), nameof(IsInvoiceCustomerGroupping), Name = "_dta_index_RntFolder_5_1298155720__K7_K1_K67_K17_K5_K6_K2_K13")]
    public partial class RntFolder
    {
        public RntFolder()
        {
            ActTiers = new HashSet<ActTier>();
            BuyDocuments = new HashSet<BuyDocument>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            RntDocuments = new HashSet<RntDocument>();
            RntFolderClauses = new HashSet<RntFolderClause>();
            RntFolderItems = new HashSet<RntFolderItem>();
            RntReconductionHistories = new HashSet<RntReconductionHistory>();
            SavClaimGroups = new HashSet<SavClaimGroup>();
            SavServices = new HashSet<SavService>();
            StkItems = new HashSet<StkItem>();
            StlItems = new HashSet<StlItem>();
            StlRecoveryFolders = new HashSet<StlRecoveryFolder>();
            SynFolders = new HashSet<SynFolder>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid RntFolderStatusId { get; set; }
        public Guid? CfgCustomerId { get; set; }
        public Guid? StkItemId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemArea { get; set; }
        [Column("StkItemRentHT", TypeName = "decimal(26, 6)")]
        public decimal? StkItemRentHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemRentVatRatio { get; set; }
        [Column("StkItemRentTTC", TypeName = "decimal(26, 6)")]
        public decimal? StkItemRentTtc { get; set; }
        public Guid? CfgCommercialId { get; set; }
        public bool? IsInvoiceCustomerGroupping { get; set; }
        [StringLength(255)]
        public string Usage { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        public int? PeriodicityNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PeriodicityReconductionRatio { get; set; }
        public int? PeriodicityReconductionFrequency { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodicityBeginDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodicityEndDate { get; set; }
        public Guid? RntReconductionTypeId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CautionMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CautionVatRatio { get; set; }
        [Column("CautionAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? CautionAmountHt { get; set; }
        [Column("CautionAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? CautionAmountTtc { get; set; }
        public bool? IsRentSyndicGroupping { get; set; }
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
        public Guid? CfgLawyerId { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? CancelDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CancelAmount { get; set; }
        [StringLength(255)]
        public string CancelDescription { get; set; }
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
        public Guid? StrEntityId { get; set; }
        public Guid? StkVocationId { get; set; }
        public bool? IsSynPricing { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextAugmentationDate { get; set; }
        public bool? IsImported { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LawyerTransmissionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartContentiousDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLetterOfIncreaseDate { get; set; }
        public Guid? CfgTierBailiffId { get; set; }
        public Guid? ComProspectionId { get; set; }
        public Guid? CfgOwnerId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommissionRate { get; set; }
        public Guid? RntPeriodicityReverseId { get; set; }
        public bool? IsReversmentBasedOnPayment { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommissionMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RegistrationFees { get; set; }

        [ForeignKey(nameof(CfgCommercialId))]
        [InverseProperty(nameof(CfgTier.RntFolderCfgCommercials))]
        public virtual CfgTier CfgCommercial { get; set; }
        [ForeignKey(nameof(CfgCustomerId))]
        [InverseProperty(nameof(CfgTier.RntFolderCfgCustomers))]
        public virtual CfgTier CfgCustomer { get; set; }
        [ForeignKey(nameof(CfgLawyerId))]
        [InverseProperty(nameof(CfgTier.RntFolderCfgLawyers))]
        public virtual CfgTier CfgLawyer { get; set; }
        [ForeignKey(nameof(CfgOwnerId))]
        [InverseProperty(nameof(CfgTier.RntFolderCfgOwners))]
        public virtual CfgTier CfgOwner { get; set; }
        [ForeignKey(nameof(CfgTierBailiffId))]
        [InverseProperty(nameof(CfgTier.RntFolderCfgTierBailiffs))]
        public virtual CfgTier CfgTierBailiff { get; set; }
        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("RntFolders")]
        public virtual ComProspection ComProspection { get; set; }
        [ForeignKey(nameof(RntFolderStatusId))]
        [InverseProperty("RntFolders")]
        public virtual RntFolderStatus RntFolderStatus { get; set; }
        [ForeignKey(nameof(RntPeriodicityId))]
        [InverseProperty("RntFolderRntPeriodicities")]
        public virtual RntPeriodicity RntPeriodicity { get; set; }
        [ForeignKey(nameof(RntPeriodicityReverseId))]
        [InverseProperty("RntFolderRntPeriodicityReverses")]
        public virtual RntPeriodicity RntPeriodicityReverse { get; set; }
        [ForeignKey(nameof(RntReconductionTypeId))]
        [InverseProperty("RntFolders")]
        public virtual RntReconductionType RntReconductionType { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("RntFolders")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("RntFolders")]
        public virtual StkVocation StkVocation { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("RntFolders")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(ActTier.RntFolder))]
        public virtual ICollection<ActTier> ActTiers { get; set; }
        [InverseProperty(nameof(BuyDocument.RntFolder))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(ComActionMessage.RntFolder))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.RntFolder))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(RntDocument.RntFolder))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
        [InverseProperty(nameof(RntFolderClause.RntFolder))]
        public virtual ICollection<RntFolderClause> RntFolderClauses { get; set; }
        [InverseProperty(nameof(RntFolderItem.RntFolder))]
        public virtual ICollection<RntFolderItem> RntFolderItems { get; set; }
        [InverseProperty(nameof(RntReconductionHistory.RntFolder))]
        public virtual ICollection<RntReconductionHistory> RntReconductionHistories { get; set; }
        [InverseProperty(nameof(SavClaimGroup.RntFolder))]
        public virtual ICollection<SavClaimGroup> SavClaimGroups { get; set; }
        [InverseProperty(nameof(SavService.RntFolder))]
        public virtual ICollection<SavService> SavServices { get; set; }
        [InverseProperty("RntFolder")]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(StlItem.RntFolder))]
        public virtual ICollection<StlItem> StlItems { get; set; }
        [InverseProperty(nameof(StlRecoveryFolder.RntFolder))]
        public virtual ICollection<StlRecoveryFolder> StlRecoveryFolders { get; set; }
        [InverseProperty(nameof(SynFolder.RntFolder))]
        public virtual ICollection<SynFolder> SynFolders { get; set; }
    }
}
