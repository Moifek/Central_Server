using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlSlipView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
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
        public Guid? StlDepositId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDepositCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDepositDescription { get; set; }
        public Guid? CfgTierEmissionId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierEmissionCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierEmissionDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EmissionDate { get; set; }
        public Guid? CfgTierTransmissionId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierTransmissionCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierTransmissionDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransmissionDate { get; set; }
        public Guid? StlAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlAccountCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlAccountDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceptionDate { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? LinesAmount { get; set; }
        public int? LinesCount { get; set; }
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
