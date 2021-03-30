using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketOffer")]
    public partial class PrjMarketOffer
    {
        public PrjMarketOffer()
        {
            BuyDocuments = new HashSet<BuyDocument>();
            PrjMarketOfferLineGroupings = new HashSet<PrjMarketOfferLineGrouping>();
            PrjMarketOfferLines = new HashSet<PrjMarketOfferLine>();
            PrjMarketOfferStockLines = new HashSet<PrjMarketOfferStockLine>();
            PrjMarketOfferSuppliers = new HashSet<PrjMarketOfferSupplier>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public int? Sorting { get; set; }
        public bool? IsTheLast { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LaunchOfTenderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WithdrawalTenderDocumentsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderMaturityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersresortDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BidOpeningDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersreportDate { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? CfgSupplierId { get; set; }

        [ForeignKey(nameof(CfgSupplierId))]
        [InverseProperty(nameof(CfgTier.PrjMarketOffers))]
        public virtual CfgTier CfgSupplier { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketOffers")]
        public virtual PrjMarket PrjMarket { get; set; }
        [InverseProperty(nameof(BuyDocument.PrjMarketOffer))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(PrjMarketOfferLineGrouping.PrjMarketOffer))]
        public virtual ICollection<PrjMarketOfferLineGrouping> PrjMarketOfferLineGroupings { get; set; }
        [InverseProperty(nameof(PrjMarketOfferLine.PrjMarketOffer))]
        public virtual ICollection<PrjMarketOfferLine> PrjMarketOfferLines { get; set; }
        [InverseProperty(nameof(PrjMarketOfferStockLine.PrjMarketOffer))]
        public virtual ICollection<PrjMarketOfferStockLine> PrjMarketOfferStockLines { get; set; }
        [InverseProperty(nameof(PrjMarketOfferSupplier.PrjMarketOffer))]
        public virtual ICollection<PrjMarketOfferSupplier> PrjMarketOfferSuppliers { get; set; }
    }
}
