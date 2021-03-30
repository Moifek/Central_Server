using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComSaleDocumentView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        public bool? ExcludeFromPrice { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string QuittanceCode { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DiscountRatio { get; set; }
        [Column("VATRatio", TypeName = "decimal(26, 6)")]
        public decimal? Vatratio { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column("AmountSettledIN", TypeName = "decimal(38, 6)")]
        public decimal? AmountSettledIn { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRest { get; set; }
        public Guid? ComFolderId { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        public Guid ComFolderStatusId { get; set; }
        public int? ComFolderStatusSorting { get; set; }
        [StringLength(255)]
        public string ComFolderStatusCode { get; set; }
        [StringLength(255)]
        public string ComFolderStatusDescription { get; set; }
        [Column("ComFolderStatusIsASale")]
        public bool? ComFolderStatusIsAsale { get; set; }
        public bool? ComFolderStatusIsCancellation { get; set; }
        public bool? ComFolderStatusIsClosing { get; set; }
        public Guid? ComSettlementCategoryId { get; set; }
        [StringLength(255)]
        public string ComSettlementCategoryCode { get; set; }
        [StringLength(255)]
        public string ComSettlementCategoryDescription { get; set; }
        public bool? IsCredit { get; set; }
        public bool? IsSaleExpense { get; set; }
        public bool? IsSaleAdvance { get; set; }
        public bool? IsSaleCredit { get; set; }
        public bool? IsSaleAutoFinancment { get; set; }
        public bool? IsSaleModification { get; set; }
        public bool? IsSaleResiliation { get; set; }
        public bool? IsSalePenality { get; set; }
        public bool? IsSyndic { get; set; }
        public bool? IsConfermentBasedDate { get; set; }
        public bool? IsInAgrementContext { get; set; }
        public Guid StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? AdmModuleId { get; set; }
        public Guid? ComSaleWithdrawalProductId { get; set; }
        public Guid? ComSaleWithdrawalClientId { get; set; }
        public Guid? ComSaleWithdrawalCancellationId { get; set; }
        public Guid? StlDocumentId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDocumentCodeProforma { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDocumentCode { get; set; }
        public int? RntRevivalCount { get; set; }
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
