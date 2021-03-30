using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SynFolder")]
    public partial class SynFolder
    {
        public SynFolder()
        {
            ActTiers = new HashSet<ActTier>();
            BuyDocuments = new HashSet<BuyDocument>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            RntDocuments = new HashSet<RntDocument>();
            RntReconductionHistories = new HashSet<RntReconductionHistory>();
            StkItems = new HashSet<StkItem>();
            StlItems = new HashSet<StlItem>();
            SynFolderClauses = new HashSet<SynFolderClause>();
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
        public Guid SynFolderStatusId { get; set; }
        public Guid? CfgCustomerId { get; set; }
        public Guid? StkItemId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemArea { get; set; }
        [Column("StkItemSyndicHT", TypeName = "decimal(26, 6)")]
        public decimal? StkItemSyndicHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemSyndicVatRatio { get; set; }
        [Column("StkItemSyndicTTC", TypeName = "decimal(26, 6)")]
        public decimal? StkItemSyndicTtc { get; set; }
        public Guid? CfgCommercialId { get; set; }
        public bool? IsInvoiceCustomerGroupping { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? ComFolderId { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? LawyerTransmissionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartContentiousDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLetterOfIncreaseDate { get; set; }
        public Guid? CfgTierBailiffId { get; set; }

        [ForeignKey(nameof(CfgCommercialId))]
        [InverseProperty(nameof(CfgTier.SynFolderCfgCommercials))]
        public virtual CfgTier CfgCommercial { get; set; }
        [ForeignKey(nameof(CfgCustomerId))]
        [InverseProperty(nameof(CfgTier.SynFolderCfgCustomers))]
        public virtual CfgTier CfgCustomer { get; set; }
        [ForeignKey(nameof(CfgLawyerId))]
        [InverseProperty(nameof(CfgTier.SynFolderCfgLawyers))]
        public virtual CfgTier CfgLawyer { get; set; }
        [ForeignKey(nameof(CfgTierBailiffId))]
        [InverseProperty(nameof(CfgTier.SynFolderCfgTierBailiffs))]
        public virtual CfgTier CfgTierBailiff { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("SynFolders")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("SynFolders")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(RntPeriodicityId))]
        [InverseProperty("SynFolders")]
        public virtual RntPeriodicity RntPeriodicity { get; set; }
        [ForeignKey(nameof(RntReconductionTypeId))]
        [InverseProperty("SynFolders")]
        public virtual RntReconductionType RntReconductionType { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("SynFolders")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("SynFolders")]
        public virtual StkVocation StkVocation { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("SynFolders")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(SynFolderStatusId))]
        [InverseProperty("SynFolders")]
        public virtual SynFolderStatus SynFolderStatus { get; set; }
        [InverseProperty(nameof(ActTier.SynFolder))]
        public virtual ICollection<ActTier> ActTiers { get; set; }
        [InverseProperty(nameof(BuyDocument.SynFolder))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(ComActionMessage.SynFolder))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.SynFolder))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(RntDocument.SynFolder))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
        [InverseProperty(nameof(RntReconductionHistory.SynFolder))]
        public virtual ICollection<RntReconductionHistory> RntReconductionHistories { get; set; }
        [InverseProperty("SynFolder")]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(StlItem.SynFolder))]
        public virtual ICollection<StlItem> StlItems { get; set; }
        [InverseProperty(nameof(SynFolderClause.SynFolder))]
        public virtual ICollection<SynFolderClause> SynFolderClauses { get; set; }
    }
}
