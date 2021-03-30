using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StkFeasibilityStudyView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AutofinancementAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Turnover { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PercentageConcretisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConretisationAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FinalizationAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? NetProfitMargin { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProfitRatioByProjectCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProfitRatioByTurnover { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProfitRatioByAutofinancementAmount { get; set; }
        public Guid? StkFeasibilityStudyStatusId { get; set; }
        [StringLength(255)]
        public string StkFeasibilityStudyStatusCode { get; set; }
        [StringLength(255)]
        public string StkFeasibilityStudyStatusDescription { get; set; }
        [StringLength(255)]
        public string LndLandDescription { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
