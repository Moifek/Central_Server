using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComProspectionType")]
    public partial class ComProspectionType
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComProspectionId { get; set; }
        public Guid? StkItemTypeId { get; set; }
        public Guid? PrmRequestOfferId { get; set; }

        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("ComProspectionTypes")]
        public virtual ComProspection ComProspection { get; set; }
        [ForeignKey(nameof(PrmRequestOfferId))]
        [InverseProperty("ComProspectionTypes")]
        public virtual PrmRequestOffer PrmRequestOffer { get; set; }
        [ForeignKey(nameof(StkItemTypeId))]
        [InverseProperty("ComProspectionTypes")]
        public virtual StkItemType StkItemType { get; set; }
    }
}
