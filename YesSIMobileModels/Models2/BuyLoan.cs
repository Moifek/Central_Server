using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyLoan")]
    public partial class BuyLoan
    {
        public BuyLoan()
        {
            BuyDocuments = new HashSet<BuyDocument>();
            BuySubLoans = new HashSet<BuySubLoan>();
            StlSettlements = new HashSet<StlSettlement>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? InterestRate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Fees { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? PrjProjectId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FeesPrevention { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? BuyLoanTypeId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommisionVatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? InterestVatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultCommisionAmount { get; set; }
        public bool? IsClosed { get; set; }
        public Guid? StrEntityId { get; set; }

        [ForeignKey(nameof(BuyLoanTypeId))]
        [InverseProperty("BuyLoans")]
        public virtual BuyLoanType BuyLoanType { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("BuyLoans")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("BuyLoans")]
        public virtual PrjProject PrjProject { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("BuyLoans")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("BuyLoans")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(BuyDocument.BuyLoan))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuySubLoan.BuyLoan))]
        public virtual ICollection<BuySubLoan> BuySubLoans { get; set; }
        [InverseProperty(nameof(StlSettlement.BuyLoan))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
    }
}
