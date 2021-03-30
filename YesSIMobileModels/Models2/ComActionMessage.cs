using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComActionMessage")]
    [Index(nameof(ComProspectionId), nameof(ComActionMessageCategoryId), Name = "_dta_index_ComActionMessage_7_1156915193__K13_K18")]
    [Index(nameof(ComActionMessageCategoryId), nameof(IsSystem), nameof(ComProspectionId), Name = "_dta_index_ComActionMessage_7_1156915193__K18_K31_K13_35")]
    [Index(nameof(ComActionMessageCategoryId), nameof(IsSystem), nameof(ComProspectionId), nameof(DocDate), nameof(ComActionMessageSubCategoryId), Name = "_dta_index_ComActionMessage_7_1156915193__K18_K31_K13_K2_K19_10_30_35")]
    [Index(nameof(ComActionMessageCategoryId), nameof(IsSystem), nameof(ComProspectionId), nameof(DocDate), nameof(ComActionMessageSubCategoryId), Name = "_dta_index_ComActionMessage_7_1156915193__K18_K31_K13_K2_K19_10_35")]
    [Index(nameof(IsUnpaid), nameof(ComActionMessageCategoryId), nameof(ComFolderId), nameof(DocDate), Name = "_dta_index_ComActionMessage_7_1156915193__K26_K18_K14_K2")]
    public partial class ComActionMessage
    {
        public ComActionMessage()
        {
            InverseComActionMessageNavigation = new HashSet<ComActionMessage>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsIn { get; set; }
        public bool? WithoutRevival { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AlertValidityDate { get; set; }
        [StringLength(255)]
        public string UserName { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? ComProspectionId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? ComSaleWithdrawalCancellationId { get; set; }
        public Guid? ComSaleWithdrawalClientId { get; set; }
        public Guid? ComSaleWithdrawalProductId { get; set; }
        public Guid? ComActionMessageCategoryId { get; set; }
        public Guid? ComActionMessageSubCategoryId { get; set; }
        public Guid? ComActionMessageTypeId { get; set; }
        public Guid? ComFolderStatusId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsUnpaid { get; set; }
        public Guid? AdmUserId { get; set; }
        public Guid? ComActionMessageId { get; set; }
        public Guid? ComDocumentId { get; set; }
        public string AlertMessage { get; set; }
        public bool? IsSystem { get; set; }
        public Guid? SavClaimId { get; set; }
        public Guid? SavClaimGroupId { get; set; }
        public Guid? AdmEventId { get; set; }
        public bool? IsNotRead { get; set; }
        public Guid? PrmRequestOfferId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }

        [ForeignKey(nameof(AdmEventId))]
        [InverseProperty("ComActionMessages")]
        public virtual AdmEvent AdmEvent { get; set; }
        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("ComActionMessages")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(CfgEmployeeId))]
        [InverseProperty("ComActionMessageCfgEmployees")]
        public virtual CfgTier CfgEmployee { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("ComActionMessageCfgTiers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(ComActionMessageCategoryId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComActionMessageCategory ComActionMessageCategory { get; set; }
        [ForeignKey(nameof(ComActionMessageId))]
        [InverseProperty(nameof(ComActionMessage.InverseComActionMessageNavigation))]
        public virtual ComActionMessage ComActionMessageNavigation { get; set; }
        [ForeignKey(nameof(ComActionMessageSubCategoryId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComActionMessageSubCategory ComActionMessageSubCategory { get; set; }
        [ForeignKey(nameof(ComActionMessageTypeId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComActionMessageType ComActionMessageType { get; set; }
        [ForeignKey(nameof(ComDocumentId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComDocument ComDocument { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(ComFolderStatusId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComFolderStatus ComFolderStatus { get; set; }
        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComProspection ComProspection { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalCancellationId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComSaleWithdrawalCancellation ComSaleWithdrawalCancellation { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalClientId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComSaleWithdrawalClient ComSaleWithdrawalClient { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalProductId))]
        [InverseProperty("ComActionMessages")]
        public virtual ComSaleWithdrawalProduct ComSaleWithdrawalProduct { get; set; }
        [ForeignKey(nameof(PrmRequestOfferId))]
        [InverseProperty("ComActionMessages")]
        public virtual PrmRequestOffer PrmRequestOffer { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("ComActionMessages")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(SavClaimId))]
        [InverseProperty("ComActionMessages")]
        public virtual SavClaim SavClaim { get; set; }
        [ForeignKey(nameof(SavClaimGroupId))]
        [InverseProperty("ComActionMessages")]
        public virtual SavClaimGroup SavClaimGroup { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComActionMessages")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(SynFolderId))]
        [InverseProperty("ComActionMessages")]
        public virtual SynFolder SynFolder { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComActionMessageNavigation))]
        public virtual ICollection<ComActionMessage> InverseComActionMessageNavigation { get; set; }
    }
}
