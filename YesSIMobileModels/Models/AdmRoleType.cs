using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models
{
    [Table("AdmRoleType")]
    public partial class AdmRoleType
    {
        public AdmRoleType()
        {
            AdmRoles = new HashSet<AdmRole>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [InverseProperty(nameof(AdmRole.AdmRoleType))]
        public virtual ICollection<AdmRole> AdmRoles { get; set; }
    }
}
