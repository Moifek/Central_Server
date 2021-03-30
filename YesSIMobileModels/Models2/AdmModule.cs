using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmModule")]
    public partial class AdmModule
    {
        public AdmModule()
        {
            ActEntries = new HashSet<ActEntry>();
            BuyDocuments = new HashSet<BuyDocument>();
            ComDocuments = new HashSet<ComDocument>();
            PrvSettlementPrevisions = new HashSet<PrvSettlementPrevision>();
            PrvTurnoverPrevisions = new HashSet<PrvTurnoverPrevision>();
            RntDocuments = new HashSet<RntDocument>();
            StlDocuments = new HashSet<StlDocument>();
            StlItemDefinitions = new HashSet<StlItemDefinition>();
            StlPaymentAuthorizations = new HashSet<StlPaymentAuthorization>();
            StlSettlements = new HashSet<StlSettlement>();
            StrEntities = new HashSet<StrEntity>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [InverseProperty(nameof(ActEntry.AdmModule))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(BuyDocument.AdmModule))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(ComDocument.AdmModule))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
        [InverseProperty(nameof(PrvSettlementPrevision.AdmModule))]
        public virtual ICollection<PrvSettlementPrevision> PrvSettlementPrevisions { get; set; }
        [InverseProperty(nameof(PrvTurnoverPrevision.AdmModule))]
        public virtual ICollection<PrvTurnoverPrevision> PrvTurnoverPrevisions { get; set; }
        [InverseProperty(nameof(RntDocument.AdmModule))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
        [InverseProperty(nameof(StlDocument.AdmModule))]
        public virtual ICollection<StlDocument> StlDocuments { get; set; }
        [InverseProperty(nameof(StlItemDefinition.AdmModule))]
        public virtual ICollection<StlItemDefinition> StlItemDefinitions { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorization.AdmModule))]
        public virtual ICollection<StlPaymentAuthorization> StlPaymentAuthorizations { get; set; }
        [InverseProperty(nameof(StlSettlement.AdmModule))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
        [InverseProperty(nameof(StrEntity.AdmModule))]
        public virtual ICollection<StrEntity> StrEntities { get; set; }
    }
}
