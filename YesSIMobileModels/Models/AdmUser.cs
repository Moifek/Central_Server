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
            SysResetPasswordAppRequests = new HashSet<SysResetPasswordAppRequest>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Required]
        public string Code { get; set; }
        public string Pass { get; set; }
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
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public int? LinesPerPage { get; set; }
        public bool? ConfirmDelete { get; set; }
        public int? LockDelay { get; set; }
        public Guid? WebRoleId { get; set; }
        public Guid? WebCultureId { get; set; }
        public Guid? WebAlertDefinitionId { get; set; }
        public bool? Disabled { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        public bool? IsVisibleForChat { get; set; }
        public bool? CanDisapearNotification { get; set; }
        [StringLength(255)]
        public string EmailPassword { get; set; }
        public int? EmailPortNumber { get; set; }
        [Column("EmailSMTPServer")]
        [StringLength(255)]
        public string EmailSmtpserver { get; set; }
        [Column("EmailSSLActive")]
        public bool? EmailSslactive { get; set; }
        [StringLength(255)]
        public string OpenBeeCode { get; set; }
        [StringLength(255)]
        public string OpenBeePass { get; set; }
        public bool? MobileUser { get; set; }

        [InverseProperty(nameof(AdmLicense.AdmUser))]
        public virtual ICollection<AdmLicense> AdmLicenses { get; set; }
        [InverseProperty(nameof(SysResetPasswordAppRequest.User))]
        public virtual ICollection<SysResetPasswordAppRequest> SysResetPasswordAppRequests { get; set; }
    }
}
