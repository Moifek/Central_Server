using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models
{
    [Table("AdmUser")]
    public partial class AdmUser
    {
        public AdmUser()
        {
            AdmLicenses = new HashSet<AdmLicense>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Pass { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? AdmRoleId { get; set; }

        [ForeignKey(nameof(AdmRoleId))]
        [InverseProperty("AdmUsers")]
        public virtual AdmRole AdmRole { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("AdmUsers")]
        public virtual CfgTier CfgTier { get; set; }
        [InverseProperty(nameof(AdmLicense.AdmUser))]
        public virtual ICollection<AdmLicense> AdmLicenses { get; set; }
    }
}
