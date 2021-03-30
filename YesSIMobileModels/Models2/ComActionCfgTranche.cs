using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComActionCfgTranche")]
    public partial class ComActionCfgTranche
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComActionId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("ComActionCfgTranches")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(ComActionId))]
        [InverseProperty("ComActionCfgTranches")]
        public virtual ComAction ComAction { get; set; }
    }
}
