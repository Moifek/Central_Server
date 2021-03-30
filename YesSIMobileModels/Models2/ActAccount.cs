using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActAccount")]
    public partial class ActAccount
    {
        public ActAccount()
        {
            ActDefaultAccounts = new HashSet<ActDefaultAccount>();
            ActDefaultSettlements = new HashSet<ActDefaultSettlement>();
            ActEntryLines = new HashSet<ActEntryLine>();
            CfgTiers = new HashSet<CfgTier>();
            CfgTranches = new HashSet<CfgTranche>();
            StlCategories = new HashSet<StlCategory>();
            StlSettlementTypeActAccountCredits = new HashSet<StlSettlementType>();
            StlSettlementTypeActAccountDebits = new HashSet<StlSettlementType>();
            StrEntities = new HashSet<StrEntity>();
        }

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
        public Guid? ActAccountTypeId { get; set; }
        public bool? IsTierAccountMandatory { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? CfgCompanyId { get; set; }

        [ForeignKey(nameof(ActAccountTypeId))]
        [InverseProperty("ActAccounts")]
        public virtual ActAccountType ActAccountType { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ActAccounts")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("ActAccounts")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(ActDefaultAccount.ActAccount))]
        public virtual ICollection<ActDefaultAccount> ActDefaultAccounts { get; set; }
        [InverseProperty(nameof(ActDefaultSettlement.ActAccount))]
        public virtual ICollection<ActDefaultSettlement> ActDefaultSettlements { get; set; }
        [InverseProperty(nameof(ActEntryLine.ActAccount))]
        public virtual ICollection<ActEntryLine> ActEntryLines { get; set; }
        [InverseProperty(nameof(CfgTier.ActAccount))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
        [InverseProperty(nameof(CfgTranche.ActAccount))]
        public virtual ICollection<CfgTranche> CfgTranches { get; set; }
        [InverseProperty(nameof(StlCategory.ActAccount))]
        public virtual ICollection<StlCategory> StlCategories { get; set; }
        [InverseProperty(nameof(StlSettlementType.ActAccountCredit))]
        public virtual ICollection<StlSettlementType> StlSettlementTypeActAccountCredits { get; set; }
        [InverseProperty(nameof(StlSettlementType.ActAccountDebit))]
        public virtual ICollection<StlSettlementType> StlSettlementTypeActAccountDebits { get; set; }
        [InverseProperty("ActAccount")]
        public virtual ICollection<StrEntity> StrEntities { get; set; }
    }
}
