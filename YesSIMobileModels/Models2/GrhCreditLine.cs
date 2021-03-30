using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhCreditLine")]
    public partial class GrhCreditLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountBase { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountInterest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? GrhCreditId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(GrhCreditId))]
        [InverseProperty("GrhCreditLines")]
        public virtual GrhCredit GrhCredit { get; set; }
    }
}
