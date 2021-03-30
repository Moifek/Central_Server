using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyDocumentVatGroupView
    {
        public Guid? BuyDocumentId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("BaseHT", TypeName = "decimal(38, 6)")]
        public decimal? BaseHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? VatAmount { get; set; }
    }
}
