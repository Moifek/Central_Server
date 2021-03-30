using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyDocumentCfgTrancheView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string BuyDocumentCode { get; set; }
        [StringLength(255)]
        public string BuyDocumentDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BuyDocumentDocDate { get; set; }
        public int? BuyDocumentYear { get; set; }
        public int? BuyDocumentMonth { get; set; }
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
        public Guid? PrjProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? VentilationRate { get; set; }
    }
}
