using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjProjectProportionChargeView
    {
        public Guid? PrjProjectId { get; set; }
        [Column("AmountHT", TypeName = "decimal(38, 6)")]
        public decimal? AmountHt { get; set; }
        [Column("AmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? AmountTtc { get; set; }
    }
}
