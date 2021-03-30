using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrStatusIntervener")]
    public partial class StrStatusIntervener
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrIntervenerId { get; set; }
        public Guid? StrStatusId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StrIntervenerId))]
        [InverseProperty("StrStatusInterveners")]
        public virtual StrIntervener StrIntervener { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("StrStatusInterveners")]
        public virtual StrStatus StrStatus { get; set; }
    }
}
