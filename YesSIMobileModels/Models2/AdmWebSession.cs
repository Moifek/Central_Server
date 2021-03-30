using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(UserId), Name = "IX_UserId")]
    public partial class AdmWebSession
    {
        public AdmWebSession()
        {
            AdmWebLockEntities = new HashSet<AdmWebLockEntity>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string WebSession { get; set; }
        public Guid? UserId { get; set; }
        public string UserDesc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("IPAddress")]
        public string Ipaddress { get; set; }
        public int State { get; set; }
        [StringLength(255)]
        public string SystemVersion { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(AdmUser2.AdmWebSessions))]
        public virtual AdmUser2 User { get; set; }
        [InverseProperty(nameof(AdmWebLockEntity.Session))]
        public virtual ICollection<AdmWebLockEntity> AdmWebLockEntities { get; set; }
    }
}
