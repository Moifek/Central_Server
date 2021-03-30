using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjClause")]
    public partial class PrjClause
    {
        public PrjClause()
        {
            BuyDocuments = new HashSet<BuyDocument>();
            PrjClauseLines = new HashSet<PrjClauseLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string DocRef { get; set; }
        [StringLength(255)]
        public string SupplierDescription { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        public bool? WarrantyBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyAmount { get; set; }
        [Column("DECBasedOnAmount")]
        public bool? DecbasedOnAmount { get; set; }
        [Column("InsuranceDECRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecratio { get; set; }
        [Column("InsuranceDECAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamount { get; set; }
        [Column("TRCBasedOnAmount")]
        public bool? TrcbasedOnAmount { get; set; }
        [Column("InsuranceTRCAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamount { get; set; }
        [Column("InsuranceTRCRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcratio { get; set; }
        public bool? ProrataBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionAmount { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("PrjClauses")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjClauses")]
        public virtual PrjMarket PrjMarket { get; set; }
        [InverseProperty(nameof(BuyDocument.PrjClause))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(PrjClauseLine.PrjClause))]
        public virtual ICollection<PrjClauseLine> PrjClauseLines { get; set; }
    }
}
