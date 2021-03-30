using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmParamsDecimal")]
    public partial class AdmParamsDecimal
    {
        [Key]
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "numeric(21, 6)")]
        public decimal? CodeValue { get; set; }
        [Column("PKey")]
        public Guid? Pkey { get; set; }
    }
}
