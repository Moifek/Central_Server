using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyLoanSchedule")]
    [Index(nameof(BuySubLoanId), nameof(Pkey), Name = "_dta_index_BuyLoanSchedule_5_336720252__K8_K1_2_3_4_5_6_7_9_10_11_12_13_14_15_16")]
    public partial class BuyLoanSchedule
    {
        public BuyLoanSchedule()
        {
            BuyDocuments = new HashSet<BuyDocument>();
            StlSettlements = new HashSet<StlSettlement>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountBase { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? InterestRate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountInterest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PaymentDate { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? BuySubLoanId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Commision { get; set; }
        [Column("AmountBaseHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountBaseHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVatRatio { get; set; }
        [Column("AmountInterestHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountInterestHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? InterestVatRatio { get; set; }
        [Column("CommisionHT", TypeName = "decimal(26, 6)")]
        public decimal? CommisionHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommisionVatRatio { get; set; }
        [Column("AmountToPayHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountToPayHt { get; set; }

        [ForeignKey(nameof(BuySubLoanId))]
        [InverseProperty("BuyLoanSchedules")]
        public virtual BuySubLoan BuySubLoan { get; set; }
        [InverseProperty(nameof(BuyDocument.BuyLoanSchedule))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(StlSettlement.BuyLoanSchedule))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
    }
}
