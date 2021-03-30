using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SavComplaintType")]
    public partial class SavComplaintType
    {
        public SavComplaintType()
        {
            SavClaims = new HashSet<SavClaim>();
            SavServiceExpenses = new HashSet<SavServiceExpense>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? SavComplaintCategoryId { get; set; }
        public int? ResolutionDelay { get; set; }
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

        [ForeignKey(nameof(SavComplaintCategoryId))]
        [InverseProperty("SavComplaintTypes")]
        public virtual SavComplaintCategory SavComplaintCategory { get; set; }
        [InverseProperty(nameof(SavClaim.SavComplaintType))]
        public virtual ICollection<SavClaim> SavClaims { get; set; }
        [InverseProperty(nameof(SavServiceExpense.SavComplaintType))]
        public virtual ICollection<SavServiceExpense> SavServiceExpenses { get; set; }
    }
}
