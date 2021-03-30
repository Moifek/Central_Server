using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhPaySlipModelUnityEntityValue")]
    public partial class GrhPaySlipModelUnityEntityValue
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? GrhPaySlipModelUnityId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public bool? IsPercentOfSalary { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DocValue { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("GrhPaySlipModelUnityEntityValues")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(GrhPaySlipModelUnityId))]
        [InverseProperty("GrhPaySlipModelUnityEntityValues")]
        public virtual GrhPaySlipModelUnity GrhPaySlipModelUnity { get; set; }
    }
}
