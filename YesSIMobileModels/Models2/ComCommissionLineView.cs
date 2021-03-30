using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComCommissionLineView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string CommissionType { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? CommissionAmount { get; set; }
        public Guid? ComCommissionId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? ComFolderStatusId { get; set; }
        public Guid? BuyDocumentId { get; set; }
        [StringLength(255)]
        public string CalculationMethod { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCustomerDescription { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        [StringLength(255)]
        public string Employee { get; set; }
        [StringLength(255)]
        public string StkItemCategoryDescription { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        [StringLength(255)]
        public string StatusDescription { get; set; }
        [StringLength(255)]
        public string DocumentCode { get; set; }
        [Column("amountSettled", TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column("amountToPay", TypeName = "decimal(38, 6)")]
        public decimal? AmountToPay { get; set; }
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
