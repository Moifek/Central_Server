using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlSlip")]
    public partial class StlSlip
    {
        public StlSlip()
        {
            StlSettlements = new HashSet<StlSettlement>();
            StlSlipLines = new HashSet<StlSlipLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EmissionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceptionDate { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? CfgTierEmissionId { get; set; }
        public Guid? CfgTierTransmissionId { get; set; }
        public Guid? StlAccountId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransmissionDate { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? StlDepositId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlSlips")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTierEmissionId))]
        [InverseProperty(nameof(CfgTier.StlSlipCfgTierEmissions))]
        public virtual CfgTier CfgTierEmission { get; set; }
        [ForeignKey(nameof(CfgTierTransmissionId))]
        [InverseProperty(nameof(CfgTier.StlSlipCfgTierTransmissions))]
        public virtual CfgTier CfgTierTransmission { get; set; }
        [ForeignKey(nameof(StlAccountId))]
        [InverseProperty("StlSlips")]
        public virtual StlAccount StlAccount { get; set; }
        [ForeignKey(nameof(StlDepositId))]
        [InverseProperty("StlSlips")]
        public virtual StlDeposit StlDeposit { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StlSlips")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("StlSlips")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(StlSettlement.StlSlip))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
        [InverseProperty(nameof(StlSlipLine.StlSlip))]
        public virtual ICollection<StlSlipLine> StlSlipLines { get; set; }
    }
}
