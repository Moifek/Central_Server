using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhWorkedDay")]
    public partial class GrhWorkedDay
    {
        [Key]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        public Guid? CfgCustomerId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? GrhWorkedDayTypeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity1 { get; set; }
        [Column("UnitPriceHT1", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt1 { get; set; }
        [StringLength(255)]
        public string StlInvoiceCode { get; set; }
        [StringLength(255)]
        public string StlInvoiceProformaCode { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? CfgTrancheLevelingDefinitionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeEnd { get; set; }
        [StringLength(255)]
        public string Unity1 { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio1 { get; set; }
        public Guid? StrStatusId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("GrhWorkedDays")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgCustomerId))]
        [InverseProperty(nameof(CfgTier.GrhWorkedDayCfgCustomers))]
        public virtual CfgTier CfgCustomer { get; set; }
        [ForeignKey(nameof(CfgEmployeeId))]
        [InverseProperty(nameof(CfgTier.GrhWorkedDayCfgEmployees))]
        public virtual CfgTier CfgEmployee { get; set; }
        [ForeignKey(nameof(CfgTrancheLevelingDefinitionId))]
        [InverseProperty("GrhWorkedDays")]
        public virtual CfgTrancheLevelingDefinition CfgTrancheLevelingDefinition { get; set; }
        [ForeignKey(nameof(GrhWorkedDayTypeId))]
        [InverseProperty("GrhWorkedDays")]
        public virtual GrhWorkedDayType GrhWorkedDayType { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("GrhWorkedDays")]
        public virtual PrjProject PrjProject { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("GrhWorkedDays")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("GrhWorkedDays")]
        public virtual StrStatus StrStatus { get; set; }
    }
}
