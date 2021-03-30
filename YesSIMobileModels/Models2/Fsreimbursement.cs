using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("FSReimbursement")]
    public partial class Fsreimbursement
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column("paymentDate", TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column("amountBase", TypeName = "decimal(26, 6)")]
        public decimal? AmountBase { get; set; }
        [Column("amountInterest", TypeName = "decimal(26, 6)")]
        public decimal? AmountInterest { get; set; }
        [Column("amountToPay", TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column("interestRate", TypeName = "decimal(26, 6)")]
        public decimal? InterestRate { get; set; }
        [Column("FSFundingId")]
        public Guid? FsfundingId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(FsfundingId))]
        [InverseProperty("Fsreimbursements")]
        public virtual Fsfunding Fsfunding { get; set; }
    }
}
