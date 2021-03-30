using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComActionMessageCategory")]
    public partial class ComActionMessageCategory
    {
        public ComActionMessageCategory()
        {
            ComActionMessageSubCategories = new HashSet<ComActionMessageSubCategory>();
            ComActionMessages = new HashSet<ComActionMessage>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(ComActionMessageSubCategory.ComActionMessageCategory))]
        public virtual ICollection<ComActionMessageSubCategory> ComActionMessageSubCategories { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComActionMessageCategory))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
    }
}
