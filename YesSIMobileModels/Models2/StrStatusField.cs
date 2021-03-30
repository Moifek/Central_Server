using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrStatusField")]
    public partial class StrStatusField
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrFieldId { get; set; }
        public Guid? StrStatusId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StrFieldId))]
        [InverseProperty("StrStatusFields")]
        public virtual StrField StrField { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("StrStatusFields")]
        public virtual StrStatus StrStatus { get; set; }
    }
}
