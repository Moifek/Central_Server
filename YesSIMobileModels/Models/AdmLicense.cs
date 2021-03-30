using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models
{
    [Table("AdmLicense")]
    public partial class AdmLicense
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateActivated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpireDate { get; set; }
        public string ServerUrl { get; set; }
        public Guid? AdmUserId { get; set; }
        public int? UserNumber { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Required]
        public string AdmUserEmail { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("AdmLicenses")]
        public virtual AdmUser AdmUser { get; set; }
    }
}
