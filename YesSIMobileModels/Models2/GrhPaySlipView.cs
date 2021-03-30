using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class GrhPaySlipView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public int? DocYear { get; set; }
        public int? DocMonth { get; set; }
        public int? DocQuarter { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        [StringLength(255)]
        public string GrhEmployeeCode { get; set; }
        [StringLength(255)]
        public string GrhEmployeeDescription { get; set; }
        [StringLength(255)]
        public string GrhEmployeeSocialSecurityNumber { get; set; }
        [Column("GrhEmployeeIDNumber")]
        [StringLength(255)]
        public string GrhEmployeeIdnumber { get; set; }
        public Guid? GrhAgreementTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhAgreementTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhAgreementTypeDescription { get; set; }
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
        public Guid? GrhEmployeeKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeKindDescription { get; set; }
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
        public Guid? GrhPaySlipModelKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhPaySlipModelKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhPaySlipModelKindDescription { get; set; }
        public Guid? GrhDepartmentId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhDepartmentCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhDepartmentDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVacationDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VacationDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseWorkedDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkedDaysCharged { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkedDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OverTimeCharged { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? NetToPay { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseSalary { get; set; }
        [Column("IND_PRE", TypeName = "decimal(38, 6)")]
        public decimal? IndPre { get; set; }
        [Column("IND_TRA", TypeName = "decimal(38, 6)")]
        public decimal? IndTra { get; set; }
        [Column("SAL_BRUAI", TypeName = "decimal(38, 6)")]
        public decimal? SalBruai { get; set; }
        [Column("SAL_ABS", TypeName = "decimal(38, 6)")]
        public decimal? SalAbs { get; set; }
        [Column("SAL_HSUP", TypeName = "decimal(38, 6)")]
        public decimal? SalHsup { get; set; }
        [Column("SAL_BRU", TypeName = "decimal(38, 6)")]
        public decimal? SalBru { get; set; }
        [Column("COT_CNSS", TypeName = "decimal(38, 6)")]
        public decimal? CotCnss { get; set; }
        [Column("COT_CNSSP", TypeName = "decimal(38, 6)")]
        public decimal? CotCnssp { get; set; }
        [Column("COT_ACT", TypeName = "decimal(38, 6)")]
        public decimal? CotAct { get; set; }
        [Column("COT_CAVIS", TypeName = "decimal(38, 6)")]
        public decimal? CotCavis { get; set; }
        [Column("COT_CAVISP", TypeName = "decimal(38, 6)")]
        public decimal? CotCavisp { get; set; }
        [Column("SAL_IMPBD", TypeName = "decimal(38, 6)")]
        public decimal? SalImpbd { get; set; }
        [Column("DED_CPR", TypeName = "decimal(38, 6)")]
        public decimal? DedCpr { get; set; }
        [Column("DED_CDF", TypeName = "decimal(38, 6)")]
        public decimal? DedCdf { get; set; }
        [Column("DED_NEN", TypeName = "decimal(38, 6)")]
        public decimal? DedNen { get; set; }
        [Column("DED_NEH", TypeName = "decimal(38, 6)")]
        public decimal? DedNeh { get; set; }
        [Column("SAL_IMP", TypeName = "decimal(38, 6)")]
        public decimal? SalImp { get; set; }
        [Column("TXT_IRPP", TypeName = "decimal(38, 6)")]
        public decimal? TxtIrpp { get; set; }
        [Column("TXT_CSS", TypeName = "decimal(38, 6)")]
        public decimal? TxtCss { get; set; }
        [Column("TXT_TFP", TypeName = "decimal(38, 6)")]
        public decimal? TxtTfp { get; set; }
        [Column("TXT_FOPROLOS", TypeName = "decimal(38, 6)")]
        public decimal? TxtFoprolos { get; set; }
        [Column("SAL_NET", TypeName = "decimal(38, 6)")]
        public decimal? SalNet { get; set; }
        [Column("RET_AVA", TypeName = "decimal(38, 6)")]
        public decimal? RetAva { get; set; }
        [Column("RET_CRE", TypeName = "decimal(38, 6)")]
        public decimal? RetCre { get; set; }
        [Column("RET_DIS", TypeName = "decimal(38, 6)")]
        public decimal? RetDis { get; set; }
        [Column("SAL_NAP", TypeName = "decimal(38, 6)")]
        public decimal? SalNap { get; set; }
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
