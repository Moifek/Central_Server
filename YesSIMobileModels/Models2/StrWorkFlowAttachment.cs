using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrWorkFlowAttachment")]
    public partial class StrWorkFlowAttachment
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrAttachmentId { get; set; }
        public Guid? StrWorkFlowId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StrAttachmentId))]
        [InverseProperty("StrWorkFlowAttachments")]
        public virtual StrAttachment StrAttachment { get; set; }
        [ForeignKey(nameof(StrWorkFlowId))]
        [InverseProperty("StrWorkFlowAttachments")]
        public virtual StrWorkFlow StrWorkFlow { get; set; }
    }
}
