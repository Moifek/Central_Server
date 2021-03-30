using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrWorkFlow")]
    public partial class StrWorkFlow
    {
        public StrWorkFlow()
        {
            StrNotificationWorkFlows = new HashSet<StrNotificationWorkFlow>();
            StrWorkFlowAttachments = new HashSet<StrWorkFlowAttachment>();
            StrWorkFlowFields = new HashSet<StrWorkFlowField>();
            StrWorkFlowInterveners = new HashSet<StrWorkFlowIntervener>();
            StrWorkFlowTierFields = new HashSet<StrWorkFlowTierField>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StatusFromId { get; set; }
        public Guid? StatusToId { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? WithComment { get; set; }
        public bool? WithPassword { get; set; }
        public Guid? StrFieldDateId { get; set; }

        [ForeignKey(nameof(StatusFromId))]
        [InverseProperty(nameof(StrStatus.StrWorkFlowStatusFroms))]
        public virtual StrStatus StatusFrom { get; set; }
        [ForeignKey(nameof(StatusToId))]
        [InverseProperty(nameof(StrStatus.StrWorkFlowStatusTos))]
        public virtual StrStatus StatusTo { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StrWorkFlows")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrFieldDateId))]
        [InverseProperty(nameof(StrField.StrWorkFlows))]
        public virtual StrField StrFieldDate { get; set; }
        [InverseProperty(nameof(StrNotificationWorkFlow.StrWorkFlow))]
        public virtual ICollection<StrNotificationWorkFlow> StrNotificationWorkFlows { get; set; }
        [InverseProperty(nameof(StrWorkFlowAttachment.StrWorkFlow))]
        public virtual ICollection<StrWorkFlowAttachment> StrWorkFlowAttachments { get; set; }
        [InverseProperty(nameof(StrWorkFlowField.StrWorkFlow))]
        public virtual ICollection<StrWorkFlowField> StrWorkFlowFields { get; set; }
        [InverseProperty(nameof(StrWorkFlowIntervener.StrWorkFlow))]
        public virtual ICollection<StrWorkFlowIntervener> StrWorkFlowInterveners { get; set; }
        [InverseProperty(nameof(StrWorkFlowTierField.StrWorkFlow))]
        public virtual ICollection<StrWorkFlowTierField> StrWorkFlowTierFields { get; set; }
    }
}
