using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmCountry")]
    public partial class AdmCountry
    {
        public AdmCountry()
        {
            AdmCities = new HashSet<AdmCity>();
            CfgCompanies = new HashSet<CfgCompany>();
            CfgProjects = new HashSet<CfgProject>();
            CfgTierAdmCountries = new HashSet<CfgTier>();
            CfgTierAdmCountryResidences = new HashSet<CfgTier>();
            CfgTranches = new HashSet<CfgTranche>();
            ComProspections = new HashSet<ComProspection>();
            LndLands = new HashSet<LndLand>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
            StkItems = new HashSet<StkItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column("ISOAlpha3")]
        [StringLength(255)]
        public string Isoalpha3 { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("Description_an")]
        [StringLength(255)]
        public string DescriptionAn { get; set; }
        [Column("ISOName")]
        [StringLength(255)]
        public string Isoname { get; set; }
        [StringLength(255)]
        public string NationCode { get; set; }
        [StringLength(255)]
        public string PhoneCode { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string PhoneFormat { get; set; }
        [StringLength(500)]
        public string WebPhoneFormat { get; set; }

        [InverseProperty(nameof(AdmCity.AdmCountry))]
        public virtual ICollection<AdmCity> AdmCities { get; set; }
        [InverseProperty(nameof(CfgCompany.AdmCountry))]
        public virtual ICollection<CfgCompany> CfgCompanies { get; set; }
        [InverseProperty(nameof(CfgProject.AdmCountry))]
        public virtual ICollection<CfgProject> CfgProjects { get; set; }
        [InverseProperty(nameof(CfgTier.AdmCountry))]
        public virtual ICollection<CfgTier> CfgTierAdmCountries { get; set; }
        [InverseProperty(nameof(CfgTier.AdmCountryResidence))]
        public virtual ICollection<CfgTier> CfgTierAdmCountryResidences { get; set; }
        [InverseProperty(nameof(CfgTranche.AdmCountry))]
        public virtual ICollection<CfgTranche> CfgTranches { get; set; }
        [InverseProperty(nameof(ComProspection.AdmCountry))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(LndLand.AdmCountry))]
        public virtual ICollection<LndLand> LndLands { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.AdmCountry))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
        [InverseProperty(nameof(StkItem.AdmCountry))]
        public virtual ICollection<StkItem> StkItems { get; set; }
    }
}
