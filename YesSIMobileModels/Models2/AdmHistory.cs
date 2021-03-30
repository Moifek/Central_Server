using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmHistory")]
    public partial class AdmHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(50)]
        public string Category { get; set; }
        public Guid? CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryLabel { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActionDate { get; set; }
        [StringLength(50)]
        public string ActionUser { get; set; }
        [StringLength(500)]
        public string ActionDescription { get; set; }
        [Column(TypeName = "ntext")]
        public string ActionVertion { get; set; }
        [StringLength(1000)]
        public string CategoryDescription { get; set; }
    }
}
