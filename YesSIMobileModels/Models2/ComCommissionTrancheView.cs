using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComCommissionTrancheView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int CountItem { get; set; }
        public int CountItemAgreeded { get; set; }
        public int? RestItem { get; set; }
        [Column(TypeName = "decimal(38, 16)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PriceAllItem { get; set; }
        [Column("CAReal", TypeName = "decimal(38, 6)")]
        public decimal? Careal { get; set; }
        [Column("CARest", TypeName = "decimal(38, 6)")]
        public decimal? Carest { get; set; }
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
