using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlTransmissionSheetLine")]
    public partial class StlTransmissionSheetLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StlTransmissionSheetId { get; set; }
        public Guid? StlSettlementId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StlSettlementId))]
        [InverseProperty("StlTransmissionSheetLines")]
        public virtual StlSettlement StlSettlement { get; set; }
        [ForeignKey(nameof(StlTransmissionSheetId))]
        [InverseProperty("StlTransmissionSheetLines")]
        public virtual StlTransmissionSheet StlTransmissionSheet { get; set; }
    }
}
