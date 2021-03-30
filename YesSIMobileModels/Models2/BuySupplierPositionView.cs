using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuySupplierPositionView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EcheanceDate { get; set; }
        [Column("AmountTTC", TypeName = "decimal(29, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(30, 6)")]
        public decimal? AmountRetained { get; set; }
        [Column(TypeName = "decimal(28, 6)")]
        public decimal? AmountCredit { get; set; }
        [Column(TypeName = "decimal(28, 6)")]
        public decimal? AmountDebit { get; set; }
        [Column("AmountRS", TypeName = "decimal(26, 6)")]
        public decimal? AmountRs { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountBase { get; set; }
        public bool? IsCredit { get; set; }
        public Guid? TierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        [StringLength(255)]
        public string ReferenceType { get; set; }
        public Guid ObjectId { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        public Guid? StrEntityId { get; set; }
    }
}
