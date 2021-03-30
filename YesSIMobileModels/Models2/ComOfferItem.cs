using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComOfferItem")]
    public partial class ComOfferItem
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? ComOfferId { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? StkItemTypeId { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? StkCostCategoryId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Blok { get; set; }
        public int? RawNumber { get; set; }
        public int? LevelNumber { get; set; }
        [StringLength(255)]
        public string Orientation { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(1000)]
        public string Contenance { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaNet { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaFloor { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceBeforeDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Price { get; set; }
        public bool? AlwaysAffected { get; set; }
        public bool? IsUnderItem { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(ComOfferId))]
        [InverseProperty("ComOfferItems")]
        public virtual ComOffer ComOffer { get; set; }
        [ForeignKey(nameof(StkCostCategoryId))]
        [InverseProperty("ComOfferItems")]
        public virtual StkCostCategory StkCostCategory { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComOfferItems")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("ComOfferItems")]
        public virtual StkItemCategory StkItemCategory { get; set; }
        [ForeignKey(nameof(StkItemTypeId))]
        [InverseProperty("ComOfferItems")]
        public virtual StkItemType StkItemType { get; set; }
    }
}
