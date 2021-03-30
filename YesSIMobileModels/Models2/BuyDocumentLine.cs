using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyDocumentLine")]
    [Index(nameof(BuyDocumentId), nameof(StlCategoryId), Name = "_dta_index_BuyDocumentLine_5_148195578__K12_K26_5_7_8_18_27")]
    public partial class BuyDocumentLine
    {
        public BuyDocumentLine()
        {
            RntDocuments = new HashSet<RntDocument>();
        }

        [Key]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DiscountRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? BuyDocumentId { get; set; }
        public int? Sorting { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        public Guid? PrjMarketLineId { get; set; }
        public Guid? BuyItemId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? QuantityOld { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? QuantityOrigin { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Coefficient { get; set; }
        public Guid? StlCategoryId { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? BuyConsultationLineId { get; set; }

        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("BuyDocumentLines")]
        public virtual BuyDocument BuyDocument { get; set; }
        [ForeignKey(nameof(BuyItemId))]
        [InverseProperty("BuyDocumentLines")]
        public virtual BuyItem BuyItem { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("BuyDocumentLines")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(RntDocument.BuyDocumentLine))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
    }
}
