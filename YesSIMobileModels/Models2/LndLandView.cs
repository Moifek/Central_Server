using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class LndLandView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusValidityDate { get; set; }
        public Guid? LndCategoryId { get; set; }
        [StringLength(255)]
        public string LndCategoryCode { get; set; }
        [StringLength(255)]
        public string LndCategoryDescription { get; set; }
        public Guid? LndTypeId { get; set; }
        [StringLength(255)]
        public string LndTypeCode { get; set; }
        [StringLength(255)]
        public string LndTypeDescription { get; set; }
        public Guid? LndLevelId { get; set; }
        [StringLength(255)]
        public string LndLevelCode { get; set; }
        [StringLength(255)]
        public string LndLevelDescription { get; set; }
        public Guid? LndVocationId { get; set; }
        [StringLength(255)]
        public string LndVocationCode { get; set; }
        [StringLength(255)]
        public string LndVocationDescription { get; set; }
        public Guid? CfgDelegationId { get; set; }
        [StringLength(255)]
        public string CfgDelegationCode { get; set; }
        [StringLength(255)]
        public string CfgDelegationDescription { get; set; }
        public Guid? CfgDepartmentId { get; set; }
        [StringLength(255)]
        public string CfgDepartmentCode { get; set; }
        [StringLength(255)]
        public string CfgDepartmentDescription { get; set; }
        public Guid? StrStatusId { get; set; }
        public int? StrStatusSorting { get; set; }
        [StringLength(255)]
        public string StrStatusCode { get; set; }
        [StringLength(255)]
        public string StrStatusDescription { get; set; }
        public bool? StrStatusIsReadOnly { get; set; }
        public bool? StrStatusCanDelete { get; set; }
        public Guid? StrStatusTypeId { get; set; }
        public int? StrStatusTypeSorting { get; set; }
        [StringLength(255)]
        public string StrStatusTypeCode { get; set; }
        [StringLength(255)]
        public string StrStatusTypeDescription { get; set; }
        [StringLength(255)]
        public string StrStatusColorName { get; set; }
        public Guid? StrStatusCfgImageId { get; set; }
        [Column(TypeName = "image")]
        public byte[] StrStatusBytes { get; set; }
        public Guid? CfgMiddlemanId { get; set; }
        [StringLength(255)]
        public string CfgMiddlemanCode { get; set; }
        [StringLength(255)]
        public string CfgMiddlemanDescription { get; set; }
        [StringLength(255)]
        public string CfgMiddlemanTierTitleCode { get; set; }
        [StringLength(255)]
        public string CfgMiddlemanTierTitleDescription { get; set; }
        [StringLength(255)]
        public string Adress { get; set; }
        [StringLength(255)]
        public string Owner { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsInArchive { get; set; }
        public bool? IsTransformedToLand { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EquipementsCoef { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EquipementsArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaNet { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Cos { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaCos { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Cuf { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaCuf { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CoefSaleableArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalableArea { get; set; }
        public int? AlinmentStop { get; set; }
        public int? MaxHeight { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProspectionUnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProspectionPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProspectionPriceProposed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RegistryDate { get; set; }
        [StringLength(255)]
        public string RegistryNumber { get; set; }
        [StringLength(255)]
        public string RegistryPlace { get; set; }
        [Column("ImmatriculationCPF")]
        [StringLength(255)]
        public string ImmatriculationCpf { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ImmatriculationDate { get; set; }
        [StringLength(1000)]
        public string Anomalies { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public int? FeasibilityStudyNumber { get; set; }
        public Guid? CfgLawyerId { get; set; }
        [StringLength(255)]
        public string CfgLawyerCode { get; set; }
        [StringLength(255)]
        public string CfgLawyerDescription { get; set; }
        public Guid? AdmCityId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityDescription { get; set; }
        public Guid? AdmCountryId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryDescription { get; set; }
        public Guid? StkOrientationId { get; set; }
        [StringLength(255)]
        public string StkOrientationCode { get; set; }
        [StringLength(255)]
        public string StkOrientationDescription { get; set; }
    }
}
