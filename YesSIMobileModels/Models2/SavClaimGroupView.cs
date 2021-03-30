using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class SavClaimGroupView
    {
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
        [Column(TypeName = "image")]
        public byte[] StatusImg { get; set; }
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
        public string CfgCustomerCode { get; set; }
        [StringLength(255)]
        public string CfgCustomerDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WarrantyEndDate { get; set; }
        public Guid? CfgClaimsManagerId { get; set; }
        [StringLength(255)]
        public string CfgClaimsManagerCode { get; set; }
        [StringLength(255)]
        public string CfgClaimsManagerDescription { get; set; }
        [StringLength(255)]
        public string CfgClaimsManagerTitle { get; set; }
        public Guid? SavOriginId { get; set; }
        [StringLength(255)]
        public string SavOriginCode { get; set; }
        [StringLength(255)]
        public string SavOriginDescription { get; set; }
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
    }
}
