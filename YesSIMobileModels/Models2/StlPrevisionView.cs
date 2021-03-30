using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlPrevisionView
    {
        [Column(TypeName = "datetime")]
        public DateTime? OriginDate { get; set; }
        public bool? Reported { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column("MONTH")]
        public int? Month { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Amount { get; set; }
        public bool? IsCredit { get; set; }
        [StringLength(561)]
        public string Description { get; set; }
        [StringLength(510)]
        public string Groupping { get; set; }
        public Guid? CfgCompanyPkey { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        [Required]
        [StringLength(20)]
        public string PrevisionType { get; set; }
        [Required]
        [StringLength(17)]
        public string SubType { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public string CfgTrancheDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        public Guid? ObjectId { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        public Guid? PrjMarketId { get; set; }
        public Guid? PrjProjectId { get; set; }
        public string PrjProjectIds { get; set; }
        [StringLength(255)]
        public string TresoGroupping2 { get; set; }
        public string TresoGroupping1 { get; set; }
        [StringLength(255)]
        public string TresoGroupping { get; set; }
    }
}
