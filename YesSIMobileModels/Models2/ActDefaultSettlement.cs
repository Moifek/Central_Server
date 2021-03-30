using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActDefaultSettlement")]
    public partial class ActDefaultSettlement
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public bool? IsCredit { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        public Guid? StlDepositId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? StlAccountId { get; set; }
        public Guid? ActAccountId { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
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

        [ForeignKey(nameof(ActAccountId))]
        [InverseProperty("ActDefaultSettlements")]
        public virtual ActAccount ActAccount { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ActDefaultSettlements")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(StlAccountId))]
        [InverseProperty("ActDefaultSettlements")]
        public virtual StlAccount StlAccount { get; set; }
        [ForeignKey(nameof(StlDepositId))]
        [InverseProperty("ActDefaultSettlements")]
        public virtual StlDeposit StlDeposit { get; set; }
        [ForeignKey(nameof(StlSettlementTypeId))]
        [InverseProperty("ActDefaultSettlements")]
        public virtual StlSettlementType StlSettlementType { get; set; }
    }
}
