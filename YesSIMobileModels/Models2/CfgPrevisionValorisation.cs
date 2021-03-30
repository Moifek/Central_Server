using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class CfgPrevisionValorisation
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("CfgProjectPKey")]
        public Guid CfgProjectPkey { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public int? CountAllItem { get; set; }
        public int? CountItem { get; set; }
        public int? CountUnderItem { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceAllItem { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PriceItem { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PriceUnderItem { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingEndDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcarttypeConcretisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcarttypeFinalisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConcretisationPercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvancePercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseMarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseEndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseStartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseMarketingEndDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseEcarttypeConcretisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseEcarttypeFinalisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseConcretisationPercent { get; set; }
    }
}
