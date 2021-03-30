using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StrEntityView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "text")]
        public string DescriptionLong { get; set; }
        [StringLength(255)]
        public string ActDefaultAccountCode { get; set; }
        public bool? IsCredit { get; set; }
        public bool? WithWorkFlow { get; set; }
        public bool? IsCharge { get; set; }
        public bool? IsProduct { get; set; }
        [Column(TypeName = "text")]
        public string QueryString { get; set; }
        public string ReportsQueryString { get; set; }
        public bool? IsAccountable { get; set; }
        [StringLength(255)]
        public string ObjectPath { get; set; }
        [StringLength(255)]
        public string ObjectForm { get; set; }
        public Guid? AdmModuleId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid? StlCategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        public Guid? ActAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountDescription { get; set; }
        [StringLength(514)]
        public string ActAccountLabel { get; set; }
        public Guid? StrTierFieldId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrTierFieldCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrTierFieldDescription { get; set; }
        [StringLength(255)]
        public string BoolField001Label { get; set; }
        [StringLength(255)]
        public string BoolField002Label { get; set; }
        [StringLength(255)]
        public string BoolField003Label { get; set; }
        [StringLength(255)]
        public string BoolField004Label { get; set; }
        [StringLength(255)]
        public string BoolField005Label { get; set; }
        [StringLength(255)]
        public string BoolField006Label { get; set; }
        [StringLength(255)]
        public string BoolField007Label { get; set; }
        [StringLength(255)]
        public string BoolField008Label { get; set; }
        [StringLength(255)]
        public string BoolField009Label { get; set; }
        [StringLength(255)]
        public string BoolField010Label { get; set; }
        [StringLength(255)]
        public string BoolField011Label { get; set; }
        [StringLength(255)]
        public string BoolField012Label { get; set; }
        [StringLength(255)]
        public string BoolField013Label { get; set; }
        [StringLength(255)]
        public string BoolField014Label { get; set; }
        [StringLength(255)]
        public string BoolField015Label { get; set; }
        [StringLength(255)]
        public string BoolField016Label { get; set; }
        [StringLength(255)]
        public string BoolField017Label { get; set; }
        [StringLength(255)]
        public string BoolField018Label { get; set; }
        [StringLength(255)]
        public string BoolField019Label { get; set; }
        [StringLength(255)]
        public string BoolField020Label { get; set; }
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
