using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class GrhPaySlipLineView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Credit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Debit { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? GrhPaySlipModelUnityId { get; set; }
        public Guid? GrhPaySlipId { get; set; }
        [StringLength(255)]
        public string GrhPaySlipCode { get; set; }
        [StringLength(255)]
        public string GrhPaySlipDescription { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
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
        public Guid? GrhEmployeeKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeKindDescription { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
