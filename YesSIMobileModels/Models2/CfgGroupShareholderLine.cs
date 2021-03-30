using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgGroupShareholderLine")]
    public partial class CfgGroupShareholderLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgGroupShareholderId { get; set; }
        public Guid? CfgShareholderId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SharingNumber { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgGroupShareholderId))]
        [InverseProperty("CfgGroupShareholderLines")]
        public virtual CfgGroupShareholder CfgGroupShareholder { get; set; }
        [ForeignKey(nameof(CfgShareholderId))]
        [InverseProperty("CfgGroupShareholderLines")]
        public virtual CfgShareholder CfgShareholder { get; set; }
    }
}
