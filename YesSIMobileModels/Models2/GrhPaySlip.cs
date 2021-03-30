using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhPaySlip")]
    public partial class GrhPaySlip
    {
        public GrhPaySlip()
        {
            GrhPaySlipLines = new HashSet<GrhPaySlipLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseWorkedDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVacationDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseSalary { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkedDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? NetToPay { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        [StringLength(255)]
        public string GrhEmployeeCode { get; set; }
        [StringLength(255)]
        public string GrhEmployeeDescription { get; set; }
        [StringLength(255)]
        public string GrhEmployeeSocialSecurityNumber { get; set; }
        public Guid? GrhEmployeeKindId { get; set; }
        public Guid? GrhPaySlipModelId { get; set; }
        public Guid? AdmFamilySituationId { get; set; }
        public Guid? GrhAgreementTypeId { get; set; }
        public Guid? GrhPaySlipModelKindId { get; set; }
        public Guid? GrhEmployeeCategoryId { get; set; }
        public Guid? GrhEchelonId { get; set; }
        public int? NbrChildren { get; set; }
        public int? NbrChildrenHandicap { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VacationDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkedDaysCharged { get; set; }
        [Column("GrhEmployeeIDNumber")]
        [StringLength(255)]
        public string GrhEmployeeIdnumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OverTimeCharged { get; set; }

        [ForeignKey(nameof(AdmFamilySituationId))]
        [InverseProperty("GrhPaySlips")]
        public virtual AdmFamilySituation AdmFamilySituation { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("GrhPaySlips")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(GrhAgreementTypeId))]
        [InverseProperty("GrhPaySlips")]
        public virtual GrhAgreementType GrhAgreementType { get; set; }
        [ForeignKey(nameof(GrhEchelonId))]
        [InverseProperty("GrhPaySlips")]
        public virtual GrhEchelon GrhEchelon { get; set; }
        [ForeignKey(nameof(GrhEmployeeId))]
        [InverseProperty(nameof(CfgTier.GrhPaySlips))]
        public virtual CfgTier GrhEmployee { get; set; }
        [ForeignKey(nameof(GrhEmployeeCategoryId))]
        [InverseProperty("GrhPaySlips")]
        public virtual GrhEmployeeCategory GrhEmployeeCategory { get; set; }
        [ForeignKey(nameof(GrhEmployeeKindId))]
        [InverseProperty(nameof(CfgTierKind.GrhPaySlips))]
        public virtual CfgTierKind GrhEmployeeKind { get; set; }
        [ForeignKey(nameof(GrhPaySlipModelId))]
        [InverseProperty("GrhPaySlips")]
        public virtual GrhPaySlipModel GrhPaySlipModel { get; set; }
        [ForeignKey(nameof(GrhPaySlipModelKindId))]
        [InverseProperty("GrhPaySlips")]
        public virtual GrhPaySlipModelKind GrhPaySlipModelKind { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("GrhPaySlips")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(GrhPaySlipLine.GrhPaySlip))]
        public virtual ICollection<GrhPaySlipLine> GrhPaySlipLines { get; set; }
    }
}
