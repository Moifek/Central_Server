using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlSalePrevisionManual")]
    public partial class StlSalePrevisionManual
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PrevisionTurnover { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EncaissementPrev { get; set; }
        public int? ConcretisationQuantityPrev { get; set; }
        [Column("CAQuantityPrev")]
        public int? CaquantityPrev { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConcretisationPrev { get; set; }

        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("StlSalePrevisionManuals")]
        public virtual CfgTranche CfgTranche { get; set; }
    }
}
