using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmMessage")]
    public partial class AdmMessage
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public string Notes { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserName { get; set; }
        public Guid? CategoryId { get; set; }
        public bool? IsIn { get; set; }
        [StringLength(255)]
        public string Origin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReminderDate { get; set; }
    }
}
