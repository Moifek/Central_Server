using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlSettlementType")]
    public partial class StlSettlementType
    {
        public StlSettlementType()
        {
            ActDefaultSettlements = new HashSet<ActDefaultSettlement>();
            BuySelections = new HashSet<BuySelection>();
            ComDocuments = new HashSet<ComDocument>();
            ComSaleWithdrawalCancellations = new HashSet<ComSaleWithdrawalCancellation>();
            PrjMarkets = new HashSet<PrjMarket>();
            StlInternalTransferStlSettlementTypeTos = new HashSet<StlInternalTransfer>();
            StlInternalTransferStlSettlementTypes = new HashSet<StlInternalTransfer>();
            StlSettlementHistories = new HashSet<StlSettlementHistory>();
            StlSettlementTypeKinds = new HashSet<StlSettlementTypeKind>();
            StlSettlements = new HashSet<StlSettlement>();
            StlTaxStampLevels = new HashSet<StlTaxStampLevel>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsReferenceUnique { get; set; }
        public bool? IsReferenceMandatory { get; set; }
        public bool? IsBankMandatory { get; set; }
        public bool? IsNotContabilized { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsTierUnique { get; set; }
        [StringLength(255)]
        public string RefFormat { get; set; }
        public bool? IsLawyerMandatory { get; set; }
        public Guid? ActAccountCreditId { get; set; }
        public Guid? ActAccountDebitId { get; set; }
        public bool? IsDeposit { get; set; }
        public bool? IsAccount { get; set; }

        [ForeignKey(nameof(ActAccountCreditId))]
        [InverseProperty(nameof(ActAccount.StlSettlementTypeActAccountCredits))]
        public virtual ActAccount ActAccountCredit { get; set; }
        [ForeignKey(nameof(ActAccountDebitId))]
        [InverseProperty(nameof(ActAccount.StlSettlementTypeActAccountDebits))]
        public virtual ActAccount ActAccountDebit { get; set; }
        [InverseProperty(nameof(ActDefaultSettlement.StlSettlementType))]
        public virtual ICollection<ActDefaultSettlement> ActDefaultSettlements { get; set; }
        [InverseProperty(nameof(BuySelection.StlSettlementType))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty(nameof(ComDocument.StlSettlementType))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalCancellation.StlSettlementType))]
        public virtual ICollection<ComSaleWithdrawalCancellation> ComSaleWithdrawalCancellations { get; set; }
        [InverseProperty(nameof(PrjMarket.StlSettlementType))]
        public virtual ICollection<PrjMarket> PrjMarkets { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.StlSettlementTypeTo))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransferStlSettlementTypeTos { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.StlSettlementType))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransferStlSettlementTypes { get; set; }
        [InverseProperty(nameof(StlSettlementHistory.StlSettlementType))]
        public virtual ICollection<StlSettlementHistory> StlSettlementHistories { get; set; }
        [InverseProperty(nameof(StlSettlementTypeKind.StlSettlementType))]
        public virtual ICollection<StlSettlementTypeKind> StlSettlementTypeKinds { get; set; }
        [InverseProperty(nameof(StlSettlement.StlSettlementType))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
        [InverseProperty(nameof(StlTaxStampLevel.StlSettlementType))]
        public virtual ICollection<StlTaxStampLevel> StlTaxStampLevels { get; set; }
    }
}
