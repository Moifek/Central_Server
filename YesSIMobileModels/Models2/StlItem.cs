using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlItem")]
    public partial class StlItem
    {
        public StlItem()
        {
            StlDocumentLines = new HashSet<StlDocumentLine>();
        }

        [Key]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DiscountRatio { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [Column("UnitPriceHTNet", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHtnet { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [Column("TotalHT", TypeName = "decimal(26, 6)")]
        public decimal? TotalHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalVat { get; set; }
        [Column("TotalTTC", TypeName = "decimal(26, 6)")]
        public decimal? TotalTtc { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StlItemDefinitionId { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
        public Guid? SavServiceId { get; set; }
        public Guid? SavClaimGroupId { get; set; }

        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("StlItems")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("StlItems")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(SavClaimGroupId))]
        [InverseProperty("StlItems")]
        public virtual SavClaimGroup SavClaimGroup { get; set; }
        [ForeignKey(nameof(SavServiceId))]
        [InverseProperty("StlItems")]
        public virtual SavService SavService { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StlItems")]
        public virtual StlCategory StlCategory { get; set; }
        [ForeignKey(nameof(StlItemDefinitionId))]
        [InverseProperty("StlItems")]
        public virtual StlItemDefinition StlItemDefinition { get; set; }
        [ForeignKey(nameof(SynFolderId))]
        [InverseProperty("StlItems")]
        public virtual SynFolder SynFolder { get; set; }
        [InverseProperty(nameof(StlDocumentLine.StlItem))]
        public virtual ICollection<StlDocumentLine> StlDocumentLines { get; set; }
    }
}
