using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComFolderGift")]
    public partial class ComFolderGift
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComGiftId { get; set; }
        public Guid ComFolderId { get; set; }
        public bool? Delivered { get; set; }
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
        public bool? IsAvailable { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? ComGiftReasonId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VoucherDate { get; set; }
        public Guid? ComProspectionId { get; set; }

        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComFolderGifts")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(ComGiftId))]
        [InverseProperty("ComFolderGifts")]
        public virtual ComGift ComGift { get; set; }
        [ForeignKey(nameof(ComGiftReasonId))]
        [InverseProperty("ComFolderGifts")]
        public virtual ComGiftReason ComGiftReason { get; set; }
        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("ComFolderGifts")]
        public virtual ComProspection ComProspection { get; set; }
    }
}
