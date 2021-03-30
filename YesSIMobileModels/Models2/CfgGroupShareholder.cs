using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgGroupShareholder")]
    public partial class CfgGroupShareholder
    {
        public CfgGroupShareholder()
        {
            CfgCompanies = new HashSet<CfgCompany>();
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

        [InverseProperty(nameof(CfgCompany.CfgGroupShareholder))]
        public virtual ICollection<CfgCompany> CfgCompanies { get; set; }
        [InverseProperty(nameof(CfgGroupShareholderLine.CfgGroupShareholder))]
        public virtual ICollection<CfgGroupShareholderLine> CfgGroupShareholderLines { get; set; }
    }
}
