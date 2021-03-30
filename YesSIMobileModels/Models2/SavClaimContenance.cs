using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SavClaimContenance")]
    public partial class SavClaimContenance
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? SavClaimId { get; set; }
        [Column("stkContenanceId")]
        public Guid? StkContenanceId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(SavClaimId))]
        [InverseProperty("SavClaimContenances")]
        public virtual SavClaim SavClaim { get; set; }
        [ForeignKey(nameof(StkContenanceId))]
        [InverseProperty("SavClaimContenances")]
        public virtual StkContenance StkContenance { get; set; }
    }
}
