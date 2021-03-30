using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmCity")]
    public partial class AdmCity
    {
        public AdmCity()
        {
            CfgTiers = new HashSet<CfgTier>();
            ComProspectionCities = new HashSet<ComProspectionCity>();
            LndLands = new HashSet<LndLand>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
            StkItems = new HashSet<StkItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? AdmCountryId { get; set; }
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

        [ForeignKey(nameof(AdmCountryId))]
        [InverseProperty("AdmCities")]
        public virtual AdmCountry AdmCountry { get; set; }
        [InverseProperty(nameof(CfgTier.AdmCity))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
        [InverseProperty(nameof(ComProspectionCity.AdmCity))]
        public virtual ICollection<ComProspectionCity> ComProspectionCities { get; set; }
        [InverseProperty(nameof(LndLand.AdmCity))]
        public virtual ICollection<LndLand> LndLands { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.AdmCity))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
        [InverseProperty(nameof(StkItem.AdmCity))]
        public virtual ICollection<StkItem> StkItems { get; set; }
    }
}
