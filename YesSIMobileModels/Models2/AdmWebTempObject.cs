using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    public partial class AdmWebTempObject
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid UserId { get; set; }
        public Guid ObjectId { get; set; }
        public string ObjectNameSpace { get; set; }
        [Column(TypeName = "text")]
        public string BinaryObject { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
