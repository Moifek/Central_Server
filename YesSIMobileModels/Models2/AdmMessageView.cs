using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class AdmMessageView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public string Notes { get; set; }
        public Guid? CategoryId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserName { get; set; }
        public bool? IsIn { get; set; }
        public Guid? CfgTierId { get; set; }
        [Required]
        [StringLength(17)]
        public string Origin { get; set; }
    }
}
