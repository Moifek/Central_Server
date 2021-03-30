using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmNotification")]
    public partial class AdmNotification
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(1000)]
        public string Note { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? EntityId { get; set; }
        public Guid? FromUserId { get; set; }
        public Guid? ToUserId { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsOpened { get; set; }

        [ForeignKey(nameof(FromUserId))]
        [InverseProperty(nameof(AdmUser2.AdmNotificationFromUsers))]
        public virtual AdmUser2 FromUser { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("AdmNotifications")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(ToUserId))]
        [InverseProperty(nameof(AdmUser2.AdmNotificationToUsers))]
        public virtual AdmUser2 ToUser { get; set; }
    }
}
