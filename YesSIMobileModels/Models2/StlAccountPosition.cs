using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlAccountPosition")]
    public partial class StlAccountPosition
    {
        public StlAccountPosition()
        {
            StlSettlements = new HashSet<StlSettlement>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime PositionDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal Position { get; set; }
        public Guid StlAccountId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PositionCalculated { get; set; }
        public Guid? StrEntityId { get; set; }

        [ForeignKey(nameof(StlAccountId))]
        [InverseProperty("StlAccountPositions")]
        public virtual StlAccount StlAccount { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StlAccountPositions")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(StlSettlement.StlAccountPosition))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
    }
}
