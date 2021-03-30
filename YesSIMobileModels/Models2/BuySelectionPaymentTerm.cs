using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuySelectionPaymentTerm")]
    public partial class BuySelectionPaymentTerm
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Ratio { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? BuySelectionId { get; set; }

        [ForeignKey(nameof(BuySelectionId))]
        [InverseProperty("BuySelectionPaymentTerms")]
        public virtual BuySelection BuySelection { get; set; }
    }
}
