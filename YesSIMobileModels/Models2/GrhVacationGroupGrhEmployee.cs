using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhVacationGroupGrhEmployee")]
    public partial class GrhVacationGroupGrhEmployee
    {
        public GrhVacationGroupGrhEmployee()
        {
            GrhVacations = new HashSet<GrhVacation>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? GrhVacationGroupId { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(GrhEmployeeId))]
        [InverseProperty(nameof(CfgTier.GrhVacationGroupGrhEmployees))]
        public virtual CfgTier GrhEmployee { get; set; }
        [ForeignKey(nameof(GrhVacationGroupId))]
        [InverseProperty("GrhVacationGroupGrhEmployees")]
        public virtual GrhVacationGroup GrhVacationGroup { get; set; }
        [InverseProperty(nameof(GrhVacation.GrhVacationGroupGrhEmployee))]
        public virtual ICollection<GrhVacation> GrhVacations { get; set; }
    }
}
