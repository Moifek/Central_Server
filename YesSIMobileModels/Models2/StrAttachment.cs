using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrAttachment")]
    public partial class StrAttachment
    {
        public StrAttachment()
        {
            StrWorkFlowAttachments = new HashSet<StrWorkFlowAttachment>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrEntityId { get; set; }
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
        [InverseProperty("StrAttachments")]
        public virtual AdmAttachedFileType AdmAttachedFileType { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StrAttachments")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(StrWorkFlowAttachment.StrAttachment))]
        public virtual ICollection<StrWorkFlowAttachment> StrWorkFlowAttachments { get; set; }
    }
}
