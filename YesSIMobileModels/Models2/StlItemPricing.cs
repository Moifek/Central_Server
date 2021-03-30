using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlItemPricing")]
    public partial class StlItemPricing
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StlItemDefinitionId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? CfgProjectId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? StkVocationId { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? StkItemTypeId { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlItemPricings")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgProjectId))]
        [InverseProperty("StlItemPricings")]
        public virtual CfgProject CfgProject { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("StlItemPricings")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("StlItemPricings")]
        public virtual StkItemCategory StkItemCategory { get; set; }
        [ForeignKey(nameof(StkItemTypeId))]
        [InverseProperty("StlItemPricings")]
        public virtual StkItemType StkItemType { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("StlItemPricings")]
        public virtual StkVocation StkVocation { get; set; }
        [ForeignKey(nameof(StlItemDefinitionId))]
        [InverseProperty("StlItemPricings")]
        public virtual StlItemDefinition StlItemDefinition { get; set; }
    }
}
