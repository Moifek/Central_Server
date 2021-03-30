using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmMailLog")]
    public partial class AdmMailLog
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Priority { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
        public string Error { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OperationDate { get; set; }
    }
}
