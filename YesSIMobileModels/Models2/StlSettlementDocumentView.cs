using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlSettlementDocumentView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public bool? IsCredit { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? ComDocumentId { get; set; }
        public Guid? RntDocumentId { get; set; }
        public Guid? BuyDocumentId { get; set; }
        public Guid? StlDocumentId { get; set; }
        public Guid? ObjectId { get; set; }
        [StringLength(511)]
        public string ObjectCode { get; set; }
        public string ObjectDescription { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        public string CfgTrancheDescription { get; set; }
        public string StkItemCode { get; set; }
        public string StkItemDescription { get; set; }
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
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRest { get; set; }
    }
}
