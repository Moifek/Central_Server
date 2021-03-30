using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFeasibilityStudyStatusHistory")]
    public partial class StkFeasibilityStudyStatusHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? StkFeasibilityStudyStatusId { get; set; }
        public Guid? StkFeasibilityStudyId { get; set; }
        public Guid? AdmUserId { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("StkFeasibilityStudyStatusHistories")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(StkFeasibilityStudyId))]
        [InverseProperty("StkFeasibilityStudyStatusHistories")]
        public virtual StkFeasibilityStudy StkFeasibilityStudy { get; set; }
        [ForeignKey(nameof(StkFeasibilityStudyStatusId))]
        [InverseProperty("StkFeasibilityStudyStatusHistories")]
        public virtual StkFeasibilityStudyStatus StkFeasibilityStudyStatus { get; set; }
    }
}
