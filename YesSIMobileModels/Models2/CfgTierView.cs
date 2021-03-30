using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class CfgTierView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
        [StringLength(43)]
        public string Phone { get; set; }
        [StringLength(43)]
        public string Phone1 { get; set; }
        [StringLength(43)]
        public string Phone2 { get; set; }
        [StringLength(43)]
        public string Fax { get; set; }
        [StringLength(43)]
        public string Mobile { get; set; }
        [Required]
        [Column("EMail")]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string WebSite { get; set; }
        [Required]
        [StringLength(255)]
        public string SocialReason { get; set; }
        [Required]
        [StringLength(1000)]
        public string Notes { get; set; }
        [Required]
        [StringLength(255)]
        public string BankAgency { get; set; }
        [Required]
        [StringLength(255)]
        public string Rib { get; set; }
        [Required]
        [StringLength(255)]
        public string Iban { get; set; }
        [Required]
        [StringLength(255)]
        public string FiscalCode { get; set; }
        [Required]
        [StringLength(255)]
        public string FiscalRegistry { get; set; }
        [Required]
        [StringLength(255)]
        public string FiscalDouane { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [StringLength(255)]
        public string BirthPlace { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Asset { get; set; }
        [Required]
        [StringLength(100)]
        public string Quality { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RsRatio { get; set; }
        [Column("VATRatio", TypeName = "decimal(26, 6)")]
        public decimal? Vatratio { get; set; }
        public string CfgTierContactDescription { get; set; }
        public Guid? AdmIdentityDocumentTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmIdentityDocumentTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmIdentityDocumentTypeDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string IdentityDocumentType { get; set; }
        [Required]
        [Column("IDNumber")]
        [StringLength(255)]
        public string Idnumber { get; set; }
        [Column("IDDate", TypeName = "datetime")]
        public DateTime? Iddate { get; set; }
        [Required]
        [Column("IDPlace")]
        [StringLength(255)]
        public string Idplace { get; set; }
        [Column("IDValidateDate", TypeName = "datetime")]
        public DateTime? IdvalidateDate { get; set; }
        [Required]
        [Column("IDValidatePlace")]
        [StringLength(255)]
        public string IdvalidatePlace { get; set; }
        [Column("IDDescription")]
        [StringLength(514)]
        public string Iddescription { get; set; }
        public bool? IsProspect { get; set; }
        public Guid? CfgBankId { get; set; }
        public Guid? CfgCommercialId { get; set; }
        public Guid? CfgContactId { get; set; }
        public Guid? AdmTierTitleId { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmTierTitleCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmTierTitleDescription { get; set; }
        public Guid? AdmCityId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string City { get; set; }
        public Guid? AdmCountryId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string Country { get; set; }
        [StringLength(1535)]
        public string Address { get; set; }
        [Required]
        [StringLength(255)]
        public string Address1 { get; set; }
        [Required]
        [StringLength(255)]
        public string Address2 { get; set; }
        [Required]
        [StringLength(255)]
        public string Address3 { get; set; }
        [Required]
        [StringLength(255)]
        public string ZipCode { get; set; }
        [Required]
        [StringLength(255)]
        public string FatherName { get; set; }
        [Required]
        [StringLength(255)]
        public string MotherName { get; set; }
        [Required]
        [StringLength(255)]
        public string Employer { get; set; }
        public int? Antiquity { get; set; }
        public Guid? AdmCountryResidenceId { get; set; }
        public Guid? AdmLiabilityId { get; set; }
        public int Age { get; set; }
        [Required]
        [StringLength(255)]
        public string CountryResidence { get; set; }
        public Guid? AdmSexTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string Sex { get; set; }
        public Guid? AdmFamilySituationId { get; set; }
        [Required]
        [StringLength(255)]
        public string FamilySituation { get; set; }
        public Guid? AdmNationalityId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmNationalityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmNationalityDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string Nationality { get; set; }
        [Required]
        [StringLength(255)]
        public string TierNationality { get; set; }
        public Guid? AdmProfessionId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmProfessionCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmProfessionDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string Profession { get; set; }
        [Required]
        [StringLength(255)]
        public string TierProfession { get; set; }
        public Guid? AdmSalaryId { get; set; }
        [Required]
        [StringLength(255)]
        public string Salary { get; set; }
        [Required]
        [StringLength(255)]
        public string Bank { get; set; }
        [Required]
        [StringLength(255)]
        public string Commercial { get; set; }
        public Guid? CfgTierTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierTypeDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string Type { get; set; }
        [StringLength(255)]
        public string TierType { get; set; }
        public Guid? ActAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountDescription { get; set; }
        [StringLength(511)]
        public string AccountLabel { get; set; }
        [Required]
        [StringLength(255)]
        public string CodeCountable { get; set; }
        [Required]
        [StringLength(255)]
        public string CodeCountableCollective { get; set; }
        public Guid? ActJournalId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActJournalCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActJournalDescription { get; set; }
        public Guid? CfgTierKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierKindDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string Kind { get; set; }
        [StringLength(255)]
        public string TierKind { get; set; }
        public Guid? AdmSocialFormId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmSocialFormCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmSocialFormDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string SocialForm { get; set; }
        [Required]
        [StringLength(255)]
        public string SocialFormCode { get; set; }
        public bool? SocialFormIsPerson { get; set; }
        [Required]
        [StringLength(255)]
        public string Liability { get; set; }
        public Guid? AdmResidenceTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string ResidenceType { get; set; }
        public Guid? AdmMatrimonialRegimeId { get; set; }
        [Required]
        [StringLength(255)]
        public string MatrimonialRegime { get; set; }
        [Required]
        [StringLength(255)]
        public string TierBank { get; set; }
        [Required]
        [StringLength(255)]
        public string TierEmployee { get; set; }
        [StringLength(255)]
        public string TierSalary { get; set; }
        [StringLength(255)]
        public string TierCountry { get; set; }
        [StringLength(255)]
        public string TierCountryResidence { get; set; }
        public bool? IsExtern { get; set; }
        public bool? IsVisibleInList { get; set; }
        public bool? IsFundReader { get; set; }
        [Column("ICE")]
        [StringLength(255)]
        public string Ice { get; set; }
        public bool? IsRntCustomer { get; set; }
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
