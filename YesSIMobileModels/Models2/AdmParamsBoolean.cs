using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmParamsBoolean")]
    public partial class AdmParamsBoolean
    {
        [Key]
        [StringLength(255)]
        public string Code { get; set; }
        public bool? CodeValue { get; set; }
        [Column("PKey")]
        public Guid? Pkey { get; set; }
    }
}
