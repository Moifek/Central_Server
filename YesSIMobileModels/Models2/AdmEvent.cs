using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmEvent")]
    public partial class AdmEvent
    {
        public AdmEvent()
        {
            ComActionMessages = new HashSet<ComActionMessage>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgEmloyeeId { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? AdmEventTypeId { get; set; }
        public Guid? ComFolderId { get; set; }
        [StringLength(255)]
        public string Subject { get; set; }
        [StringLength(255)]
        public string Location { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartHour { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndHour { get; set; }
        public bool? AllDay { get; set; }
        [StringLength(255)]
        public string Color { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string EventStatus { get; set; }
        public Guid? ComActionMessageSubCategoryId { get; set; }

        [ForeignKey(nameof(AdmEventTypeId))]
        [InverseProperty("AdmEvents")]
        public virtual AdmEventType AdmEventType { get; set; }
        [ForeignKey(nameof(CfgEmloyeeId))]
        [InverseProperty(nameof(CfgTier.AdmEvents))]
        public virtual CfgTier CfgEmloyee { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("AdmEvents")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(ComActionMessageSubCategoryId))]
        [InverseProperty("AdmEvents")]
        public virtual ComActionMessageSubCategory ComActionMessageSubCategory { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("AdmEvents")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("AdmEvents")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(ComActionMessage.AdmEvent))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
    }
}
