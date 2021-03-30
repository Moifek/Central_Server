using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlAcountDeposit")]
    public partial class StlAcountDeposit
    {
        public StlAcountDeposit()
        {
            StlPaymentAuthorizations = new HashSet<StlPaymentAuthorization>();
            StlSettlements = new HashSet<StlSettlement>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(500)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? AdmUserId { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        public Guid? GrhEmployeeClosingId { get; set; }
        public Guid? StlDepositId { get; set; }
        public Guid? StlDepositToId { get; set; }
        public Guid? StlAccountToId { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountOpening { get; set; }

        [ForeignKey(nameof(GrhEmployeeId))]
        [InverseProperty(nameof(CfgTier.StlAcountDepositGrhEmployees))]
        public virtual CfgTier GrhEmployee { get; set; }
        [ForeignKey(nameof(GrhEmployeeClosingId))]
        [InverseProperty(nameof(CfgTier.StlAcountDepositGrhEmployeeClosings))]
        public virtual CfgTier GrhEmployeeClosing { get; set; }
        [ForeignKey(nameof(StlAccountToId))]
        [InverseProperty(nameof(StlAccount.StlAcountDeposits))]
        public virtual StlAccount StlAccountTo { get; set; }
        [ForeignKey(nameof(StlDepositId))]
        [InverseProperty("StlAcountDepositStlDeposits")]
        public virtual StlDeposit StlDeposit { get; set; }
        [ForeignKey(nameof(StlDepositToId))]
        [InverseProperty("StlAcountDepositStlDepositTos")]
        public virtual StlDeposit StlDepositTo { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StlAcountDeposits")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorization.StlAcountDeposit))]
        public virtual ICollection<StlPaymentAuthorization> StlPaymentAuthorizations { get; set; }
        [InverseProperty(nameof(StlSettlement.StlAcountDeposit))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
    }
}
