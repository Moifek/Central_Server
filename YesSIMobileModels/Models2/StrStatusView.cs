using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StrStatusView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool? CanDelete { get; set; }
        public Guid? CfgImageId { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        [Column("int")]
        public int? Int { get; set; }
        public Guid? StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? StrStatusTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrStatusTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrStatusTypeDescription { get; set; }
        public bool? BoolField001 { get; set; }
        public bool? BoolField002 { get; set; }
        public bool? BoolField003 { get; set; }
        public bool? BoolField004 { get; set; }
        public bool? BoolField005 { get; set; }
        public bool? BoolField006 { get; set; }
        public bool? BoolField007 { get; set; }
        public bool? BoolField008 { get; set; }
        public bool? BoolField009 { get; set; }
        public bool? BoolField010 { get; set; }
        public bool? BoolField011 { get; set; }
        public bool? BoolField012 { get; set; }
        public bool? BoolField013 { get; set; }
        public bool? BoolField014 { get; set; }
        public bool? BoolField015 { get; set; }
        public bool? BoolField016 { get; set; }
        public bool? BoolField017 { get; set; }
        public bool? BoolField018 { get; set; }
        public bool? BoolField019 { get; set; }
        public bool? BoolField020 { get; set; }
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
