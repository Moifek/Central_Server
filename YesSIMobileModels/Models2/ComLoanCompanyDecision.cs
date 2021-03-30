using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComLoanCompanyDecision")]
    public partial class ComLoanCompanyDecision
    {
        public ComLoanCompanyDecision()
        {
            ComFolders = new HashSet<ComFolder>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column("sorting")]
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

        [InverseProperty(nameof(ComFolder.ComLoanCompanyDecision))]
        public virtual ICollection<ComFolder> ComFolders { get; set; }
    }
}
