using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class GrhPaySlipModelView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValidityDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "text")]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseMonthNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseWorkedDaysNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVacationDaysNumber { get; set; }
        public Guid? GrhPaySlipModelKindId { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhPaySlipModelKindCode { get; set; }
        [Required]
        [StringLength(255)]
        public string GrhPaySlipModelKindDescription { get; set; }
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
