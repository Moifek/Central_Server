using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileAPI.Models
{
    [Table("SysBlackListToken")]
    public partial class SysBlackListToken
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Required]
        public string Token { get; set; }
    }
}
