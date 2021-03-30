using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmCalanderTrimester")]
    public partial class AdmCalanderTrimester
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public short? TrimesterNumber { get; set; }
        [StringLength(25)]
        public string Code { get; set; }
        [StringLength(25)]
        public string Description { get; set; }
    }
}
