using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    public partial class AdmWebAlertDefinition
    {
        public AdmWebAlertDefinition()
        {
            AdmUsers = new HashSet<AdmUser2>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string Code { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(AdmUser2.WebAlertDefinition))]
        public virtual ICollection<AdmUser2> AdmUsers { get; set; }
    }
}
