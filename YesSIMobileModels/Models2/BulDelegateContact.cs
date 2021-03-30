using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BulDelegateContact")]
    public partial class BulDelegateContact
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? BulDelegateId { get; set; }
        public Guid? ContactId { get; set; }
        public bool? IsPresent { get; set; }
        public bool? Notify { get; set; }

        [ForeignKey(nameof(BulDelegateId))]
        [InverseProperty("BulDelegateContacts")]
        public virtual BulDelegate BulDelegate { get; set; }
        [ForeignKey(nameof(ContactId))]
        [InverseProperty(nameof(CfgTier.BulDelegateContacts))]
        public virtual CfgTier Contact { get; set; }
    }
}
