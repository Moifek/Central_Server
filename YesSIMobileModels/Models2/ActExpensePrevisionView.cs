using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ActExpensePrevisionView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public int? DocDateYear { get; set; }
        public int? DocDateMonth { get; set; }
        public bool? IsCharge { get; set; }
        public bool? IsProduct { get; set; }
        public Guid? ObjectId { get; set; }
        [StringLength(317)]
        public string ObjectCode { get; set; }
        [StringLength(317)]
        public string ObjectDescription { get; set; }
        [StringLength(255)]
        public string ObjectPath { get; set; }
        [StringLength(255)]
        public string ObjectForm { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
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
        public Guid? StkItemId { get; set; }
        [Required]
        [StringLength(1)]
        public string StkItemCode { get; set; }
        [Required]
        [StringLength(1)]
        public string StkItemeDescription { get; set; }
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
        public Guid? PrjMarketTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierCodeCountable { get; set; }
        public Guid? AdmModuleId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid? BuyFolderId { get; set; }
        [Required]
        [StringLength(1)]
        public string BuyFolderCode { get; set; }
        [Required]
        [StringLength(1)]
        public string BuyFolderDescription { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public bool? StrEntityIsCharge { get; set; }
        public bool? StrEntityIsProduct { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        public bool? StlCategoryIsCharge { get; set; }
        public bool? StlCategoryIsProduct { get; set; }
        public bool? StlCategoryIsCredit { get; set; }
        public int? StlCategorySorting { get; set; }
        public Guid? ActAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountDescription { get; set; }
        public bool ActAccountIsTierAccountMandatory { get; set; }
        public Guid? ActAccountTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountTypeDescription { get; set; }
        public bool ActAccountTypeIsActive { get; set; }
        public bool ActAccountTypeIsPassive { get; set; }
        public bool ActAccountTypeIsCharge { get; set; }
        public bool ActAccountTypeIsProduct { get; set; }
        public Guid? ActAccountForPaymentId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountForPaymentCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountForPaymentDescription { get; set; }
        public bool ActAccountForPaymentIsTierAccountMandatory { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? VentilationRate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column("AmountHT", TypeName = "decimal(38, 6)")]
        public decimal? AmountHt { get; set; }
        [Column("AmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? AmountTtc { get; set; }
    }
}
