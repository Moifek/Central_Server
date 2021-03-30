using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(ParentObjectId), nameof(ObjectId), Name = "_dta_index_AdmWebHistorics_5_1753773305__K13_K4_1_2_3_5_6_7_8_9_10_12_14")]
    [Index(nameof(ObjectId), Name = "_dta_index_AdmWebHistorics_5_1753773305__K4")]
    public partial class AdmWebHistoric
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string UserDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActionDateTime { get; set; }
        public Guid? ObjectId { get; set; }
        public Guid? LockEntityId { get; set; }
        public string Action { get; set; }
        public string ObjectType { get; set; }
        public string ObjectTypeLabel { get; set; }
        public string ObjectLabel { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "text")]
        public string Details { get; set; }
        [StringLength(255)]
        public string ParentObjectType { get; set; }
        public Guid? ParentObjectId { get; set; }
        [StringLength(255)]
        public string SystemVersion { get; set; }
    }
}
