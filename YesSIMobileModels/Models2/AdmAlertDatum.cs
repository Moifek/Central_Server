using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(Active), nameof(RelatedKey), nameof(AlertDate), Name = "_dta_index_AdmAlertData_7_816721962__K10_K8_K7")]
    public partial class AdmAlertDatum
    {
        [Key]
        public Guid Pkey { get; set; }
        [StringLength(256)]
        public string Label { get; set; }
        [StringLength(256)]
        public string Code { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Message { get; set; }
        [StringLength(256)]
        public string Groupping { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AlertDate { get; set; }
        public Guid? RelatedKey { get; set; }
        [StringLength(256)]
        public string RightKey { get; set; }
        public bool? Active { get; set; }
    }
}
