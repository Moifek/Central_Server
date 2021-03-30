using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComFolderItem")]
    [Index(nameof(IsUnderItem), nameof(IsUnderItemOrigin), nameof(ComFolderId), Name = "_dta_index_ComFolderItem_7_1309247719__K24_K32_K2_19")]
    [Index(nameof(ComFolderId), nameof(IsUnderItem), nameof(IsUnderItemOrigin), Name = "_dta_index_ComFolderItem_7_1309247719__K2_K24_K32_9_19")]
    [Index(nameof(IsUnderItemOrigin), nameof(IsUnderItem), nameof(ComFolderId), Name = "_dta_index_ComFolderItem_7_1309247719__K32_K24_K2_9_19")]
    public partial class ComFolderItem
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? StkItemTypeId { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? StkCostCategoryId { get; set; }
        public Guid? ParentId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
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
        public Guid? StkOrientationId { get; set; }
        public Guid? StkFloorId { get; set; }
        public Guid? StkBuildingId { get; set; }
        public bool? IsUnderItemOrigin { get; set; }
        [Column("PriceBeforeDiscountHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceBeforeDiscountHt { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column("VATRatio", TypeName = "decimal(26, 6)")]
        public decimal? Vatratio { get; set; }
        public bool? IsTitled { get; set; }

        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComFolderItems")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(StkBuildingId))]
        [InverseProperty("ComFolderItems")]
        public virtual StkBuilding StkBuilding { get; set; }
        [ForeignKey(nameof(StkCostCategoryId))]
        [InverseProperty("ComFolderItems")]
        public virtual StkCostCategory StkCostCategory { get; set; }
        [ForeignKey(nameof(StkFloorId))]
        [InverseProperty("ComFolderItems")]
        public virtual StkFloor StkFloor { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComFolderItems")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("ComFolderItems")]
        public virtual StkItemCategory StkItemCategory { get; set; }
        [ForeignKey(nameof(StkItemTypeId))]
        [InverseProperty("ComFolderItems")]
        public virtual StkItemType StkItemType { get; set; }
        [ForeignKey(nameof(StkOrientationId))]
        [InverseProperty("ComFolderItems")]
        public virtual StkOrientation StkOrientation { get; set; }
    }
}
