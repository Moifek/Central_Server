using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComSalePrevision
    {
        public Guid CfgProjectPkey { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid CfgTranchePkey { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid CfgCompanyPkey { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid? ComFolderId { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        [StringLength(255)]
        public string ComFolderDescription { get; set; }
        public Guid? ComDocumentId { get; set; }
        [StringLength(255)]
        public string ComDocumentDescription { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int Trimester { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Required]
        [StringLength(561)]
        public string Description { get; set; }
        public int BaseConcretisationQuantity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal BaseConcretisationAmount { get; set; }
        public int BaseFinalisationQuantity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal BaseFinalisationAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal BaseAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal BaseTurnover { get; set; }
        public int HistoryConcretisationQuantity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal HistoryConcretisationAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal HistoryFinalisationQuantity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal HistoryFinalisationAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal HistoryAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal HistoryTurnover { get; set; }
        public int ConcretisationQuantityPrev { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal ConcretisationPrev { get; set; }
        [Column("CAQuantityPrev")]
        public int CaquantityPrev { get; set; }
        [Column("CAPrev", TypeName = "decimal(26, 6)")]
        public decimal Caprev { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal EncaissementPrev { get; set; }
        [Column("PrevisionTurnoverHT", TypeName = "numeric(38, 12)")]
        public decimal? PrevisionTurnoverHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal PrevisionTurnover { get; set; }
        [Column(TypeName = "decimal(37, 6)")]
        public decimal? EncaissementReal { get; set; }
        public int ConcretisationQuantityReal { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ConcretisationReal { get; set; }
        public int ConcretisationQuantityRealWihoutCancelations { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ConcretisationRealWihoutCancelations { get; set; }
        public int PromesseQuantityRealWihoutCancelations { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PromesseRealWihoutCancelations { get; set; }
        [Column(TypeName = "decimal(37, 6)")]
        public decimal? EncaissementRealAdvance { get; set; }
        [Column("CAQuantityReal")]
        public int CaquantityReal { get; set; }
        [Column("CARealHT", TypeName = "decimal(26, 6)")]
        public decimal CarealHt { get; set; }
        [Column("CAReal", TypeName = "decimal(26, 6)")]
        public decimal Careal { get; set; }
        public int DeliveryQuantityReal { get; set; }
        public int CancelQuantityReal { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CancelReal { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal CancelRefund { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CancelRefundRest { get; set; }
        public int AnnulQuantityReal { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AnnulReal { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal EngagedAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RestEngagedAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal OtherEngagedAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RestOtherEngagedAmount { get; set; }
    }
}
