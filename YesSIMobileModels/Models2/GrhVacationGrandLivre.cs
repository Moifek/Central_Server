using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class GrhVacationGrandLivre
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        [StringLength(255)]
        public string GrhEmployeeCode { get; set; }
        [StringLength(255)]
        public string GrhEmployeeDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(756)]
        public string Description { get; set; }
        [StringLength(255)]
        public string LineCode { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DaysNumberDebit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DaysNumberCredit { get; set; }
    }
}
