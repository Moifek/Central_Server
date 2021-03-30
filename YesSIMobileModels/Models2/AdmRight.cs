using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmRight")]
    public partial class AdmRight
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? AdmRoleId { get; set; }

        [ForeignKey(nameof(AdmRoleId))]
        [InverseProperty("AdmRights")]
        public virtual AdmRole AdmRole { get; set; }
    }
}
