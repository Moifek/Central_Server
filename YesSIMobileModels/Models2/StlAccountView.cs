using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlAccountView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? StlSettlementKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlSettlementKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlSettlementKindDescription { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? CfgBankId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgBankCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgBankDescription { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
        [StringLength(50)]
        public string CurrencyCode { get; set; }
        [StringLength(255)]
        public string CurrencyLabel { get; set; }
        [StringLength(5)]
        public string BankCode { get; set; }
        [StringLength(5)]
        public string AgencyCode { get; set; }
        [StringLength(255)]
        public string AccountNumber { get; set; }
        [StringLength(5)]
        public string AccountKey { get; set; }
        [Required]
        [Column("RIB")]
        [StringLength(273)]
        public string Rib { get; set; }
        [StringLength(50)]
        public string Iban { get; set; }
        [StringLength(50)]
        public string CodeBic { get; set; }
        [StringLength(255)]
        public string AgencyAddress { get; set; }
        [StringLength(255)]
        public string CompanyAddress { get; set; }
        [StringLength(255)]
        public string CreationPlace { get; set; }
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
