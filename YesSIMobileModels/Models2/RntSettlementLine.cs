using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntSettlementLine")]
    [Index(nameof(RntDocumentId), Name = "_dta_index_RntSettlementLine_5_743009728__K11_2")]
    [Index(nameof(RntDocumentId), Name = "_dta_index_RntSettlementLine_5_743009728__K11_2_4")]
    [Index(nameof(RntSettlementId), nameof(RntDocumentId), Name = "_dta_index_RntSettlementLine_5_743009728__K4_K11")]
    [Index(nameof(RntSettlementId), nameof(RntDocumentId), Name = "_dta_index_RntSettlementLine_5_743009728__K4_K11_2")]
    [Index(nameof(RntSettlementId), nameof(StlDocumentId), Name = "_dta_index_RntSettlementLine_5_743009728__K4_K12_1_2_5_6_7_8_11")]
    [Index(nameof(RntSettlementId), nameof(Pkey), nameof(RntDocumentId), nameof(StlDocumentId), Name = "_dta_index_RntSettlementLine_5_743009728__K4_K1_K11_K12_2")]
    [Index(nameof(RntDocumentId), nameof(StlDocumentId), Name = "_dta_index_RntSettlementLine_7_743009728__K11_K12_2")]
    [Index(nameof(StlDocumentId), Name = "_dta_index_RntSettlementLine_7_743009728__K12_2")]
    public partial class RntSettlementLine
    {
        public RntSettlementLine()
        {
            ActEntryLines = new HashSet<ActEntryLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public Guid? RntSettlementId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? RntDocumentId { get; set; }
        public Guid? StlDocumentId { get; set; }

        [ForeignKey(nameof(RntDocumentId))]
        [InverseProperty("RntSettlementLines")]
        public virtual RntDocument RntDocument { get; set; }
        [ForeignKey(nameof(RntSettlementId))]
        [InverseProperty("RntSettlementLines")]
        public virtual RntSettlement RntSettlement { get; set; }
        [ForeignKey(nameof(StlDocumentId))]
        [InverseProperty("RntSettlementLines")]
        public virtual StlDocument StlDocument { get; set; }
        [InverseProperty(nameof(ActEntryLine.RntSettlementLine))]
        public virtual ICollection<ActEntryLine> ActEntryLines { get; set; }
    }
}
