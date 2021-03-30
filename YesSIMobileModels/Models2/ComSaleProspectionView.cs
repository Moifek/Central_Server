using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComSaleProspectionView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaTo { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceTo { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingOwnBase { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingCredit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingOther { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsClosed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        public Guid? ComProspectionClosingReasonId { get; set; }
        [StringLength(255)]
        public string ComProspectionClosingReasonCode { get; set; }
        [StringLength(255)]
        public string ComProspectionClosingReasonDescription { get; set; }
        [StringLength(255)]
        public string ClosingReasonText { get; set; }
        public Guid? StkVocationId { get; set; }
        [StringLength(255)]
        public string StkVocationCode { get; set; }
        [StringLength(255)]
        public string StkVocationDescription { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? AdmCountryId { get; set; }
        [StringLength(255)]
        public string AdmCountryCode { get; set; }
        [StringLength(255)]
        public string AdmCountryDescription { get; set; }
        public Guid? ComProspectionOriginId { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginCode { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginDescription { get; set; }
        public Guid? ComProspectionOriginSupportId { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginSupportCode { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginSupportDescription { get; set; }
        public Guid? ComActionMessageTypeId { get; set; }
        [StringLength(255)]
        public string ComActionMessageTypeCode { get; set; }
        [StringLength(255)]
        public string ComActionMessageTypeDescription { get; set; }
        public Guid? ComProspectionOriginTypeId { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginTypeCode { get; set; }
        public Guid? CfgProspectId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [StringLength(255)]
        public string CfgTierCity { get; set; }
        [StringLength(43)]
        public string CfgTierPhone { get; set; }
        [StringLength(43)]
        public string CfgTierMobile { get; set; }
        [Column("CfgTierEMail")]
        [StringLength(100)]
        public string CfgTierEmail { get; set; }
        [StringLength(255)]
        public string CfgTierFirstName { get; set; }
        [StringLength(255)]
        public string CfgTierLastName { get; set; }
        [StringLength(30)]
        public string CfgTierMobile1 { get; set; }
        [StringLength(10)]
        public string CfgTierMobile1Indicatif { get; set; }
        [Column("CfgTierIDNumber")]
        [StringLength(255)]
        public string CfgTierIdnumber { get; set; }
        [StringLength(255)]
        public string CfgTierKindCode { get; set; }
        [StringLength(255)]
        public string CfgTierKindDescription { get; set; }
        public Guid? CfgTierTypeId { get; set; }
        [StringLength(255)]
        public string CfgTierTypeCode { get; set; }
        [StringLength(255)]
        public string CfgTierTypeDescription { get; set; }
        public Guid? ComProspectionKindId { get; set; }
        [StringLength(255)]
        public string ComProspectionKindCode { get; set; }
        [StringLength(255)]
        public string ComProspectionKindDescription { get; set; }
        public int ComProspectionKindAlertDelay { get; set; }
        public Guid? ComActionId { get; set; }
        [StringLength(255)]
        public string ComActionCode { get; set; }
        [StringLength(255)]
        public string ComActionDescription { get; set; }
        public Guid? CfgCommercialId { get; set; }
        [StringLength(255)]
        public string CfgCommercialCode { get; set; }
        [StringLength(255)]
        public string CfgCommercialDescription { get; set; }
        [StringLength(255)]
        public string Commercial { get; set; }
        public Guid? StkHierarchyId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string TrancheDescription { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLatitude { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLongitude { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string Article { get; set; }
        [StringLength(255)]
        public string ArticleDescription { get; set; }
        [StringLength(255)]
        public string ItemCategory { get; set; }
        [StringLength(255)]
        public string ItemType { get; set; }
        [StringLength(255)]
        public string ItemPresentationType { get; set; }
        public Guid? CfgProposerId { get; set; }
        [StringLength(255)]
        public string CfgProposerCode { get; set; }
        [StringLength(255)]
        public string CfgProposerDescription { get; set; }
        public Guid? CfgIntermediateId { get; set; }
        [StringLength(255)]
        public string CfgIntermediateCode { get; set; }
        [StringLength(255)]
        public string CfgIntermediateDescription { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapRadius { get; set; }
        public Guid? ComPaymentMethodId { get; set; }
        [StringLength(255)]
        public string ComPaymentMethodCode { get; set; }
        [StringLength(255)]
        public string ComPaymentMethodDescription { get; set; }
        public Guid? ComFolderId { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        [StringLength(255)]
        public string ComFolderDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdvanceDate { get; set; }
        public int Delai { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [StringLength(255)]
        public string CfgCustomerCode { get; set; }
        [StringLength(255)]
        public string CfgCustomerDescription { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        public bool? StatusIsCancellation { get; set; }
        public bool? StatusIsClosing { get; set; }
        [Column(TypeName = "image")]
        public byte[] StatusImg { get; set; }
        [Required]
        public string Project { get; set; }
        [Required]
        public string Categories { get; set; }
        [Required]
        public string Types { get; set; }
        [Required]
        public string Cities { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstVisit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastVisitDate { get; set; }
        public int? NbrVisit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastCommunicationDate { get; set; }
        [Required]
        [StringLength(255)]
        public string LastCommunicationResult { get; set; }
        [Required]
        public string LastCommunicationMessage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastActionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastActiveAlertOld { get; set; }
        public int ThereIsInstructionNotRead { get; set; }
        public Guid? CfgCommercialForInstructionId { get; set; }
        public int? ActionsMessageNumber { get; set; }
        public int? InactivityTimeout { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastActiveAlertDate { get; set; }
        [StringLength(284)]
        public string LastActiveAlertReason { get; set; }
        public bool? IsPreProspection { get; set; }
        [StringLength(255)]
        public string TempDescription { get; set; }
        [StringLength(255)]
        public string TempTel { get; set; }
        [Column("TempEMail")]
        [StringLength(255)]
        public string TempEmail { get; set; }
        [StringLength(255)]
        public string TempField1 { get; set; }
        [StringLength(255)]
        public string TempField2 { get; set; }
        [StringLength(255)]
        public string TempField3 { get; set; }
        [StringLength(255)]
        public string TempField4 { get; set; }
        [StringLength(255)]
        public string TempField5 { get; set; }
        [StringLength(255)]
        public string TempField6 { get; set; }
        [StringLength(255)]
        public string TempField7 { get; set; }
        [StringLength(255)]
        public string TempField8 { get; set; }
        [StringLength(255)]
        public string TempField9 { get; set; }
        [StringLength(255)]
        public string TempField10 { get; set; }
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
