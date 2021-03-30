using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmParamsImage")]
    public partial class AdmParamsImage
    {
        [Key]
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "image")]
        public byte[] CodeValue { get; set; }
        [Column("PKey")]
        public Guid? Pkey { get; set; }
    }
}
