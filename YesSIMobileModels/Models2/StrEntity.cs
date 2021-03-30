using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrEntity")]
    [Index(nameof(Pkey), Name = "_dta_index_StrEntity_5_1517964484__K1_2_3")]
    [Index(nameof(Pkey), nameof(Description), Name = "_dta_index_StrEntity_5_1517964484__K1_K3")]
    [Index(nameof(Pkey), Name = "_dta_index_StrEntity_5_1761441349__K1")]
    public partial class StrEntity
    {
        public StrEntity()
        {
            ActAccounts = new HashSet<ActAccount>();
            ActEntryStrEntities = new HashSet<ActEntry>();
            ActEntryStrEntityRelations = new HashSet<ActEntry>();
            ActJournals = new HashSet<ActJournal>();
            AdmAttachedFileTypeStrEntities = new HashSet<AdmAttachedFileTypeStrEntity>();
            AdmEvents = new HashSet<AdmEvent>();
            AdmNotifications = new HashSet<AdmNotification>();
            AdmToDoLists = new HashSet<AdmToDoList>();
            BuyConsultations = new HashSet<BuyConsultation>();
            BuyDocumentWorkFlows = new HashSet<BuyDocumentWorkFlow>();
            BuyDocuments = new HashSet<BuyDocument>();
            BuyLoans = new HashSet<BuyLoan>();
            BuyRequests = new HashSet<BuyRequest>();
            BuySelections = new HashSet<BuySelection>();
            ComFolders = new HashSet<ComFolder>();
            ComProspections = new HashSet<ComProspection>();
            GrhAdvances = new HashSet<GrhAdvance>();
            GrhCredits = new HashSet<GrhCredit>();
            GrhDisciplines = new HashSet<GrhDiscipline>();
            GrhOverTimes = new HashSet<GrhOverTime>();
            GrhPaySlips = new HashSet<GrhPaySlip>();
            GrhResignations = new HashSet<GrhResignation>();
            GrhTerminations = new HashSet<GrhTermination>();
            GrhVacationGroups = new HashSet<GrhVacationGroup>();
            GrhVacations = new HashSet<GrhVacation>();
            GrhWorkedDays = new HashSet<GrhWorkedDay>();
            LndLands = new HashSet<LndLand>();
            PrjMarketPaymentPrevisions = new HashSet<PrjMarketPaymentPrevision>();
            PrjMarkets = new HashSet<PrjMarket>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
            RntFolderWorkFlows = new HashSet<RntFolderWorkFlow>();
            RntFolders = new HashSet<RntFolder>();
            SavClaims = new HashSet<SavClaim>();
            SavServices = new HashSet<SavService>();
            StkFeasibilityStudies = new HashSet<StkFeasibilityStudy>();
            StkFeasibilityStudyWorkFlows = new HashSet<StkFeasibilityStudyWorkFlow>();
            StkItems = new HashSet<StkItem>();
            StlAccountPositions = new HashSet<StlAccountPosition>();
            StlAcountDeposits = new HashSet<StlAcountDeposit>();
            StlDocuments = new HashSet<StlDocument>();
            StlInternalTransfers = new HashSet<StlInternalTransfer>();
            StlPaymentAuthorizations = new HashSet<StlPaymentAuthorization>();
            StlRecoveryFolders = new HashSet<StlRecoveryFolder>();
            StlSettlements = new HashSet<StlSettlement>();
            StlSlips = new HashSet<StlSlip>();
            StlTransmissionSheets = new HashSet<StlTransmissionSheet>();
            StrAttachments = new HashSet<StrAttachment>();
            StrFields = new HashSet<StrField>();
            StrHistories = new HashSet<StrHistory>();
            StrInterveners = new HashSet<StrIntervener>();
            StrNotifications = new HashSet<StrNotification>();
            StrReports = new HashSet<StrReport>();
            StrStatuses = new HashSet<StrStatus>();
            StrWorkFlows = new HashSet<StrWorkFlow>();
            SynFolders = new HashSet<SynFolder>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "text")]
        public string DescriptionLong { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? AdmModuleId { get; set; }
        public Guid? StlCategoryId { get; set; }
        public bool? IsCredit { get; set; }
        public bool? WithWorkFlow { get; set; }
        public bool? IsCharge { get; set; }
        [Column(TypeName = "text")]
        public string QueryString { get; set; }
        public string ReportsQueryString { get; set; }
        public Guid? ActAccountId { get; set; }
        public bool? IsAccountable { get; set; }
        [StringLength(255)]
        public string ObjectPath { get; set; }
        [StringLength(255)]
        public string ObjectForm { get; set; }
        [StringLength(255)]
        public string ActDefaultAccountCode { get; set; }
        public bool? IsProduct { get; set; }
        public Guid? StrTierFieldId { get; set; }
        [StringLength(255)]
        public string BoolField001Label { get; set; }
        [StringLength(255)]
        public string BoolField002Label { get; set; }
        [StringLength(255)]
        public string BoolField003Label { get; set; }
        [StringLength(255)]
        public string BoolField004Label { get; set; }
        [StringLength(255)]
        public string BoolField005Label { get; set; }
        [StringLength(255)]
        public string BoolField006Label { get; set; }
        [StringLength(255)]
        public string BoolField007Label { get; set; }
        [StringLength(255)]
        public string BoolField008Label { get; set; }
        [StringLength(255)]
        public string BoolField009Label { get; set; }
        [StringLength(255)]
        public string BoolField010Label { get; set; }
        [StringLength(255)]
        public string BoolField011Label { get; set; }
        [StringLength(255)]
        public string BoolField012Label { get; set; }
        [StringLength(255)]
        public string BoolField013Label { get; set; }
        [StringLength(255)]
        public string BoolField014Label { get; set; }
        [StringLength(255)]
        public string BoolField015Label { get; set; }
        [StringLength(255)]
        public string BoolField016Label { get; set; }
        [StringLength(255)]
        public string BoolField017Label { get; set; }
        [StringLength(255)]
        public string BoolField018Label { get; set; }
        [StringLength(255)]
        public string BoolField019Label { get; set; }
        [StringLength(255)]
        public string BoolField020Label { get; set; }

        [ForeignKey(nameof(ActAccountId))]
        [InverseProperty("StrEntities")]
        public virtual ActAccount ActAccount { get; set; }
        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("StrEntities")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StrEntities")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty("StrEntity")]
        public virtual ICollection<ActAccount> ActAccounts { get; set; }
        [InverseProperty(nameof(ActEntry.StrEntity))]
        public virtual ICollection<ActEntry> ActEntryStrEntities { get; set; }
        [InverseProperty(nameof(ActEntry.StrEntityRelation))]
        public virtual ICollection<ActEntry> ActEntryStrEntityRelations { get; set; }
        [InverseProperty(nameof(ActJournal.StrEntity))]
        public virtual ICollection<ActJournal> ActJournals { get; set; }
        [InverseProperty(nameof(AdmAttachedFileTypeStrEntity.StrEntity))]
        public virtual ICollection<AdmAttachedFileTypeStrEntity> AdmAttachedFileTypeStrEntities { get; set; }
        [InverseProperty(nameof(AdmEvent.StrEntity))]
        public virtual ICollection<AdmEvent> AdmEvents { get; set; }
        [InverseProperty(nameof(AdmNotification.StrEntity))]
        public virtual ICollection<AdmNotification> AdmNotifications { get; set; }
        [InverseProperty(nameof(AdmToDoList.StrEntity))]
        public virtual ICollection<AdmToDoList> AdmToDoLists { get; set; }
        [InverseProperty(nameof(BuyConsultation.StrEntity))]
        public virtual ICollection<BuyConsultation> BuyConsultations { get; set; }
        [InverseProperty(nameof(BuyDocumentWorkFlow.StrEntity))]
        public virtual ICollection<BuyDocumentWorkFlow> BuyDocumentWorkFlows { get; set; }
        [InverseProperty(nameof(BuyDocument.StrEntity))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuyLoan.StrEntity))]
        public virtual ICollection<BuyLoan> BuyLoans { get; set; }
        [InverseProperty(nameof(BuyRequest.StrEntity))]
        public virtual ICollection<BuyRequest> BuyRequests { get; set; }
        [InverseProperty(nameof(BuySelection.StrEntity))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty(nameof(ComFolder.StrEntity))]
        public virtual ICollection<ComFolder> ComFolders { get; set; }
        [InverseProperty(nameof(ComProspection.StrEntity))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(GrhAdvance.StrEntity))]
        public virtual ICollection<GrhAdvance> GrhAdvances { get; set; }
        [InverseProperty(nameof(GrhCredit.StrEntity))]
        public virtual ICollection<GrhCredit> GrhCredits { get; set; }
        [InverseProperty(nameof(GrhDiscipline.StrEntity))]
        public virtual ICollection<GrhDiscipline> GrhDisciplines { get; set; }
        [InverseProperty(nameof(GrhOverTime.StrEntity))]
        public virtual ICollection<GrhOverTime> GrhOverTimes { get; set; }
        [InverseProperty(nameof(GrhPaySlip.StrEntity))]
        public virtual ICollection<GrhPaySlip> GrhPaySlips { get; set; }
        [InverseProperty(nameof(GrhResignation.StrEntity))]
        public virtual ICollection<GrhResignation> GrhResignations { get; set; }
        [InverseProperty(nameof(GrhTermination.StrEntity))]
        public virtual ICollection<GrhTermination> GrhTerminations { get; set; }
        [InverseProperty(nameof(GrhVacationGroup.StrEntity))]
        public virtual ICollection<GrhVacationGroup> GrhVacationGroups { get; set; }
        [InverseProperty(nameof(GrhVacation.StrEntity))]
        public virtual ICollection<GrhVacation> GrhVacations { get; set; }
        [InverseProperty(nameof(GrhWorkedDay.StrEntity))]
        public virtual ICollection<GrhWorkedDay> GrhWorkedDays { get; set; }
        [InverseProperty(nameof(LndLand.StrEntity))]
        public virtual ICollection<LndLand> LndLands { get; set; }
        [InverseProperty(nameof(PrjMarketPaymentPrevision.StrEntity))]
        public virtual ICollection<PrjMarketPaymentPrevision> PrjMarketPaymentPrevisions { get; set; }
        [InverseProperty(nameof(PrjMarket.StrEntity))]
        public virtual ICollection<PrjMarket> PrjMarkets { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.StrEntity))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
        [InverseProperty(nameof(RntFolderWorkFlow.StrEntity))]
        public virtual ICollection<RntFolderWorkFlow> RntFolderWorkFlows { get; set; }
        [InverseProperty(nameof(RntFolder.StrEntity))]
        public virtual ICollection<RntFolder> RntFolders { get; set; }
        [InverseProperty(nameof(SavClaim.StrEntity))]
        public virtual ICollection<SavClaim> SavClaims { get; set; }
        [InverseProperty(nameof(SavService.StrEntity))]
        public virtual ICollection<SavService> SavServices { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudy.StrEntity))]
        public virtual ICollection<StkFeasibilityStudy> StkFeasibilityStudies { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyWorkFlow.StrEntity))]
        public virtual ICollection<StkFeasibilityStudyWorkFlow> StkFeasibilityStudyWorkFlows { get; set; }
        [InverseProperty(nameof(StkItem.StrEntity))]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(StlAccountPosition.StrEntity))]
        public virtual ICollection<StlAccountPosition> StlAccountPositions { get; set; }
        [InverseProperty(nameof(StlAcountDeposit.StrEntity))]
        public virtual ICollection<StlAcountDeposit> StlAcountDeposits { get; set; }
        [InverseProperty(nameof(StlDocument.StrEntity))]
        public virtual ICollection<StlDocument> StlDocuments { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.StrEntity))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransfers { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorization.StrEntity))]
        public virtual ICollection<StlPaymentAuthorization> StlPaymentAuthorizations { get; set; }
        [InverseProperty(nameof(StlRecoveryFolder.StrEntity))]
        public virtual ICollection<StlRecoveryFolder> StlRecoveryFolders { get; set; }
        [InverseProperty(nameof(StlSettlement.StrEntity))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
        [InverseProperty(nameof(StlSlip.StrEntity))]
        public virtual ICollection<StlSlip> StlSlips { get; set; }
        [InverseProperty(nameof(StlTransmissionSheet.StrEntity))]
        public virtual ICollection<StlTransmissionSheet> StlTransmissionSheets { get; set; }
        [InverseProperty(nameof(StrAttachment.StrEntity))]
        public virtual ICollection<StrAttachment> StrAttachments { get; set; }
        [InverseProperty(nameof(StrField.StrEntity))]
        public virtual ICollection<StrField> StrFields { get; set; }
        [InverseProperty(nameof(StrHistory.StrEntity))]
        public virtual ICollection<StrHistory> StrHistories { get; set; }
        [InverseProperty(nameof(StrIntervener.StrEntity))]
        public virtual ICollection<StrIntervener> StrInterveners { get; set; }
        [InverseProperty(nameof(StrNotification.StrEntity))]
        public virtual ICollection<StrNotification> StrNotifications { get; set; }
        [InverseProperty(nameof(StrReport.StrEntity))]
        public virtual ICollection<StrReport> StrReports { get; set; }
        [InverseProperty(nameof(StrStatus.StrEntity))]
        public virtual ICollection<StrStatus> StrStatuses { get; set; }
        [InverseProperty(nameof(StrWorkFlow.StrEntity))]
        public virtual ICollection<StrWorkFlow> StrWorkFlows { get; set; }
        [InverseProperty(nameof(SynFolder.StrEntity))]
        public virtual ICollection<SynFolder> SynFolders { get; set; }
    }
}
