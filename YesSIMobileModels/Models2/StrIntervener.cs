using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrIntervener")]
    public partial class StrIntervener
    {
        public StrIntervener()
        {
            StrNotificationInterveners = new HashSet<StrNotificationIntervener>();
            StrStatusInterveners = new HashSet<StrStatusIntervener>();
            StrWorkFlowInterveners = new HashSet<StrWorkFlowIntervener>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "text")]
        public string QueryText { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? AdmRoleId { get; set; }
        public Guid? AdmUserId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmRoleId))]
        [InverseProperty("StrInterveners")]
        public virtual AdmRole AdmRole { get; set; }
        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("StrInterveners")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StrInterveners")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(StrNotificationIntervener.StrIntervener))]
        public virtual ICollection<StrNotificationIntervener> StrNotificationInterveners { get; set; }
        [InverseProperty(nameof(StrStatusIntervener.StrIntervener))]
        public virtual ICollection<StrStatusIntervener> StrStatusInterveners { get; set; }
        [InverseProperty(nameof(StrWorkFlowIntervener.StrIntervener))]
        public virtual ICollection<StrWorkFlowIntervener> StrWorkFlowInterveners { get; set; }
    }
}
