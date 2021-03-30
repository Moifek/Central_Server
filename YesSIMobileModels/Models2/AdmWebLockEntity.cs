using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(SessionId), Name = "IX_SessionId")]
    public partial class AdmWebLockEntity
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LockDate { get; set; }
        public Guid SessionId { get; set; }
        public Guid DataObjectId { get; set; }
        public int State { get; set; }

        [ForeignKey(nameof(SessionId))]
        [InverseProperty(nameof(AdmWebSession.AdmWebLockEntities))]
        public virtual AdmWebSession Session { get; set; }
    }
}
