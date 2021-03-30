using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhVacationGroup")]
    public partial class GrhVacationGroup
    {
        public GrhVacationGroup()
        {
            GrhVacationGroupGrhEmployees = new HashSet<GrhVacationGroupGrhEmployee>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTo { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DaysNumber { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? GrhVacationTypeId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StrStatusId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("GrhVacationGroups")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(GrhVacationTypeId))]
        [InverseProperty("GrhVacationGroups")]
        public virtual GrhVacationType GrhVacationType { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("GrhVacationGroups")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("GrhVacationGroups")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(GrhVacationGroupGrhEmployee.GrhVacationGroup))]
        public virtual ICollection<GrhVacationGroupGrhEmployee> GrhVacationGroupGrhEmployees { get; set; }
    }
}
