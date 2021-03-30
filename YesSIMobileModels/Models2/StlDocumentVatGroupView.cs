using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlDocumentVatGroupView
    {
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        public Guid? StlDocumentId { get; set; }
        [Column("BaseHT", TypeName = "decimal(38, 6)")]
        public decimal? BaseHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? VatAmount { get; set; }
    }
}
