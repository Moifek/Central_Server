using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmDeploymentHistory")]
    public partial class AdmDeploymentHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Version { get; set; }
        [StringLength(255)]
        public string Revision { get; set; }
        [StringLength(255)]
        public string WebRevision { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeploymentDateTime { get; set; }
    }
}
