using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComProspectionOriginSupport")]
    public partial class ComProspectionOriginSupport
    {
        public ComProspectionOriginSupport()
        {
            ComProspections = new HashSet<ComProspection>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? ComProspectionOriginId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(ComProspectionOriginId))]
        [InverseProperty("ComProspectionOriginSupports")]
        public virtual ComProspectionOrigin ComProspectionOrigin { get; set; }
        [InverseProperty(nameof(ComProspection.ComProspectionOriginSupport))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.ComProspectionOriginSupport))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
    }
}
