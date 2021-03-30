using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActAccountType")]
    public partial class ActAccountType
    {
        public ActAccountType()
        {
            ActAccounts = new HashSet<ActAccount>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPassive { get; set; }
        public bool? IsProduct { get; set; }
        public bool? IsCharge { get; set; }

        [InverseProperty(nameof(ActAccount.ActAccountType))]
        public virtual ICollection<ActAccount> ActAccounts { get; set; }
    }
}
