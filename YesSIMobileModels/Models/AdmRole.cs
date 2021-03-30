using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models
{
    [Table("AdmRole")]
    public partial class AdmRole
    {
        public AdmRole()
        {
            AdmUsers = new HashSet<AdmUser>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? AdmRoleTypeId { get; set; }

        [ForeignKey(nameof(AdmRoleTypeId))]
        [InverseProperty("AdmRoles")]
        public virtual AdmRoleType AdmRoleType { get; set; }
        [InverseProperty(nameof(AdmUser.AdmRole))]
        public virtual ICollection<AdmUser> AdmUsers { get; set; }
    }
}
