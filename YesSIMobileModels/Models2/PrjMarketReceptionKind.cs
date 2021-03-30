using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketReceptionKind")]
    public partial class PrjMarketReceptionKind
    {
        public PrjMarketReceptionKind()
        {
            PrjMarketReceptions = new HashSet<PrjMarketReception>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column("sorting")]
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsFinal { get; set; }

        [InverseProperty(nameof(PrjMarketReception.PrjMarketReceptionKind))]
        public virtual ICollection<PrjMarketReception> PrjMarketReceptions { get; set; }
    }
}
