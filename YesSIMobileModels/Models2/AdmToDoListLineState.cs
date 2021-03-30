using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmToDoListLineState")]
    public partial class AdmToDoListLineState
    {
        public AdmToDoListLineState()
        {
            AdmToDoListLines = new HashSet<AdmToDoListLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsDone { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Color { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(AdmToDoListLine.AdmToDoListLineState))]
        public virtual ICollection<AdmToDoListLine> AdmToDoListLines { get; set; }
    }
}
