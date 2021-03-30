using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class RomInvoiceView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MaturityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RntDocumentPaymentDate { get; set; }
        [StringLength(255)]
        public string DocRef { get; set; }
        [StringLength(255)]
        public string OrderCode { get; set; }
        [StringLength(255)]
        public string PersonToContact { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(1000)]
        public string Notes1 { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        [StringLength(255)]
        public string ReferenceType { get; set; }
        public bool? IsCredit { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column("AmountRefundedHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedVat { get; set; }
        [Column("AmountRefundedTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedTtc { get; set; }
        [Column("TotalHT", TypeName = "decimal(26, 6)")]
        public decimal? TotalHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalVat { get; set; }
        [Column("TotalTTC", TypeName = "decimal(26, 6)")]
        public decimal? TotalTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStamp { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRegul { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        public int AmountDocumentSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountInvoiceSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRest { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentAuthorizationDate { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? ComFolderId { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        public Guid? RntFolderId { get; set; }
        [StringLength(255)]
        public string RntFolderCode { get; set; }
        public string StlCategoryDescription { get; set; }
        public Guid ObjectId { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        public int? RntRevivalCount { get; set; }
        public string CfgTrancheIds { get; set; }
        public string CfgTrancheDescription { get; set; }
        public string StkItemCode { get; set; }
        public string StkItemDescription { get; set; }
        public string RelatedDocumentDescription { get; set; }
        public string StlRefundCode { get; set; }
        public Guid? StlRecoveryFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlRecoveryFolderCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlRecoveryDescription { get; set; }
        public Guid? CfgDebtCollectorId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtCollectorCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtCollectorDescription { get; set; }
        public Guid? CfgDebtManagerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtManagerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtManagerDescription { get; set; }
        public int? LinesCount { get; set; }
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
