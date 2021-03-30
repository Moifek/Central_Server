using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjWorkingOut")]
    [Index(nameof(PrjMarketId), Name = "_dta_index_PrjWorkingOut_10_957246465__K16_4")]
    [Index(nameof(PrjMarketId), nameof(Sorting), nameof(Pkey), nameof(BuyDocumentId), nameof(CfgTierId), Name = "_dta_index_PrjWorkingOut_10_957246465__K16_K18_K1_K19_K15_2_3_4_5_6_7_8_9_11_12_14_17_21_22_23_24_25_26_27_28_30_31_33_34_35_")]
    [Index(nameof(PrjMarketId), nameof(Pkey), nameof(Sorting), Name = "_dta_index_PrjWorkingOut_10_957246465__K16_K1_K18_21_23_41_42_43_47_58_68_71")]
    [Index(nameof(PrjMarketId), nameof(Pkey), nameof(BuyDocumentId), nameof(CfgTierId), nameof(Sorting), Name = "_dta_index_PrjWorkingOut_10_957246465__K16_K1_K19_K15_K18_2_3_4_5_6_7_8_9_11_12_14_17_21_22_23_24_25_26_27_28_30_31_33_34_35_")]
    [Index(nameof(Pkey), nameof(Sorting), Name = "_dta_index_PrjWorkingOut_10_957246465__K1_K18_11")]
    [Index(nameof(PrjMarketId), Name = "_dta_index_PrjWorkingOut_5_1472724299__K16_23")]
    [Index(nameof(PrjMarketId), nameof(Pkey), Name = "_dta_index_PrjWorkingOut_5_1472724299__K16_K1_21_23_26_27_31_33_43")]
    public partial class PrjWorkingOut
    {
        public PrjWorkingOut()
        {
            BuyDocuments = new HashSet<BuyDocument>();
            PrjWorkingOutLineExtras = new HashSet<PrjWorkingOutLineExtra>();
            PrjWorkingOutLines = new HashSet<PrjWorkingOutLine>();
            PrjWorkingOutRetainedLines = new HashSet<PrjWorkingOutRetainedLine>();
            PrjWorkingOutStockLines = new HashSet<PrjWorkingOutStockLine>();
            PrjWorkingOutViewHierarchies = new HashSet<PrjWorkingOutViewHierarchy>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
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
        [StringLength(1000)]
        public string ParentDocuments { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRegul { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        public int? LinesCount { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? PrjMarketId { get; set; }
        [Column("AmountTTCAfterDeductions", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtcafterDeductions { get; set; }
        public int? Sorting { get; set; }
        public Guid? BuyDocumentId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Achievement { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRatio { get; set; }
        [Column("insuranceDECRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecratio { get; set; }
        [Column("insuranceDECAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamount { get; set; }
        [Column("insuranceTRCAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamount { get; set; }
        [Column("insuranceTRCRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcratio { get; set; }
        [Column("proportionRatio", TypeName = "decimal(26, 6)")]
        public decimal? ProportionRatio { get; set; }
        [Column("proportionAmount", TypeName = "decimal(26, 6)")]
        public decimal? ProportionAmount { get; set; }
        [Column("extraAmount", TypeName = "decimal(26, 6)")]
        public decimal? ExtraAmount { get; set; }
        [Column("nonRefundableRetainer", TypeName = "decimal(26, 6)")]
        public decimal? NonRefundableRetainer { get; set; }
        [Column("amountToBePaid", TypeName = "decimal(26, 6)")]
        public decimal? AmountToBePaid { get; set; }
        [Column("refundableRetainer", TypeName = "decimal(26, 6)")]
        public decimal? RefundableRetainer { get; set; }
        [Column("advanceRest", TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRest { get; set; }
        [Column("insuranceDECRest", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecrest { get; set; }
        [Column("insuranceTRCRest", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcrest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockAmountToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkingOutAdvanceAmountRestAtCreation { get; set; }
        [Column("WorkingOutAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? WorkingOutAmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockPileRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockAmountOld { get; set; }
        [Column("InsuranceTRCAmountMax", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamountMax { get; set; }
        [Column("InsuranceDECAmountMax", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamountMax { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProrataRefundAmount { get; set; }
        public bool? AdvanceBasedOnAmount { get; set; }
        public bool? WarrantyBasedOnAmount { get; set; }
        [Column("TRCBasedOnAmount")]
        public bool? TrcbasedOnAmount { get; set; }
        [Column("DECBasedOnAmount")]
        public bool? DecbasedOnAmount { get; set; }
        public bool? ProrataBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsOld { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Fluctuations { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsToPay { get; set; }
        public bool? FinalWorkingOut { get; set; }
        [Column("SourceRatio_OLD", TypeName = "decimal(26, 6)")]
        public decimal? SourceRatioOld { get; set; }
        [Column("RSAmount_OLD", TypeName = "decimal(26, 6)")]
        public decimal? RsamountOld { get; set; }
        [Column("DefaultRSBasedOnRetainedAmounts_OLD")]
        public bool? DefaultRsbasedOnRetainedAmountsOld { get; set; }
        [Column("StockAmountOldHT", TypeName = "decimal(26, 6)")]
        public decimal? StockAmountOldHt { get; set; }
        [Column("StockAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? StockAmountHt { get; set; }
        [Column("StockAmountToPayHT", TypeName = "decimal(26, 6)")]
        public decimal? StockAmountToPayHt { get; set; }
        [Column("FluctuationsOldHT", TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsOldHt { get; set; }
        [Column("FluctuationsHT", TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsHt { get; set; }
        [Column("FluctuationsToPayHT", TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsToPayHt { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StlCurrencyId { get; set; }

        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("PrjWorkingOuts")]
        public virtual BuyDocument BuyDocument { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("PrjWorkingOuts")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjWorkingOuts")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("PrjWorkingOuts")]
        public virtual StlCurrency StlCurrency { get; set; }
        [InverseProperty("PrjWorkingOut")]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(PrjWorkingOutLineExtra.PrjWorkingOut))]
        public virtual ICollection<PrjWorkingOutLineExtra> PrjWorkingOutLineExtras { get; set; }
        [InverseProperty(nameof(PrjWorkingOutLine.PrjWorkingOut))]
        public virtual ICollection<PrjWorkingOutLine> PrjWorkingOutLines { get; set; }
        [InverseProperty(nameof(PrjWorkingOutRetainedLine.PrjWorkingOut))]
        public virtual ICollection<PrjWorkingOutRetainedLine> PrjWorkingOutRetainedLines { get; set; }
        [InverseProperty(nameof(PrjWorkingOutStockLine.PrjWorkingOut))]
        public virtual ICollection<PrjWorkingOutStockLine> PrjWorkingOutStockLines { get; set; }
        [InverseProperty(nameof(PrjWorkingOutViewHierarchy.PrjWorkingOut))]
        public virtual ICollection<PrjWorkingOutViewHierarchy> PrjWorkingOutViewHierarchies { get; set; }
    }
}
