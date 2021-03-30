using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFeasibilityStudyWorkFlow")]
    public partial class StkFeasibilityStudyWorkFlow
    {
        public StkFeasibilityStudyWorkFlow()
        {
            StkFeasibilityStudyWorkFlowAdmRoles = new HashSet<StkFeasibilityStudyWorkFlowAdmRole>();
            StkFeasibilityStudyWorkFlowDocumentToAttaches = new HashSet<StkFeasibilityStudyWorkFlowDocumentToAttach>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? StartStatusId { get; set; }
        public Guid? EndStatusId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string MandatoryFields { get; set; }
        public bool? NotesMandatory { get; set; }
        public Guid? StrEntityId { get; set; }
        public bool? WithNotification { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? SendEmailToUsers { get; set; }

        [ForeignKey(nameof(EndStatusId))]
        [InverseProperty(nameof(StkFeasibilityStudyStatus.StkFeasibilityStudyWorkFlowEndStatuses))]
        public virtual StkFeasibilityStudyStatus EndStatus { get; set; }
        [ForeignKey(nameof(StartStatusId))]
        [InverseProperty(nameof(StkFeasibilityStudyStatus.StkFeasibilityStudyWorkFlowStartStatuses))]
        public virtual StkFeasibilityStudyStatus StartStatus { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StkFeasibilityStudyWorkFlows")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyWorkFlowAdmRole.WorkFlow))]
        public virtual ICollection<StkFeasibilityStudyWorkFlowAdmRole> StkFeasibilityStudyWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyWorkFlowDocumentToAttach.StkFeasibilityStudyWorkFlow))]
        public virtual ICollection<StkFeasibilityStudyWorkFlowDocumentToAttach> StkFeasibilityStudyWorkFlowDocumentToAttaches { get; set; }
    }
}
