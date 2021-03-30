using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkContenance")]
    public partial class StkContenance
    {
        public StkContenance()
        {
            SavClaimContenances = new HashSet<SavClaimContenance>();
            StkItemContenances = new HashSet<StkItemContenance>();
            StkPresentationTypeContenances = new HashSet<StkPresentationTypeContenance>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
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
        public bool? IsOption1WithQuantity { get; set; }
        [StringLength(255)]
        public string Option2 { get; set; }
        public bool? IsOption2WithQuantity { get; set; }
        [StringLength(255)]
        public string Option3 { get; set; }
        public bool? IsOption3WithQuantity { get; set; }

        [InverseProperty(nameof(SavClaimContenance.StkContenance))]
        public virtual ICollection<SavClaimContenance> SavClaimContenances { get; set; }
        [InverseProperty(nameof(StkItemContenance.StkContenance))]
        public virtual ICollection<StkItemContenance> StkItemContenances { get; set; }
        [InverseProperty(nameof(StkPresentationTypeContenance.StkContenance))]
        public virtual ICollection<StkPresentationTypeContenance> StkPresentationTypeContenances { get; set; }
    }
}
