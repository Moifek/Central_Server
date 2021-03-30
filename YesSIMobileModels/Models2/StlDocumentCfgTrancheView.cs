using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlDocumentCfgTrancheView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string StlDocumentCode { get; set; }
        [StringLength(255)]
        public string StlDocumentDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StlDocumentDocDate { get; set; }
        public int? StlDocumentYear { get; set; }
        public int? StlDocumentMonth { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? StkItemId { get; set; }
        [Required]
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        [Column(TypeName = "decimal(38, 12)")]
        public decimal? VentilationRate { get; set; }
    }
}
