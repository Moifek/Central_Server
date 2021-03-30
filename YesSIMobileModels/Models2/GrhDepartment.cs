using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhDepartment")]
    public partial class GrhDepartment
    {
        public GrhDepartment()
        {
            CfgTiers = new HashSet<CfgTier>();
            GrhEmployeeHistories = new HashSet<GrhEmployeeHistory>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? GrhManagerId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgCompanyId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("GrhDepartments")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(GrhManagerId))]
        [InverseProperty(nameof(CfgTier.GrhDepartments))]
        public virtual CfgTier GrhManager { get; set; }
        [InverseProperty(nameof(CfgTier.GrhDepartment))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
        [InverseProperty(nameof(GrhEmployeeHistory.GrhDepartment))]
        public virtual ICollection<GrhEmployeeHistory> GrhEmployeeHistories { get; set; }
    }
}
