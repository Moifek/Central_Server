using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlPaymentAuthorizationView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? AdmModuleId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? StlSettlementId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlSettlementCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlSettlementDescription { get; set; }
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
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public bool? IsCredit { get; set; }
        public string Notes { get; set; }
        public string RelationDescription { get; set; }
        public string RelationItemCode { get; set; }
        public string RelationItemDescription { get; set; }
        public string CfgTrancheDescription { get; set; }
        public string CfgProjectCode { get; set; }
        public string CfgProjectDescription { get; set; }
        public string RelationCode { get; set; }
        public int? AffectCount { get; set; }
        public Guid? StlRecoveryFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlRecoveryFolderCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlRecoveryFolderDescription { get; set; }
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
