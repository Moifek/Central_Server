using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComOffer")]
    public partial class ComOffer
    {
        public ComOffer()
        {
            ComOfferItems = new HashSet<ComOfferItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? ComProspectionId { get; set; }
        public Guid? StkHierarchyId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MaturityDate { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("ComOffers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("ComOffers")]
        public virtual ComProspection ComProspection { get; set; }
        [ForeignKey(nameof(StkHierarchyId))]
        [InverseProperty(nameof(CfgTranche.ComOffers))]
        public virtual CfgTranche StkHierarchy { get; set; }
        [InverseProperty(nameof(ComOfferItem.ComOffer))]
        public virtual ICollection<ComOfferItem> ComOfferItems { get; set; }
    }
}
