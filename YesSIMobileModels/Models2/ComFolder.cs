using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComFolder")]
    [Index(nameof(Pkey), Name = "_dta_index_ComFolder_5_1149247149__K1_9")]
    [Index(nameof(Pkey), nameof(StkItemId), Name = "_dta_index_ComFolder_5_1149247149__K1_K8")]
    [Index(nameof(StkVocationId), nameof(StkItemId), nameof(Pkey), Name = "_dta_index_ComFolder_7_1149247149__K2_K8_K1")]
    public partial class ComFolder
    {
        public ComFolder()
        {
            ActEntries = new HashSet<ActEntry>();
            ActTiers = new HashSet<ActTier>();
            AdmEvents = new HashSet<AdmEvent>();
            BuyDocuments = new HashSet<BuyDocument>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComCommissionLines = new HashSet<ComCommissionLine>();
            ComDocumentPaymentMethods = new HashSet<ComDocumentPaymentMethod>();
            ComDocuments = new HashSet<ComDocument>();
            ComFolderCustomers = new HashSet<ComFolderCustomer>();
            ComFolderDocumentToAttaches = new HashSet<ComFolderDocumentToAttach>();
            ComFolderGifts = new HashSet<ComFolderGift>();
            ComFolderItems = new HashSet<ComFolderItem>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            ComModifications = new HashSet<ComModification>();
            ComRecondictionHistories = new HashSet<ComRecondictionHistory>();
            ComSaleWithdrawalCancellations = new HashSet<ComSaleWithdrawalCancellation>();
            ComSaleWithdrawalClients = new HashSet<ComSaleWithdrawalClient>();
            ComSaleWithdrawalProducts = new HashSet<ComSaleWithdrawalProduct>();
            RntDocuments = new HashSet<RntDocument>();
            SavClaimGroups = new HashSet<SavClaimGroup>();
            SavServices = new HashSet<SavService>();
            StlDocumentLines = new HashSet<StlDocumentLine>();
            StlItems = new HashSet<StlItem>();
            StlRecoveryFolders = new HashSet<StlRecoveryFolder>();
            SynFolders = new HashSet<SynFolder>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid StkVocationId { get; set; }
        public Guid? CfgCustomerId { get; set; }
        public Guid ComFolderStatusId { get; set; }
        public Guid? CfgCommercialId { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ItemPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPrice { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StatusValidityDate { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        [StringLength(255)]
        public string Usage { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CancelDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ModificationsAmount { get; set; }
        [StringLength(255)]
        public string PenalityDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceBeforeDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceAfterDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Price { get; set; }
        [Column("VATRatio", TypeName = "decimal(26, 6)")]
        public decimal? Vatratio { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalToPay { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDateReal { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryRatio { get; set; }
        public int? DeliveryMaxNumber { get; set; }
        public int? DeliveryNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryAmount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AgreementDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementSavingDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? OwnershipCertificateDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReceptionDate { get; set; }
        public bool? PriceWithModification { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreditApprovalDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreditPossessionDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AdvanceDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AgreementAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AgreementPrice { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComProspectionId { get; set; }
        public Guid? CfgLawyerId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PartPercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival1ValidityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival2ValidityDate { get; set; }
        [StringLength(255)]
        public string CreditAgency { get; set; }
        public Guid? CreditBankId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InsuranceDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BankRecordDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InterventionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementDatePrevisionel { get; set; }
        public bool? IsConfirmedAgreementDate { get; set; }
        public bool? IsOldCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiscountChangeDate { get; set; }
        [Column("loanCompanySendDate", TypeName = "datetime")]
        public DateTime? LoanCompanySendDate { get; set; }
        [Column("loanCompanyDecisionDate", TypeName = "datetime")]
        public DateTime? LoanCompanyDecisionDate { get; set; }
        public Guid? ComLoanCompanyDecisionId { get; set; }
        [Column(TypeName = "text")]
        public string ComDocumentDetail { get; set; }
        [StringLength(1000)]
        public string CancelDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservationDate { get; set; }
        public bool? IsWithGiftChoiceLater { get; set; }
        public Guid? CfgSaleManagerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementRegistryDate { get; set; }
        [Column("UnitCostHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitCostHt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrecisionActDate { get; set; }
        public Guid? StrEntityId { get; set; }
        [Column("ModificationsAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? ModificationsAmountHt { get; set; }
        [Column("ItemPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceHt { get; set; }
        [Column("UnderItemsPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPriceHt { get; set; }
        [Column("PriceBeforeDiscountHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceBeforeDiscountHt { get; set; }
        [Column("ItemPriceAfterHT", TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceAfterHt { get; set; }
        [Column("UnderItemsPriceAfterHT", TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPriceAfterHt { get; set; }
        [Column("PriceAfterDiscountHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceAfterDiscountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceAfter { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPriceAfter { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? GlobalArea { get; set; }
        public bool? IsAccounted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservationDateCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementSavingDateCustomer { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDateRealCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrecisionActDateCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservationRegistryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryRegistryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrecisionActRegistryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractPrintDate { get; set; }
        public Guid? CfgSaleManager2Id { get; set; }
        public Guid? CfgOwnerId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommissionRate { get; set; }
        public Guid? ComPaymentMethodId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProbabilityOfFinalisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RomInterest { get; set; }

        [ForeignKey(nameof(CfgCommercialId))]
        [InverseProperty(nameof(CfgTier.ComFolderCfgCommercials))]
        public virtual CfgTier CfgCommercial { get; set; }
        [ForeignKey(nameof(CfgCustomerId))]
        [InverseProperty(nameof(CfgTier.ComFolderCfgCustomers))]
        public virtual CfgTier CfgCustomer { get; set; }
        [ForeignKey(nameof(CfgLawyerId))]
        [InverseProperty(nameof(CfgTier.ComFolderCfgLawyers))]
        public virtual CfgTier CfgLawyer { get; set; }
        [ForeignKey(nameof(CfgOwnerId))]
        [InverseProperty(nameof(CfgTier.ComFolderCfgOwners))]
        public virtual CfgTier CfgOwner { get; set; }
        [ForeignKey(nameof(CfgSaleManagerId))]
        [InverseProperty(nameof(CfgTier.ComFolderCfgSaleManagers))]
        public virtual CfgTier CfgSaleManager { get; set; }
        [ForeignKey(nameof(CfgSaleManager2Id))]
        [InverseProperty(nameof(CfgTier.ComFolderCfgSaleManager2s))]
        public virtual CfgTier CfgSaleManager2 { get; set; }
        [ForeignKey(nameof(ComFolderStatusId))]
        [InverseProperty("ComFolders")]
        public virtual ComFolderStatus ComFolderStatus { get; set; }
        [ForeignKey(nameof(ComLoanCompanyDecisionId))]
        [InverseProperty("ComFolders")]
        public virtual ComLoanCompanyDecision ComLoanCompanyDecision { get; set; }
        [ForeignKey(nameof(ComPaymentMethodId))]
        [InverseProperty("ComFolders")]
        public virtual ComPaymentMethod ComPaymentMethod { get; set; }
        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("ComFolders")]
        public virtual ComProspection ComProspection { get; set; }
        [ForeignKey(nameof(CreditBankId))]
        [InverseProperty(nameof(CfgTier.ComFolderCreditBanks))]
        public virtual CfgTier CreditBank { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComFolders")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("ComFolders")]
        public virtual StkVocation StkVocation { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("ComFolders")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(ActEntry.ComFolder))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(ActTier.ComFolder))]
        public virtual ICollection<ActTier> ActTiers { get; set; }
        [InverseProperty(nameof(AdmEvent.ComFolder))]
        public virtual ICollection<AdmEvent> AdmEvents { get; set; }
        [InverseProperty(nameof(BuyDocument.ComFolder))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComFolder))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComCommissionLine.ComFolder))]
        public virtual ICollection<ComCommissionLine> ComCommissionLines { get; set; }
        [InverseProperty(nameof(ComDocumentPaymentMethod.ComFolder))]
        public virtual ICollection<ComDocumentPaymentMethod> ComDocumentPaymentMethods { get; set; }
        [InverseProperty(nameof(ComDocument.ComFolder))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
        [InverseProperty(nameof(ComFolderCustomer.ComFolder))]
        public virtual ICollection<ComFolderCustomer> ComFolderCustomers { get; set; }
        [InverseProperty(nameof(ComFolderDocumentToAttach.ComFolder))]
        public virtual ICollection<ComFolderDocumentToAttach> ComFolderDocumentToAttaches { get; set; }
        [InverseProperty(nameof(ComFolderGift.ComFolder))]
        public virtual ICollection<ComFolderGift> ComFolderGifts { get; set; }
        [InverseProperty(nameof(ComFolderItem.ComFolder))]
        public virtual ICollection<ComFolderItem> ComFolderItems { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.ComFolder))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(ComModification.ComFolder))]
        public virtual ICollection<ComModification> ComModifications { get; set; }
        [InverseProperty(nameof(ComRecondictionHistory.ComFolder))]
        public virtual ICollection<ComRecondictionHistory> ComRecondictionHistories { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalCancellation.ComSale))]
        public virtual ICollection<ComSaleWithdrawalCancellation> ComSaleWithdrawalCancellations { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClient.ComSale))]
        public virtual ICollection<ComSaleWithdrawalClient> ComSaleWithdrawalClients { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProduct.ComSale))]
        public virtual ICollection<ComSaleWithdrawalProduct> ComSaleWithdrawalProducts { get; set; }
        [InverseProperty(nameof(RntDocument.ComFolder))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
        [InverseProperty(nameof(SavClaimGroup.ComFolder))]
        public virtual ICollection<SavClaimGroup> SavClaimGroups { get; set; }
        [InverseProperty(nameof(SavService.ComFolder))]
        public virtual ICollection<SavService> SavServices { get; set; }
        [InverseProperty(nameof(StlDocumentLine.ComFolder))]
        public virtual ICollection<StlDocumentLine> StlDocumentLines { get; set; }
        [InverseProperty(nameof(StlItem.ComFolder))]
        public virtual ICollection<StlItem> StlItems { get; set; }
        [InverseProperty(nameof(StlRecoveryFolder.ComFolder))]
        public virtual ICollection<StlRecoveryFolder> StlRecoveryFolders { get; set; }
        [InverseProperty(nameof(SynFolder.ComFolder))]
        public virtual ICollection<SynFolder> SynFolders { get; set; }
    }
}
