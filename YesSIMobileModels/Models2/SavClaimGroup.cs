using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SavClaimGroup")]
    public partial class SavClaimGroup
    {
        public SavClaimGroup()
        {
            ComActionMessages = new HashSet<ComActionMessage>();
            SavClaims = new HashSet<SavClaim>();
            StlItems = new HashSet<StlItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ClosingDate { get; set; }
        public bool? IsInReception { get; set; }
        public Guid? SavOriginId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocRefDate { get; set; }
        [StringLength(255)]
        public string DocRef { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WarrantyEndDate { get; set; }
        public Guid? CfgClaimsManagerId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? StkVocationId { get; set; }
        public Guid? RntFolderId { get; set; }

        [ForeignKey(nameof(CfgClaimsManagerId))]
        [InverseProperty(nameof(CfgTier.SavClaimGroups))]
        public virtual CfgTier CfgClaimsManager { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("SavClaimGroups")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("SavClaimGroups")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(SavOriginId))]
        [InverseProperty("SavClaimGroups")]
        public virtual SavOrigin SavOrigin { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("SavClaimGroups")]
        public virtual StkVocation StkVocation { get; set; }
        [InverseProperty(nameof(ComActionMessage.SavClaimGroup))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(SavClaim.SavClaimGroup))]
        public virtual ICollection<SavClaim> SavClaims { get; set; }
        [InverseProperty(nameof(StlItem.SavClaimGroup))]
        public virtual ICollection<StlItem> StlItems { get; set; }
    }
}
