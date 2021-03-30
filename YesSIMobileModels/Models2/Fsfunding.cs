using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("FSFunding")]
    public partial class Fsfunding
    {
        public Fsfunding()
        {
            Fsreimbursements = new HashSet<Fsreimbursement>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column("paymentDate", TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column("amount", TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Column("monthsCount")]
        public int? MonthsCount { get; set; }
        [Column("monthsStep")]
        public int? MonthsStep { get; set; }
        [Column("gracePeriod")]
        public int? GracePeriod { get; set; }
        public Guid? FeasibilityStudyId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column("chargeRatio", TypeName = "decimal(26, 6)")]
        public decimal? ChargeRatio { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [ForeignKey(nameof(FeasibilityStudyId))]
        [InverseProperty(nameof(StkFeasibilityStudy.Fsfundings))]
        public virtual StkFeasibilityStudy FeasibilityStudy { get; set; }
        [InverseProperty(nameof(Fsreimbursement.Fsfunding))]
        public virtual ICollection<Fsreimbursement> Fsreimbursements { get; set; }
    }
}
