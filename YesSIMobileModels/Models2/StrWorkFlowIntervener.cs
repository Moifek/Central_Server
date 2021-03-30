using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrWorkFlowIntervener")]
    public partial class StrWorkFlowIntervener
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrIntervenerId { get; set; }
        public Guid? StrWorkFlowId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? WithPassword { get; set; }

        [ForeignKey(nameof(StrIntervenerId))]
        [InverseProperty("StrWorkFlowInterveners")]
        public virtual StrIntervener StrIntervener { get; set; }
        [ForeignKey(nameof(StrWorkFlowId))]
        [InverseProperty("StrWorkFlowInterveners")]
        public virtual StrWorkFlow StrWorkFlow { get; set; }
    }
}
