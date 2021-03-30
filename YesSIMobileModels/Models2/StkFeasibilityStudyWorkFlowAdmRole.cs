using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFeasibilityStudyWorkFlowAdmRole")]
    public partial class StkFeasibilityStudyWorkFlowAdmRole
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? WorkFlowId { get; set; }
        public Guid? AdmRoleId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmRoleId))]
        [InverseProperty("StkFeasibilityStudyWorkFlowAdmRoles")]
        public virtual AdmRole AdmRole { get; set; }
        [ForeignKey(nameof(WorkFlowId))]
        [InverseProperty(nameof(StkFeasibilityStudyWorkFlow.StkFeasibilityStudyWorkFlowAdmRoles))]
        public virtual StkFeasibilityStudyWorkFlow WorkFlow { get; set; }
    }
}
