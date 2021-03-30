using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntFolderWorkFlowDocumentToAttach")]
    public partial class RntFolderWorkFlowDocumentToAttach
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? RntFolderWorkFlowId { get; set; }
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
        [InverseProperty("RntFolderWorkFlowDocumentToAttaches")]
        public virtual AdmAttachedFileType AdmAttachedFileType { get; set; }
        [ForeignKey(nameof(RntFolderWorkFlowId))]
        [InverseProperty("RntFolderWorkFlowDocumentToAttaches")]
        public virtual RntFolderWorkFlow RntFolderWorkFlow { get; set; }
    }
}
