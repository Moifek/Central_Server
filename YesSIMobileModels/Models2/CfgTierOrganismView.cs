using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class CfgTierOrganismView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? AdmCountryId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryDescription { get; set; }
        public Guid? CfgTierKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierKindDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string FiscalCode { get; set; }
        [Required]
        [StringLength(255)]
        public string FiscalRegistry { get; set; }
        [Required]
        [Column("ICE")]
        [StringLength(255)]
        public string Ice { get; set; }
        public Guid? ActAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountDescription { get; set; }
        [StringLength(511)]
        public string AccountLabel { get; set; }
        public Guid? ActJournalId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActJournalCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActJournalDescription { get; set; }
        [Required]
        [StringLength(10)]
        public string MobileIndicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Mobile { get; set; }
        [StringLength(43)]
        public string MobileFormated { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneIndicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone { get; set; }
        [StringLength(43)]
        public string PhoneFormated { get; set; }
        [Required]
        [StringLength(10)]
        public string Phone1Indicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone1 { get; set; }
        [StringLength(43)]
        public string Phone1Formated { get; set; }
        [Required]
        [StringLength(10)]
        public string Phone2Indicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone2 { get; set; }
        [StringLength(43)]
        public string Phone2Formated { get; set; }
        [Required]
        [StringLength(10)]
        public string FaxIndicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Fax { get; set; }
        [StringLength(43)]
        public string FaxFormated { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        [Required]
        [StringLength(255)]
        public string Address2 { get; set; }
        [Required]
        [StringLength(255)]
        public string Address3 { get; set; }
        [Required]
        [StringLength(255)]
        public string ZipCode { get; set; }
        public Guid? AdmCityId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityDescription { get; set; }
        [StringLength(1535)]
        public string AddressFormated { get; set; }
        [Required]
        [Column("EMail")]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string WebSite { get; set; }
        public string CfgTierContactDescription { get; set; }
        [Required]
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
