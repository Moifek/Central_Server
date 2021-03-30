using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComGift")]
    public partial class ComGift
    {
        public ComGift()
        {
            ComFolderGifts = new HashSet<ComFolderGift>();
            ComGiftQuantities = new HashSet<ComGiftQuantity>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Price { get; set; }

        [InverseProperty(nameof(ComFolderGift.ComGift))]
        public virtual ICollection<ComFolderGift> ComFolderGifts { get; set; }
        [InverseProperty(nameof(ComGiftQuantity.ComGift))]
        public virtual ICollection<ComGiftQuantity> ComGiftQuantities { get; set; }
    }
}
