using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComCommissionView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        public bool? IsValidated { get; set; }
        [Column(TypeName = "decimal(38, 16)")]
        public decimal? Total { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRest { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsConcretisation { get; set; }
        public bool? IsDelivery { get; set; }
        public bool? IsDelivery2 { get; set; }
        public bool? IsCancellation { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
    }
}
