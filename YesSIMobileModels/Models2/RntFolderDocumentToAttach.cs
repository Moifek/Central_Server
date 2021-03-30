using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntFolderDocumentToAttach")]
    public partial class RntFolderDocumentToAttach
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? RntFolderId { get; set; }
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
        [InverseProperty("RntFolderDocumentToAttaches")]
        public virtual AdmAttachedFileType AdmAttachedFileType { get; set; }
    }
}
