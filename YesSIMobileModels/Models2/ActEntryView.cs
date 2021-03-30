using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ActEntryView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        [StringLength(255)]
        public string StrEntityObjectPath { get; set; }
        [StringLength(255)]
        public string StrEntityObjectForm { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
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
        public Guid? ActJournalId { get; set; }
        [StringLength(255)]
        public string ActJournalCode { get; set; }
        [StringLength(255)]
        public string ActJournalDescription { get; set; }
        [StringLength(255)]
        public string DocCode { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StlSettlementId { get; set; }
        public Guid? BuyDocumentId { get; set; }
        public Guid? StlDocumentId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? ComSaleWithdrawalCancellationId { get; set; }
        public Guid? ComSaleWithdrawalProductId { get; set; }
        public Guid? ComSaleWithdrawalClientId { get; set; }
        public Guid? StrEntityRelationId { get; set; }
        public Guid? RelationId { get; set; }
        [StringLength(255)]
        public string RelationCode { get; set; }
        [StringLength(255)]
        public string RelationDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityRelationCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityRelationDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityRelationObjectPath { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityRelationObjectForm { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountDebit { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountCredit { get; set; }
    }
}
