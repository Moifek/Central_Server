using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComTierTransfertOperationView
    {
        [Column(TypeName = "datetime")]
        public DateTime? ClaimDate { get; set; }
        public Guid ComSaleWithdrawalId { get; set; }
        public Guid? ComSaleWithdrawalProductId { get; set; }
        public Guid? ComSaleWithdrawalClientId { get; set; }
        public Guid? ComSaleWithdrawalCancellationId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TransfertExpenseAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TransfertExpenseAmountAfterDiscount { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Reason { get; set; }
        [StringLength(255)]
        public string SaleNumber { get; set; }
        public Guid? ComSaleId { get; set; }
        [StringLength(255)]
        public string Tier { get; set; }
        public Guid TierId { get; set; }
        public Guid? NewTierId { get; set; }
        [StringLength(255)]
        public string NewTier { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        public Guid? NewStkItemId { get; set; }
        [StringLength(255)]
        public string NewStkItemCode { get; set; }
        [StringLength(534)]
        public string Detail { get; set; }
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
