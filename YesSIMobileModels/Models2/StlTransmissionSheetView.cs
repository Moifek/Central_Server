using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlTransmissionSheetView
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
        public Guid? CfgCompanyFromId { get; set; }
        [StringLength(255)]
        public string CfgCompanyFromCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyFromDescription { get; set; }
        public Guid? StlDepositFromId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDepositFromCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDepositFromDescription { get; set; }
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
        public Guid? CfgCompanyToId { get; set; }
        [StringLength(255)]
        public string CfgCompanyToCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyToDescription { get; set; }
        public Guid? StlDepositToId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDepositToCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDepositToDescription { get; set; }
        public Guid? CfgTierReceptionId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierReceptionCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierReceptionDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceptionDate { get; set; }
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
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? LinesAmount { get; set; }
        public int? LinesCount { get; set; }
    }
}
