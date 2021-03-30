using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFeasibilityStudyWorkFlowDocumentToAttach")]
    public partial class StkFeasibilityStudyWorkFlowDocumentToAttach
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StkFeasibilityStudyWorkFlowId { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? WithTitle { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? AdmAttachedFileTypeId { get; set; }

        [ForeignKey(nameof(AdmAttachedFileTypeId))]
        [InverseProperty("StkFeasibilityStudyWorkFlowDocumentToAttaches")]
        public virtual AdmAttachedFileType AdmAttachedFileType { get; set; }
        [ForeignKey(nameof(StkFeasibilityStudyWorkFlowId))]
        [InverseProperty("StkFeasibilityStudyWorkFlowDocumentToAttaches")]
        public virtual StkFeasibilityStudyWorkFlow StkFeasibilityStudyWorkFlow { get; set; }
    }
}
