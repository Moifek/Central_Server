using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmUserRole")]
    public partial class AdmUserRole
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? AdmRoleId { get; set; }
        public Guid? AdmUserId { get; set; }

        [ForeignKey(nameof(AdmRoleId))]
        [InverseProperty("AdmUserRoles")]
        public virtual AdmRole AdmRole { get; set; }
        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("AdmUserRoles")]
        public virtual AdmUser2 AdmUser { get; set; }
    }
}
