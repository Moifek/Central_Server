using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BulDelegate")]
    public partial class BulDelegate
    {
        public BulDelegate()
        {
            BulDelegateContacts = new HashSet<BulDelegateContact>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? PrjMarketId { get; set; }
        public Guid? BulMeetingId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public int? Effectif { get; set; }
        public Guid? CfgSupplierId { get; set; }

        [ForeignKey(nameof(BulMeetingId))]
        [InverseProperty("BulDelegates")]
        public virtual BulMeeting BulMeeting { get; set; }
        [ForeignKey(nameof(CfgSupplierId))]
        [InverseProperty(nameof(CfgTier.BulDelegates))]
        public virtual CfgTier CfgSupplier { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("BulDelegates")]
        public virtual PrjMarket PrjMarket { get; set; }
        [InverseProperty(nameof(BulDelegateContact.BulDelegate))]
        public virtual ICollection<BulDelegateContact> BulDelegateContacts { get; set; }
    }
}
