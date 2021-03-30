using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhPaySlipModel")]
    public partial class GrhPaySlipModel
    {
        public GrhPaySlipModel()
        {
            CfgTiers = new HashSet<CfgTier>();
            GrhEmployeeHistories = new HashSet<GrhEmployeeHistory>();
            GrhPaySlipModelLines = new HashSet<GrhPaySlipModelLine>();
            GrhPaySlips = new HashSet<GrhPaySlip>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValidityDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "text")]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseWorkedDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVacationDaysNumber { get; set; }
        public Guid? GrhPaySlipModelKindId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(GrhPaySlipModelKindId))]
        [InverseProperty("GrhPaySlipModels")]
        public virtual GrhPaySlipModelKind GrhPaySlipModelKind { get; set; }
        [InverseProperty(nameof(CfgTier.GrhPaySlipModel))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
        [InverseProperty(nameof(GrhEmployeeHistory.GrhPaySlipModel))]
        public virtual ICollection<GrhEmployeeHistory> GrhEmployeeHistories { get; set; }
        [InverseProperty(nameof(GrhPaySlipModelLine.GrhPaySlipModel))]
        public virtual ICollection<GrhPaySlipModelLine> GrhPaySlipModelLines { get; set; }
        [InverseProperty(nameof(GrhPaySlip.GrhPaySlipModel))]
        public virtual ICollection<GrhPaySlip> GrhPaySlips { get; set; }
    }
}
