using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SavOrigin")]
    public partial class SavOrigin
    {
        public SavOrigin()
        {
            SavClaimGroups = new HashSet<SavClaimGroup>();
            SavServices = new HashSet<SavService>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
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

        [InverseProperty(nameof(SavClaimGroup.SavOrigin))]
        public virtual ICollection<SavClaimGroup> SavClaimGroups { get; set; }
        [InverseProperty(nameof(SavService.SavOrigin))]
        public virtual ICollection<SavService> SavServices { get; set; }
    }
}
