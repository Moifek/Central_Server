using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileAPI.Models
{
    public partial class SysResetPasswordAppRequest
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        public Guid ServerUrl { get; set; }
        public Guid UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ResetRequestDateTime { get; set; }
        public bool Valid { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(AdmUser.SysResetPasswordAppRequests))]
        public virtual AdmUser User { get; set; }
    }
}
