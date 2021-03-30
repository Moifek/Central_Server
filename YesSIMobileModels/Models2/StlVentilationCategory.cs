using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlVentilationCategory")]
    [Index(nameof(StlDocumentId), nameof(StlCategoryId), Name = "_dta_index_StlVentilationCategory_5_1808061527__K3_K4")]
    public partial class StlVentilationCategory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VentilationRate { get; set; }
        public Guid? StlDocumentId { get; set; }
        public Guid? StlCategoryId { get; set; }

        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StlVentilationCategories")]
        public virtual StlCategory StlCategory { get; set; }
        [ForeignKey(nameof(StlDocumentId))]
        [InverseProperty("StlVentilationCategories")]
        public virtual StlDocument StlDocument { get; set; }
    }
}
