using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlInternalTransferView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
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
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        [StringLength(1281)]
        public string FromCompanyAddress { get; set; }
        [StringLength(255)]
        public string FromCompanyPhone { get; set; }
        [StringLength(255)]
        public string FromCompanyFax { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeCode { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeDescription { get; set; }
        [StringLength(255)]
        public string Reference { get; set; }
        [StringLength(255)]
        public string FromCode { get; set; }
        public Guid? StlAccountId { get; set; }
        public Guid? FromAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlAccountCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlAccountDescription { get; set; }
        [Required]
        [Column("FromAccountRIB")]
        [StringLength(270)]
        public string FromAccountRib { get; set; }
        [Required]
        [StringLength(255)]
        public string FromAccountAgencyAddress { get; set; }
        [Required]
        [StringLength(255)]
        public string FromAccountCompanyAddress { get; set; }
        [Required]
        [StringLength(255)]
        public string FromAccountCreationPlace { get; set; }
        [Required]
        [StringLength(255)]
        public string FromBankCode { get; set; }
        [Required]
        [StringLength(255)]
        public string FromBankDescription { get; set; }
        public Guid? CfgCompanyToId { get; set; }
        [StringLength(255)]
        public string CfgCompanyToCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyToDescription { get; set; }
        [StringLength(1281)]
        public string ToCompanyAddress { get; set; }
        [StringLength(255)]
        public string ToCompanyPhone { get; set; }
        [StringLength(255)]
        public string ToCompanyFax { get; set; }
        public Guid? StlSettlementTypeToId { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeToCode { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeToDescription { get; set; }
        [StringLength(255)]
        public string ReferenceTo { get; set; }
        [StringLength(255)]
        public string ToCode { get; set; }
        public Guid? StlAccountToId { get; set; }
        public Guid? ToAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlAccountToCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlAccountToDescription { get; set; }
        [Required]
        [Column("ToAccountRIB")]
        [StringLength(270)]
        public string ToAccountRib { get; set; }
        [Required]
        [StringLength(255)]
        public string ToAccountAgencyAddress { get; set; }
        [Required]
        [StringLength(255)]
        public string ToAccountCompanyAddress { get; set; }
        [Required]
        [StringLength(255)]
        public string ToAccountCreationPlace { get; set; }
        [Required]
        [StringLength(255)]
        public string ToBankCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ToBankDescription { get; set; }
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
