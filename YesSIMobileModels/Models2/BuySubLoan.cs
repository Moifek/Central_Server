using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuySubLoan")]
    public partial class BuySubLoan
    {
        public BuySubLoan()
        {
            BuyLoanSchedules = new HashSet<BuyLoanSchedule>();
            StlSettlements = new HashSet<StlSettlement>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PaymentDate { get; set; }
        public int? MonthsCount { get; set; }
        public int? GracePeriod { get; set; }
        public int? MonthsStep { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? BuyLoanId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AnnualRate { get; set; }
        public int? AmortizationDeferredDelay { get; set; }
        public int? TotalDeferredDelay { get; set; }
        public bool? IsMensualRate { get; set; }
        public bool? IsActoriel { get; set; }

        [ForeignKey(nameof(BuyLoanId))]
        [InverseProperty("BuySubLoans")]
        public virtual BuyLoan BuyLoan { get; set; }
        [InverseProperty(nameof(BuyLoanSchedule.BuySubLoan))]
        public virtual ICollection<BuyLoanSchedule> BuyLoanSchedules { get; set; }
        [InverseProperty(nameof(StlSettlement.BuySubLoan))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
    }
}
