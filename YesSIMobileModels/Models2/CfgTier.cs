using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [JsonObject(MemberSerialization.OptIn)]
    [Table("CfgTier")]
    [Index(nameof(Pkey), Name = "_dta_index_CfgTier_5_930102354__K1_2_4")]
    [Index(nameof(Pkey), Name = "_dta_index_CfgTier_5_930102354__K1_4_5_9")]
    [Index(nameof(Pkey), nameof(Description), Name = "_dta_index_CfgTier_5_930102354__K1_K4")]
    [Index(nameof(Pkey), nameof(AdmTierTitleId), Name = "_dta_index_CfgTier_5_930102354__K1_K84_4")]
    [Index(nameof(CfgTierTypeId), nameof(AdmCityId), Name = "_dta_index_CfgTier_5_930102354__K78_K112_1_2_4_5_6_7_8_9_10_12_13_14_18_19_20_21_22_23_24_25_39_40_48_49_51_52_53_66_67_69_74_")]
    [Index(nameof(CfgTierTypeId), nameof(Pkey), nameof(Description), Name = "_dta_index_CfgTier_5_930102354__K78_K1_K4")]
    [Index(nameof(Pkey), Name = "_dta_index_CfgTier_7_930102354__K1_4_5_9_13_24_25_51_107_108")]
    public partial class CfgTier
    {
        public CfgTier()
        {
            ActTiers = new HashSet<ActTier>();
            AdmEvents = new HashSet<AdmEvent>();
            AdmMailingTierCcs = new HashSet<AdmMailing>();
            AdmMailingTierTos = new HashSet<AdmMailing>();
            AdmUsers = new HashSet<AdmUser2>();
            BulDelegateContacts = new HashSet<BulDelegateContact>();
            BulDelegates = new HashSet<BulDelegate>();
            BulMeetingContacts = new HashSet<BulMeetingContact>();
            BulMeetingLines = new HashSet<BulMeetingLine>();
            BulMeetings = new HashSet<BulMeeting>();
            BuyConsultationOfferSuppliers = new HashSet<BuyConsultationOfferSupplier>();
            BuyConsultationOffers = new HashSet<BuyConsultationOffer>();
            BuyConsultations = new HashSet<BuyConsultation>();
            BuyDocumentCfgTierTriggers = new HashSet<BuyDocument>();
            BuyDocumentCfgTiers = new HashSet<BuyDocument>();
            BuyRequests = new HashSet<BuyRequest>();
            BuySelectionSuppliers = new HashSet<BuySelectionSupplier>();
            BuySelections = new HashSet<BuySelection>();
            CfgCompanyAdmSignatories = new HashSet<CfgCompany>();
            CfgCompanyCfgSalesManagers = new HashSet<CfgCompany>();
            CfgCompanyCfgTechnicalManagers = new HashSet<CfgCompany>();
            CfgCompanyCfgTiers = new HashSet<CfgCompany>();
            CfgProjectAdmSignatories = new HashSet<CfgProject>();
            CfgProjectCfgSalesManagers = new HashSet<CfgProject>();
            CfgProjectCfgTechnicalManagers = new HashSet<CfgProject>();
            CfgTierContactCfgContacts = new HashSet<CfgTierContact>();
            CfgTierContactCfgTiers = new HashSet<CfgTierContact>();
            CfgTierVatExonarations = new HashSet<CfgTierVatExonaration>();
            CfgTrancheCfgClaimsManagers = new HashSet<CfgTranche>();
            CfgTrancheCfgTierOthers = new HashSet<CfgTranche>();
            ComActionMessageCfgEmployees = new HashSet<ComActionMessage>();
            ComActionMessageCfgTiers = new HashSet<ComActionMessage>();
            ComActions = new HashSet<ComAction>();
            ComCommissionLines = new HashSet<ComCommissionLine>();
            ComDocumentCfgContacts = new HashSet<ComDocument>();
            ComDocumentCfgDebtCollectors = new HashSet<ComDocument>();
            ComFolderCfgCommercials = new HashSet<ComFolder>();
            ComFolderCfgCustomers = new HashSet<ComFolder>();
            ComFolderCfgLawyers = new HashSet<ComFolder>();
            ComFolderCfgOwners = new HashSet<ComFolder>();
            ComFolderCfgSaleManager2s = new HashSet<ComFolder>();
            ComFolderCfgSaleManagers = new HashSet<ComFolder>();
            ComFolderCreditBanks = new HashSet<ComFolder>();
            ComFolderCustomers = new HashSet<ComFolderCustomer>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            ComOffers = new HashSet<ComOffer>();
            ComProspectionCfgCommercials = new HashSet<ComProspection>();
            ComProspectionCfgIntermediates = new HashSet<ComProspection>();
            ComProspectionCfgProposers = new HashSet<ComProspection>();
            ComProspectionCfgProspects = new HashSet<ComProspection>();
            ComSaleWithdrawalCancellationCfgBanks = new HashSet<ComSaleWithdrawalCancellation>();
            ComSaleWithdrawalCancellationCfgContacts = new HashSet<ComSaleWithdrawalCancellation>();
            ComSaleWithdrawalCancellationCfgOldCustomers = new HashSet<ComSaleWithdrawalCancellation>();
            ComSaleWithdrawalClientCfgCustomers = new HashSet<ComSaleWithdrawalClient>();
            ComSaleWithdrawalClientCfgOldCustomers = new HashSet<ComSaleWithdrawalClient>();
            ComSaleWithdrawalClientNewCustomers = new HashSet<ComSaleWithdrawalClientNewCustomer>();
            ComSaleWithdrawalClientOldCustomers = new HashSet<ComSaleWithdrawalClientOldCustomer>();
            ComSaleWithdrawalProducts = new HashSet<ComSaleWithdrawalProduct>();
            ComSalesCommissionCfgTiers = new HashSet<ComSalesCommission>();
            ComSalesCommissionComEmployees = new HashSet<ComSalesCommission>();
            ComSettlements = new HashSet<ComSettlement>();
            GrhAdvances = new HashSet<GrhAdvance>();
            GrhCredits = new HashSet<GrhCredit>();
            GrhDepartments = new HashSet<GrhDepartment>();
            GrhDisciplines = new HashSet<GrhDiscipline>();
            GrhEmployeeHistories = new HashSet<GrhEmployeeHistory>();
            GrhOverTimes = new HashSet<GrhOverTime>();
            GrhPaySlips = new HashSet<GrhPaySlip>();
            GrhResignations = new HashSet<GrhResignation>();
            GrhTerminations = new HashSet<GrhTermination>();
            GrhVacationGroupGrhEmployees = new HashSet<GrhVacationGroupGrhEmployee>();
            GrhVacations = new HashSet<GrhVacation>();
            GrhWorkedDayCfgCustomers = new HashSet<GrhWorkedDay>();
            GrhWorkedDayCfgEmployees = new HashSet<GrhWorkedDay>();
            InverseCfgBank = new HashSet<CfgTier>();
            InverseCfgCommercial = new HashSet<CfgTier>();
            InverseCfgContact = new HashSet<CfgTier>();
            LndLandCfgLawyers = new HashSet<LndLand>();
            LndLandCfgMiddlemen = new HashSet<LndLand>();
            LndLandCfgSuppliers = new HashSet<LndLand>();
            PrjClauses = new HashSet<PrjClause>();
            PrjMarketOfferSuppliers = new HashSet<PrjMarketOfferSupplier>();
            PrjMarketOffers = new HashSet<PrjMarketOffer>();
            PrjMarketReceptionCfgTiers = new HashSet<PrjMarketReceptionCfgTier>();
            PrjProjects = new HashSet<PrjProject>();
            PrjWorkingOuts = new HashSet<PrjWorkingOut>();
            PrmRequestOfferCfgCommercials = new HashSet<PrmRequestOffer>();
            PrmRequestOfferCfgCustomers = new HashSet<PrmRequestOffer>();
            PrmRequestOfferCfgIntermediates = new HashSet<PrmRequestOffer>();
            PrmRequestOfferCfgOwners = new HashSet<PrmRequestOffer>();
            PrmRequestOfferCfgProposers = new HashSet<PrmRequestOffer>();
            PrmRequestOfferCfgTiers = new HashSet<PrmRequestOffer>();
            RntDocuments = new HashSet<RntDocument>();
            RntFolderCfgCommercials = new HashSet<RntFolder>();
            RntFolderCfgCustomers = new HashSet<RntFolder>();
            RntFolderCfgLawyers = new HashSet<RntFolder>();
            RntFolderCfgOwners = new HashSet<RntFolder>();
            RntFolderCfgTierBailiffs = new HashSet<RntFolder>();
            RntRevivals = new HashSet<RntRevival>();
            RntSettlements = new HashSet<RntSettlement>();
            SavClaimGroups = new HashSet<SavClaimGroup>();
            SavClaims = new HashSet<SavClaim>();
            SavServices = new HashSet<SavService>();
            StkItemCfgLawyers = new HashSet<StkItem>();
            StkItemCfgMiddlemen = new HashSet<StkItem>();
            StkItemCfgOwners = new HashSet<StkItem>();
            StkItemCfgSuppliers = new HashSet<StkItem>();
            StlAccountingEntries = new HashSet<StlAccountingEntry>();
            StlAccounts = new HashSet<StlAccount>();
            StlAcountDepositGrhEmployeeClosings = new HashSet<StlAcountDeposit>();
            StlAcountDepositGrhEmployees = new HashSet<StlAcountDeposit>();
            StlDocumentCfgDebtCollectors = new HashSet<StlDocument>();
            StlDocumentCfgTiers = new HashSet<StlDocument>();
            StlInternalTransferCfgTierEmissions = new HashSet<StlInternalTransfer>();
            StlInternalTransferCfgTierReceptions = new HashSet<StlInternalTransfer>();
            StlInternalTransferCfgTierTransmissions = new HashSet<StlInternalTransfer>();
            StlPaymentAuthorizationCfgTierOthers = new HashSet<StlPaymentAuthorization>();
            StlPaymentAuthorizationCfgTiers = new HashSet<StlPaymentAuthorization>();
            StlRecoveryFolderCfgCustomers = new HashSet<StlRecoveryFolder>();
            StlRecoveryFolderCfgDebtCollectors = new HashSet<StlRecoveryFolder>();
            StlRecoveryFolderCfgDebtManagers = new HashSet<StlRecoveryFolder>();
            StlSettlementCfgBanks = new HashSet<StlSettlement>();
            StlSettlementCfgLawyers = new HashSet<StlSettlement>();
            StlSettlementCfgTierOthers = new HashSet<StlSettlement>();
            StlSettlementTierPayers = new HashSet<StlSettlement>();
            StlSettlementTiers = new HashSet<StlSettlement>();
            StlSlipCfgTierEmissions = new HashSet<StlSlip>();
            StlSlipCfgTierTransmissions = new HashSet<StlSlip>();
            StlTransmissionSheetCfgTierEmissions = new HashSet<StlTransmissionSheet>();
            StlTransmissionSheetCfgTierReceptions = new HashSet<StlTransmissionSheet>();
            StlTransmissionSheetCfgTierTransmissions = new HashSet<StlTransmissionSheet>();
            SynFolderCfgCommercials = new HashSet<SynFolder>();
            SynFolderCfgCustomers = new HashSet<SynFolder>();
            SynFolderCfgLawyers = new HashSet<SynFolder>();
            SynFolderCfgTierBailiffs = new HashSet<SynFolder>();
        }

        [Key]
        [Column("PKey")]
        [JsonProperty]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string Code { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string Description { get; set; }
        [StringLength(30)]
        [JsonProperty]
        public string Phone { get; set; }
        [StringLength(30)]
        public string Phone1 { get; set; }
        [StringLength(30)]
        public string Phone2 { get; set; }
        [StringLength(30)]
        public string Fax { get; set; }
        [StringLength(30)]
        [JsonProperty]
        public string Mobile { get; set; }
        [Column("EMail")]
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string WebSite { get; set; }
        [StringLength(255)]
        public string SocialReason { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string BankAgency { get; set; }
        [StringLength(255)]
        public string Rib { get; set; }
        [StringLength(255)]
        public string Iban { get; set; }
        [StringLength(255)]
        public string FiscalCode { get; set; }
        [StringLength(255)]
        public string FiscalRegistry { get; set; }
        [StringLength(255)]
        public string FiscalDouane { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string FirstName { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string LastName { get; set; }
        [StringLength(255)]
        public string BirthPlace { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        public int? NbrChildren { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Asset { get; set; }
        [StringLength(100)]
        public string Quality { get; set; }
        [Column("IDNumber")]
        [StringLength(255)]
        public string Idnumber { get; set; }
        [Column("IDDate", TypeName = "datetime")]
        public DateTime? Iddate { get; set; }
        [Column("IDPlace")]
        [StringLength(255)]
        public string Idplace { get; set; }
        [Column("IDValidateDate", TypeName = "datetime")]
        public DateTime? IdvalidateDate { get; set; }
        [Column("IDValidatePlace")]
        [StringLength(255)]
        public string IdvalidatePlace { get; set; }
        public bool? IsProspect { get; set; }
        public Guid? CfgBankId { get; set; }
        [JsonProperty]
        public Guid? CfgCommercialId { get; set; }
        public Guid? CfgContactId { get; set; }
        [StringLength(255)]
        public string CodeCountable { get; set; }
        public Guid? CfgTierTypeId { get; set; }
        public Guid? CfgTierKindId { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [JsonProperty]
        public Guid? AdmTierTitleId { get; set; }
        [StringLength(255)]
        public string FatherName { get; set; }
        [StringLength(255)]
        public string MotherName { get; set; }
        [StringLength(255)]
        public string Employer { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Address3 { get; set; }
        [StringLength(255)]
        public string ZipCode { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        public int? Antiquity { get; set; }
        public Guid? AdmCountryId { get; set; }
        public Guid? AdmCountryResidenceId { get; set; }
        public Guid? AdmSocialFormId { get; set; }
        public Guid? AdmLiabilityId { get; set; }
        public Guid? AdmFamilySituationId { get; set; }
        public Guid? AdmResidenceTypeId { get; set; }
        public Guid? AdmMatrimonialRegimeId { get; set; }
        public Guid? AdmIdentityDocumentTypeId { get; set; }
        public Guid? AdmSexTypeId { get; set; }
        public Guid? AdmNationalityId { get; set; }
        public Guid? AdmProfessionId { get; set; }
        public Guid? AdmSalaryId { get; set; }
        [StringLength(10)]
        public string MobileIndicatif { get; set; }
        [StringLength(10)]
        public string PhoneIndicatif { get; set; }
        [StringLength(10)]
        public string Phone1Indicatif { get; set; }
        [StringLength(10)]
        public string Phone2Indicatif { get; set; }
        [StringLength(10)]
        public string FaxIndicatif { get; set; }
        public Guid? AdmCityId { get; set; }
        [StringLength(255)]
        public string CodeCountableCollective { get; set; }
        public Guid? AdmRankId { get; set; }
        public bool? IsOldCustomer { get; set; }
        public bool? IsExtern { get; set; }
        [Column("ICE")]
        [StringLength(255)]
        public string Ice { get; set; }
        public bool? IsRntCustomer { get; set; }
        public bool? IsVisibleInList { get; set; }
        public Guid? ActAccountId { get; set; }
        public Guid? ActJournalId { get; set; }
        public Guid? GrhDepartmentId { get; set; }
        public Guid? GrhEmployeeCategoryId { get; set; }
        public Guid? GrhEchelonId { get; set; }
        public Guid? GrhAgreementTypeId { get; set; }
        [StringLength(255)]
        public string SocialSecurityNumber { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? GrhPaySlipModelId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HireDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FireDate { get; set; }
        public int? NbrChildrenHandicap { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalaryBase { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseWorkedDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVacationDaysNumber { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RsRatio { get; set; }
        public bool? IsFundReader { get; set; }
        [Column("VATRatio", TypeName = "decimal(26, 6)")]
        public decimal? Vatratio { get; set; }

        [ForeignKey(nameof(ActAccountId))]
        [InverseProperty("CfgTiers")]
        public virtual ActAccount ActAccount { get; set; }
        [ForeignKey(nameof(ActJournalId))]
        [InverseProperty("CfgTiers")]
        public virtual ActJournal ActJournal { get; set; }
        [ForeignKey(nameof(AdmCityId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmCity AdmCity { get; set; }
        [ForeignKey(nameof(AdmCountryId))]
        [InverseProperty("CfgTierAdmCountries")]
        public virtual AdmCountry AdmCountry { get; set; }
        [ForeignKey(nameof(AdmCountryResidenceId))]
        [InverseProperty("CfgTierAdmCountryResidences")]
        public virtual AdmCountry AdmCountryResidence { get; set; }
        [ForeignKey(nameof(AdmFamilySituationId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmFamilySituation AdmFamilySituation { get; set; }
        [ForeignKey(nameof(AdmIdentityDocumentTypeId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmIdentityDocumentType AdmIdentityDocumentType { get; set; }
        [ForeignKey(nameof(AdmLiabilityId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmLiability AdmLiability { get; set; }
        [ForeignKey(nameof(AdmMatrimonialRegimeId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmMatrimonialRegime AdmMatrimonialRegime { get; set; }
        [ForeignKey(nameof(AdmNationalityId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmNationality AdmNationality { get; set; }
        [ForeignKey(nameof(AdmProfessionId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmProfession AdmProfession { get; set; }
        [ForeignKey(nameof(AdmRankId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmRank AdmRank { get; set; }
        [ForeignKey(nameof(AdmResidenceTypeId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmResidenceType AdmResidenceType { get; set; }
        [ForeignKey(nameof(AdmSalaryId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmSalary AdmSalary { get; set; }
        [ForeignKey(nameof(AdmSexTypeId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmSexType AdmSexType { get; set; }
        [ForeignKey(nameof(AdmSocialFormId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmSocialForm AdmSocialForm { get; set; }
        [ForeignKey(nameof(AdmTierTitleId))]
        [InverseProperty("CfgTiers")]
        public virtual AdmTierTitle AdmTierTitle { get; set; }
        [ForeignKey(nameof(CfgBankId))]
        [InverseProperty(nameof(CfgTier.InverseCfgBank))]
        public virtual CfgTier CfgBank { get; set; }
        [ForeignKey(nameof(CfgCommercialId))]
        [InverseProperty(nameof(CfgTier.InverseCfgCommercial))]
        public virtual CfgTier CfgCommercial { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("CfgTiers")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgContactId))]
        [InverseProperty(nameof(CfgTier.InverseCfgContact))]
        public virtual CfgTier CfgContact { get; set; }
        [ForeignKey(nameof(CfgTierKindId))]
        [InverseProperty("CfgTiers")]
        public virtual CfgTierKind CfgTierKind { get; set; }
        [ForeignKey(nameof(CfgTierTypeId))]
        [InverseProperty("CfgTiers")]
        public virtual CfgTierType CfgTierType { get; set; }
        [ForeignKey(nameof(GrhAgreementTypeId))]
        [InverseProperty("CfgTiers")]
        public virtual GrhAgreementType GrhAgreementType { get; set; }
        [ForeignKey(nameof(GrhDepartmentId))]
        [InverseProperty("CfgTiers")]
        public virtual GrhDepartment GrhDepartment { get; set; }
        [ForeignKey(nameof(GrhEchelonId))]
        [InverseProperty("CfgTiers")]
        public virtual GrhEchelon GrhEchelon { get; set; }
        [ForeignKey(nameof(GrhEmployeeCategoryId))]
        [InverseProperty("CfgTiers")]
        public virtual GrhEmployeeCategory GrhEmployeeCategory { get; set; }
        [ForeignKey(nameof(GrhPaySlipModelId))]
        [InverseProperty("CfgTiers")]
        public virtual GrhPaySlipModel GrhPaySlipModel { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("CfgTiers")]
        public virtual StlCurrency StlCurrency { get; set; }
        [InverseProperty(nameof(ActTier.CfgTier))]
        public virtual ICollection<ActTier> ActTiers { get; set; }
        [InverseProperty(nameof(AdmEvent.CfgEmloyee))]
        public virtual ICollection<AdmEvent> AdmEvents { get; set; }
        [InverseProperty(nameof(AdmMailing.TierCc))]
        public virtual ICollection<AdmMailing> AdmMailingTierCcs { get; set; }
        [InverseProperty(nameof(AdmMailing.TierTo))]
        public virtual ICollection<AdmMailing> AdmMailingTierTos { get; set; }
        [InverseProperty(nameof(AdmUser2.CfgEmployee))]
        public virtual ICollection<AdmUser2> AdmUsers { get; set; }
        [InverseProperty(nameof(BulDelegateContact.Contact))]
        public virtual ICollection<BulDelegateContact> BulDelegateContacts { get; set; }
        [InverseProperty(nameof(BulDelegate.CfgSupplier))]
        public virtual ICollection<BulDelegate> BulDelegates { get; set; }
        [InverseProperty(nameof(BulMeetingContact.Contact))]
        public virtual ICollection<BulMeetingContact> BulMeetingContacts { get; set; }
        [InverseProperty(nameof(BulMeetingLine.CfgSupplier))]
        public virtual ICollection<BulMeetingLine> BulMeetingLines { get; set; }
        [InverseProperty(nameof(BulMeeting.CfgEmployee))]
        public virtual ICollection<BulMeeting> BulMeetings { get; set; }
        [InverseProperty(nameof(BuyConsultationOfferSupplier.CfgTier))]
        public virtual ICollection<BuyConsultationOfferSupplier> BuyConsultationOfferSuppliers { get; set; }
        [InverseProperty(nameof(BuyConsultationOffer.CfgSupplier))]
        public virtual ICollection<BuyConsultationOffer> BuyConsultationOffers { get; set; }
        [InverseProperty(nameof(BuyConsultation.CfgTier))]
        public virtual ICollection<BuyConsultation> BuyConsultations { get; set; }
        [InverseProperty(nameof(BuyDocument.CfgTierTrigger))]
        public virtual ICollection<BuyDocument> BuyDocumentCfgTierTriggers { get; set; }
        [InverseProperty(nameof(BuyDocument.CfgTier))]
        public virtual ICollection<BuyDocument> BuyDocumentCfgTiers { get; set; }
        [InverseProperty(nameof(BuyRequest.GrhEmployee))]
        public virtual ICollection<BuyRequest> BuyRequests { get; set; }
        [InverseProperty(nameof(BuySelectionSupplier.CfgTier))]
        public virtual ICollection<BuySelectionSupplier> BuySelectionSuppliers { get; set; }
        [InverseProperty(nameof(BuySelection.CfgTier))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty("AdmSignatory")]
        public virtual ICollection<CfgCompany> CfgCompanyAdmSignatories { get; set; }
        [InverseProperty("CfgSalesManager")]
        public virtual ICollection<CfgCompany> CfgCompanyCfgSalesManagers { get; set; }
        [InverseProperty("CfgTechnicalManager")]
        public virtual ICollection<CfgCompany> CfgCompanyCfgTechnicalManagers { get; set; }
        [InverseProperty("CfgTier")]
        public virtual ICollection<CfgCompany> CfgCompanyCfgTiers { get; set; }
        [InverseProperty(nameof(CfgProject.AdmSignatory))]
        public virtual ICollection<CfgProject> CfgProjectAdmSignatories { get; set; }
        [InverseProperty(nameof(CfgProject.CfgSalesManager))]
        public virtual ICollection<CfgProject> CfgProjectCfgSalesManagers { get; set; }
        [InverseProperty(nameof(CfgProject.CfgTechnicalManager))]
        public virtual ICollection<CfgProject> CfgProjectCfgTechnicalManagers { get; set; }
        [InverseProperty(nameof(CfgTierContact.CfgContact))]
        public virtual ICollection<CfgTierContact> CfgTierContactCfgContacts { get; set; }
        [InverseProperty(nameof(CfgTierContact.CfgTier))]
        public virtual ICollection<CfgTierContact> CfgTierContactCfgTiers { get; set; }
        [InverseProperty(nameof(CfgTierVatExonaration.CfgTier))]
        public virtual ICollection<CfgTierVatExonaration> CfgTierVatExonarations { get; set; }
        [InverseProperty(nameof(CfgTranche.CfgClaimsManager))]
        public virtual ICollection<CfgTranche> CfgTrancheCfgClaimsManagers { get; set; }
        [InverseProperty(nameof(CfgTranche.CfgTierOther))]
        public virtual ICollection<CfgTranche> CfgTrancheCfgTierOthers { get; set; }
        [InverseProperty(nameof(ComActionMessage.CfgEmployee))]
        public virtual ICollection<ComActionMessage> ComActionMessageCfgEmployees { get; set; }
        [InverseProperty(nameof(ComActionMessage.CfgTier))]
        public virtual ICollection<ComActionMessage> ComActionMessageCfgTiers { get; set; }
        [InverseProperty(nameof(ComAction.CfgEmployee))]
        public virtual ICollection<ComAction> ComActions { get; set; }
        [InverseProperty(nameof(ComCommissionLine.CfgEmployee))]
        public virtual ICollection<ComCommissionLine> ComCommissionLines { get; set; }
        [InverseProperty(nameof(ComDocument.CfgContact))]
        public virtual ICollection<ComDocument> ComDocumentCfgContacts { get; set; }
        [InverseProperty(nameof(ComDocument.CfgDebtCollector))]
        public virtual ICollection<ComDocument> ComDocumentCfgDebtCollectors { get; set; }
        [InverseProperty(nameof(ComFolder.CfgCommercial))]
        public virtual ICollection<ComFolder> ComFolderCfgCommercials { get; set; }
        [InverseProperty(nameof(ComFolder.CfgCustomer))]
        public virtual ICollection<ComFolder> ComFolderCfgCustomers { get; set; }
        [InverseProperty(nameof(ComFolder.CfgLawyer))]
        public virtual ICollection<ComFolder> ComFolderCfgLawyers { get; set; }
        [InverseProperty(nameof(ComFolder.CfgOwner))]
        public virtual ICollection<ComFolder> ComFolderCfgOwners { get; set; }
        [InverseProperty(nameof(ComFolder.CfgSaleManager2))]
        public virtual ICollection<ComFolder> ComFolderCfgSaleManager2s { get; set; }
        [InverseProperty(nameof(ComFolder.CfgSaleManager))]
        public virtual ICollection<ComFolder> ComFolderCfgSaleManagers { get; set; }
        [InverseProperty(nameof(ComFolder.CreditBank))]
        public virtual ICollection<ComFolder> ComFolderCreditBanks { get; set; }
        [InverseProperty(nameof(ComFolderCustomer.CfgTier))]
        public virtual ICollection<ComFolderCustomer> ComFolderCustomers { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.CfgTier))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(ComOffer.CfgTier))]
        public virtual ICollection<ComOffer> ComOffers { get; set; }
        [InverseProperty(nameof(ComProspection.CfgCommercial))]
        public virtual ICollection<ComProspection> ComProspectionCfgCommercials { get; set; }
        [InverseProperty(nameof(ComProspection.CfgIntermediate))]
        public virtual ICollection<ComProspection> ComProspectionCfgIntermediates { get; set; }
        [InverseProperty(nameof(ComProspection.CfgProposer))]
        public virtual ICollection<ComProspection> ComProspectionCfgProposers { get; set; }
        [InverseProperty(nameof(ComProspection.CfgProspect))]
        public virtual ICollection<ComProspection> ComProspectionCfgProspects { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalCancellation.CfgBank))]
        public virtual ICollection<ComSaleWithdrawalCancellation> ComSaleWithdrawalCancellationCfgBanks { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalCancellation.CfgContact))]
        public virtual ICollection<ComSaleWithdrawalCancellation> ComSaleWithdrawalCancellationCfgContacts { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalCancellation.CfgOldCustomer))]
        public virtual ICollection<ComSaleWithdrawalCancellation> ComSaleWithdrawalCancellationCfgOldCustomers { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClient.CfgCustomer))]
        public virtual ICollection<ComSaleWithdrawalClient> ComSaleWithdrawalClientCfgCustomers { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClient.CfgOldCustomer))]
        public virtual ICollection<ComSaleWithdrawalClient> ComSaleWithdrawalClientCfgOldCustomers { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClientNewCustomer.CfgTier))]
        public virtual ICollection<ComSaleWithdrawalClientNewCustomer> ComSaleWithdrawalClientNewCustomers { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClientOldCustomer.CfgTier))]
        public virtual ICollection<ComSaleWithdrawalClientOldCustomer> ComSaleWithdrawalClientOldCustomers { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProduct.CfgCustomer))]
        public virtual ICollection<ComSaleWithdrawalProduct> ComSaleWithdrawalProducts { get; set; }
        [InverseProperty(nameof(ComSalesCommission.CfgTier))]
        public virtual ICollection<ComSalesCommission> ComSalesCommissionCfgTiers { get; set; }
        [InverseProperty(nameof(ComSalesCommission.ComEmployee))]
        public virtual ICollection<ComSalesCommission> ComSalesCommissionComEmployees { get; set; }
        [InverseProperty(nameof(ComSettlement.CfgTier))]
        public virtual ICollection<ComSettlement> ComSettlements { get; set; }
        [InverseProperty(nameof(GrhAdvance.GrhEmployee))]
        public virtual ICollection<GrhAdvance> GrhAdvances { get; set; }
        [InverseProperty(nameof(GrhCredit.GrhEmployee))]
        public virtual ICollection<GrhCredit> GrhCredits { get; set; }
        [InverseProperty("GrhManager")]
        public virtual ICollection<GrhDepartment> GrhDepartments { get; set; }
        [InverseProperty(nameof(GrhDiscipline.GrhEmployee))]
        public virtual ICollection<GrhDiscipline> GrhDisciplines { get; set; }
        [InverseProperty(nameof(GrhEmployeeHistory.GrhEmployee))]
        public virtual ICollection<GrhEmployeeHistory> GrhEmployeeHistories { get; set; }
        [InverseProperty(nameof(GrhOverTime.GrhEmployee))]
        public virtual ICollection<GrhOverTime> GrhOverTimes { get; set; }
        [InverseProperty(nameof(GrhPaySlip.GrhEmployee))]
        public virtual ICollection<GrhPaySlip> GrhPaySlips { get; set; }
        [InverseProperty(nameof(GrhResignation.GrhEmployee))]
        public virtual ICollection<GrhResignation> GrhResignations { get; set; }
        [InverseProperty(nameof(GrhTermination.GrhEmployee))]
        public virtual ICollection<GrhTermination> GrhTerminations { get; set; }
        [InverseProperty(nameof(GrhVacationGroupGrhEmployee.GrhEmployee))]
        public virtual ICollection<GrhVacationGroupGrhEmployee> GrhVacationGroupGrhEmployees { get; set; }
        [InverseProperty(nameof(GrhVacation.GrhEmployee))]
        public virtual ICollection<GrhVacation> GrhVacations { get; set; }
        [InverseProperty(nameof(GrhWorkedDay.CfgCustomer))]
        public virtual ICollection<GrhWorkedDay> GrhWorkedDayCfgCustomers { get; set; }
        [InverseProperty(nameof(GrhWorkedDay.CfgEmployee))]
        public virtual ICollection<GrhWorkedDay> GrhWorkedDayCfgEmployees { get; set; }
        [InverseProperty(nameof(CfgTier.CfgBank))]
        public virtual ICollection<CfgTier> InverseCfgBank { get; set; }
        [InverseProperty(nameof(CfgTier.CfgCommercial))]
        public virtual ICollection<CfgTier> InverseCfgCommercial { get; set; }
        [InverseProperty(nameof(CfgTier.CfgContact))]
        public virtual ICollection<CfgTier> InverseCfgContact { get; set; }
        [InverseProperty(nameof(LndLand.CfgLawyer))]
        public virtual ICollection<LndLand> LndLandCfgLawyers { get; set; }
        [InverseProperty(nameof(LndLand.CfgMiddleman))]
        public virtual ICollection<LndLand> LndLandCfgMiddlemen { get; set; }
        [InverseProperty(nameof(LndLand.CfgSupplier))]
        public virtual ICollection<LndLand> LndLandCfgSuppliers { get; set; }
        [InverseProperty(nameof(PrjClause.CfgTier))]
        public virtual ICollection<PrjClause> PrjClauses { get; set; }
        [InverseProperty(nameof(PrjMarketOfferSupplier.CfgTier))]
        public virtual ICollection<PrjMarketOfferSupplier> PrjMarketOfferSuppliers { get; set; }
        [InverseProperty(nameof(PrjMarketOffer.CfgSupplier))]
        public virtual ICollection<PrjMarketOffer> PrjMarketOffers { get; set; }
        [InverseProperty(nameof(PrjMarketReceptionCfgTier.CfgTier))]
        public virtual ICollection<PrjMarketReceptionCfgTier> PrjMarketReceptionCfgTiers { get; set; }
        [InverseProperty(nameof(PrjProject.CfgTierManager))]
        public virtual ICollection<PrjProject> PrjProjects { get; set; }
        [InverseProperty(nameof(PrjWorkingOut.CfgTier))]
        public virtual ICollection<PrjWorkingOut> PrjWorkingOuts { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.CfgCommercial))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOfferCfgCommercials { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.CfgCustomer))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOfferCfgCustomers { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.CfgIntermediate))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOfferCfgIntermediates { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.CfgOwner))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOfferCfgOwners { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.CfgProposer))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOfferCfgProposers { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.CfgTier))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOfferCfgTiers { get; set; }
        [InverseProperty(nameof(RntDocument.CfgDebtCollector))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
        [InverseProperty(nameof(RntFolder.CfgCommercial))]
        public virtual ICollection<RntFolder> RntFolderCfgCommercials { get; set; }
        [InverseProperty(nameof(RntFolder.CfgCustomer))]
        public virtual ICollection<RntFolder> RntFolderCfgCustomers { get; set; }
        [InverseProperty(nameof(RntFolder.CfgLawyer))]
        public virtual ICollection<RntFolder> RntFolderCfgLawyers { get; set; }
        [InverseProperty(nameof(RntFolder.CfgOwner))]
        public virtual ICollection<RntFolder> RntFolderCfgOwners { get; set; }
        [InverseProperty(nameof(RntFolder.CfgTierBailiff))]
        public virtual ICollection<RntFolder> RntFolderCfgTierBailiffs { get; set; }
        [InverseProperty(nameof(RntRevival.CfgTier))]
        public virtual ICollection<RntRevival> RntRevivals { get; set; }
        [InverseProperty(nameof(RntSettlement.CfgTier))]
        public virtual ICollection<RntSettlement> RntSettlements { get; set; }
        [InverseProperty(nameof(SavClaimGroup.CfgClaimsManager))]
        public virtual ICollection<SavClaimGroup> SavClaimGroups { get; set; }
        [InverseProperty(nameof(SavClaim.CfgSupplier))]
        public virtual ICollection<SavClaim> SavClaims { get; set; }
        [InverseProperty(nameof(SavService.CfgServiceManager))]
        public virtual ICollection<SavService> SavServices { get; set; }
        [InverseProperty(nameof(StkItem.CfgLawyer))]
        public virtual ICollection<StkItem> StkItemCfgLawyers { get; set; }
        [InverseProperty(nameof(StkItem.CfgMiddleman))]
        public virtual ICollection<StkItem> StkItemCfgMiddlemen { get; set; }
        [InverseProperty(nameof(StkItem.CfgOwner))]
        public virtual ICollection<StkItem> StkItemCfgOwners { get; set; }
        [InverseProperty(nameof(StkItem.CfgSupplier))]
        public virtual ICollection<StkItem> StkItemCfgSuppliers { get; set; }
        [InverseProperty(nameof(StlAccountingEntry.CfgTier))]
        public virtual ICollection<StlAccountingEntry> StlAccountingEntries { get; set; }
        [InverseProperty(nameof(StlAccount.CfgBank))]
        public virtual ICollection<StlAccount> StlAccounts { get; set; }
        [InverseProperty(nameof(StlAcountDeposit.GrhEmployeeClosing))]
        public virtual ICollection<StlAcountDeposit> StlAcountDepositGrhEmployeeClosings { get; set; }
        [InverseProperty(nameof(StlAcountDeposit.GrhEmployee))]
        public virtual ICollection<StlAcountDeposit> StlAcountDepositGrhEmployees { get; set; }
        [InverseProperty(nameof(StlDocument.CfgDebtCollector))]
        public virtual ICollection<StlDocument> StlDocumentCfgDebtCollectors { get; set; }
        [InverseProperty(nameof(StlDocument.CfgTier))]
        public virtual ICollection<StlDocument> StlDocumentCfgTiers { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.CfgTierEmission))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransferCfgTierEmissions { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.CfgTierReception))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransferCfgTierReceptions { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.CfgTierTransmission))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransferCfgTierTransmissions { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorization.CfgTierOther))]
        public virtual ICollection<StlPaymentAuthorization> StlPaymentAuthorizationCfgTierOthers { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorization.CfgTier))]
        public virtual ICollection<StlPaymentAuthorization> StlPaymentAuthorizationCfgTiers { get; set; }
        [InverseProperty(nameof(StlRecoveryFolder.CfgCustomer))]
        public virtual ICollection<StlRecoveryFolder> StlRecoveryFolderCfgCustomers { get; set; }
        [InverseProperty(nameof(StlRecoveryFolder.CfgDebtCollector))]
        public virtual ICollection<StlRecoveryFolder> StlRecoveryFolderCfgDebtCollectors { get; set; }
        [InverseProperty(nameof(StlRecoveryFolder.CfgDebtManager))]
        public virtual ICollection<StlRecoveryFolder> StlRecoveryFolderCfgDebtManagers { get; set; }
        [InverseProperty(nameof(StlSettlement.CfgBank))]
        public virtual ICollection<StlSettlement> StlSettlementCfgBanks { get; set; }
        [InverseProperty(nameof(StlSettlement.CfgLawyer))]
        public virtual ICollection<StlSettlement> StlSettlementCfgLawyers { get; set; }
        [InverseProperty(nameof(StlSettlement.CfgTierOther))]
        public virtual ICollection<StlSettlement> StlSettlementCfgTierOthers { get; set; }
        [InverseProperty(nameof(StlSettlement.TierPayer))]
        public virtual ICollection<StlSettlement> StlSettlementTierPayers { get; set; }
        [InverseProperty(nameof(StlSettlement.Tier))]
        public virtual ICollection<StlSettlement> StlSettlementTiers { get; set; }
        [InverseProperty(nameof(StlSlip.CfgTierEmission))]
        public virtual ICollection<StlSlip> StlSlipCfgTierEmissions { get; set; }
        [InverseProperty(nameof(StlSlip.CfgTierTransmission))]
        public virtual ICollection<StlSlip> StlSlipCfgTierTransmissions { get; set; }
        [InverseProperty(nameof(StlTransmissionSheet.CfgTierEmission))]
        public virtual ICollection<StlTransmissionSheet> StlTransmissionSheetCfgTierEmissions { get; set; }
        [InverseProperty(nameof(StlTransmissionSheet.CfgTierReception))]
        public virtual ICollection<StlTransmissionSheet> StlTransmissionSheetCfgTierReceptions { get; set; }
        [InverseProperty(nameof(StlTransmissionSheet.CfgTierTransmission))]
        public virtual ICollection<StlTransmissionSheet> StlTransmissionSheetCfgTierTransmissions { get; set; }
        [InverseProperty(nameof(SynFolder.CfgCommercial))]
        public virtual ICollection<SynFolder> SynFolderCfgCommercials { get; set; }
        [InverseProperty(nameof(SynFolder.CfgCustomer))]
        public virtual ICollection<SynFolder> SynFolderCfgCustomers { get; set; }
        [InverseProperty(nameof(SynFolder.CfgLawyer))]
        public virtual ICollection<SynFolder> SynFolderCfgLawyers { get; set; }
        [InverseProperty(nameof(SynFolder.CfgTierBailiff))]
        public virtual ICollection<SynFolder> SynFolderCfgTierBailiffs { get; set; }
    }
}
