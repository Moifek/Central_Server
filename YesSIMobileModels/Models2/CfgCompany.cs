using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgCompany")]
    public partial class CfgCompany
    {
        public CfgCompany()
        {
            ActAccounts = new HashSet<ActAccount>();
            ActDefaultAccounts = new HashSet<ActDefaultAccount>();
            ActDefaultJournals = new HashSet<ActDefaultJournal>();
            ActDefaultSettlements = new HashSet<ActDefaultSettlement>();
            ActEntries = new HashSet<ActEntry>();
            ActJournals = new HashSet<ActJournal>();
            ActStockVariationCoefs = new HashSet<ActStockVariationCoef>();
            ActStockVariationExclusions = new HashSet<ActStockVariationExclusion>();
            ActTiers = new HashSet<ActTier>();
            AdmSequences = new HashSet<AdmSequence>();
            AdmUserHabilitations = new HashSet<AdmUserHabilitation>();
            BuyConsultations = new HashSet<BuyConsultation>();
            BuyDocuments = new HashSet<BuyDocument>();
            BuyLoans = new HashSet<BuyLoan>();
            BuySelections = new HashSet<BuySelection>();
            CfgCompanyShareholders = new HashSet<CfgCompanyShareholder>();
            CfgProjects = new HashSet<CfgProject>();
            CfgTierKinds = new HashSet<CfgTierKind>();
            CfgTiers = new HashSet<CfgTier>();
            ComDocumentPaymentMethods = new HashSet<ComDocumentPaymentMethod>();
            ComDocuments = new HashSet<ComDocument>();
            GrhAdvances = new HashSet<GrhAdvance>();
            GrhCredits = new HashSet<GrhCredit>();
            GrhDepartments = new HashSet<GrhDepartment>();
            GrhDisciplines = new HashSet<GrhDiscipline>();
            GrhEchelons = new HashSet<GrhEchelon>();
            GrhEmployeeCategories = new HashSet<GrhEmployeeCategory>();
            GrhEmployeeHistories = new HashSet<GrhEmployeeHistory>();
            GrhOverTimes = new HashSet<GrhOverTime>();
            GrhPaySlipModelUnityEntityValues = new HashSet<GrhPaySlipModelUnityEntityValue>();
            GrhPaySlips = new HashSet<GrhPaySlip>();
            GrhResignations = new HashSet<GrhResignation>();
            GrhTerminations = new HashSet<GrhTermination>();
            GrhVacationGroups = new HashSet<GrhVacationGroup>();
            GrhVacations = new HashSet<GrhVacation>();
            GrhWorkedDays = new HashSet<GrhWorkedDay>();
            PrjProjects = new HashSet<PrjProject>();
            PrvSettlementPrevisions = new HashSet<PrvSettlementPrevision>();
            PrvTurnoverPrevisions = new HashSet<PrvTurnoverPrevision>();
            RntDocuments = new HashSet<RntDocument>();
            SavServiceExpenses = new HashSet<SavServiceExpense>();
            StkFeasibilityStudies = new HashSet<StkFeasibilityStudy>();
            StkItemCfgCompanies = new HashSet<StkItem>();
            StkItemCfgCompanySyndics = new HashSet<StkItem>();
            StlAccountingEntries = new HashSet<StlAccountingEntry>();
            StlAccounts = new HashSet<StlAccount>();
            StlCategoryPrevisions = new HashSet<StlCategoryPrevision>();
            StlDeposits = new HashSet<StlDeposit>();
            StlDocuments = new HashSet<StlDocument>();
            StlInternalTransferCfgCompanies = new HashSet<StlInternalTransfer>();
            StlInternalTransferCfgCompanyTos = new HashSet<StlInternalTransfer>();
            StlItemPricings = new HashSet<StlItemPricing>();
            StlPaymentAuthorizations = new HashSet<StlPaymentAuthorization>();
            StlProjectVentilations = new HashSet<StlProjectVentilation>();
            StlRecoveryFolders = new HashSet<StlRecoveryFolder>();
            StlSettlements = new HashSet<StlSettlement>();
            StlSlips = new HashSet<StlSlip>();
            StlTrancheVentilations = new HashSet<StlTrancheVentilation>();
            StlTransmissionSheetCfgCompanyFroms = new HashSet<StlTransmissionSheet>();
            StlTransmissionSheetCfgCompanyTos = new HashSet<StlTransmissionSheet>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string FiscalNumber { get; set; }
        [StringLength(255)]
        public string CommercialRegister { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Mobile { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Fax { get; set; }
        [StringLength(255)]
        public string WebSite { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Address3 { get; set; }
        [StringLength(255)]
        public string ZipCode { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        [StringLength(255)]
        public string SignatureCity { get; set; }
        [StringLength(255)]
        public string LegalForm { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Capital { get; set; }
        [StringLength(255)]
        public string Cnss { get; set; }
        [StringLength(255)]
        public string Patent { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? AdmCountryId { get; set; }
        public Guid? AdmSignatoryId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public int? TotalSharing { get; set; }
        public Guid? CfgTechnicalManagerId { get; set; }
        public Guid? CfgSalesManagerId { get; set; }
        [StringLength(1000)]
        public string DescriptionLong { get; set; }
        [Column("ICE")]
        [StringLength(255)]
        public string Ice { get; set; }
        public int? SharingNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LiquidationDate { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? HomePart { get; set; }
        public Guid? CfgGroupShareholderId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StlCurrencyId { get; set; }

        [ForeignKey(nameof(AdmCountryId))]
        [InverseProperty("CfgCompanies")]
        public virtual AdmCountry AdmCountry { get; set; }
        [ForeignKey(nameof(AdmSignatoryId))]
        [InverseProperty("CfgCompanyAdmSignatories")]
        public virtual CfgTier AdmSignatory { get; set; }
        [ForeignKey(nameof(CfgGroupShareholderId))]
        [InverseProperty("CfgCompanies")]
        public virtual CfgGroupShareholder CfgGroupShareholder { get; set; }
        [ForeignKey(nameof(CfgSalesManagerId))]
        [InverseProperty("CfgCompanyCfgSalesManagers")]
        public virtual CfgTier CfgSalesManager { get; set; }
        [ForeignKey(nameof(CfgTechnicalManagerId))]
        [InverseProperty("CfgCompanyCfgTechnicalManagers")]
        public virtual CfgTier CfgTechnicalManager { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("CfgCompanyCfgTiers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("CfgCompanies")]
        public virtual StlCurrency StlCurrency { get; set; }
        [InverseProperty(nameof(ActAccount.CfgCompany))]
        public virtual ICollection<ActAccount> ActAccounts { get; set; }
        [InverseProperty(nameof(ActDefaultAccount.CfgCompany))]
        public virtual ICollection<ActDefaultAccount> ActDefaultAccounts { get; set; }
        [InverseProperty(nameof(ActDefaultJournal.CfgCompany))]
        public virtual ICollection<ActDefaultJournal> ActDefaultJournals { get; set; }
        [InverseProperty(nameof(ActDefaultSettlement.CfgCompany))]
        public virtual ICollection<ActDefaultSettlement> ActDefaultSettlements { get; set; }
        [InverseProperty(nameof(ActEntry.CfgCompany))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(ActJournal.CfgCompany))]
        public virtual ICollection<ActJournal> ActJournals { get; set; }
        [InverseProperty(nameof(ActStockVariationCoef.CfgCompany))]
        public virtual ICollection<ActStockVariationCoef> ActStockVariationCoefs { get; set; }
        [InverseProperty(nameof(ActStockVariationExclusion.CfgCompany))]
        public virtual ICollection<ActStockVariationExclusion> ActStockVariationExclusions { get; set; }
        [InverseProperty(nameof(ActTier.CfgCompany))]
        public virtual ICollection<ActTier> ActTiers { get; set; }
        [InverseProperty(nameof(AdmSequence.CfgCompany))]
        public virtual ICollection<AdmSequence> AdmSequences { get; set; }
        [InverseProperty(nameof(AdmUserHabilitation.CfgCompany))]
        public virtual ICollection<AdmUserHabilitation> AdmUserHabilitations { get; set; }
        [InverseProperty(nameof(BuyConsultation.CfgCompany))]
        public virtual ICollection<BuyConsultation> BuyConsultations { get; set; }
        [InverseProperty(nameof(BuyDocument.CfgCompany))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuyLoan.CfgCompany))]
        public virtual ICollection<BuyLoan> BuyLoans { get; set; }
        [InverseProperty(nameof(BuySelection.CfgCompany))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty(nameof(CfgCompanyShareholder.CfgCompany))]
        public virtual ICollection<CfgCompanyShareholder> CfgCompanyShareholders { get; set; }
        [InverseProperty(nameof(CfgProject.CfgCompany))]
        public virtual ICollection<CfgProject> CfgProjects { get; set; }
        [InverseProperty(nameof(CfgTierKind.CfgCompany))]
        public virtual ICollection<CfgTierKind> CfgTierKinds { get; set; }
        [InverseProperty("CfgCompany")]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
        [InverseProperty(nameof(ComDocumentPaymentMethod.CfgCompany))]
        public virtual ICollection<ComDocumentPaymentMethod> ComDocumentPaymentMethods { get; set; }
        [InverseProperty(nameof(ComDocument.CfgCompany))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
        [InverseProperty(nameof(GrhAdvance.CfgCompany))]
        public virtual ICollection<GrhAdvance> GrhAdvances { get; set; }
        [InverseProperty(nameof(GrhCredit.CfgCompany))]
        public virtual ICollection<GrhCredit> GrhCredits { get; set; }
        [InverseProperty(nameof(GrhDepartment.CfgCompany))]
        public virtual ICollection<GrhDepartment> GrhDepartments { get; set; }
        [InverseProperty(nameof(GrhDiscipline.CfgCompany))]
        public virtual ICollection<GrhDiscipline> GrhDisciplines { get; set; }
        [InverseProperty(nameof(GrhEchelon.CfgCompany))]
        public virtual ICollection<GrhEchelon> GrhEchelons { get; set; }
        [InverseProperty(nameof(GrhEmployeeCategory.CfgCompany))]
        public virtual ICollection<GrhEmployeeCategory> GrhEmployeeCategories { get; set; }
        [InverseProperty(nameof(GrhEmployeeHistory.CfgCompany))]
        public virtual ICollection<GrhEmployeeHistory> GrhEmployeeHistories { get; set; }
        [InverseProperty(nameof(GrhOverTime.CfgCompany))]
        public virtual ICollection<GrhOverTime> GrhOverTimes { get; set; }
        [InverseProperty(nameof(GrhPaySlipModelUnityEntityValue.CfgCompany))]
        public virtual ICollection<GrhPaySlipModelUnityEntityValue> GrhPaySlipModelUnityEntityValues { get; set; }
        [InverseProperty(nameof(GrhPaySlip.CfgCompany))]
        public virtual ICollection<GrhPaySlip> GrhPaySlips { get; set; }
        [InverseProperty(nameof(GrhResignation.CfgCompany))]
        public virtual ICollection<GrhResignation> GrhResignations { get; set; }
        [InverseProperty(nameof(GrhTermination.CfgCompany))]
        public virtual ICollection<GrhTermination> GrhTerminations { get; set; }
        [InverseProperty(nameof(GrhVacationGroup.CfgCompany))]
        public virtual ICollection<GrhVacationGroup> GrhVacationGroups { get; set; }
        [InverseProperty(nameof(GrhVacation.CfgCompany))]
        public virtual ICollection<GrhVacation> GrhVacations { get; set; }
        [InverseProperty(nameof(GrhWorkedDay.CfgCompany))]
        public virtual ICollection<GrhWorkedDay> GrhWorkedDays { get; set; }
        [InverseProperty(nameof(PrjProject.CfgCompany))]
        public virtual ICollection<PrjProject> PrjProjects { get; set; }
        [InverseProperty(nameof(PrvSettlementPrevision.CfgCompany))]
        public virtual ICollection<PrvSettlementPrevision> PrvSettlementPrevisions { get; set; }
        [InverseProperty(nameof(PrvTurnoverPrevision.CfgCompany))]
        public virtual ICollection<PrvTurnoverPrevision> PrvTurnoverPrevisions { get; set; }
        [InverseProperty(nameof(RntDocument.CfgCompany))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
        [InverseProperty(nameof(SavServiceExpense.CfgCompany))]
        public virtual ICollection<SavServiceExpense> SavServiceExpenses { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudy.CfgCompany))]
        public virtual ICollection<StkFeasibilityStudy> StkFeasibilityStudies { get; set; }
        [InverseProperty(nameof(StkItem.CfgCompany))]
        public virtual ICollection<StkItem> StkItemCfgCompanies { get; set; }
        [InverseProperty(nameof(StkItem.CfgCompanySyndic))]
        public virtual ICollection<StkItem> StkItemCfgCompanySyndics { get; set; }
        [InverseProperty(nameof(StlAccountingEntry.CfgCompany))]
        public virtual ICollection<StlAccountingEntry> StlAccountingEntries { get; set; }
        [InverseProperty(nameof(StlAccount.CfgCompany))]
        public virtual ICollection<StlAccount> StlAccounts { get; set; }
        [InverseProperty(nameof(StlCategoryPrevision.CfgCompany))]
        public virtual ICollection<StlCategoryPrevision> StlCategoryPrevisions { get; set; }
        [InverseProperty(nameof(StlDeposit.CfgCompany))]
        public virtual ICollection<StlDeposit> StlDeposits { get; set; }
        [InverseProperty(nameof(StlDocument.CfgCompany))]
        public virtual ICollection<StlDocument> StlDocuments { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.CfgCompany))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransferCfgCompanies { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.CfgCompanyTo))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransferCfgCompanyTos { get; set; }
        [InverseProperty(nameof(StlItemPricing.CfgCompany))]
        public virtual ICollection<StlItemPricing> StlItemPricings { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorization.CfgCompany))]
        public virtual ICollection<StlPaymentAuthorization> StlPaymentAuthorizations { get; set; }
        [InverseProperty(nameof(StlProjectVentilation.CfgCompany))]
        public virtual ICollection<StlProjectVentilation> StlProjectVentilations { get; set; }
        [InverseProperty(nameof(StlRecoveryFolder.CfgCompany))]
        public virtual ICollection<StlRecoveryFolder> StlRecoveryFolders { get; set; }
        [InverseProperty(nameof(StlSettlement.CfgCompany))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
        [InverseProperty(nameof(StlSlip.CfgCompany))]
        public virtual ICollection<StlSlip> StlSlips { get; set; }
        [InverseProperty(nameof(StlTrancheVentilation.CfgCompany))]
        public virtual ICollection<StlTrancheVentilation> StlTrancheVentilations { get; set; }
        [InverseProperty(nameof(StlTransmissionSheet.CfgCompanyFrom))]
        public virtual ICollection<StlTransmissionSheet> StlTransmissionSheetCfgCompanyFroms { get; set; }
        [InverseProperty(nameof(StlTransmissionSheet.CfgCompanyTo))]
        public virtual ICollection<StlTransmissionSheet> StlTransmissionSheetCfgCompanyTos { get; set; }
    }
}
