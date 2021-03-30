using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlAcountDepositView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(500)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public Guid? AdmUserId { get; set; }
        public Guid? GrhEmployeeId { get; set; }
        [StringLength(255)]
        public string GrhEmployeeCode { get; set; }
        [StringLength(255)]
        public string GrhEmployeeDescription { get; set; }
        public Guid? GrhEmployeeClosingId { get; set; }
        [StringLength(255)]
        public string GrhEmployeeClosingCode { get; set; }
        [StringLength(255)]
        public string GrhEmployeeClosingDescription { get; set; }
        public Guid? StlDepositId { get; set; }
        [StringLength(255)]
        public string StlDepositCode { get; set; }
        [StringLength(255)]
        public string StlDepositDescription { get; set; }
        public Guid? StlDepositToId { get; set; }
        [StringLength(255)]
        public string StlDepositToCode { get; set; }
        [StringLength(255)]
        public string StlDepositToDescription { get; set; }
        public Guid? StlAccountToId { get; set; }
        [StringLength(255)]
        public string StlAccountToCode { get; set; }
        [StringLength(255)]
        public string StlAccountToDescription { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountOpening { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
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
