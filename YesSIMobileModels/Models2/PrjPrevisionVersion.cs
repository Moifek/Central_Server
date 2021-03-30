using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjPrevisionVersion")]
    public partial class PrjPrevisionVersion
    {
        public PrjPrevisionVersion()
        {
            PrjLinePrevisions = new HashSet<PrjLinePrevision>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? VersionDate { get; set; }
        [Column(TypeName = "text")]
        public string VersionValues { get; set; }
        public Guid? PrjProjectId { get; set; }

        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjPrevisionVersions")]
        public virtual PrjProject PrjProject { get; set; }
        [InverseProperty(nameof(PrjLinePrevision.PrjPrevisionVersion))]
        public virtual ICollection<PrjLinePrevision> PrjLinePrevisions { get; set; }
    }
}
