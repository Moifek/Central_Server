using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileAPI.Models
{
    [Table("AdmRole")]
    public partial class AdmRole
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? AdmRoleTypeId { get; set; }

        [ForeignKey(nameof(AdmRoleTypeId))]
        [InverseProperty("AdmRoles")]
        public virtual AdmRoleType AdmRoleType { get; set; }
    }
}
