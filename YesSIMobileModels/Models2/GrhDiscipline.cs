using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhDiscipline")]
    public partial class GrhDiscipline
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
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? CfgCompanyId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("GrhDisciplines")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(GrhEmployeeId))]
        [InverseProperty(nameof(CfgTier.GrhDisciplines))]
        public virtual CfgTier GrhEmployee { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("GrhDisciplines")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("GrhDisciplines")]
        public virtual StrStatus StrStatus { get; set; }
    }
}
