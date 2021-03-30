using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmCalanderMonth")]
    public partial class AdmCalanderMonth
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public short? MonthNumber { get; set; }
        [StringLength(25)]
        public string Code { get; set; }
        [StringLength(25)]
        public string Description { get; set; }
    }
}
