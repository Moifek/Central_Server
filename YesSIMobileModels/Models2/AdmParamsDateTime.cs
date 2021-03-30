using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmParamsDateTime")]
    public partial class AdmParamsDateTime
    {
        [Key]
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CodeValue { get; set; }
        [Column("PKey")]
        public Guid? Pkey { get; set; }
    }
}
