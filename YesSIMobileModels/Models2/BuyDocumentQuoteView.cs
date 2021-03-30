using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyDocumentQuoteView
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
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgTierTriggerId { get; set; }
        [StringLength(255)]
        public string CfgTierTriggerDescription { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        [StringLength(255)]
        public string PersonToContact { get; set; }
        [StringLength(255)]
        public string DocRef { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public string Notes2 { get; set; }
        [StringLength(255)]
        public string OfficeOrderRef { get; set; }
        public Guid? PrjProjectId { get; set; }
        public string PrjProjectDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public bool? PrjMarketIsMultiSupplier { get; set; }
        public Guid? BuyConsultationId { get; set; }
        [StringLength(255)]
        public string BuyConsultationDescription { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        public Guid? PrjMarketOfferId { get; set; }
        [StringLength(255)]
        public string PrjMarketOfferCode { get; set; }
        public Guid? BuyFolderId { get; set; }
        [StringLength(255)]
        public string BuyFolderDescription { get; set; }
        public bool? IsSelected { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStamp { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRegul { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        public bool? IsRejected { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        [Column(TypeName = "text")]
        public string StrEntityDescriptionLong { get; set; }
        public Guid? BuyOrderId { get; set; }
        public string BuyOrderCode { get; set; }
        public string BuyDeliveryCode { get; set; }
        public string BuyInvoiceCode { get; set; }
        public string StlCategoryDescription { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
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
