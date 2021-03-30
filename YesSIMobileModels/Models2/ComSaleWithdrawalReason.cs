using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSaleWithdrawalReason")]
    public partial class ComSaleWithdrawalReason
    {
        public ComSaleWithdrawalReason()
        {
            ComSaleWithdrawalCancellations = new HashSet<ComSaleWithdrawalCancellation>();
            ComSaleWithdrawalClients = new HashSet<ComSaleWithdrawalClient>();
            ComSaleWithdrawalProducts = new HashSet<ComSaleWithdrawalProduct>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(ComSaleWithdrawalCancellation.ComSaleWithdrawalReason))]
        public virtual ICollection<ComSaleWithdrawalCancellation> ComSaleWithdrawalCancellations { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClient.ComSaleWithdrawalReason))]
        public virtual ICollection<ComSaleWithdrawalClient> ComSaleWithdrawalClients { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProduct.ComSaleWithdrawalReason))]
        public virtual ICollection<ComSaleWithdrawalProduct> ComSaleWithdrawalProducts { get; set; }
    }
}
