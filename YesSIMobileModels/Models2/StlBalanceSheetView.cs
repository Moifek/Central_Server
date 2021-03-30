using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlBalanceSheetView
    {
        [Column("PKey")]
        public Guid? Pkey { get; set; }
        [Column("FeasabilityStudyHT", TypeName = "decimal(38, 6)")]
        public decimal? FeasabilityStudyHt { get; set; }
        [Column("FeasabilityStudyVAT", TypeName = "decimal(38, 6)")]
        public decimal? FeasabilityStudyVat { get; set; }
        [Column("FeasabilityStudyTTC", TypeName = "decimal(38, 6)")]
        public decimal? FeasabilityStudyTtc { get; set; }
        [Column("AmountPrevisionHT", TypeName = "decimal(38, 6)")]
        public decimal? AmountPrevisionHt { get; set; }
        [Column("AmountPrevisionTTC", TypeName = "decimal(38, 6)")]
        public decimal? AmountPrevisionTtc { get; set; }
        [Column("AmountHT", TypeName = "decimal(38, 6)")]
        public decimal? AmountHt { get; set; }
        [Column("AmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountReal { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public int IsPointed { get; set; }
        [Required]
        [StringLength(26)]
        public string Type { get; set; }
    }
}
