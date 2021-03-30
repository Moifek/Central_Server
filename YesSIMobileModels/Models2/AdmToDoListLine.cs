using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmToDoListLine")]
    public partial class AdmToDoListLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? AdmToDoListLineStateId { get; set; }
        public Guid? AdmToDoListId { get; set; }
        public Guid? EntityId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmToDoListId))]
        [InverseProperty("AdmToDoListLines")]
        public virtual AdmToDoList AdmToDoList { get; set; }
        [ForeignKey(nameof(AdmToDoListLineStateId))]
        [InverseProperty("AdmToDoListLines")]
        public virtual AdmToDoListLineState AdmToDoListLineState { get; set; }
    }
}
