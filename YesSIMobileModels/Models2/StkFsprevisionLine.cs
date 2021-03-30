using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFSPrevisionLine")]
    public partial class StkFsprevisionLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public int? DateMonth { get; set; }
        public int? DateYear { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public Guid? StkFeasibilityStudyId { get; set; }
        public Guid? StkFeasibilityStudyCfgTrancheId { get; set; }
        [StringLength(255)]
        public string PrevisionType { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsCredit { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }

        [ForeignKey(nameof(StkFeasibilityStudyCfgTrancheId))]
        [InverseProperty("StkFsprevisionLines")]
        public virtual StkFeasibilityStudyCfgTranche StkFeasibilityStudyCfgTranche { get; set; }
    }
}
