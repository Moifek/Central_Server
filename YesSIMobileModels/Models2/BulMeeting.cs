using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BulMeeting")]
    public partial class BulMeeting
    {
        public BulMeeting()
        {
            BulDelegates = new HashSet<BulDelegate>();
            BulMeetingContacts = new HashSet<BulMeetingContact>();
            BulMeetingLines = new HashSet<BulMeetingLine>();
            BulMeetingPrjProjectProgressCriteriaLines = new HashSet<BulMeetingPrjProjectProgressCriteriaLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MeetingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextDate { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public int? Sorting { get; set; }
        [StringLength(500)]
        public string Note { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? BulMeetingTypeId { get; set; }

        [ForeignKey(nameof(BulMeetingTypeId))]
        [InverseProperty("BulMeetings")]
        public virtual BulMeetingType BulMeetingType { get; set; }
        [ForeignKey(nameof(CfgEmployeeId))]
        [InverseProperty(nameof(CfgTier.BulMeetings))]
        public virtual CfgTier CfgEmployee { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("BulMeetings")]
        public virtual PrjProject PrjProject { get; set; }
        [InverseProperty(nameof(BulDelegate.BulMeeting))]
        public virtual ICollection<BulDelegate> BulDelegates { get; set; }
        [InverseProperty(nameof(BulMeetingContact.BulMeeting))]
        public virtual ICollection<BulMeetingContact> BulMeetingContacts { get; set; }
        [InverseProperty(nameof(BulMeetingLine.BulMeeting))]
        public virtual ICollection<BulMeetingLine> BulMeetingLines { get; set; }
        [InverseProperty(nameof(BulMeetingPrjProjectProgressCriteriaLine.BulMeeting))]
        public virtual ICollection<BulMeetingPrjProjectProgressCriteriaLine> BulMeetingPrjProjectProgressCriteriaLines { get; set; }
    }
}
