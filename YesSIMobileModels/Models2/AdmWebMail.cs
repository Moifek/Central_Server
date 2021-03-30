using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    public partial class AdmWebMail
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Object { get; set; }
        public string Body { get; set; }
        public byte[] File { get; set; }
        public string FileName { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
