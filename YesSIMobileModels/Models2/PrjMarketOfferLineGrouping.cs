using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketOfferLineGrouping")]
    public partial class PrjMarketOfferLineGrouping
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? PrjMarketOfferId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }

        [ForeignKey(nameof(PrjMarketOfferId))]
        [InverseProperty("PrjMarketOfferLineGroupings")]
        public virtual PrjMarketOffer PrjMarketOffer { get; set; }
    }
}
