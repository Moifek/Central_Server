using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlCategoryPrevision")]
    public partial class StlCategoryPrevision
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? PrevisionYear { get; set; }
        public int? PrevisionMonth { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PrevisionAmount { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? CfgCompanyId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlCategoryPrevisions")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StlCategoryPrevisions")]
        public virtual StlCategory StlCategory { get; set; }
    }
}
