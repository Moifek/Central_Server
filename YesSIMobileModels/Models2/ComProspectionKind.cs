using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [JsonObject(MemberSerialization.OptIn)]
    [Table("ComProspectionKind")]
    public partial class ComProspectionKind
    {
        public ComProspectionKind()
        {
            ComProspections = new HashSet<ComProspection>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
        }

        [Key]
        [JsonProperty]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string Code { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsWithProjectMandatory { get; set; }
        public int? AlertDelay { get; set; }
        public Guid? ComActionMessageSubCategoryId { get; set; }

        [ForeignKey(nameof(ComActionMessageSubCategoryId))]
        [InverseProperty("ComProspectionKinds")]
        public virtual ComActionMessageSubCategory ComActionMessageSubCategory { get; set; }
        [InverseProperty(nameof(ComProspection.ComProspectionKind))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.ComProspectionKind))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
    }
}
