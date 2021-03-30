using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlSlipLine")]
    public partial class StlSlipLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StlSettlementId { get; set; }
        public Guid? StlSlipId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StlSettlementId))]
        [InverseProperty("StlSlipLines")]
        public virtual StlSettlement StlSettlement { get; set; }
        [ForeignKey(nameof(StlSlipId))]
        [InverseProperty("StlSlipLines")]
        public virtual StlSlip StlSlip { get; set; }
    }
}
