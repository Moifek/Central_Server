using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class SynPricingView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [Column("AmountHT", TypeName = "decimal(38, 6)")]
        public decimal? AmountHt { get; set; }
        [Column("AmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? AmountTtc { get; set; }
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
