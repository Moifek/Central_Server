using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BulMeetingContact")]
    public partial class BulMeetingContact
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? BulMeetingId { get; set; }
        public Guid? ContactId { get; set; }
        public bool? IsPresent { get; set; }
        public bool? Notify { get; set; }

        [ForeignKey(nameof(BulMeetingId))]
        [InverseProperty("BulMeetingContacts")]
        public virtual BulMeeting BulMeeting { get; set; }
        [ForeignKey(nameof(ContactId))]
        [InverseProperty(nameof(CfgTier.BulMeetingContacts))]
        public virtual CfgTier Contact { get; set; }
    }
}
