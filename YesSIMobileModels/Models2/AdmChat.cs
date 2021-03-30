using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmChat")]
    public partial class AdmChat
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? FromUserId { get; set; }
        public Guid? ToUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SentDate { get; set; }
        [StringLength(1000)]
        public string Message { get; set; }
        public bool? IsRead { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(FromUserId))]
        [InverseProperty(nameof(AdmUser2.AdmChatFromUsers))]
        public virtual AdmUser2 FromUser { get; set; }
        [ForeignKey(nameof(ToUserId))]
        [InverseProperty(nameof(AdmUser2.AdmChatToUsers))]
        public virtual AdmUser2 ToUser { get; set; }
    }
}
