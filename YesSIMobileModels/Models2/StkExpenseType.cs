using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkExpenseType")]
    public partial class StkExpenseType
    {
        public StkExpenseType()
        {
            StkExpenses = new HashSet<StkExpense>();
        }

        [Key]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? PrjMarketTypeId { get; set; }

        [ForeignKey(nameof(PrjMarketTypeId))]
        [InverseProperty("StkExpenseTypes")]
        public virtual PrjMarketType PrjMarketType { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StkExpenseTypes")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(StkExpense.StkExpenseType))]
        public virtual ICollection<StkExpense> StkExpenses { get; set; }
    }
}
