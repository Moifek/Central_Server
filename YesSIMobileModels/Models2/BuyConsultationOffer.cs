using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyConsultationOffer")]
    public partial class BuyConsultationOffer
    {
        public BuyConsultationOffer()
        {
            BuyConsultationOfferGroups = new HashSet<BuyConsultationOfferGroup>();
            BuyConsultationOfferLines = new HashSet<BuyConsultationOfferLine>();
            BuyConsultationOfferSuppliers = new HashSet<BuyConsultationOfferSupplier>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? BuyConsultationId { get; set; }
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
        public string TextLetterOffre { get; set; }

        [ForeignKey(nameof(BuyConsultationId))]
        [InverseProperty("BuyConsultationOffers")]
        public virtual BuyConsultation BuyConsultation { get; set; }
        [ForeignKey(nameof(CfgSupplierId))]
        [InverseProperty(nameof(CfgTier.BuyConsultationOffers))]
        public virtual CfgTier CfgSupplier { get; set; }
        [InverseProperty(nameof(BuyConsultationOfferGroup.BuyConsultationOffer))]
        public virtual ICollection<BuyConsultationOfferGroup> BuyConsultationOfferGroups { get; set; }
        [InverseProperty(nameof(BuyConsultationOfferLine.BuyConsultationOffer))]
        public virtual ICollection<BuyConsultationOfferLine> BuyConsultationOfferLines { get; set; }
        [InverseProperty(nameof(BuyConsultationOfferSupplier.BuyConsultationOffer))]
        public virtual ICollection<BuyConsultationOfferSupplier> BuyConsultationOfferSuppliers { get; set; }
    }
}
