using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class CfgCompanyView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        [StringLength(255)]
        public string FiscalNumber { get; set; }
        [StringLength(255)]
        public string CommercialRegister { get; set; }
        [StringLength(255)]
        public string LegalForm { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Capital { get; set; }
        public int? TotalSharing { get; set; }
        public int? SharingNumber { get; set; }
        [StringLength(255)]
        public string Cnss { get; set; }
        [StringLength(255)]
        public string Patent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LiquidationDate { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? HomePart { get; set; }
        public Guid? CfgGroupShareholderId { get; set; }
        [StringLength(255)]
        public string CfgGroupShareholderDescription { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Address3 { get; set; }
        [StringLength(255)]
        public string ZipCode { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        public Guid? AdmCountryId { get; set; }
        [StringLength(255)]
        public string AdmCountryDescription { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Mobile { get; set; }
        [StringLength(255)]
        public string Fax { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string WebSite { get; set; }
        [Required]
        [StringLength(1535)]
        public string MainAddress { get; set; }
        [Required]
        [StringLength(1535)]
        public string MainAddress1 { get; set; }
        [StringLength(255)]
        public string SignatureCity { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [StringLength(255)]
        public string CfgTierTitle { get; set; }
        [StringLength(255)]
        public string CfgTierKindDescription { get; set; }
        public Guid? AdmSignatoryId { get; set; }
        [StringLength(255)]
        public string CfgSignatoryDescription { get; set; }
        [StringLength(255)]
        public string CfgSignatoryTitle { get; set; }
        [StringLength(255)]
        public string CfgSignatoryKindDescription { get; set; }
        public Guid? CfgTechnicalManagerId { get; set; }
        [StringLength(255)]
        public string CfgTechnicalManagerDescription { get; set; }
        [StringLength(255)]
        public string CfgTechnicalManagerTitle { get; set; }
        [StringLength(255)]
        public string CfgTechnicalManagerKindyDescription { get; set; }
        public Guid? CfgSalesManagerId { get; set; }
        [StringLength(255)]
        public string CfgSalesManagerDescription { get; set; }
        [StringLength(255)]
        public string CfgSalesManagerTitle { get; set; }
        [StringLength(255)]
        public string CfgSalesManagerKindyDescription { get; set; }
        [Column("ICE")]
        [StringLength(255)]
        public string Ice { get; set; }
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
