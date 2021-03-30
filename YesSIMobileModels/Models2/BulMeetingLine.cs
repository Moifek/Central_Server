using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BulMeetingLine")]
    public partial class BulMeetingLine
    {
        public BulMeetingLine()
        {
            InverseBulMeetingLineNavigation = new HashSet<BulMeetingLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Note { get; set; }
        public bool? IsClosed { get; set; }
        public Guid? CfgSupplierId { get; set; }
        public Guid? PrjMarketId { get; set; }
        public Guid? BulMeetingId { get; set; }
        public Guid? BulMeetingLineId { get; set; }
        public Guid? BulObservationStatusId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsInternal { get; set; }

        [ForeignKey(nameof(BulMeetingId))]
        [InverseProperty("BulMeetingLines")]
        public virtual BulMeeting BulMeeting { get; set; }
        [ForeignKey(nameof(BulMeetingLineId))]
        [InverseProperty(nameof(BulMeetingLine.InverseBulMeetingLineNavigation))]
        public virtual BulMeetingLine BulMeetingLineNavigation { get; set; }
        [ForeignKey(nameof(BulObservationStatusId))]
        [InverseProperty("BulMeetingLines")]
        public virtual BulObservationStatus BulObservationStatus { get; set; }
        [ForeignKey(nameof(CfgSupplierId))]
        [InverseProperty(nameof(CfgTier.BulMeetingLines))]
        public virtual CfgTier CfgSupplier { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("BulMeetingLines")]
        public virtual PrjMarket PrjMarket { get; set; }
        [InverseProperty(nameof(BulMeetingLine.BulMeetingLineNavigation))]
        public virtual ICollection<BulMeetingLine> InverseBulMeetingLineNavigation { get; set; }
    }
}
