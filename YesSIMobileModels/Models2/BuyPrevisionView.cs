using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyPrevisionView
    {
        public int? YearNumber { get; set; }
        public int? MonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountPrev { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountReal { get; set; }
        [Column(TypeName = "decimal(37, 6)")]
        public decimal? DecaissementReal { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
    }
}
