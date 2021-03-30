using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkPresentationTypeContenance")]
    public partial class StkPresentationTypeContenance
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StkPresentationTypeId { get; set; }
        public Guid? StkContenanceId { get; set; }
        public int? ItemsNumber { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string Option1 { get; set; }
        public bool? IsWithOption1 { get; set; }
        public int? QuantityOption1 { get; set; }
        [StringLength(255)]
        public string Option2 { get; set; }
        public bool? IsWithOption2 { get; set; }
        public int? QuantityOption2 { get; set; }
        [StringLength(255)]
        public string Option3 { get; set; }
        public bool? IsWithOption3 { get; set; }
        public int? QuantityOption3 { get; set; }

        [ForeignKey(nameof(StkContenanceId))]
        [InverseProperty("StkPresentationTypeContenances")]
        public virtual StkContenance StkContenance { get; set; }
        [ForeignKey(nameof(StkPresentationTypeId))]
        [InverseProperty("StkPresentationTypeContenances")]
        public virtual StkPresentationType StkPresentationType { get; set; }
    }
}
