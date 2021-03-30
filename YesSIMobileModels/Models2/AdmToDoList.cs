using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmToDoList")]
    public partial class AdmToDoList
    {
        public AdmToDoList()
        {
            AdmToDoListLines = new HashSet<AdmToDoListLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Note { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? AdmUserId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("AdmToDoLists")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("AdmToDoLists")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(AdmToDoListLine.AdmToDoList))]
        public virtual ICollection<AdmToDoListLine> AdmToDoListLines { get; set; }
    }
}
