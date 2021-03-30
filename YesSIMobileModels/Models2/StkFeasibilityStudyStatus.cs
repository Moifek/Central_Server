using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFeasibilityStudyStatus")]
    public partial class StkFeasibilityStudyStatus
    {
        public StkFeasibilityStudyStatus()
        {
            StkFeasibilityStudies = new HashSet<StkFeasibilityStudy>();
            StkFeasibilityStudyStatusDocumentToAttaches = new HashSet<StkFeasibilityStudyStatusDocumentToAttach>();
            StkFeasibilityStudyStatusHistories = new HashSet<StkFeasibilityStudyStatusHistory>();
            StkFeasibilityStudyWorkFlowEndStatuses = new HashSet<StkFeasibilityStudyWorkFlow>();
            StkFeasibilityStudyWorkFlowStartStatuses = new HashSet<StkFeasibilityStudyWorkFlow>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        public int? Delay { get; set; }
        [StringLength(1000)]
        public string MandatoryFields { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        public Guid? CfgImageId { get; set; }
        public Guid? AdmWorkFlowStateTypeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmWorkFlowStateTypeId))]
        [InverseProperty("StkFeasibilityStudyStatuses")]
        public virtual AdmWorkFlowStateType AdmWorkFlowStateType { get; set; }
        [ForeignKey(nameof(CfgImageId))]
        [InverseProperty("StkFeasibilityStudyStatuses")]
        public virtual CfgImage CfgImage { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudy.StkFeasibilityStudyStatus))]
        public virtual ICollection<StkFeasibilityStudy> StkFeasibilityStudies { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyStatusDocumentToAttach.StkFeasibilityStudyStatus))]
        public virtual ICollection<StkFeasibilityStudyStatusDocumentToAttach> StkFeasibilityStudyStatusDocumentToAttaches { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyStatusHistory.StkFeasibilityStudyStatus))]
        public virtual ICollection<StkFeasibilityStudyStatusHistory> StkFeasibilityStudyStatusHistories { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyWorkFlow.EndStatus))]
        public virtual ICollection<StkFeasibilityStudyWorkFlow> StkFeasibilityStudyWorkFlowEndStatuses { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyWorkFlow.StartStatus))]
        public virtual ICollection<StkFeasibilityStudyWorkFlow> StkFeasibilityStudyWorkFlowStartStatuses { get; set; }
    }
}
