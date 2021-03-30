using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlTransmissionSheet")]
    public partial class StlTransmissionSheet
    {
        public StlTransmissionSheet()
        {
            StlTransmissionSheetLines = new HashSet<StlTransmissionSheetLine>();
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
        public Guid? CfgTierReceptionId { get; set; }
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
        public Guid? CfgCompanyFromId { get; set; }
        public Guid? StlDepositFromId { get; set; }
        public Guid? CfgCompanyToId { get; set; }
        public Guid? StlDepositToId { get; set; }

        [ForeignKey(nameof(CfgCompanyFromId))]
        [InverseProperty(nameof(CfgCompany.StlTransmissionSheetCfgCompanyFroms))]
        public virtual CfgCompany CfgCompanyFrom { get; set; }
        [ForeignKey(nameof(CfgCompanyToId))]
        [InverseProperty(nameof(CfgCompany.StlTransmissionSheetCfgCompanyTos))]
        public virtual CfgCompany CfgCompanyTo { get; set; }
        [ForeignKey(nameof(CfgTierEmissionId))]
        [InverseProperty(nameof(CfgTier.StlTransmissionSheetCfgTierEmissions))]
        public virtual CfgTier CfgTierEmission { get; set; }
        [ForeignKey(nameof(CfgTierReceptionId))]
        [InverseProperty(nameof(CfgTier.StlTransmissionSheetCfgTierReceptions))]
        public virtual CfgTier CfgTierReception { get; set; }
        [ForeignKey(nameof(CfgTierTransmissionId))]
        [InverseProperty(nameof(CfgTier.StlTransmissionSheetCfgTierTransmissions))]
        public virtual CfgTier CfgTierTransmission { get; set; }
        [ForeignKey(nameof(StlDepositFromId))]
        [InverseProperty(nameof(StlDeposit.StlTransmissionSheetStlDepositFroms))]
        public virtual StlDeposit StlDepositFrom { get; set; }
        [ForeignKey(nameof(StlDepositToId))]
        [InverseProperty(nameof(StlDeposit.StlTransmissionSheetStlDepositTos))]
        public virtual StlDeposit StlDepositTo { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StlTransmissionSheets")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("StlTransmissionSheets")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(StlTransmissionSheetLine.StlTransmissionSheet))]
        public virtual ICollection<StlTransmissionSheetLine> StlTransmissionSheetLines { get; set; }
    }
}
