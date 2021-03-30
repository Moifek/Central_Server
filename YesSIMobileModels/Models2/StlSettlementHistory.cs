using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlSettlementHistory")]
    public partial class StlSettlementHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? AdmUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EcheanceDate { get; set; }
        public Guid? StlSettlementId { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(255)]
        public string Reference { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("StlSettlementHistories")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(StlSettlementId))]
        [InverseProperty("StlSettlementHistories")]
        public virtual StlSettlement StlSettlement { get; set; }
        [ForeignKey(nameof(StlSettlementTypeId))]
        [InverseProperty("StlSettlementHistories")]
        public virtual StlSettlementType StlSettlementType { get; set; }
    }
}
