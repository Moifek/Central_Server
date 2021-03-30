using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    public partial class AdmWebSequence
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int SeqType { get; set; }
        public int? SeqYear { get; set; }
        public int SeqYearCharNumber { get; set; }
        public int SeqNumber { get; set; }
        public int SeqNumberCharNumber { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
