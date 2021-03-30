using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhPaySlipModelKind")]
    public partial class GrhPaySlipModelKind
    {
        public GrhPaySlipModelKind()
        {
            GrhPaySlipModels = new HashSet<GrhPaySlipModel>();
            GrhPaySlips = new HashSet<GrhPaySlip>();
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
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(GrhPaySlipModel.GrhPaySlipModelKind))]
        public virtual ICollection<GrhPaySlipModel> GrhPaySlipModels { get; set; }
        [InverseProperty(nameof(GrhPaySlip.GrhPaySlipModelKind))]
        public virtual ICollection<GrhPaySlip> GrhPaySlips { get; set; }
    }
}
