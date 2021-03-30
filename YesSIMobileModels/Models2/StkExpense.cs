using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkExpense")]
    public partial class StkExpense
    {
        public StkExpense()
        {
            BuyDocuments = new HashSet<BuyDocument>();
        }

        [Key]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public bool IsValidated { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? CfgSupplierId { get; set; }
        public Guid? StkExpenseTypeId { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StkExpenseTypeId))]
        [InverseProperty("StkExpenses")]
        public virtual StkExpenseType StkExpenseType { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("StkExpenses")]
        public virtual StkItem StkItem { get; set; }
        [InverseProperty(nameof(BuyDocument.StkExpense))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
    }
}
