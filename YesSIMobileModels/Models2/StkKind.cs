using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkKind")]
    public partial class StkKind
    {
        public StkKind()
        {
            StkItemCategories = new HashSet<StkItemCategory>();
            StkItemTypes = new HashSet<StkItemType>();
            StkItems = new HashSet<StkItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(StkItemCategory.StkKind))]
        public virtual ICollection<StkItemCategory> StkItemCategories { get; set; }
        [InverseProperty(nameof(StkItemType.StkKind))]
        public virtual ICollection<StkItemType> StkItemTypes { get; set; }
        [InverseProperty(nameof(StkItem.StkKind))]
        public virtual ICollection<StkItem> StkItems { get; set; }
    }
}
