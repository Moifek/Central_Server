using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhOverTime")]
    public partial class GrhOverTime
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
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? HoursNumber { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? GrhOverTimeTypeId { get; set; }
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

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("GrhOverTimes")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(GrhEmployeeId))]
        [InverseProperty(nameof(CfgTier.GrhOverTimes))]
        public virtual CfgTier GrhEmployee { get; set; }
        [ForeignKey(nameof(GrhOverTimeTypeId))]
        [InverseProperty("GrhOverTimes")]
        public virtual GrhOverTimeType GrhOverTimeType { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("GrhOverTimes")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("GrhOverTimes")]
        public virtual StrStatus StrStatus { get; set; }
    }
}
