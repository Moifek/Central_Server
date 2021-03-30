using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SavClaim")]
    public partial class SavClaim
    {
        public SavClaim()
        {
            ComActionMessages = new HashSet<ComActionMessage>();
            SavClaimContenances = new HashSet<SavClaimContenance>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? SavClaimGroupId { get; set; }
        public Guid? SavComplaintCategoryId { get; set; }
        public Guid? SavComplaintTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusValidityDate { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? CfgSupplierId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InterventionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? StrEntityId { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("PriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? PriceTtc { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? StlCurrencyId { get; set; }
        public Guid? PrjMarketClaimId { get; set; }

        [ForeignKey(nameof(CfgSupplierId))]
        [InverseProperty(nameof(CfgTier.SavClaims))]
        public virtual CfgTier CfgSupplier { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("SavClaimPrjMarkets")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(PrjMarketClaimId))]
        [InverseProperty("SavClaimPrjMarketClaims")]
        public virtual PrjMarket PrjMarketClaim { get; set; }
        [ForeignKey(nameof(SavClaimGroupId))]
        [InverseProperty("SavClaims")]
        public virtual SavClaimGroup SavClaimGroup { get; set; }
        [ForeignKey(nameof(SavComplaintCategoryId))]
        [InverseProperty("SavClaims")]
        public virtual SavComplaintCategory SavComplaintCategory { get; set; }
        [ForeignKey(nameof(SavComplaintTypeId))]
        [InverseProperty("SavClaims")]
        public virtual SavComplaintType SavComplaintType { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("SavClaims")]
        public virtual StlCategory StlCategory { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("SavClaims")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("SavClaims")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("SavClaims")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(ComActionMessage.SavClaim))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(SavClaimContenance.SavClaim))]
        public virtual ICollection<SavClaimContenance> SavClaimContenances { get; set; }
    }
}
