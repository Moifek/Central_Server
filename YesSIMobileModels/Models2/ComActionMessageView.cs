using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComActionMessageView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public int? DocDateYear { get; set; }
        public int? DocDateMonth { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsIn { get; set; }
        public bool? WithoutRevival { get; set; }
        public Guid? ComDocumentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AlertValidityDate { get; set; }
        public string AlertMessage { get; set; }
        public bool AlertActive { get; set; }
        [Required]
        [StringLength(255)]
        public string UserName { get; set; }
        public bool? IsUnpaid { get; set; }
        public Guid? CfgTierId { get; set; }
        [Required]
        [StringLength(255)]
        public string TierDescription { get; set; }
        public Guid? AdmUserId { get; set; }
        [Required]
        [StringLength(255)]
        public string UserDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string Personnel { get; set; }
        [Required]
        [StringLength(255)]
        public string Commercial { get; set; }
        public Guid? PrmRequestOfferId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
        public Guid? ComProspectionId { get; set; }
        [Required]
        [StringLength(255)]
        public string ProspectionCode { get; set; }
        public Guid? ComFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string FolderCode { get; set; }
        public Guid? SavClaimId { get; set; }
        [Required]
        [StringLength(255)]
        public string SavClaimCode { get; set; }
        public Guid? SavClaimGroupId { get; set; }
        [Required]
        [StringLength(255)]
        public string SavClaimGroupCode { get; set; }
        public Guid? ComSaleWithdrawalCancellationId { get; set; }
        [Required]
        [StringLength(255)]
        public string SaleWithdrawalCancellationCode { get; set; }
        public Guid? ComSaleWithdrawalClientId { get; set; }
        [Required]
        [StringLength(255)]
        public string SaleWithdrawalClientCode { get; set; }
        public Guid? ComSaleWithdrawalProductId { get; set; }
        [StringLength(255)]
        public string SaleWithdrawalProductCode { get; set; }
        public Guid? ComActionMessageCategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActionMessageCategoryDescription { get; set; }
        public Guid? ComActionMessageSubCategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActionMessageSubCategoryDescription { get; set; }
        public Guid? ComActionMessageTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActionMessageTypeDescription { get; set; }
        public Guid? ComFolderStatusId { get; set; }
        [Required]
        [StringLength(255)]
        public string FolderStatusDescription { get; set; }
        public Guid? ComActionMessageId { get; set; }
        public Guid? StkItemId { get; set; }
        [Required]
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? AdmEventId { get; set; }
        public bool? IsSystem { get; set; }
        public int? ActionRank { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
