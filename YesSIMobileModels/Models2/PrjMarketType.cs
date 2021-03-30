using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketType")]
    public partial class PrjMarketType
    {
        public PrjMarketType()
        {
            BuyConsultations = new HashSet<BuyConsultation>();
            BuyDocumentWorkFlowDocumentToAttaches = new HashSet<BuyDocumentWorkFlowDocumentToAttach>();
            BuyDocuments = new HashSet<BuyDocument>();
            BuySelections = new HashSet<BuySelection>();
            PrjMarkets = new HashSet<PrjMarket>();
            StkExpenseTypes = new HashSet<StkExpenseType>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [InverseProperty(nameof(BuyConsultation.PrjMarketType))]
        public virtual ICollection<BuyConsultation> BuyConsultations { get; set; }
        [InverseProperty(nameof(BuyDocumentWorkFlowDocumentToAttach.PrjMarketType))]
        public virtual ICollection<BuyDocumentWorkFlowDocumentToAttach> BuyDocumentWorkFlowDocumentToAttaches { get; set; }
        [InverseProperty(nameof(BuyDocument.PrjMarketType))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuySelection.PrjMarketType))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty(nameof(PrjMarket.PrjMarketType))]
        public virtual ICollection<PrjMarket> PrjMarkets { get; set; }
        [InverseProperty(nameof(StkExpenseType.PrjMarketType))]
        public virtual ICollection<StkExpenseType> StkExpenseTypes { get; set; }
    }
}
