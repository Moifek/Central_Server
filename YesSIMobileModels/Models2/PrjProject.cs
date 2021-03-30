using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjProject")]
    public partial class PrjProject
    {
        public PrjProject()
        {
            AdmUserHabilitations = new HashSet<AdmUserHabilitation>();
            BulMeetings = new HashSet<BulMeeting>();
            BuyConsultations = new HashSet<BuyConsultation>();
            BuyDocuments = new HashSet<BuyDocument>();
            BuyFolderPrjProjectVentilations = new HashSet<BuyFolderPrjProjectVentilation>();
            BuyLoans = new HashSet<BuyLoan>();
            BuySelections = new HashSet<BuySelection>();
            BuyVentilationExpenses = new HashSet<BuyVentilationExpense>();
            CfgTrancheLevelingDefinitions = new HashSet<CfgTrancheLevelingDefinition>();
            CfgTranches = new HashSet<CfgTranche>();
            GrhWorkedDays = new HashSet<GrhWorkedDay>();
            InverseReference = new HashSet<PrjProject>();
            PrjAchivementVersions = new HashSet<PrjAchivementVersion>();
            PrjCoefficientCosts = new HashSet<PrjCoefficientCost>();
            PrjGanttTasks = new HashSet<PrjGanttTask>();
            PrjMarkets = new HashSet<PrjMarket>();
            PrjPrevisionVersions = new HashSet<PrjPrevisionVersion>();
            PrjPrevisions = new HashSet<PrjPrevision>();
            PrjProjectAchievementPrevisions = new HashSet<PrjProjectAchievementPrevision>();
            PrjProjectAchievementReals = new HashSet<PrjProjectAchievementReal>();
            PrjProjectBuildingPrevisions = new HashSet<PrjProjectBuildingPrevision>();
            PrjProjectCfgTrancheVentilations = new HashSet<PrjProjectCfgTrancheVentilation>();
            PrjProjectProgressCriteriaLines = new HashSet<PrjProjectProgressCriteriaLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        public int? Delay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultVentilationRate { get; set; }
        public bool? IsVentilated { get; set; }
        public Guid? StkLevelingId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? ReferenceId { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        public Guid? ManageProrataPrjMarketId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column("IsACommon")]
        public bool? IsAcommon { get; set; }
        public Guid? CfgTierManagerId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("PrjProjects")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTierManagerId))]
        [InverseProperty(nameof(CfgTier.PrjProjects))]
        public virtual CfgTier CfgTierManager { get; set; }
        [ForeignKey(nameof(ManageProrataPrjMarketId))]
        [InverseProperty(nameof(PrjMarket.PrjProjects))]
        public virtual PrjMarket ManageProrataPrjMarket { get; set; }
        [ForeignKey(nameof(ReferenceId))]
        [InverseProperty(nameof(PrjProject.InverseReference))]
        public virtual PrjProject Reference { get; set; }
        [ForeignKey(nameof(StkLevelingId))]
        [InverseProperty("PrjProjects")]
        public virtual StkLeveling StkLeveling { get; set; }
        [InverseProperty(nameof(AdmUserHabilitation.PrjProject))]
        public virtual ICollection<AdmUserHabilitation> AdmUserHabilitations { get; set; }
        [InverseProperty(nameof(BulMeeting.PrjProject))]
        public virtual ICollection<BulMeeting> BulMeetings { get; set; }
        [InverseProperty(nameof(BuyConsultation.PrjProject))]
        public virtual ICollection<BuyConsultation> BuyConsultations { get; set; }
        [InverseProperty(nameof(BuyDocument.PrjProject))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuyFolderPrjProjectVentilation.PrjProject))]
        public virtual ICollection<BuyFolderPrjProjectVentilation> BuyFolderPrjProjectVentilations { get; set; }
        [InverseProperty(nameof(BuyLoan.PrjProject))]
        public virtual ICollection<BuyLoan> BuyLoans { get; set; }
        [InverseProperty(nameof(BuySelection.PrjProject))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty(nameof(BuyVentilationExpense.PrjProject))]
        public virtual ICollection<BuyVentilationExpense> BuyVentilationExpenses { get; set; }
        [InverseProperty(nameof(CfgTrancheLevelingDefinition.CfgTranche))]
        public virtual ICollection<CfgTrancheLevelingDefinition> CfgTrancheLevelingDefinitions { get; set; }
        [InverseProperty(nameof(CfgTranche.PrjProject))]
        public virtual ICollection<CfgTranche> CfgTranches { get; set; }
        [InverseProperty(nameof(GrhWorkedDay.PrjProject))]
        public virtual ICollection<GrhWorkedDay> GrhWorkedDays { get; set; }
        [InverseProperty(nameof(PrjProject.Reference))]
        public virtual ICollection<PrjProject> InverseReference { get; set; }
        [InverseProperty(nameof(PrjAchivementVersion.PrjProject))]
        public virtual ICollection<PrjAchivementVersion> PrjAchivementVersions { get; set; }
        [InverseProperty(nameof(PrjCoefficientCost.PrjProject))]
        public virtual ICollection<PrjCoefficientCost> PrjCoefficientCosts { get; set; }
        [InverseProperty(nameof(PrjGanttTask.PrjProject))]
        public virtual ICollection<PrjGanttTask> PrjGanttTasks { get; set; }
        [InverseProperty(nameof(PrjMarket.PrjProject))]
        public virtual ICollection<PrjMarket> PrjMarkets { get; set; }
        [InverseProperty(nameof(PrjPrevisionVersion.PrjProject))]
        public virtual ICollection<PrjPrevisionVersion> PrjPrevisionVersions { get; set; }
        [InverseProperty(nameof(PrjPrevision.PrjProject))]
        public virtual ICollection<PrjPrevision> PrjPrevisions { get; set; }
        [InverseProperty(nameof(PrjProjectAchievementPrevision.PrjProject))]
        public virtual ICollection<PrjProjectAchievementPrevision> PrjProjectAchievementPrevisions { get; set; }
        [InverseProperty(nameof(PrjProjectAchievementReal.PrjProject))]
        public virtual ICollection<PrjProjectAchievementReal> PrjProjectAchievementReals { get; set; }
        [InverseProperty(nameof(PrjProjectBuildingPrevision.PrjProject))]
        public virtual ICollection<PrjProjectBuildingPrevision> PrjProjectBuildingPrevisions { get; set; }
        [InverseProperty(nameof(PrjProjectCfgTrancheVentilation.PrjProject))]
        public virtual ICollection<PrjProjectCfgTrancheVentilation> PrjProjectCfgTrancheVentilations { get; set; }
        [InverseProperty(nameof(PrjProjectProgressCriteriaLine.PrjProject))]
        public virtual ICollection<PrjProjectProgressCriteriaLine> PrjProjectProgressCriteriaLines { get; set; }
    }
}
