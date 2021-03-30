using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSaleWithdrawalProductUnderItem")]
    public partial class ComSaleWithdrawalProductUnderItem
    {
        [Key]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
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
        public bool? IsUnderItemOrigin { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? StkItemTypeId { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? StkCostCategoryId { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? StkOrientationId { get; set; }
        public Guid? StkBuildingId { get; set; }
        public Guid? StkFloorId { get; set; }
        public Guid? ComSaleWithdrawalProductId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(ComSaleWithdrawalProductId))]
        [InverseProperty("ComSaleWithdrawalProductUnderItems")]
        public virtual ComSaleWithdrawalProduct ComSaleWithdrawalProduct { get; set; }
        [ForeignKey(nameof(StkBuildingId))]
        [InverseProperty("ComSaleWithdrawalProductUnderItems")]
        public virtual StkBuilding StkBuilding { get; set; }
        [ForeignKey(nameof(StkCostCategoryId))]
        [InverseProperty("ComSaleWithdrawalProductUnderItems")]
        public virtual StkCostCategory StkCostCategory { get; set; }
        [ForeignKey(nameof(StkFloorId))]
        [InverseProperty("ComSaleWithdrawalProductUnderItems")]
        public virtual StkFloor StkFloor { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("ComSaleWithdrawalProductUnderItems")]
        public virtual StkItemCategory StkItemCategory { get; set; }
        [ForeignKey(nameof(StkItemTypeId))]
        [InverseProperty("ComSaleWithdrawalProductUnderItems")]
        public virtual StkItemType StkItemType { get; set; }
        [ForeignKey(nameof(StkOrientationId))]
        [InverseProperty("ComSaleWithdrawalProductUnderItems")]
        public virtual StkOrientation StkOrientation { get; set; }
    }
}
