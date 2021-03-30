using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class GrhEmployeeHistoryView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? GrhDepartmentId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhDepartmentCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhDepartmentDescription { get; set; }
        public Guid? GrhEmployeeKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhEmployeeKindDescription { get; set; }
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
        public Guid? AdmFamilySituationId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmFamilySituationCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmFamilySituationDescription { get; set; }
        public bool AdmFamilySituationIsHouseHolder { get; set; }
        public Guid? AdmMatrimonialRegimeId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmMatrimonialRegimeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmMatrimonialRegimeDescription { get; set; }
        public Guid? GrhPaySlipModelId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhPaySlipModelCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhPaySlipModelDescription { get; set; }
        public int? NbrChildren { get; set; }
        public int? NbrChildrenHandicap { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseWorkedDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVacationDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalaryBase { get; set; }
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
