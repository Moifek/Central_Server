using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlTrancheVentilation")]
    public partial class StlTrancheVentilation
    {
        public StlTrancheVentilation()
        {
            StlTrancheVentilationItems = new HashSet<StlTrancheVentilationItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgCompanyId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlTrancheVentilations")]
        public virtual CfgCompany CfgCompany { get; set; }
        [InverseProperty(nameof(StlTrancheVentilationItem.StlTrancheVentilation))]
        public virtual ICollection<StlTrancheVentilationItem> StlTrancheVentilationItems { get; set; }
    }
}
