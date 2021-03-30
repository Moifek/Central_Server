using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class GrhEmployeeView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgTierTypeId { get; set; }
        [Required]
        [StringLength(36)]
        public string StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public Guid? AdmTierTitleId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmTierTitleCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmTierTitleDescription { get; set; }
        public Guid? AdmSexTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmSexTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmSexTypeDescription { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string FatherName { get; set; }
        [StringLength(255)]
        public string MotherName { get; set; }
        public Guid? GrhDepartmentId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhDepartmentCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhDepartmentDescription { get; set; }
        public Guid? CfgTierKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierKindDescription { get; set; }
        public Guid? GrhAgreementTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhAgreementTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhAgreementTypeDescription { get; set; }
        public Guid? GrhEmployeeCategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeCategoryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeCategoryDescription { get; set; }
        public Guid? GrhEchelonId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEchelonCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEchelonDescription { get; set; }
        public Guid? GrhPaySlipModelId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhPaySlipModelCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhPaySlipModelDescription { get; set; }
        public Guid? CfgCommercialId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCommercialCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCommercialDescription { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string SocialReason { get; set; }
        public Guid? AdmCountryId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryDescription { get; set; }
        public Guid? AdmCountryResidenceId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryResidenceCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryResidenceDescription { get; set; }
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
        public string AddressMain { get; set; }
        public Guid? AdmNationalityId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmNationalityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmNationalityDescription { get; set; }
        public Guid? AdmResidenceTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmResidenceTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmResidenceTypeDescription { get; set; }
        [Required]
        [StringLength(10)]
        public string MobileIndicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneIndicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone { get; set; }
        [Required]
        [StringLength(10)]
        public string Phone1Indicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone1 { get; set; }
        [Required]
        [StringLength(10)]
        public string Phone2Indicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone2 { get; set; }
        [Required]
        [StringLength(10)]
        public string FaxIndicatif { get; set; }
        [Required]
        [StringLength(30)]
        public string Fax { get; set; }
        [Required]
        [Column("EMail")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        [Required]
        [StringLength(255)]
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public Guid? AdmIdentityDocumentTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmIdentityDocumentTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmIdentityDocumentTypeDescription { get; set; }
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
        [Required]
        [Column("IDDescription")]
        [StringLength(514)]
        public string Iddescription { get; set; }
        public Guid? AdmFamilySituationId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmFamilySituationCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmFamilySituationDescription { get; set; }
        public bool AdmFamilySituationIsHouseHolder { get; set; }
        public int NbrChildren { get; set; }
        public int NbrChildrenHandicap { get; set; }
        public Guid? AdmMatrimonialRegimeId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmMatrimonialRegimeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmMatrimonialRegimeDescription { get; set; }
        public Guid? AdmRankId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmRankCode { get; set; }
        public int AdmRank { get; set; }
        [Required]
        [StringLength(100)]
        public string Quality { get; set; }
        [Required]
        [StringLength(255)]
        public string SocialSecurityNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HireDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FireDate { get; set; }
        public Guid? AdmLiabilityId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmLiabilityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmLiabilityDescription { get; set; }
        public Guid? CfgBankId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgBankCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgBankDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string BankAgency { get; set; }
        [Required]
        [StringLength(255)]
        public string Rib { get; set; }
        [Required]
        [StringLength(255)]
        public string Iban { get; set; }
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
        public bool IsExtern { get; set; }
        public bool IsVisibleInList { get; set; }
        [Required]
        [StringLength(1000)]
        public string Notes { get; set; }
        public string CfgTierContactDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalaryBase { get; set; }
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
