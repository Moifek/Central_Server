using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlCategory")]
    [Index(nameof(Pkey), Name = "_dta_index_StlCategory_10_1765581328__K1_2_4")]
    public partial class StlCategory
    {
        public StlCategory()
        {
            ActDefaultAccounts = new HashSet<ActDefaultAccount>();
            ActStockVariationExclusions = new HashSet<ActStockVariationExclusion>();
            BuyConsultationEstimationLines = new HashSet<BuyConsultationEstimationLine>();
            BuyConsultationLines = new HashSet<BuyConsultationLine>();
            BuyConsultationOfferLines = new HashSet<BuyConsultationOfferLine>();
            BuyConsultations = new HashSet<BuyConsultation>();
            BuyDocumentLines = new HashSet<BuyDocumentLine>();
            BuyItems = new HashSet<BuyItem>();
            BuyLoanTypeBaseStlCategories = new HashSet<BuyLoanType>();
            BuyLoanTypeCommissionStlCategories = new HashSet<BuyLoanType>();
            BuyLoanTypeInterestStlCategories = new HashSet<BuyLoanType>();
            BuySelectionLines = new HashSet<BuySelectionLine>();
            BuySelections = new HashSet<BuySelection>();
            BuyVentilationCategories = new HashSet<BuyVentilationCategory>();
            ComSettlementCategories = new HashSet<ComSettlementCategory>();
            Fsprevisions = new HashSet<Fsprevision>();
            GrhPaySlipModelUnities = new HashSet<GrhPaySlipModelUnity>();
            PrjClauseLines = new HashSet<PrjClauseLine>();
            PrjMarketLineEstimations = new HashSet<PrjMarketLineEstimation>();
            PrjMarketLines = new HashSet<PrjMarketLine>();
            PrjMarketOfferLines = new HashSet<PrjMarketOfferLine>();
            PrjMarketPrevisionModels = new HashSet<PrjMarketPrevisionModel>();
            PrjMarketVentilationCategories = new HashSet<PrjMarketVentilationCategory>();
            PrjMarkets = new HashSet<PrjMarket>();
            PrjProjectProgressCriteriaLines = new HashSet<PrjProjectProgressCriteriaLine>();
            PrjWorkingOutLineExtras = new HashSet<PrjWorkingOutLineExtra>();
            PrjWorkingOutLines = new HashSet<PrjWorkingOutLine>();
            PrvSettlementPrevisions = new HashSet<PrvSettlementPrevision>();
            PrvTurnoverPrevisions = new HashSet<PrvTurnoverPrevision>();
            RntSettlementCategories = new HashSet<RntSettlementCategory>();
            SavClaims = new HashSet<SavClaim>();
            SavComplaintCategories = new HashSet<SavComplaintCategory>();
            SavServiceExpenses = new HashSet<SavServiceExpense>();
            StkExpenseTypes = new HashSet<StkExpenseType>();
            StkFsprevisionStkTranches = new HashSet<StkFsprevisionStkTranche>();
            StkItemCategories = new HashSet<StkItemCategory>();
            StkItemTypes = new HashSet<StkItemType>();
            StlCategoryPrevisions = new HashSet<StlCategoryPrevision>();
            StlDocumentLines = new HashSet<StlDocumentLine>();
            StlItemDefinitions = new HashSet<StlItemDefinition>();
            StlItems = new HashSet<StlItem>();
            StlSettlements = new HashSet<StlSettlement>();
            StlVentilationCategories = new HashSet<StlVentilationCategory>();
            StrEntities = new HashSet<StrEntity>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string CodeCountable { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsCredit { get; set; }
        public Guid? ParentId { get; set; }
        public bool? IsWithoutPrevision { get; set; }
        public Guid? StlAccountId { get; set; }
        public int? Sorting { get; set; }
        public bool? IsCharge { get; set; }
        public Guid? ActAccountId { get; set; }
        public Guid? ActAccountForPaymentId { get; set; }
        public bool? IsProduct { get; set; }

        [ForeignKey(nameof(ActAccountId))]
        [InverseProperty("StlCategories")]
        public virtual ActAccount ActAccount { get; set; }
        [ForeignKey(nameof(StlAccountId))]
        [InverseProperty("StlCategories")]
        public virtual StlAccount StlAccount { get; set; }
        [InverseProperty(nameof(ActDefaultAccount.StlCategory))]
        public virtual ICollection<ActDefaultAccount> ActDefaultAccounts { get; set; }
        [InverseProperty(nameof(ActStockVariationExclusion.StlCategory))]
        public virtual ICollection<ActStockVariationExclusion> ActStockVariationExclusions { get; set; }
        [InverseProperty(nameof(BuyConsultationEstimationLine.StlCategory))]
        public virtual ICollection<BuyConsultationEstimationLine> BuyConsultationEstimationLines { get; set; }
        [InverseProperty(nameof(BuyConsultationLine.StlCategory))]
        public virtual ICollection<BuyConsultationLine> BuyConsultationLines { get; set; }
        [InverseProperty(nameof(BuyConsultationOfferLine.StlCategory))]
        public virtual ICollection<BuyConsultationOfferLine> BuyConsultationOfferLines { get; set; }
        [InverseProperty(nameof(BuyConsultation.StlCategory))]
        public virtual ICollection<BuyConsultation> BuyConsultations { get; set; }
        [InverseProperty(nameof(BuyDocumentLine.StlCategory))]
        public virtual ICollection<BuyDocumentLine> BuyDocumentLines { get; set; }
        [InverseProperty(nameof(BuyItem.StlCategory))]
        public virtual ICollection<BuyItem> BuyItems { get; set; }
        [InverseProperty(nameof(BuyLoanType.BaseStlCategory))]
        public virtual ICollection<BuyLoanType> BuyLoanTypeBaseStlCategories { get; set; }
        [InverseProperty(nameof(BuyLoanType.CommissionStlCategory))]
        public virtual ICollection<BuyLoanType> BuyLoanTypeCommissionStlCategories { get; set; }
        [InverseProperty(nameof(BuyLoanType.InterestStlCategory))]
        public virtual ICollection<BuyLoanType> BuyLoanTypeInterestStlCategories { get; set; }
        [InverseProperty(nameof(BuySelectionLine.StlCategory))]
        public virtual ICollection<BuySelectionLine> BuySelectionLines { get; set; }
        [InverseProperty(nameof(BuySelection.StlCategory))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty(nameof(BuyVentilationCategory.StlCategory))]
        public virtual ICollection<BuyVentilationCategory> BuyVentilationCategories { get; set; }
        [InverseProperty(nameof(ComSettlementCategory.StlCategory))]
        public virtual ICollection<ComSettlementCategory> ComSettlementCategories { get; set; }
        [InverseProperty(nameof(Fsprevision.StlCategory))]
        public virtual ICollection<Fsprevision> Fsprevisions { get; set; }
        [InverseProperty(nameof(GrhPaySlipModelUnity.StlCategory))]
        public virtual ICollection<GrhPaySlipModelUnity> GrhPaySlipModelUnities { get; set; }
        [InverseProperty(nameof(PrjClauseLine.StlCategory))]
        public virtual ICollection<PrjClauseLine> PrjClauseLines { get; set; }
        [InverseProperty(nameof(PrjMarketLineEstimation.StlCategory))]
        public virtual ICollection<PrjMarketLineEstimation> PrjMarketLineEstimations { get; set; }
        [InverseProperty(nameof(PrjMarketLine.StlCategory))]
        public virtual ICollection<PrjMarketLine> PrjMarketLines { get; set; }
        [InverseProperty(nameof(PrjMarketOfferLine.StlCategory))]
        public virtual ICollection<PrjMarketOfferLine> PrjMarketOfferLines { get; set; }
        [InverseProperty(nameof(PrjMarketPrevisionModel.StlCategory))]
        public virtual ICollection<PrjMarketPrevisionModel> PrjMarketPrevisionModels { get; set; }
        [InverseProperty(nameof(PrjMarketVentilationCategory.StlCategory))]
        public virtual ICollection<PrjMarketVentilationCategory> PrjMarketVentilationCategories { get; set; }
        [InverseProperty(nameof(PrjMarket.StlCategory))]
        public virtual ICollection<PrjMarket> PrjMarkets { get; set; }
        [InverseProperty(nameof(PrjProjectProgressCriteriaLine.StlCategory))]
        public virtual ICollection<PrjProjectProgressCriteriaLine> PrjProjectProgressCriteriaLines { get; set; }
        [InverseProperty(nameof(PrjWorkingOutLineExtra.StlCategory))]
        public virtual ICollection<PrjWorkingOutLineExtra> PrjWorkingOutLineExtras { get; set; }
        [InverseProperty(nameof(PrjWorkingOutLine.StlCategory))]
        public virtual ICollection<PrjWorkingOutLine> PrjWorkingOutLines { get; set; }
        [InverseProperty(nameof(PrvSettlementPrevision.StlCategory))]
        public virtual ICollection<PrvSettlementPrevision> PrvSettlementPrevisions { get; set; }
        [InverseProperty(nameof(PrvTurnoverPrevision.StlCategory))]
        public virtual ICollection<PrvTurnoverPrevision> PrvTurnoverPrevisions { get; set; }
        [InverseProperty(nameof(RntSettlementCategory.StlCategory))]
        public virtual ICollection<RntSettlementCategory> RntSettlementCategories { get; set; }
        [InverseProperty(nameof(SavClaim.StlCategory))]
        public virtual ICollection<SavClaim> SavClaims { get; set; }
        [InverseProperty(nameof(SavComplaintCategory.StlCategory))]
        public virtual ICollection<SavComplaintCategory> SavComplaintCategories { get; set; }
        [InverseProperty(nameof(SavServiceExpense.StlCategory))]
        public virtual ICollection<SavServiceExpense> SavServiceExpenses { get; set; }
        [InverseProperty(nameof(StkExpenseType.StlCategory))]
        public virtual ICollection<StkExpenseType> StkExpenseTypes { get; set; }
        [InverseProperty(nameof(StkFsprevisionStkTranche.StlCategory))]
        public virtual ICollection<StkFsprevisionStkTranche> StkFsprevisionStkTranches { get; set; }
        [InverseProperty(nameof(StkItemCategory.StlCategory))]
        public virtual ICollection<StkItemCategory> StkItemCategories { get; set; }
        [InverseProperty(nameof(StkItemType.StlCategory))]
        public virtual ICollection<StkItemType> StkItemTypes { get; set; }
        [InverseProperty(nameof(StlCategoryPrevision.StlCategory))]
        public virtual ICollection<StlCategoryPrevision> StlCategoryPrevisions { get; set; }
        [InverseProperty(nameof(StlDocumentLine.StlCategory))]
        public virtual ICollection<StlDocumentLine> StlDocumentLines { get; set; }
        [InverseProperty(nameof(StlItemDefinition.StlCategory))]
        public virtual ICollection<StlItemDefinition> StlItemDefinitions { get; set; }
        [InverseProperty(nameof(StlItem.StlCategory))]
        public virtual ICollection<StlItem> StlItems { get; set; }
        [InverseProperty(nameof(StlSettlement.StlCategory))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
        [InverseProperty(nameof(StlVentilationCategory.StlCategory))]
        public virtual ICollection<StlVentilationCategory> StlVentilationCategories { get; set; }
        [InverseProperty(nameof(StrEntity.StlCategory))]
        public virtual ICollection<StrEntity> StrEntities { get; set; }
    }
}
