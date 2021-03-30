using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntFolderItem")]
    public partial class RntFolderItem
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? StkItemTypeId { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? StkCostCategoryId { get; set; }
        public Guid? StkOrientationId { get; set; }
        public Guid? StkFloorId { get; set; }
        public Guid? StkBuildingId { get; set; }
        public Guid? ParentId { get; set; }
        public bool? AlwaysAffected { get; set; }
        public bool? IsUnderItem { get; set; }
        public bool? IsUnderItemOrigin { get; set; }
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
        [Column("RentAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentAmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RentVatRatio { get; set; }
        [Column("RentAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? RentAmountTtc { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("RntFolderItems")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(StkBuildingId))]
        [InverseProperty("RntFolderItems")]
        public virtual StkBuilding StkBuilding { get; set; }
        [ForeignKey(nameof(StkCostCategoryId))]
        [InverseProperty("RntFolderItems")]
        public virtual StkCostCategory StkCostCategory { get; set; }
        [ForeignKey(nameof(StkFloorId))]
        [InverseProperty("RntFolderItems")]
        public virtual StkFloor StkFloor { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("RntFolderItems")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("RntFolderItems")]
        public virtual StkItemCategory StkItemCategory { get; set; }
        [ForeignKey(nameof(StkItemTypeId))]
        [InverseProperty("RntFolderItems")]
        public virtual StkItemType StkItemType { get; set; }
        [ForeignKey(nameof(StkOrientationId))]
        [InverseProperty("RntFolderItems")]
        public virtual StkOrientation StkOrientation { get; set; }
    }
}
