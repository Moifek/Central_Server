using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlSettlementLineView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StlSettlementId { get; set; }
        public Guid? ComSettlementId { get; set; }
        public Guid? RntSettlementId { get; set; }
        public Guid? BuySettlementId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public string CategoryDescription { get; set; }
        public string ProjectDescription { get; set; }
        public string TrancheDescription { get; set; }
        public string ItemDescription { get; set; }
        [Required]
        [StringLength(1512)]
        public string Notes { get; set; }
        public Guid? ObjectId { get; set; }
        public Guid StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        public Guid? DocumentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
    }
}
