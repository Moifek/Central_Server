using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgTierContact")]
    public partial class CfgTierContact
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? CfgContactId { get; set; }
        public Guid? CfgRelationTypeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgContactId))]
        [InverseProperty("CfgTierContactCfgContacts")]
        public virtual CfgTier CfgContact { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("CfgTierContactCfgTiers")]
        public virtual CfgTier CfgTier { get; set; }
    }
}
