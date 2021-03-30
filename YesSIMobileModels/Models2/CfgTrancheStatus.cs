using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgTrancheStatus")]
    public partial class CfgTrancheStatus
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid CfgTrancheId { get; set; }
        public Guid ComFolderStatusId { get; set; }
        public int? ThresholdOperator { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ThresholdRatio { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("CfgTrancheStatuses")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(ComFolderStatusId))]
        [InverseProperty("CfgTrancheStatuses")]
        public virtual ComFolderStatus ComFolderStatus { get; set; }
    }
}
