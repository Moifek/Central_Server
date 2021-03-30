using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmReportDataRole")]
    public partial class AdmReportDataRole
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? AdmRoleId { get; set; }
        public Guid? AdmReportDataId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmReportDataId))]
        [InverseProperty(nameof(AdmReportDatum.AdmReportDataRoles))]
        public virtual AdmReportDatum AdmReportData { get; set; }
        [ForeignKey(nameof(AdmRoleId))]
        [InverseProperty("AdmReportDataRoles")]
        public virtual AdmRole AdmRole { get; set; }
    }
}
