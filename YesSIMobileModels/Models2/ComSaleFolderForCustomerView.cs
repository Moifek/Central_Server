using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComSaleFolderForCustomerView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Total { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalSettled { get; set; }
        public int IsCancellation { get; set; }
        public Guid CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid ComFolderStatusId { get; set; }
        [StringLength(255)]
        public string ComFolderStatusCode { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PartPercent { get; set; }
    }
}
