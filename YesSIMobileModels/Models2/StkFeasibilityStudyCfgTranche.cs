using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFeasibilityStudyCfgTranche")]
    public partial class StkFeasibilityStudyCfgTranche
    {
        public StkFeasibilityStudyCfgTranche()
        {
            StkFeasibilityStudyCfgTrancheStkBaseUnits = new HashSet<StkFeasibilityStudyCfgTrancheStkBaseUnit>();
            StkFsprevisionLines = new HashSet<StkFsprevisionLine>();
            StkFsprevisionStkTranches = new HashSet<StkFsprevisionStkTranche>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public Guid? FeasibilityStudyId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OccupancyPermitsDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Weight { get; set; }

        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("StkFeasibilityStudyCfgTranches")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(FeasibilityStudyId))]
        [InverseProperty(nameof(StkFeasibilityStudy.StkFeasibilityStudyCfgTranches))]
        public virtual StkFeasibilityStudy FeasibilityStudy { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyCfgTrancheStkBaseUnit.StkFeasibilityStudyCfgTranche))]
        public virtual ICollection<StkFeasibilityStudyCfgTrancheStkBaseUnit> StkFeasibilityStudyCfgTrancheStkBaseUnits { get; set; }
        [InverseProperty(nameof(StkFsprevisionLine.StkFeasibilityStudyCfgTranche))]
        public virtual ICollection<StkFsprevisionLine> StkFsprevisionLines { get; set; }
        [InverseProperty(nameof(StkFsprevisionStkTranche.StkTranche))]
        public virtual ICollection<StkFsprevisionStkTranche> StkFsprevisionStkTranches { get; set; }
    }
}
