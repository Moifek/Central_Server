using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketReceptionReserve")]
    public partial class PrjMarketReceptionReserve
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column("sorting")]
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsFixed { get; set; }
        public Guid? PrjMarketReceptionId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(PrjMarketReceptionId))]
        [InverseProperty("PrjMarketReceptionReserves")]
        public virtual PrjMarketReception PrjMarketReception { get; set; }
    }
}
