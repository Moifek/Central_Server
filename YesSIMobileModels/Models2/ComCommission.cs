using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComCommission")]
    public partial class ComCommission
    {
        public ComCommission()
        {
            ComCommissionLines = new HashSet<ComCommissionLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public bool? IsValidated { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        public bool? IsConcretisation { get; set; }
        public bool? IsDelivery { get; set; }
        public bool? IsDelivery2 { get; set; }
        public bool? IsCancellation { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }

        [InverseProperty(nameof(ComCommissionLine.ComCommission))]
        public virtual ICollection<ComCommissionLine> ComCommissionLines { get; set; }
    }
}
