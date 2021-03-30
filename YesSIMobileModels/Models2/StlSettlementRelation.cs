using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    [Table("StlSettlementRelation")]
    public partial class StlSettlementRelation
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StlCategoryId { get; set; }

        [ForeignKey(nameof(StlCategoryId))]
        public virtual StlCategory StlCategory { get; set; }
    }
}
