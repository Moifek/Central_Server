using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrHistory")]
    public partial class StrHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? ObjectId { get; set; }
        public Guid? AdmUserId { get; set; }
        [StringLength(1000)]
        public string AdmUserDescription { get; set; }
        public Guid? StrWorkflowId { get; set; }
        [StringLength(1000)]
        public string StrWorkflowDescription { get; set; }
        public Guid? StrStatusId { get; set; }
        [StringLength(1000)]
        public string StrStatusDescription { get; set; }

        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StrHistories")]
        public virtual StrEntity StrEntity { get; set; }
    }
}
