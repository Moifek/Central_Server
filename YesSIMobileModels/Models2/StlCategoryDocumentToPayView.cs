using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlCategoryDocumentToPayView
    {
        [Column("PKey")]
        public Guid? Pkey { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        [StringLength(255)]
        public string StlCategoryCodeCountable { get; set; }
        public bool? StlCategoryIsCredit { get; set; }
        public bool? StlCategoryIsWithoutPrevision { get; set; }
        public Guid? StlCategoryParentId { get; set; }
        public int? StlCategorySorting { get; set; }
        public bool? StlCategoryIsCharge { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal StlCategoryVentilationRate { get; set; }
        public Guid? PrjProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public Guid? BuyFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyFolderCode { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyFolderDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        [Required]
        [StringLength(3)]
        public string OriginCode { get; set; }
        [Required]
        [StringLength(80)]
        public string Origin { get; set; }
        public Guid? StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public bool StrEntityIsCharge { get; set; }
        public Guid? CfgTierId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgTierTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierTypeDescription { get; set; }
        public Guid BuyDocumentId { get; set; }
        [StringLength(255)]
        public string BuyDocumentCode { get; set; }
        [StringLength(255)]
        public string BuyDocumentDescription { get; set; }
        [StringLength(255)]
        public string BuyDocumentDocRef { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public int? DocDateYear { get; set; }
        public int? DocDateMonth { get; set; }
        public bool? BuyDocumentIsCharge { get; set; }
        public Guid ObjectId { get; set; }
        [Required]
        [StringLength(32)]
        public string ObjectOrigin { get; set; }
        [Required]
        [StringLength(6)]
        public string ObjectModule { get; set; }
        [Required]
        [StringLength(41)]
        public string ObjectNameSpace { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? BuyDocumentVentilationRate { get; set; }
        [Column("AmountHT", TypeName = "decimal(38, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountToPay { get; set; }
    }
}
