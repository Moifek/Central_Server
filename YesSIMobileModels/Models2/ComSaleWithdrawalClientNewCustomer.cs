using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSaleWithdrawalClientNewCustomer")]
    public partial class ComSaleWithdrawalClientNewCustomer
    {
        [Key]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PartPercent { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? ComSaleWithdrawalClientId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("ComSaleWithdrawalClientNewCustomers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalClientId))]
        [InverseProperty("ComSaleWithdrawalClientNewCustomers")]
        public virtual ComSaleWithdrawalClient ComSaleWithdrawalClient { get; set; }
    }
}
