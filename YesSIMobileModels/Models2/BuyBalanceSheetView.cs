using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyBalanceSheetView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        [StringLength(255)]
        public string ReferenceType { get; set; }
        public string Notes { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Credit { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Debit { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Solde { get; set; }
    }
}
