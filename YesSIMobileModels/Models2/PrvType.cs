using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrvType")]
    public partial class PrvType
    {
        public PrvType()
        {
            PrvSettlementPrevisions = new HashSet<PrvSettlementPrevision>();
            PrvTurnoverPrevisions = new HashSet<PrvTurnoverPrevision>();
            StkFeasibilityStudies = new HashSet<StkFeasibilityStudy>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(PrvSettlementPrevision.PrvType))]
        public virtual ICollection<PrvSettlementPrevision> PrvSettlementPrevisions { get; set; }
        [InverseProperty(nameof(PrvTurnoverPrevision.PrvType))]
        public virtual ICollection<PrvTurnoverPrevision> PrvTurnoverPrevisions { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudy.PrvType))]
        public virtual ICollection<StkFeasibilityStudy> StkFeasibilityStudies { get; set; }
    }
}
