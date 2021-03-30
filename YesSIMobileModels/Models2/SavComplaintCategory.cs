using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SavComplaintCategory")]
    public partial class SavComplaintCategory
    {
        public SavComplaintCategory()
        {
            SavClaims = new HashSet<SavClaim>();
            SavComplaintTypes = new HashSet<SavComplaintType>();
            SavServiceExpenses = new HashSet<SavServiceExpense>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsForService { get; set; }

        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("SavComplaintCategories")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(SavClaim.SavComplaintCategory))]
        public virtual ICollection<SavClaim> SavClaims { get; set; }
        [InverseProperty(nameof(SavComplaintType.SavComplaintCategory))]
        public virtual ICollection<SavComplaintType> SavComplaintTypes { get; set; }
        [InverseProperty(nameof(SavServiceExpense.SavComplaintCategory))]
        public virtual ICollection<SavServiceExpense> SavServiceExpenses { get; set; }
    }
}
