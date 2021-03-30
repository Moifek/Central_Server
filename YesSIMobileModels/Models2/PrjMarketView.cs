using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketView")]
    public partial class PrjMarketView
    {
        public PrjMarketView()
        {
            PrjMarketViewHierarchies = new HashSet<PrjMarketViewHierarchy>();
            PrjMarketViewLines = new HashSet<PrjMarketViewLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ParentId { get; set; }
        public Guid PrjMarketId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Percentage { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        public bool? IsTask { get; set; }
        public bool? IsMarket { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public int? Sorting { get; set; }
        public Guid? StkLevelingLineId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PointsNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PointsAmount { get; set; }

        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketViews")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(StkLevelingLineId))]
        [InverseProperty("PrjMarketViews")]
        public virtual StkLevelingLine StkLevelingLine { get; set; }
        [InverseProperty(nameof(PrjMarketViewHierarchy.PrjMarketView))]
        public virtual ICollection<PrjMarketViewHierarchy> PrjMarketViewHierarchies { get; set; }
        [InverseProperty(nameof(PrjMarketViewLine.PrjMarketView))]
        public virtual ICollection<PrjMarketViewLine> PrjMarketViewLines { get; set; }
    }
}
