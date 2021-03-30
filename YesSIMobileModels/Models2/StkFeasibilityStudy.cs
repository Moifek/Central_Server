using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFeasibilityStudy")]
    public partial class StkFeasibilityStudy
    {
        public StkFeasibilityStudy()
        {
            Fsfundings = new HashSet<Fsfunding>();
            Fsprevisions = new HashSet<Fsprevision>();
            StkFeasibilityStudyCfgTranches = new HashSet<StkFeasibilityStudyCfgTranche>();
            StkFeasibilityStudyStatusHistories = new HashSet<StkFeasibilityStudyStatusHistory>();
            StkFsbaseUnitStkFeasibilityStudies = new HashSet<StkFsbaseUnitStkFeasibilityStudy>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OccupationSolRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OccupationGroundArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Cuf { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalCoveredArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CoefSaleableArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalableArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? NoBuiltArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PurchaseUnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RegistryCostsRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RegistryCosts { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OtherCostsLandRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OtherCostsLand { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalCostLand { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitCostConstructionBuilt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CostAreaBuilt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitCostConstructionNoBuilt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CostAreaNoBuilt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OtherCostsExecution { get; set; }
        [Column("otherCostsExecutionRatio", TypeName = "decimal(26, 6)")]
        public decimal? OtherCostsExecutionRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalCostExecution { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitBackCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitSalePrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Turnover { get; set; }
        [Column("percentageConcretisation", TypeName = "decimal(26, 6)")]
        public decimal? PercentageConcretisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FinalizationAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConretisationAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateExpenses { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateExpenses { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateFinalization { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateFinalization { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDatePeriodeOfValidation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDatePeriodeOfValidation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDatePermissionBatir { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDatePermissionBatir { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateStudy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateStudy { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcartTypeExpenses { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcartTypeConcretisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcartTypeFinalization { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalCostFunding { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BackGuaranteeRate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BackGuaranteeApplicationRate { get; set; }
        public int? BackTimeOnDays { get; set; }
        public Guid? LndLandId { get; set; }
        public Guid? StkItemId { get; set; }
        public int? NumberOfItemForSale { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AutofinancementRate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ClientfinancementRate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CreditfinancementRate { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Column("ISRatio", TypeName = "decimal(26, 6)")]
        public decimal? Isratio { get; set; }
        [Column("ISAmount", TypeName = "decimal(26, 6)")]
        public decimal? Isamount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? NetProfitMargin { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? GrossProfitMargin { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AutofinancementAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProfitRatioByProjectCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProfitRatioByTurnover { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProfitRatioByAutofinancementAmount { get; set; }
        [Column("TotalCostExecutionHT", TypeName = "decimal(26, 6)")]
        public decimal? TotalCostExecutionHt { get; set; }
        [Column("TotalCostHT", TypeName = "decimal(26, 6)")]
        public decimal? TotalCostHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EquipementsCoef { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EquipementsAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? InterestVatRatio { get; set; }
        [StringLength(255)]
        public string LandDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaNet { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDatePurchaseLand { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDatePurchaseLand { get; set; }
        public int? DelayPurchaseLand { get; set; }
        public int? DelayPeriodeOfValidation { get; set; }
        public int? DelayPermissionBatir { get; set; }
        public int? DelayStudy { get; set; }
        public int? DelayExpenses { get; set; }
        public int? DelayConcretisation { get; set; }
        public int? DelayFinalization { get; set; }
        public int? DelayEndDatePurchaseLandStartDatePeriodeOfValidation { get; set; }
        public int? DelayEndDatePeriodeOfValidationStartDatePermissionBatir { get; set; }
        public int? DelayStartDatePermissionBatirStartDateStudy { get; set; }
        public int? DelayEndDatePermissionBatirStartDateExpenses { get; set; }
        public int? DelayStartDateExpenseStartDateConcretisations { get; set; }
        public int? DelayStartDateExpenseStartDateFinalization { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? LandVatRatio { get; set; }
        [Column("PriceAreaHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceAreaHt { get; set; }
        [Column("PurchaseUnitCostHT", TypeName = "decimal(26, 6)")]
        public decimal? PurchaseUnitCostHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PurchaseUnitCostVatAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceAreaVatAmount { get; set; }
        [Column("RegistryCostsHT", TypeName = "decimal(26, 6)")]
        public decimal? RegistryCostsHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RegistryCostsVatAmount { get; set; }
        [Column("OtherCostsExecutionHT", TypeName = "decimal(26, 6)")]
        public decimal? OtherCostsExecutionHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OtherCostsExecutionVatAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? StkFeasibilityStudyStatusId { get; set; }
        public Guid? StrEntityId { get; set; }
        [Column("UseLandProportionForTVACalculation")]
        public bool? UseLandProportionForTvacalculation { get; set; }
        public bool? IsLocked { get; set; }
        public Guid? PrvTypeId { get; set; }
        public Guid? PrvVersionId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StkFeasibilityStudies")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(LndLandId))]
        [InverseProperty("StkFeasibilityStudies")]
        public virtual LndLand LndLand { get; set; }
        [ForeignKey(nameof(PrvTypeId))]
        [InverseProperty("StkFeasibilityStudies")]
        public virtual PrvType PrvType { get; set; }
        [ForeignKey(nameof(PrvVersionId))]
        [InverseProperty("StkFeasibilityStudies")]
        public virtual PrvVersion PrvVersion { get; set; }
        [ForeignKey(nameof(StkFeasibilityStudyStatusId))]
        [InverseProperty("StkFeasibilityStudies")]
        public virtual StkFeasibilityStudyStatus StkFeasibilityStudyStatus { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("StkFeasibilityStudies")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StkFeasibilityStudies")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(Fsfunding.FeasibilityStudy))]
        public virtual ICollection<Fsfunding> Fsfundings { get; set; }
        [InverseProperty(nameof(Fsprevision.FeasibilityStudy))]
        public virtual ICollection<Fsprevision> Fsprevisions { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyCfgTranche.FeasibilityStudy))]
        public virtual ICollection<StkFeasibilityStudyCfgTranche> StkFeasibilityStudyCfgTranches { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyStatusHistory.StkFeasibilityStudy))]
        public virtual ICollection<StkFeasibilityStudyStatusHistory> StkFeasibilityStudyStatusHistories { get; set; }
        [InverseProperty(nameof(StkFsbaseUnitStkFeasibilityStudy.FeasibilityStudy))]
        public virtual ICollection<StkFsbaseUnitStkFeasibilityStudy> StkFsbaseUnitStkFeasibilityStudies { get; set; }
    }
}
