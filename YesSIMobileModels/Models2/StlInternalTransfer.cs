using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlInternalTransfer")]
    public partial class StlInternalTransfer
    {
        public StlInternalTransfer()
        {
            StlSettlements = new HashSet<StlSettlement>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgCompanyToId { get; set; }
        public Guid? StlAccountId { get; set; }
        public Guid? StlAccountToId { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        public Guid? StlSettlementTypeToId { get; set; }
        [StringLength(255)]
        public string Reference { get; set; }
        [StringLength(255)]
        public string ReferenceTo { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StrStatusId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? CfgTierEmissionId { get; set; }
        public Guid? CfgTierTransmissionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransmissionDate { get; set; }
        public Guid? CfgTierReceptionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceptionDate { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlInternalTransferCfgCompanies")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgCompanyToId))]
        [InverseProperty("StlInternalTransferCfgCompanyTos")]
        public virtual CfgCompany CfgCompanyTo { get; set; }
        [ForeignKey(nameof(CfgTierEmissionId))]
        [InverseProperty(nameof(CfgTier.StlInternalTransferCfgTierEmissions))]
        public virtual CfgTier CfgTierEmission { get; set; }
        [ForeignKey(nameof(CfgTierReceptionId))]
        [InverseProperty(nameof(CfgTier.StlInternalTransferCfgTierReceptions))]
        public virtual CfgTier CfgTierReception { get; set; }
        [ForeignKey(nameof(CfgTierTransmissionId))]
        [InverseProperty(nameof(CfgTier.StlInternalTransferCfgTierTransmissions))]
        public virtual CfgTier CfgTierTransmission { get; set; }
        [ForeignKey(nameof(StlAccountId))]
        [InverseProperty("StlInternalTransferStlAccounts")]
        public virtual StlAccount StlAccount { get; set; }
        [ForeignKey(nameof(StlAccountToId))]
        [InverseProperty("StlInternalTransferStlAccountTos")]
        public virtual StlAccount StlAccountTo { get; set; }
        [ForeignKey(nameof(StlSettlementTypeId))]
        [InverseProperty("StlInternalTransferStlSettlementTypes")]
        public virtual StlSettlementType StlSettlementType { get; set; }
        [ForeignKey(nameof(StlSettlementTypeToId))]
        [InverseProperty("StlInternalTransferStlSettlementTypeTos")]
        public virtual StlSettlementType StlSettlementTypeTo { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StlInternalTransfers")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("StlInternalTransfers")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(StlSettlement.StlInternalTransfer))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
    }
}
