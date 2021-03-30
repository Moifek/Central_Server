using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyLoanType")]
    public partial class BuyLoanType
    {
        public BuyLoanType()
        {
            BuyLoans = new HashSet<BuyLoan>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsSupplierFinancing { get; set; }
        public bool? IsLeasing { get; set; }
        public Guid? BaseStlCategoryId { get; set; }
        public Guid? InterestStlCategoryId { get; set; }
        public Guid? CommissionStlCategoryId { get; set; }

        [ForeignKey(nameof(BaseStlCategoryId))]
        [InverseProperty(nameof(StlCategory.BuyLoanTypeBaseStlCategories))]
        public virtual StlCategory BaseStlCategory { get; set; }
        [ForeignKey(nameof(CommissionStlCategoryId))]
        [InverseProperty(nameof(StlCategory.BuyLoanTypeCommissionStlCategories))]
        public virtual StlCategory CommissionStlCategory { get; set; }
        [ForeignKey(nameof(InterestStlCategoryId))]
        [InverseProperty(nameof(StlCategory.BuyLoanTypeInterestStlCategories))]
        public virtual StlCategory InterestStlCategory { get; set; }
        [InverseProperty(nameof(BuyLoan.BuyLoanType))]
        public virtual ICollection<BuyLoan> BuyLoans { get; set; }
    }
}
