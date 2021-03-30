using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrmRequestOfferView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(500)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? StrStatusId { get; set; }
        public int? StrStatusSorting { get; set; }
        [StringLength(255)]
        public string StrStatusCode { get; set; }
        [StringLength(255)]
        public string StrStatusDescription { get; set; }
        public bool? StrStatusIsReadOnly { get; set; }
        public bool? StrStatusCanDelete { get; set; }
        public Guid? StrStatusTypeId { get; set; }
        public int? StrStatusTypeSorting { get; set; }
        [StringLength(255)]
        public string StrStatusTypeCode { get; set; }
        [StringLength(255)]
        public string StrStatusTypeDescription { get; set; }
        [StringLength(255)]
        public string StrStatusColorName { get; set; }
        public Guid? StrStatusCfgImageId { get; set; }
        [Column(TypeName = "image")]
        public byte[] StrStatusBytes { get; set; }
        public Guid? CfgCommercialId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCommercialCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCommercialDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? ComActionId { get; set; }
        [Required]
        [StringLength(255)]
        public string ComActionCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ComActionDescription { get; set; }
        public Guid? ComProspectionKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string ComProspectionKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ComProspectionKindDescription { get; set; }
        public Guid? ComActionMessageTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string ComActionMessageTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ComActionMessageTypeDescription { get; set; }
        public Guid? ComProspectionOriginId { get; set; }
        [Required]
        [StringLength(255)]
        public string ComProspectionOriginCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ComProspectionOriginDescription { get; set; }
        public Guid? ComProspectionOriginSupportId { get; set; }
        [Required]
        [StringLength(255)]
        public string ComProspectionOriginSupportCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ComProspectionOriginSupportDescription { get; set; }
        public Guid? CfgIntermediateId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgIntermediateCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgIntermediateDescription { get; set; }
        public Guid? CfgOwnerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgOwnerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgOwnerDescription { get; set; }
        [Required]
        [StringLength(30)]
        public string CfgOwnerMobile { get; set; }
        [Required]
        [StringLength(100)]
        public string CfgOwnerEmail { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCustomerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCustomerDescription { get; set; }
        public Guid? CfgProposerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProposerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProposerDescription { get; set; }
        public Guid? PrmPropertyCategoryId { get; set; }
        [StringLength(255)]
        public string PrmPropertyCategoryCode { get; set; }
        [StringLength(255)]
        public string PrmPropertyCategoryDescription { get; set; }
        public Guid? PrmPropertyTypeId { get; set; }
        [StringLength(255)]
        public string PrmPropertyTypeCode { get; set; }
        [StringLength(255)]
        public string PrmPropertyTypeDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        public Guid? AdmCountryId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryDescription { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Address3 { get; set; }
        [StringLength(255)]
        public string ZipCode { get; set; }
        public Guid? AdmCityId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityDescription { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLatitude { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLongitude { get; set; }
        public Guid? PrmPropertyId { get; set; }
        [StringLength(255)]
        public string PrmPropertyCode { get; set; }
        [StringLength(255)]
        public string PrmPropertyDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Budget { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingCredit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingOwnBase { get; set; }
        public bool? IsOccupied { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommissionRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractEndDate { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        [StringLength(255)]
        public string RntPeriodicityCode { get; set; }
        [StringLength(255)]
        public string RntPeriodicityDescription { get; set; }
        public bool? IsReversmentBasedOnPayment { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
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
