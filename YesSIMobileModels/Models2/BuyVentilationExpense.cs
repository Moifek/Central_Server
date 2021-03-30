using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyVentilationExpense")]
    [Index(nameof(BuyDocumentId), nameof(PrjProjectId), Name = "_dta_index_BuyVentilationExpense")]
    [Index(nameof(BuyDocumentId), nameof(PrjProjectId), Name = "_dta_index_BuyVentilationExpense_10_1815677516__K3_K2_4")]
    public partial class BuyVentilationExpense
    {
        [Key]
        public Guid Pkey { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? BuyDocumentId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VentilationRate { get; set; }

        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("BuyVentilationExpenses")]
        public virtual BuyDocument BuyDocument { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("BuyVentilationExpenses")]
        public virtual PrjProject PrjProject { get; set; }
    }
}
