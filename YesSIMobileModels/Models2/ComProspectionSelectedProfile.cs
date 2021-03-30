using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComProspectionSelectedProfile")]
    public partial class ComProspectionSelectedProfile
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComProspectionId { get; set; }
        public Guid? ComProspectionProfileId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? PrmRequestOfferId { get; set; }

        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("ComProspectionSelectedProfiles")]
        public virtual ComProspection ComProspection { get; set; }
        [ForeignKey(nameof(ComProspectionProfileId))]
        [InverseProperty("ComProspectionSelectedProfiles")]
        public virtual ComProspectionProfile ComProspectionProfile { get; set; }
        [ForeignKey(nameof(PrmRequestOfferId))]
        [InverseProperty("ComProspectionSelectedProfiles")]
        public virtual PrmRequestOffer PrmRequestOffer { get; set; }
    }
}
