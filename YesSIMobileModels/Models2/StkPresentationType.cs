using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkPresentationType")]
    [Index(nameof(Pkey), nameof(Description), Name = "_dta_index_StkPresentationType_5_1789249429__K1_K3")]
    public partial class StkPresentationType
    {
        public StkPresentationType()
        {
            StkItems = new HashSet<StkItem>();
            StkPresentationTypeContenances = new HashSet<StkPresentationTypeContenance>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        public Guid? StkHierarchyId { get; set; }

        [ForeignKey(nameof(StkHierarchyId))]
        [InverseProperty(nameof(CfgTranche.StkPresentationTypes))]
        public virtual CfgTranche StkHierarchy { get; set; }
        [InverseProperty(nameof(StkItem.StkPresentationType))]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(StkPresentationTypeContenance.StkPresentationType))]
        public virtual ICollection<StkPresentationTypeContenance> StkPresentationTypeContenances { get; set; }
    }
}
