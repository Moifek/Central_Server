using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhVacationType")]
    public partial class GrhVacationType
    {
        public GrhVacationType()
        {
            GrhVacationGroups = new HashSet<GrhVacationGroup>();
            GrhVacations = new HashSet<GrhVacation>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsCharged { get; set; }
        public bool? IsChargedWorkedDay { get; set; }

        [InverseProperty(nameof(GrhVacationGroup.GrhVacationType))]
        public virtual ICollection<GrhVacationGroup> GrhVacationGroups { get; set; }
        [InverseProperty(nameof(GrhVacation.GrhVacationType))]
        public virtual ICollection<GrhVacation> GrhVacations { get; set; }
    }
}
