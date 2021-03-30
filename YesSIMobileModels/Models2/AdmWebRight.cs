using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(RoleId), Name = "IX_RoleId")]
    public partial class AdmWebRight
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string NodeKey { get; set; }
        public Guid RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(AdmRole.AdmWebRights))]
        public virtual AdmRole Role { get; set; }
    }
}
