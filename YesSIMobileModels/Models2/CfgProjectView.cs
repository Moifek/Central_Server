using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class CfgProjectView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingEndDate { get; set; }
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
        [StringLength(255)]
        public string SignatureCity { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [StringLength(255)]
        public string CfgTierTitle { get; set; }
        public Guid? AdmSignatoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgSignatoryTitle { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgSignatoryDescription { get; set; }
        public Guid? CfgTechnicalManagerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTechnicalManagerTitle { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTechnicalManagerDescription { get; set; }
        public Guid? CfgSalesManagerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgSalesManagerTitle { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgSalesManagerDescription { get; set; }
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
