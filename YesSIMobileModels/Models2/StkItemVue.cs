using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkItemVue")]
    public partial class StkItemVue
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? StkVueId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("StkItemVues")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkVueId))]
        [InverseProperty("StkItemVues")]
        public virtual StkVue StkVue { get; set; }
    }
}
