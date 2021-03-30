using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SavServiceExpense")]
    public partial class SavServiceExpense
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? SavComplaintCategoryId { get; set; }
        public Guid? SavComplaintTypeId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? CfgProjectId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? StkVocationId { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? StkItemTypeId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ServiceExpenseAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FolderExpenseAmount { get; set; }
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
        public Guid? StlCategoryId { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("PriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? PriceTtc { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("SavServiceExpenses")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgProjectId))]
        [InverseProperty("SavServiceExpenses")]
        public virtual CfgProject CfgProject { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("SavServiceExpenses")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(SavComplaintCategoryId))]
        [InverseProperty("SavServiceExpenses")]
        public virtual SavComplaintCategory SavComplaintCategory { get; set; }
        [ForeignKey(nameof(SavComplaintTypeId))]
        [InverseProperty("SavServiceExpenses")]
        public virtual SavComplaintType SavComplaintType { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("SavServiceExpenses")]
        public virtual StkItemCategory StkItemCategory { get; set; }
        [ForeignKey(nameof(StkItemTypeId))]
        [InverseProperty("SavServiceExpenses")]
        public virtual StkItemType StkItemType { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("SavServiceExpenses")]
        public virtual StkVocation StkVocation { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("SavServiceExpenses")]
        public virtual StlCategory StlCategory { get; set; }
    }
}
