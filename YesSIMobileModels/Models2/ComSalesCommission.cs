using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSalesCommission")]
    public partial class ComSalesCommission
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? SaleCommissionAmount { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DeliveryCommissionAmount { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? SaleCommissionAmountExtern { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DeliveryCommissionAmountExtern { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComActionId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryCommissionAmount2 { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryCommissionAmountExtern2 { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SaleCommissionPercent { get; set; }
        public bool? SaleCommissionBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SaleCommissionPercentExtern { get; set; }
        public bool? SaleCommissionExternBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryCommissionPercent { get; set; }
        public bool? DeliveryCommissionBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryCommissionPercentExtern { get; set; }
        public bool? DeliveryCommissionExternBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryCommissionPercent2 { get; set; }
        public bool? DeliveryCommission2BasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryCommissionPercentExtern2 { get; set; }
        public bool? DeliveryCommissionExtern2BasedOnAmount { get; set; }
        public Guid? ComEmployeeId { get; set; }

        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("ComSalesCommissionCfgTiers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("ComSalesCommissions")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(ComActionId))]
        [InverseProperty("ComSalesCommissions")]
        public virtual ComAction ComAction { get; set; }
        [ForeignKey(nameof(ComEmployeeId))]
        [InverseProperty("ComSalesCommissionComEmployees")]
        public virtual CfgTier ComEmployee { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("ComSalesCommissions")]
        public virtual StkItemCategory StkItemCategory { get; set; }
    }
}
