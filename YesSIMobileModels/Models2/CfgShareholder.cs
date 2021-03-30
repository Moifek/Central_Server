using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgShareholder")]
    public partial class CfgShareholder
    {
        public CfgShareholder()
        {
            CfgCompanyShareholders = new HashSet<CfgCompanyShareholder>();
            CfgGroupShareholderLines = new HashSet<CfgGroupShareholderLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }

        [InverseProperty(nameof(CfgCompanyShareholder.CfgShareholder))]
        public virtual ICollection<CfgCompanyShareholder> CfgCompanyShareholders { get; set; }
        [InverseProperty(nameof(CfgGroupShareholderLine.CfgShareholder))]
        public virtual ICollection<CfgGroupShareholderLine> CfgGroupShareholderLines { get; set; }
    }
}
