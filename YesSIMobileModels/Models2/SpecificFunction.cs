using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SpecificFunction")]
    public partial class SpecificFunction
    {
        public SpecificFunction()
        {
            StkFsbaseUnits = new HashSet<StkFsbaseUnit>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsTotal { get; set; }
        public bool? SaleAbleArea { get; set; }
        public bool? CoveredArea { get; set; }
        public bool? AreaNet { get; set; }
        public bool? AreaBrut { get; set; }
        public bool? AreaCos { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(StkFsbaseUnit.SpecificFunction))]
        public virtual ICollection<StkFsbaseUnit> StkFsbaseUnits { get; set; }
    }
}
