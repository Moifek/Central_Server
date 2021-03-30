using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkLevelingLine")]
    public partial class StkLevelingLine
    {
        public StkLevelingLine()
        {
            PrjMarketViews = new HashSet<PrjMarketView>();
            PrjMarkets = new HashSet<PrjMarket>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public int? Sorting { get; set; }
        public Guid? StkLevelId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StkLevelId))]
        [InverseProperty(nameof(StkLeveling.StkLevelingLines))]
        public virtual StkLeveling StkLevel { get; set; }
        [InverseProperty(nameof(PrjMarketView.StkLevelingLine))]
        public virtual ICollection<PrjMarketView> PrjMarketViews { get; set; }
        [InverseProperty(nameof(PrjMarket.StkLevelingLine))]
        public virtual ICollection<PrjMarket> PrjMarkets { get; set; }
    }
}
