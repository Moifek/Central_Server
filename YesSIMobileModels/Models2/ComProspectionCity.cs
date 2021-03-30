using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComProspectionCity")]
    public partial class ComProspectionCity
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? AdmCityId { get; set; }
        public Guid? ComProspectionId { get; set; }

        [ForeignKey(nameof(AdmCityId))]
        [InverseProperty("ComProspectionCities")]
        public virtual AdmCity AdmCity { get; set; }
        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("ComProspectionCities")]
        public virtual ComProspection ComProspection { get; set; }
    }
}
