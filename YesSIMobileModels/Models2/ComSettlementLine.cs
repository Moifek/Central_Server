using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSettlementLine")]
    [Index(nameof(ComSettlementId), Name = "_dta_index_ComSettlementLine_5_1684201050__K4_2")]
    [Index(nameof(ComSettlementId), nameof(ComDocumentId), Name = "_dta_index_ComSettlementLine_5_1684201050__K4_K3")]
    [Index(nameof(ComDocumentId), nameof(ComSettlementId), Name = "_dta_index_ComSettlementLine_7_1684201050__K3_K4_2")]
    public partial class ComSettlementLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public Guid? ComDocumentId { get; set; }
        public Guid? ComSettlementId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StlDocumentId { get; set; }

        [ForeignKey(nameof(ComDocumentId))]
        [InverseProperty("ComSettlementLines")]
        public virtual ComDocument ComDocument { get; set; }
        [ForeignKey(nameof(ComSettlementId))]
        [InverseProperty("ComSettlementLines")]
        public virtual ComSettlement ComSettlement { get; set; }
        [ForeignKey(nameof(StlDocumentId))]
        [InverseProperty("ComSettlementLines")]
        public virtual StlDocument StlDocument { get; set; }
    }
}
