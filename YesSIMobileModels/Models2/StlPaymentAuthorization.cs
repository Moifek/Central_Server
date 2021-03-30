using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlPaymentAuthorization")]
    public partial class StlPaymentAuthorization
    {
        public StlPaymentAuthorization()
        {
            StlPaymentAuthorizationLines = new HashSet<StlPaymentAuthorizationLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public bool? IsCredit { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? CfgTierOtherId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? AdmModuleId { get; set; }
        public Guid? StlSettlementId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StlAcountDepositId { get; set; }
        public Guid? StlRecoveryFolderId { get; set; }

        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("StlPaymentAuthorizations")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlPaymentAuthorizations")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("StlPaymentAuthorizationCfgTiers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(CfgTierOtherId))]
        [InverseProperty("StlPaymentAuthorizationCfgTierOthers")]
        public virtual CfgTier CfgTierOther { get; set; }
        [ForeignKey(nameof(StlAcountDepositId))]
        [InverseProperty("StlPaymentAuthorizations")]
        public virtual StlAcountDeposit StlAcountDeposit { get; set; }
        [ForeignKey(nameof(StlRecoveryFolderId))]
        [InverseProperty("StlPaymentAuthorizations")]
        public virtual StlRecoveryFolder StlRecoveryFolder { get; set; }
        [ForeignKey(nameof(StlSettlementId))]
        [InverseProperty("StlPaymentAuthorizations")]
        public virtual StlSettlement StlSettlement { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StlPaymentAuthorizations")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("StlPaymentAuthorizations")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorizationLine.StlPaymentAuthorization))]
        public virtual ICollection<StlPaymentAuthorizationLine> StlPaymentAuthorizationLines { get; set; }
    }
}
