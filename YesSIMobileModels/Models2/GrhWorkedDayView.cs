using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class GrhWorkedDayView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeEnd { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
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
        [StringLength(255)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column("TotalHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [StringLength(255)]
        public string Unity1 { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity1 { get; set; }
        [Column("UnitPriceHT1", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt1 { get; set; }
        [Column("TotalHT1", TypeName = "decimal(38, 6)")]
        public decimal? TotalHt1 { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio1 { get; set; }
        [StringLength(255)]
        public string StlInvoiceProformaCode { get; set; }
        [StringLength(255)]
        public string StlInvoiceCode { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgEmployeeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgEmployeeDescription { get; set; }
        public Guid? CfgTierKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgEmployeeKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgEmployeeKindDescription { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCustomerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCustomerDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? GrhWorkedDayTypeId { get; set; }
        [StringLength(255)]
        public string GrhWorkedDayTypeCode { get; set; }
        [StringLength(255)]
        public string GrhWorkedDayTypeDescription { get; set; }
        [StringLength(255)]
        public string GrhWorkedDayTypeGroupDescription { get; set; }
        public Guid? PrjProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? CfgTrancheLevelingDefinitionId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheLevelingDefinitionCode { get; set; }
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
