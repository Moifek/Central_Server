using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyItem")]
    public partial class BuyItem
    {
        public BuyItem()
        {
            BuyConsultationEstimationLines = new HashSet<BuyConsultationEstimationLine>();
            BuyConsultationLines = new HashSet<BuyConsultationLine>();
            BuyDocumentLines = new HashSet<BuyDocumentLine>();
            BuyRequests = new HashSet<BuyRequest>();
            BuySelectionLines = new HashSet<BuySelectionLine>();
            BuySelectionStockLines = new HashSet<BuySelectionStockLine>();
            PrjMarketLineEstimations = new HashSet<PrjMarketLineEstimation>();
            PrjMarketLines = new HashSet<PrjMarketLine>();
            PrjWorkingOutLines = new HashSet<PrjWorkingOutLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }

        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("BuyItems")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(BuyConsultationEstimationLine.BuyItem))]
        public virtual ICollection<BuyConsultationEstimationLine> BuyConsultationEstimationLines { get; set; }
        [InverseProperty(nameof(BuyConsultationLine.BuyItem))]
        public virtual ICollection<BuyConsultationLine> BuyConsultationLines { get; set; }
        [InverseProperty(nameof(BuyDocumentLine.BuyItem))]
        public virtual ICollection<BuyDocumentLine> BuyDocumentLines { get; set; }
        [InverseProperty(nameof(BuyRequest.BuyItem))]
        public virtual ICollection<BuyRequest> BuyRequests { get; set; }
        [InverseProperty(nameof(BuySelectionLine.BuyItem))]
        public virtual ICollection<BuySelectionLine> BuySelectionLines { get; set; }
        [InverseProperty(nameof(BuySelectionStockLine.BuyItem))]
        public virtual ICollection<BuySelectionStockLine> BuySelectionStockLines { get; set; }
        [InverseProperty(nameof(PrjMarketLineEstimation.BuyItem))]
        public virtual ICollection<PrjMarketLineEstimation> PrjMarketLineEstimations { get; set; }
        [InverseProperty(nameof(PrjMarketLine.BuyItem))]
        public virtual ICollection<PrjMarketLine> PrjMarketLines { get; set; }
        [InverseProperty(nameof(PrjWorkingOutLine.BuyItem))]
        public virtual ICollection<PrjWorkingOutLine> PrjWorkingOutLines { get; set; }
    }
}
