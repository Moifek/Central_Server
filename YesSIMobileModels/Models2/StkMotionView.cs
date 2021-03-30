using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StkMotionView
    {
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MotionDate { get; set; }
        public int MotionCount { get; set; }
        [Required]
        [StringLength(33)]
        public string MotionLabel { get; set; }
    }
}
