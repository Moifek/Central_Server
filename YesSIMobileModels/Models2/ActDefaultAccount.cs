using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActDefaultAccount")]
    public partial class ActDefaultAccount
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ActAccountId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? CfgProjectId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? StlAccountId { get; set; }
        public bool? RatioEnabled { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Ratio { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsCredit { get; set; }
        public Guid? StlCategoryId { get; set; }

        [ForeignKey(nameof(ActAccountId))]
        [InverseProperty("ActDefaultAccounts")]
        public virtual ActAccount ActAccount { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ActDefaultAccounts")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgProjectId))]
        [InverseProperty("ActDefaultAccounts")]
        public virtual CfgProject CfgProject { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("ActDefaultAccounts")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(StlAccountId))]
        [InverseProperty("ActDefaultAccounts")]
        public virtual StlAccount StlAccount { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("ActDefaultAccounts")]
        public virtual StlCategory StlCategory { get; set; }
    }
}
