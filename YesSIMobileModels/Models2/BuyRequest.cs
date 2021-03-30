using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyRequest")]
    public partial class BuyRequest
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        public bool? IsPrivate { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        public Guid? BuyItemId { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StrStatusId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(BuyItemId))]
        [InverseProperty("BuyRequests")]
        public virtual BuyItem BuyItem { get; set; }
        [ForeignKey(nameof(GrhEmployeeId))]
        [InverseProperty(nameof(CfgTier.BuyRequests))]
        public virtual CfgTier GrhEmployee { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("BuyRequests")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("BuyRequests")]
        public virtual StrStatus StrStatus { get; set; }
    }
}
