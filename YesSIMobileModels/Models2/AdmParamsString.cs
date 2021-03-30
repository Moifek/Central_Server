using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmParamsString")]
    public partial class AdmParamsString
    {
        [Key]
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(1000)]
        public string CodeValue { get; set; }
        [Column("PKey")]
        public Guid? Pkey { get; set; }
    }
}
