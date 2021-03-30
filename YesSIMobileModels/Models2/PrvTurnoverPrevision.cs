using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrvTurnoverPrevision")]
    public partial class PrvTurnoverPrevision
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public bool? IsCredit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? AdmModuleId { get; set; }
        public Guid? PrvTypeId { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? PrvVersionId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("PrvTurnoverPrevisions")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("PrvTurnoverPrevisions")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("PrvTurnoverPrevisions")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(PrvTypeId))]
        [InverseProperty("PrvTurnoverPrevisions")]
        public virtual PrvType PrvType { get; set; }
        [ForeignKey(nameof(PrvVersionId))]
        [InverseProperty("PrvTurnoverPrevisions")]
        public virtual PrvVersion PrvVersion { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("PrvTurnoverPrevisions")]
        public virtual StlCategory StlCategory { get; set; }
    }
}
