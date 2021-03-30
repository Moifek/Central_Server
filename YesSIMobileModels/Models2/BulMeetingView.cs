using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BulMeetingView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MeetingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextDate { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? BulMeetingTypeId { get; set; }
        [StringLength(25)]
        public string BulMeetingTypeCode { get; set; }
        [StringLength(25)]
        public string BulMeetingTypeDescription { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        [StringLength(255)]
        public string CfgEmployeeCode { get; set; }
        [StringLength(255)]
        public string CfgEmployeeDescription { get; set; }
        [StringLength(500)]
        public string Note { get; set; }
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
