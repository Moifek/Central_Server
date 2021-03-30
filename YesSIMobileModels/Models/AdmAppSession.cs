using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models
{
    [Table("AdmAppSession")]
    public partial class AdmAppSession
    {
        [Key]
        [Column("PKEY")]
        public Guid Pkey { get; set; }
        [Column("UserID")]
        public Guid UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        [Column("IP")]
        [StringLength(50)]
        public string Ip { get; set; }
        [Column("JWToken")]
        public string Jwtoken { get; set; }
        public bool? State { get; set; }
        [Column("MAC")]
        public string Mac { get; set; }
        [StringLength(50)]
        public string AppVersion { get; set; }
    }
}
