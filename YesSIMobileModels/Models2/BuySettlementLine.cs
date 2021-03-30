using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuySettlementLine")]
    [Index(nameof(Amount), nameof(BuyDocumentId), Name = "_dta_index_BuySettlementLine_10_903674267__K2_K3")]
    [Index(nameof(BuyDocumentId), Name = "_dta_index_BuySettlementLine_10_903674267__K3_2")]
    public partial class BuySettlementLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public Guid? BuyDocumentId { get; set; }
        public Guid? StlSettlementId { get; set; }

        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("BuySettlementLines")]
        public virtual BuyDocument BuyDocument { get; set; }
        [ForeignKey(nameof(StlSettlementId))]
        [InverseProperty("BuySettlementLines")]
        public virtual StlSettlement StlSettlement { get; set; }
    }
}
