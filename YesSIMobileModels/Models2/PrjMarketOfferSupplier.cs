using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketOfferSupplier")]
    public partial class PrjMarketOfferSupplier
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? PrjMarketOfferId { get; set; }
        public Guid? CfgTierId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConsultationLetterSendDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderAcquisitionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderDepositDate { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsRejected { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string OfficeOrderRef { get; set; }

        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("PrjMarketOfferSuppliers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketOfferSuppliers")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(PrjMarketOfferId))]
        [InverseProperty("PrjMarketOfferSuppliers")]
        public virtual PrjMarketOffer PrjMarketOffer { get; set; }
    }
}
