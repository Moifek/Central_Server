using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(ModuleNameId), Name = "IX_ModuleNameId")]
    public partial class AdmWebNotificationDefinition
    {
        public AdmWebNotificationDefinition()
        {
            AdmWebNotificationDefinitionUsers = new HashSet<AdmWebNotificationDefinitionUser>();
            AdmWebNotifications = new HashSet<AdmWebNotification>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string Code { get; set; }
        public Guid ModuleNameId { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(ModuleNameId))]
        [InverseProperty(nameof(AdmWebModuleName.AdmWebNotificationDefinitions))]
        public virtual AdmWebModuleName ModuleName { get; set; }
        [InverseProperty(nameof(AdmWebNotificationDefinitionUser.NotificationDefinition))]
        public virtual ICollection<AdmWebNotificationDefinitionUser> AdmWebNotificationDefinitionUsers { get; set; }
        [InverseProperty(nameof(AdmWebNotification.NotificationDefinition))]
        public virtual ICollection<AdmWebNotification> AdmWebNotifications { get; set; }
    }
}
