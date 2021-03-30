using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmSequence")]
    public partial class AdmSequence
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public int? SeqYear { get; set; }
        public int? SeqYearNumber { get; set; }
        public int? SeqValue { get; set; }
        public int? SeqValueNumber { get; set; }
        [StringLength(255)]
        public string Separator { get; set; }
        public bool? BasedOnSystemYear { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string TypeCode { get; set; }
        [StringLength(255)]
        public string SeqPrefix { get; set; }
        [StringLength(255)]
        public string SeqSuffix { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("AdmSequences")]
        public virtual CfgCompany CfgCompany { get; set; }
    }
}
