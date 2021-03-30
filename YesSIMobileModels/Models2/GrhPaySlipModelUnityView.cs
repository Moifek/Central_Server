using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class GrhPaySlipModelUnityView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(512)]
        public string SearchDescription { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsCredit { get; set; }
        public bool? IsSalary { get; set; }
        public bool? IsIndemnity { get; set; }
        public bool? IsContribuation { get; set; }
        public bool? IsDeduction { get; set; }
        public bool? IsTaxe { get; set; }
        public bool? IsRetention { get; set; }
        public bool? IsForCompany { get; set; }
        public bool? IsPrintable { get; set; }
        public bool? IsAddedToSalaryBase { get; set; }
        public bool? IsAddedToSalaryWorked { get; set; }
        public bool? IsAddedToSalaryGross { get; set; }
        public bool? IsAddedToSalaryContributory { get; set; }
        [Column("IsAddedToSalaryTaxableBD")]
        public bool? IsAddedToSalaryTaxableBd { get; set; }
        public bool? IsAddedToSalaryTaxable { get; set; }
        public bool? IsAddedToSalaryNet { get; set; }
        public bool? IsAddedToSalaryToPay { get; set; }
        public Guid? StlCategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
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
