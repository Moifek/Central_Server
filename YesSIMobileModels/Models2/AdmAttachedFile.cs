using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmAttachedFile")]
    public partial class AdmAttachedFile
    {
        [StringLength(255)]
        public string Category { get; set; }
        [StringLength(255)]
        public string CategoryDescription { get; set; }
        [StringLength(255)]
        public string Type { get; set; }
        [StringLength(255)]
        public string Extention { get; set; }
        [Column(TypeName = "image")]
        public byte[] AttachedFile { get; set; }
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CategoryId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? AdmAttachedFileTypeId { get; set; }
        [StringLength(255)]
        public string FoderGroup { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public int? OpenBeeDocumentId { get; set; }

        [ForeignKey(nameof(AdmAttachedFileTypeId))]
        [InverseProperty("AdmAttachedFiles")]
        public virtual AdmAttachedFileType AdmAttachedFileType { get; set; }
    }
}
