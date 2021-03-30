using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComSettlementLineView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComSettlementId { get; set; }
        public Guid? StlSettlementId { get; set; }
        [Column(TypeName = "decimal(37, 6)")]
        public decimal? Amount { get; set; }
        [StringLength(255)]
        public string StlSettlementCode { get; set; }
        [StringLength(255)]
        public string ReceiptCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MotionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EcheanceDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SettlementDate { get; set; }
        [StringLength(255)]
        public string StlSettlementDescription { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StlSettlementAmount { get; set; }
        public bool? IsCredit { get; set; }
        public string StlSettlementNotes { get; set; }
        public Guid? TierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeCode { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeDescription { get; set; }
        public bool? IsNotContabilized { get; set; }
        public Guid? CfgBankId { get; set; }
        [StringLength(255)]
        public string CfgBankCode { get; set; }
        [StringLength(255)]
        public string CfgBankDescription { get; set; }
        public Guid? StlAccountId { get; set; }
        [StringLength(255)]
        public string StlAccountCode { get; set; }
        [StringLength(255)]
        public string StlAccountDescription { get; set; }
        [Required]
        [StringLength(1)]
        public string StlAccountCodeCountable { get; set; }
        public Guid? ComDocumentId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ComDocumentDocDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComDocumentAmount { get; set; }
        [StringLength(1000)]
        public string ComDocumentNotes { get; set; }
        public Guid? ComSettlementCategoryId { get; set; }
        [StringLength(255)]
        public string ComSettlementCategoryDescription { get; set; }
        public bool? IsSaleExpense { get; set; }
        public Guid? ComFolderId { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        public Guid ComFolderStatusId { get; set; }
        [StringLength(255)]
        public string ComFolderStatusDescription { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public bool? CfgTrancheIsForSale { get; set; }
        public bool? CfgTrancheIsForRent { get; set; }
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
