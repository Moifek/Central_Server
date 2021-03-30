using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlSettlementRelationView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? AdmModuleId { get; set; }
        public Guid? ComDocumentId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? RntDocumentId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
        public Guid? StlDocumentId { get; set; }
        public Guid? BuyDocumentId { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? StlSettlementId { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Amount { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? CfgProjectId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? PrjMarketId { get; set; }
        [Required]
        [StringLength(3)]
        public string Origin { get; set; }
    }
}
