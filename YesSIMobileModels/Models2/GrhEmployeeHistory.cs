using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhEmployeeHistory")]
    public partial class GrhEmployeeHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? GrhDepartmentId { get; set; }
        public Guid? GrhEmployeeKindId { get; set; }
        public Guid? GrhAgreementTypeId { get; set; }
        public Guid? GrhEmployeeCategoryId { get; set; }
        public Guid? GrhEchelonId { get; set; }
        public Guid? AdmFamilySituationId { get; set; }
        public Guid? AdmMatrimonialRegimeId { get; set; }
        public Guid? GrhPaySlipModelId { get; set; }
        public int? NbrChildren { get; set; }
        public int? NbrChildrenHandicap { get; set; }
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
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseWorkedDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVacationDaysNumber { get; set; }

        [ForeignKey(nameof(AdmFamilySituationId))]
        [InverseProperty("GrhEmployeeHistories")]
        public virtual AdmFamilySituation AdmFamilySituation { get; set; }
        [ForeignKey(nameof(AdmMatrimonialRegimeId))]
        [InverseProperty("GrhEmployeeHistories")]
        public virtual AdmMatrimonialRegime AdmMatrimonialRegime { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("GrhEmployeeHistories")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(GrhAgreementTypeId))]
        [InverseProperty("GrhEmployeeHistories")]
        public virtual GrhAgreementType GrhAgreementType { get; set; }
        [ForeignKey(nameof(GrhDepartmentId))]
        [InverseProperty("GrhEmployeeHistories")]
        public virtual GrhDepartment GrhDepartment { get; set; }
        [ForeignKey(nameof(GrhEchelonId))]
        [InverseProperty("GrhEmployeeHistories")]
        public virtual GrhEchelon GrhEchelon { get; set; }
        [ForeignKey(nameof(GrhEmployeeId))]
        [InverseProperty(nameof(CfgTier.GrhEmployeeHistories))]
        public virtual CfgTier GrhEmployee { get; set; }
        [ForeignKey(nameof(GrhEmployeeCategoryId))]
        [InverseProperty("GrhEmployeeHistories")]
        public virtual GrhEmployeeCategory GrhEmployeeCategory { get; set; }
        [ForeignKey(nameof(GrhEmployeeKindId))]
        [InverseProperty(nameof(CfgTierKind.GrhEmployeeHistories))]
        public virtual CfgTierKind GrhEmployeeKind { get; set; }
        [ForeignKey(nameof(GrhPaySlipModelId))]
        [InverseProperty("GrhEmployeeHistories")]
        public virtual GrhPaySlipModel GrhPaySlipModel { get; set; }
    }
}
