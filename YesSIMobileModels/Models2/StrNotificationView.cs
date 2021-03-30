using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StrNotificationView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? AdmReportId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmReportCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmReportDescription { get; set; }
        public bool? GroupedMail { get; set; }
        public bool? AfterAdd { get; set; }
        public bool? AfterUpDate { get; set; }
        public bool? AfterDelete { get; set; }
        [StringLength(1000)]
        public string Subject { get; set; }
        [Column(TypeName = "text")]
        public string Text { get; set; }
        [Column(TypeName = "text")]
        public string QueryText { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
