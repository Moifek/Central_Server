using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(NotificationDefinitionId), Name = "IX_NotificationDefinitionId")]
    [Index(nameof(UserId), Name = "IX_UserId")]
    public partial class AdmWebNotification
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid UserId { get; set; }
        public Guid NotificationDefinitionId { get; set; }
        public string NameSpace { get; set; }
        public Guid NameSpaceId { get; set; }
        public string Object { get; set; }
        public string MessageBody { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(NotificationDefinitionId))]
        [InverseProperty(nameof(AdmWebNotificationDefinition.AdmWebNotifications))]
        public virtual AdmWebNotificationDefinition NotificationDefinition { get; set; }
    }
}
