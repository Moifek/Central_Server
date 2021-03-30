using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComGiftQuantity")]
    public partial class ComGiftQuantity
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComGiftId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceptionDate { get; set; }
        public int? Quantity { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(ComGiftId))]
        [InverseProperty("ComGiftQuantities")]
        public virtual ComGift ComGift { get; set; }
    }
}
