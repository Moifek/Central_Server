using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComProspectionProfile")]
    public partial class ComProspectionProfile
    {
        public ComProspectionProfile()
        {
            ComProspectionSelectedProfiles = new HashSet<ComProspectionSelectedProfile>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? ComProspectionProfileCategoryId { get; set; }
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

        [ForeignKey(nameof(ComProspectionProfileCategoryId))]
        [InverseProperty("ComProspectionProfiles")]
        public virtual ComProspectionProfileCategory ComProspectionProfileCategory { get; set; }
        [InverseProperty(nameof(ComProspectionSelectedProfile.ComProspectionProfile))]
        public virtual ICollection<ComProspectionSelectedProfile> ComProspectionSelectedProfiles { get; set; }
    }
}
