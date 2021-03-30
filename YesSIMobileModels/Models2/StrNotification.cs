using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrNotification")]
    public partial class StrNotification
    {
        public StrNotification()
        {
            StrNotificationInterveners = new HashSet<StrNotificationIntervener>();
            StrNotificationWorkFlows = new HashSet<StrNotificationWorkFlow>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? AdmReportId { get; set; }
        public bool? GroupedMail { get; set; }
        public bool? AfterAdd { get; set; }
        public bool? AfterUpDate { get; set; }
        public bool? AfterDelete { get; set; }
        [StringLength(1000)]
        public string Subject { get; set; }
        [Column(TypeName = "text")]
        public string Text { get; set; }
        [Column(TypeName = "text")]
        public string QueryText { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmReportId))]
        [InverseProperty(nameof(AdmReportDatum.StrNotifications))]
        public virtual AdmReportDatum AdmReport { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StrNotifications")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(StrNotificationIntervener.StrNotification))]
        public virtual ICollection<StrNotificationIntervener> StrNotificationInterveners { get; set; }
        [InverseProperty(nameof(StrNotificationWorkFlow.StrNotification))]
        public virtual ICollection<StrNotificationWorkFlow> StrNotificationWorkFlows { get; set; }
    }
}
