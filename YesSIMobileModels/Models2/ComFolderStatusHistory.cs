using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComFolderStatusHistory")]
    public partial class ComFolderStatusHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? ComFolderStatusId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? AdmUserId { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? ComSaleWithdrawalClientId { get; set; }
        public Guid? ComSaleWithdrawalProductId { get; set; }
        public Guid? ComSaleWithdrawalCancellationId { get; set; }
        public Guid? RntFolderStatusId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderStatusId { get; set; }
        public Guid? SynFolderId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(ComFolderStatusId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual ComFolderStatus ComFolderStatus { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalCancellationId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual ComSaleWithdrawalCancellation ComSaleWithdrawalCancellation { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalClientId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual ComSaleWithdrawalClient ComSaleWithdrawalClient { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalProductId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual ComSaleWithdrawalProduct ComSaleWithdrawalProduct { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(RntFolderStatusId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual RntFolderStatus RntFolderStatus { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(SynFolderId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual SynFolder SynFolder { get; set; }
        [ForeignKey(nameof(SynFolderStatusId))]
        [InverseProperty("ComFolderStatusHistories")]
        public virtual SynFolderStatus SynFolderStatus { get; set; }
    }
}
