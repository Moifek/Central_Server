using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmMailing")]
    public partial class AdmMailing
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? TierFromId { get; set; }
        public Guid? TierToId { get; set; }
        [Column("TierCCId")]
        public Guid? TierCcid { get; set; }
        public string Massage { get; set; }
        [StringLength(255)]
        public string MailObject { get; set; }
        public Guid? AdmMailModelId { get; set; }
        public Guid? RelationId { get; set; }
        [StringLength(255)]
        public string RelationNameSpace { get; set; }
        public bool? IsSent { get; set; }

        [ForeignKey(nameof(AdmMailModelId))]
        [InverseProperty("AdmMailings")]
        public virtual AdmMailModel AdmMailModel { get; set; }
        [ForeignKey(nameof(TierCcid))]
        [InverseProperty(nameof(CfgTier.AdmMailingTierCcs))]
        public virtual CfgTier TierCc { get; set; }
        [ForeignKey(nameof(TierToId))]
        [InverseProperty(nameof(CfgTier.AdmMailingTierTos))]
        public virtual CfgTier TierTo { get; set; }
    }
}
