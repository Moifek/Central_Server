using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkLeveling")]
    public partial class StkLeveling
    {
        public StkLeveling()
        {
            CfgTranches = new HashSet<CfgTranche>();
            PrjProjects = new HashSet<PrjProject>();
            StkLevelingLines = new HashSet<StkLevelingLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(CfgTranche.StkLeveling))]
        public virtual ICollection<CfgTranche> CfgTranches { get; set; }
        [InverseProperty(nameof(PrjProject.StkLeveling))]
        public virtual ICollection<PrjProject> PrjProjects { get; set; }
        [InverseProperty(nameof(StkLevelingLine.StkLevel))]
        public virtual ICollection<StkLevelingLine> StkLevelingLines { get; set; }
    }
}
