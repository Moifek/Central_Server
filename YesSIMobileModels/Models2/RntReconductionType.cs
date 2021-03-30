using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntReconductionType")]
    public partial class RntReconductionType
    {
        public RntReconductionType()
        {
            RntFolders = new HashSet<RntFolder>();
            SynFolders = new HashSet<SynFolder>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("isAuto")]
        public bool? IsAuto { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(RntFolder.RntReconductionType))]
        public virtual ICollection<RntFolder> RntFolders { get; set; }
        [InverseProperty(nameof(SynFolder.RntReconductionType))]
        public virtual ICollection<SynFolder> SynFolders { get; set; }
    }
}
