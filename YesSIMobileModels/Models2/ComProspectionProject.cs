using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComProspectionProject")]
    [Index(nameof(ComProspectionId), Name = "_dta_index_ComProspectionProject_5_1767677345__K2_4")]
    public partial class ComProspectionProject
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComProspectionId { get; set; }
        public Guid? StkHierarchyId { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("ComProspectionProjects")]
        public virtual ComProspection ComProspection { get; set; }
        [ForeignKey(nameof(StkHierarchyId))]
        [InverseProperty(nameof(CfgTranche.ComProspectionProjects))]
        public virtual CfgTranche StkHierarchy { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComProspectionProjects")]
        public virtual StkItem StkItem { get; set; }
    }
}
