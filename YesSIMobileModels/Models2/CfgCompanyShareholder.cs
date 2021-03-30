using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgCompanyShareholder")]
    public partial class CfgCompanyShareholder
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public int? SharingNumber { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgShareholderId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("CfgCompanyShareholders")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgShareholderId))]
        [InverseProperty("CfgCompanyShareholders")]
        public virtual CfgShareholder CfgShareholder { get; set; }
    }
}
