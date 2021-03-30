using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmCalanderYear")]
    public partial class AdmCalanderYear
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public short? YearNumber { get; set; }
    }
}
