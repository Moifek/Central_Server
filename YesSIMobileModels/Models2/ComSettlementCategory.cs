using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSettlementCategory")]
    public partial class ComSettlementCategory
    {
        public ComSettlementCategory()
        {
            CfgTrancheSettlementCategories = new HashSet<CfgTrancheSettlementCategory>();
            ComDocumentPaymentMethods = new HashSet<ComDocumentPaymentMethod>();
            ComDocuments = new HashSet<ComDocument>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsCredit { get; set; }
        public bool? IsSaleExpense { get; set; }
        public Guid? StlCategoryId { get; set; }
        public bool? IsSaleAdvance { get; set; }
        public bool? IsSaleCredit { get; set; }
        public bool? IsSaleAutoFinancment { get; set; }
        public bool? IsSaleModification { get; set; }
        public bool? IsSaleResiliation { get; set; }
        public bool? IsSalePenality { get; set; }
        public Guid? StkVocationId { get; set; }
        public bool? IsRentCaution { get; set; }
        public bool? IsRentAmount { get; set; }
        public bool? IsRentExpense { get; set; }
        public bool? IsRentResiliation { get; set; }
        public bool? IsSyndic { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsConfermentBasedDate { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? VatRatio { get; set; }
        public bool? ExcludeFromPrice { get; set; }
        public bool? IsSaleBeforeReservation { get; set; }
        public bool? IsInAgrementContext { get; set; }
        public bool? CanUpdateDocuments { get; set; }
        public bool? IsForOthers { get; set; }
        public bool? IsAlwaysPayed { get; set; }
        [StringLength(500)]
        public string ReportDescription { get; set; }
        public bool? IsSaleIncome { get; set; }
        public bool? IsWithPenalty { get; set; }

        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("ComSettlementCategories")]
        public virtual StkVocation StkVocation { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("ComSettlementCategories")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(CfgTrancheSettlementCategory.ComSettlementCategory))]
        public virtual ICollection<CfgTrancheSettlementCategory> CfgTrancheSettlementCategories { get; set; }
        [InverseProperty(nameof(ComDocumentPaymentMethod.ComSettlementCategory))]
        public virtual ICollection<ComDocumentPaymentMethod> ComDocumentPaymentMethods { get; set; }
        [InverseProperty(nameof(ComDocument.ComSettlementCategory))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
    }
}
