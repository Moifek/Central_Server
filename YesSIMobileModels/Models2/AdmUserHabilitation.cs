using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmUserHabilitation")]
    [Index(nameof(AdmUserId), nameof(CfgTrancheId), Name = "_dta_index_AdmUserHabilitation_5_483532806__K2_K5")]
    public partial class AdmUserHabilitation
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? AdmUserId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? CfgProjectId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? PrjProjectId { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("AdmUserHabilitations")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("AdmUserHabilitations")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgProjectId))]
        [InverseProperty("AdmUserHabilitations")]
        public virtual CfgProject CfgProject { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("AdmUserHabilitations")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("AdmUserHabilitations")]
        public virtual PrjProject PrjProject { get; set; }
    }
}
