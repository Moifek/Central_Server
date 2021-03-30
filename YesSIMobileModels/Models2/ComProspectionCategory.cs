using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComProspectionCategory")]
    public partial class ComProspectionCategory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComProspectionId { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? PrmRequestOfferId { get; set; }

        [ForeignKey(nameof(ComProspectionId))]
        [InverseProperty("ComProspectionCategories")]
        public virtual ComProspection ComProspection { get; set; }
        [ForeignKey(nameof(PrmRequestOfferId))]
        [InverseProperty("ComProspectionCategories")]
        public virtual PrmRequestOffer PrmRequestOffer { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("ComProspectionCategories")]
        public virtual StkItemCategory StkItemCategory { get; set; }
    }
}
