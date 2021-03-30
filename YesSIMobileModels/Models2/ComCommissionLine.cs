using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComCommissionLine")]
    public partial class ComCommissionLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? ComCommissionId { get; set; }
        [StringLength(255)]
        public string CommissionType { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? CommissionAmount { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComFolderStatusId { get; set; }
        public Guid? BuyDocumentId { get; set; }
        [StringLength(255)]
        public string CalculationMethod { get; set; }

        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("ComCommissionLines")]
        public virtual BuyDocument BuyDocument { get; set; }
        [ForeignKey(nameof(CfgEmployeeId))]
        [InverseProperty(nameof(CfgTier.ComCommissionLines))]
        public virtual CfgTier CfgEmployee { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("ComCommissionLines")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(ComCommissionId))]
        [InverseProperty("ComCommissionLines")]
        public virtual ComCommission ComCommission { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComCommissionLines")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(ComFolderStatusId))]
        [InverseProperty("ComCommissionLines")]
        public virtual ComFolderStatus ComFolderStatus { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComCommissionLines")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("ComCommissionLines")]
        public virtual StkItemCategory StkItemCategory { get; set; }
    }
}
