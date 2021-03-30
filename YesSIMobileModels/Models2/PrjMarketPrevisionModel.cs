using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketPrevisionModel")]
    public partial class PrjMarketPrevisionModel
    {
        public PrjMarketPrevisionModel()
        {
            Fsprevisions = new HashSet<Fsprevision>();
            PrjMarketPrevisionModelLines = new HashSet<PrjMarketPrevisionModelLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StlCategoryId { get; set; }

        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("PrjMarketPrevisionModels")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(Fsprevision.PrjMarketPrevisionModel))]
        public virtual ICollection<Fsprevision> Fsprevisions { get; set; }
        [InverseProperty(nameof(PrjMarketPrevisionModelLine.PrjMarketPrevisionModel))]
        public virtual ICollection<PrjMarketPrevisionModelLine> PrjMarketPrevisionModelLines { get; set; }
    }
}
