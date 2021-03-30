using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComDocument")]
    [Index(nameof(Pkey), nameof(ComFolderId), nameof(ComSettlementCategoryId), Name = "_dta_index_ComDocument_5_1556200594__K1_K32_K6")]
    [Index(nameof(CfgCompanyId), nameof(ExcludeFromPrice), nameof(Pkey), nameof(ComFolderId), nameof(ComSettlementCategoryId), Name = "_dta_index_ComDocument_5_720721620__K33_K7_K1_K32_K6_3")]
    [Index(nameof(Pkey), Name = "_dta_index_ComDocument_7_1556200594__K1_6")]
    [Index(nameof(ComFolderId), nameof(Pkey), nameof(CfgCompanyId), nameof(ComSettlementCategoryId), Name = "_dta_index_ComDocument_7_1556200594__K32_K1_K33_K6")]
    [Index(nameof(ComSettlementCategoryId), nameof(Pkey), nameof(ComFolderId), nameof(CfgCompanyId), nameof(ExcludeFromPrice), Name = "_dta_index_ComDocument_7_1556200594__K6_K1_K32_K33_K7_3")]
    [Index(nameof(ExcludeFromPrice), nameof(ComFolderId), nameof(Pkey), nameof(CfgCompanyId), nameof(ComSettlementCategoryId), Name = "_dta_index_ComDocument_7_1556200594__K7_K32_K1_K33_K6")]
    public partial class ComDocument
    {
        public ComDocument()
        {
            ComActionMessages = new HashSet<ComActionMessage>();
            ComSettlementLines = new HashSet<ComSettlementLine>();
            InverseComPenaltyDocument = new HashSet<ComDocument>();
            RntRevivals = new HashSet<RntRevival>();
            StlDocumentLines = new HashSet<StlDocumentLine>();
            StlPaymentAuthorizationLines = new HashSet<StlPaymentAuthorizationLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public Guid? ComSettlementCategoryId { get; set; }
        public bool? ExcludeFromPrice { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column("VATRatio", TypeName = "decimal(26, 6)")]
        public decimal? Vatratio { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string QuittanceCode { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? AdmModuleId { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DiscountRatio { get; set; }
        public Guid? ComSaleWithdrawalProductId { get; set; }
        public Guid? ComSaleWithdrawalClientId { get; set; }
        public Guid? ComSaleWithdrawalCancellationId { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        public Guid? StlAccountId { get; set; }
        public Guid? CfgContactId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentAuthorizationDate { get; set; }
        public Guid? CfgDebtCollectorId { get; set; }
        public Guid? ComPenaltyDocumentId { get; set; }
        public Guid? StlRecoveryFolderId { get; set; }

        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("ComDocuments")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ComDocuments")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgContactId))]
        [InverseProperty(nameof(CfgTier.ComDocumentCfgContacts))]
        public virtual CfgTier CfgContact { get; set; }
        [ForeignKey(nameof(CfgDebtCollectorId))]
        [InverseProperty(nameof(CfgTier.ComDocumentCfgDebtCollectors))]
        public virtual CfgTier CfgDebtCollector { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComDocuments")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(ComPenaltyDocumentId))]
        [InverseProperty(nameof(ComDocument.InverseComPenaltyDocument))]
        public virtual ComDocument ComPenaltyDocument { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalCancellationId))]
        [InverseProperty("ComDocuments")]
        public virtual ComSaleWithdrawalCancellation ComSaleWithdrawalCancellation { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalClientId))]
        [InverseProperty("ComDocuments")]
        public virtual ComSaleWithdrawalClient ComSaleWithdrawalClient { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalProductId))]
        [InverseProperty("ComDocuments")]
        public virtual ComSaleWithdrawalProduct ComSaleWithdrawalProduct { get; set; }
        [ForeignKey(nameof(ComSettlementCategoryId))]
        [InverseProperty("ComDocuments")]
        public virtual ComSettlementCategory ComSettlementCategory { get; set; }
        [ForeignKey(nameof(StlAccountId))]
        [InverseProperty("ComDocuments")]
        public virtual StlAccount StlAccount { get; set; }
        [ForeignKey(nameof(StlRecoveryFolderId))]
        [InverseProperty("ComDocuments")]
        public virtual StlRecoveryFolder StlRecoveryFolder { get; set; }
        [ForeignKey(nameof(StlSettlementTypeId))]
        [InverseProperty("ComDocuments")]
        public virtual StlSettlementType StlSettlementType { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComDocument))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComSettlementLine.ComDocument))]
        public virtual ICollection<ComSettlementLine> ComSettlementLines { get; set; }
        [InverseProperty(nameof(ComDocument.ComPenaltyDocument))]
        public virtual ICollection<ComDocument> InverseComPenaltyDocument { get; set; }
        [InverseProperty(nameof(RntRevival.ComDocument))]
        public virtual ICollection<RntRevival> RntRevivals { get; set; }
        [InverseProperty(nameof(StlDocumentLine.ComDocument))]
        public virtual ICollection<StlDocumentLine> StlDocumentLines { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorizationLine.ComDocument))]
        public virtual ICollection<StlPaymentAuthorizationLine> StlPaymentAuthorizationLines { get; set; }
    }
}
