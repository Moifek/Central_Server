using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhVacation")]
    public partial class GrhVacation
    {
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
        public Guid? GrhEmployeeId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? GrhVacationGroupGrhEmployeeId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("GrhVacations")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(GrhEmployeeId))]
        [InverseProperty(nameof(CfgTier.GrhVacations))]
        public virtual CfgTier GrhEmployee { get; set; }
        [ForeignKey(nameof(GrhVacationGroupGrhEmployeeId))]
        [InverseProperty("GrhVacations")]
        public virtual GrhVacationGroupGrhEmployee GrhVacationGroupGrhEmployee { get; set; }
        [ForeignKey(nameof(GrhVacationTypeId))]
        [InverseProperty("GrhVacations")]
        public virtual GrhVacationType GrhVacationType { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("GrhVacations")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("GrhVacations")]
        public virtual StrStatus StrStatus { get; set; }
    }
}
