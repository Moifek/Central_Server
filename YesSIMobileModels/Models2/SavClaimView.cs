using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class SavClaimView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column("statusValidityDate", TypeName = "datetime")]
        public DateTime? StatusValidityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InterventionDate { get; set; }
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
        public Guid? SavComplaintCategoryId { get; set; }
        [StringLength(255)]
        public string SavComplaintCategoryCode { get; set; }
        [StringLength(255)]
        public string SavComplaintCategoryDescription { get; set; }
        public Guid? SavComplaintTypeId { get; set; }
        [StringLength(255)]
        public string SavComplaintTypeCode { get; set; }
        [StringLength(255)]
        public string SavComplaintTypeDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public Guid? CfgSupplierId { get; set; }
        [StringLength(255)]
        public string CfgSupplierCode { get; set; }
        [StringLength(255)]
        public string CfgSupplierDescription { get; set; }
        public string StkContenanceDescription { get; set; }
        public Guid SavClaimGroupId { get; set; }
        [StringLength(255)]
        public string SavClaimGroupCode { get; set; }
        [StringLength(255)]
        public string SavClaimGroupDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SavClaimGroupDocDate { get; set; }
        public Guid? StkVocationId { get; set; }
        [StringLength(255)]
        public string StkVocationCode { get; set; }
        [StringLength(255)]
        public string StkVocationDescription { get; set; }
        public Guid? FolderId { get; set; }
        [StringLength(255)]
        public string FolderCode { get; set; }
        [StringLength(255)]
        public string FolderDescription { get; set; }
        public Guid? FolderStatusId { get; set; }
        [StringLength(255)]
        public string FolderStatusCode { get; set; }
        [StringLength(255)]
        public string FolderStatusDescription { get; set; }
        public Guid? FolderStatusCfgImageId { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public string StkUnderItemsCode { get; set; }
        public string StkUnderItemsDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? StkFloorId { get; set; }
        [StringLength(255)]
        public string StkFloorCode { get; set; }
        [StringLength(255)]
        public string StkFloorDescription { get; set; }
        public Guid? StkBuildingId { get; set; }
        [StringLength(255)]
        public string StkBuildingCode { get; set; }
        [StringLength(255)]
        public string StkBuildingDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [StringLength(255)]
        public string CfgCustomerCodeCode { get; set; }
        [StringLength(255)]
        public string CfgCustomerDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WarrantyEndDate { get; set; }
        public Guid? CfgClaimsManagerId { get; set; }
        [StringLength(255)]
        public string CfgClaimsManagerDescription { get; set; }
        [StringLength(255)]
        public string CfgClaimsManagerTitle { get; set; }
        public Guid? SavOriginId { get; set; }
        [StringLength(255)]
        public string SavOriginOriginCode { get; set; }
        [StringLength(255)]
        public string SavOriginDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SavClaimGroupDocRefDate { get; set; }
        [StringLength(255)]
        public string SavClaimGroupDocRef { get; set; }
        public bool? IsInReception { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("PriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? PriceTtc { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
        public Guid? PrjMarketClaimId { get; set; }
        [StringLength(255)]
        public string PrjMarketClaimCode { get; set; }
        [StringLength(255)]
        public string PrjMarketClaimDescription { get; set; }
        public int ProcessingDelai { get; set; }
        public int ManagementDelai { get; set; }
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
