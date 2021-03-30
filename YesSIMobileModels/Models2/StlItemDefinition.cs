using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlItemDefinition")]
    public partial class StlItemDefinition
    {
        public StlItemDefinition()
        {
            StlItemPricings = new HashSet<StlItemPricing>();
            StlItems = new HashSet<StlItem>();
        }

        [Key]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Unity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [StringLength(500)]
        public string ReportDescription { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsCredit { get; set; }
        public bool? IsInvoicable { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StlItemKindId { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? AdmModuleId { get; set; }
        public Guid? StlItemGroupId { get; set; }

        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("StlItemDefinitions")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StlItemDefinitions")]
        public virtual StlCategory StlCategory { get; set; }
        [ForeignKey(nameof(StlItemGroupId))]
        [InverseProperty("StlItemDefinitions")]
        public virtual StlItemGroup StlItemGroup { get; set; }
        [ForeignKey(nameof(StlItemKindId))]
        [InverseProperty("StlItemDefinitions")]
        public virtual StlItemKind StlItemKind { get; set; }
        [InverseProperty(nameof(StlItemPricing.StlItemDefinition))]
        public virtual ICollection<StlItemPricing> StlItemPricings { get; set; }
        [InverseProperty(nameof(StlItem.StlItemDefinition))]
        public virtual ICollection<StlItem> StlItems { get; set; }
    }
}
