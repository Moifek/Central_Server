using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyVentilationCategory")]
    [Index(nameof(BuyDocumentId), nameof(StlCategoryId), Name = "_dta_index_BuyVentilationCategory")]
    public partial class BuyVentilationCategory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? BuyDocumentId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VentilationRate { get; set; }

        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("BuyVentilationCategories")]
        public virtual BuyDocument BuyDocument { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("BuyVentilationCategories")]
        public virtual StlCategory StlCategory { get; set; }
    }
}
