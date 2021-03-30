using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgDelegation")]
    public partial class CfgDelegation
    {
        public CfgDelegation()
        {
            LndLands = new HashSet<LndLand>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? CfgDepartmentId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgDepartmentId))]
        [InverseProperty("CfgDelegations")]
        public virtual CfgDepartment CfgDepartment { get; set; }
        [InverseProperty(nameof(LndLand.CfgDelegation))]
        public virtual ICollection<LndLand> LndLands { get; set; }
    }
}
