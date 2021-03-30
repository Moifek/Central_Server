using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmFormsLog")]
    public partial class AdmFormsLog
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(500)]
        public string NameSpace { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActionDateTime { get; set; }
        [StringLength(500)]
        public string UserDescription { get; set; }
        public Guid? AdmUserId { get; set; }
        public Guid? AdmSessionId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("AdmFormsLogs")]
        public virtual AdmUser2 AdmUser { get; set; }
    }
}
