using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuySelectionSupplier")]
    public partial class BuySelectionSupplier
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string OfficeOrderRef { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SelectionLetterSendDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderAcquisitionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderDepositDate { get; set; }
        public bool? IsRejected { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? BuySelectionId { get; set; }
        public Guid? CfgTierId { get; set; }

        [ForeignKey(nameof(BuySelectionId))]
        [InverseProperty("BuySelectionSuppliers")]
        public virtual BuySelection BuySelection { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("BuySelectionSuppliers")]
        public virtual CfgTier CfgTier { get; set; }
    }
}
