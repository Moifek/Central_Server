using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlCurrency")]
    public partial class StlCurrency
    {
        public StlCurrency()
        {
            ActEntries = new HashSet<ActEntry>();
            BuyConsultations = new HashSet<BuyConsultation>();
            BuyDocuments = new HashSet<BuyDocument>();
            BuySelections = new HashSet<BuySelection>();
            CfgCompanies = new HashSet<CfgCompany>();
            CfgTiers = new HashSet<CfgTier>();
            PrjMarkets = new HashSet<PrjMarket>();
            PrjWorkingOuts = new HashSet<PrjWorkingOut>();
            SavClaims = new HashSet<SavClaim>();
            SavServices = new HashSet<SavService>();
            StlAccounts = new HashSet<StlAccount>();
            StlCurrencyConversionStlCurrencyFroms = new HashSet<StlCurrencyConversion>();
            StlCurrencyConversionStlCurrencyTos = new HashSet<StlCurrencyConversion>();
            StlDocuments = new HashSet<StlDocument>();
            StlSettlementStlCurrencies = new HashSet<StlSettlement>();
            StlSettlementStlCurrencyAffectations = new HashSet<StlSettlement>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string CodeIso { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        [StringLength(255)]
        public string CurrencyFormat { get; set; }
        [StringLength(255)]
        public string CurrencySymbol { get; set; }
        public int? CurrencyDecimalDigits { get; set; }

        [InverseProperty(nameof(ActEntry.StlCurrency))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(BuyConsultation.StlCurrency))]
        public virtual ICollection<BuyConsultation> BuyConsultations { get; set; }
        [InverseProperty(nameof(BuyDocument.StlCurrency))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuySelection.StlCurrency))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty(nameof(CfgCompany.StlCurrency))]
        public virtual ICollection<CfgCompany> CfgCompanies { get; set; }
        [InverseProperty(nameof(CfgTier.StlCurrency))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
        [InverseProperty(nameof(PrjMarket.StlCurrency))]
        public virtual ICollection<PrjMarket> PrjMarkets { get; set; }
        [InverseProperty(nameof(PrjWorkingOut.StlCurrency))]
        public virtual ICollection<PrjWorkingOut> PrjWorkingOuts { get; set; }
        [InverseProperty(nameof(SavClaim.StlCurrency))]
        public virtual ICollection<SavClaim> SavClaims { get; set; }
        [InverseProperty(nameof(SavService.StlCurrency))]
        public virtual ICollection<SavService> SavServices { get; set; }
        [InverseProperty(nameof(StlAccount.StlCurrency))]
        public virtual ICollection<StlAccount> StlAccounts { get; set; }
        [InverseProperty(nameof(StlCurrencyConversion.StlCurrencyFrom))]
        public virtual ICollection<StlCurrencyConversion> StlCurrencyConversionStlCurrencyFroms { get; set; }
        [InverseProperty(nameof(StlCurrencyConversion.StlCurrencyTo))]
        public virtual ICollection<StlCurrencyConversion> StlCurrencyConversionStlCurrencyTos { get; set; }
        [InverseProperty(nameof(StlDocument.StlCurrency))]
        public virtual ICollection<StlDocument> StlDocuments { get; set; }
        [InverseProperty(nameof(StlSettlement.StlCurrency))]
        public virtual ICollection<StlSettlement> StlSettlementStlCurrencies { get; set; }
        [InverseProperty(nameof(StlSettlement.StlCurrencyAffectation))]
        public virtual ICollection<StlSettlement> StlSettlementStlCurrencyAffectations { get; set; }
    }
}
