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
        [Required(ErrorMessage = "The Expire Date is Required")]
        public DateTime? ExpireDate { get; set; }
        [Required(ErrorMessage = "The Server Url is Required")]
        public string ServerUrl { get; set; }
        public Guid? AdmUserId { get; set; }
        [Required(ErrorMessage = "The User Number is Required")]
        public int? UserNumber { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "The Description (Company Name) is Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "The UserName is Required")]
        public string AdmUserEmail { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("AdmLicenses")]
        public virtual AdmUser AdmUser { get; set; }
    }
}
