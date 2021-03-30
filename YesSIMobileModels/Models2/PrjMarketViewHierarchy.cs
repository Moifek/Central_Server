using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketViewHierarchy")]
    public partial class PrjMarketViewHierarchy
    {
        public PrjMarketViewHierarchy()
        {
            PrjWorkingOutViewHierarchies = new HashSet<PrjWorkingOutViewHierarchy>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid PrjMarketViewId { get; set; }
        public Guid PrjMarketHierarchyId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(PrjMarketHierarchyId))]
        [InverseProperty("PrjMarketViewHierarchies")]
        public virtual PrjMarketHierarchy PrjMarketHierarchy { get; set; }
        [ForeignKey(nameof(PrjMarketViewId))]
        [InverseProperty("PrjMarketViewHierarchies")]
        public virtual PrjMarketView PrjMarketView { get; set; }
        [InverseProperty(nameof(PrjWorkingOutViewHierarchy.PrjMarketViewHierarchy))]
        public virtual ICollection<PrjWorkingOutViewHierarchy> PrjWorkingOutViewHierarchies { get; set; }
    }
}
