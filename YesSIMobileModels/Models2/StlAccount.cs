using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlAccount")]
    public partial class StlAccount
    {
        public StlAccount()
        {
            ActDefaultAccounts = new HashSet<ActDefaultAccount>();
            ActDefaultJournals = new HashSet<ActDefaultJournal>();
            ActDefaultSettlements = new HashSet<ActDefaultSettlement>();
            ComDocuments = new HashSet<ComDocument>();
            StlAccountPositions = new HashSet<StlAccountPosition>();
            StlAcountDeposits = new HashSet<StlAcountDeposit>();
            StlCategories = new HashSet<StlCategory>();
            StlInternalTransferStlAccountTos = new HashSet<StlInternalTransfer>();
            StlInternalTransferStlAccounts = new HashSet<StlInternalTransfer>();
            StlSettlements = new HashSet<StlSettlement>();
            StlSlips = new HashSet<StlSlip>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? CfgBankId { get; set; }
        public Guid? StlSettlementKindId { get; set; }
        [StringLength(5)]
        public string BankCode { get; set; }
        [StringLength(5)]
        public string AgencyCode { get; set; }
        [StringLength(255)]
        public string AccountNumber { get; set; }
        [StringLength(5)]
        public string AccountKey { get; set; }
        [StringLength(50)]
        public string Iban { get; set; }
        [StringLength(50)]
        public string CodeBic { get; set; }
        [StringLength(255)]
        public string AgencyAddress { get; set; }
        [StringLength(255)]
        public string CompanyAddress { get; set; }
        [StringLength(255)]
        public string CreationPlace { get; set; }
        [StringLength(50)]
        public string CurrencyCode { get; set; }
        [StringLength(255)]
        public string CurrencyLabel { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StlCurrencyId { get; set; }

        [ForeignKey(nameof(CfgBankId))]
        [InverseProperty(nameof(CfgTier.StlAccounts))]
        public virtual CfgTier CfgBank { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlAccounts")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("StlAccounts")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StlSettlementKindId))]
        [InverseProperty("StlAccounts")]
        public virtual StlSettlementKind StlSettlementKind { get; set; }
        [InverseProperty(nameof(ActDefaultAccount.StlAccount))]
        public virtual ICollection<ActDefaultAccount> ActDefaultAccounts { get; set; }
        [InverseProperty(nameof(ActDefaultJournal.StlAccount))]
        public virtual ICollection<ActDefaultJournal> ActDefaultJournals { get; set; }
        [InverseProperty(nameof(ActDefaultSettlement.StlAccount))]
        public virtual ICollection<ActDefaultSettlement> ActDefaultSettlements { get; set; }
        [InverseProperty(nameof(ComDocument.StlAccount))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
        [InverseProperty(nameof(StlAccountPosition.StlAccount))]
        public virtual ICollection<StlAccountPosition> StlAccountPositions { get; set; }
        [InverseProperty(nameof(StlAcountDeposit.StlAccountTo))]
        public virtual ICollection<StlAcountDeposit> StlAcountDeposits { get; set; }
        [InverseProperty(nameof(StlCategory.StlAccount))]
        public virtual ICollection<StlCategory> StlCategories { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.StlAccountTo))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransferStlAccountTos { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.StlAccount))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransferStlAccounts { get; set; }
        [InverseProperty(nameof(StlSettlement.StlAccount))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
        [InverseProperty(nameof(StlSlip.StlAccount))]
        public virtual ICollection<StlSlip> StlSlips { get; set; }
    }
}
