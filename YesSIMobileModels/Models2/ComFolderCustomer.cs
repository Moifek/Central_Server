using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComFolderCustomer")]
    public partial class ComFolderCustomer
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid CfgTierId { get; set; }
        public Guid ComFolderId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PartPercent { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("ComFolderCustomers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComFolderCustomers")]
        public virtual ComFolder ComFolder { get; set; }
    }
}
