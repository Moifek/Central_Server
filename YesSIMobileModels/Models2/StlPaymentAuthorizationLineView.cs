using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlPaymentAuthorizationLineView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StlPaymentAuthorizationId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Required]
        [StringLength(1001)]
        public string CategoryDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string TrancheDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string ProjectDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string ItemDescription { get; set; }
        [Required]
        [StringLength(1512)]
        public string Notes { get; set; }
        public Guid? ObjectId { get; set; }
        public Guid StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        public Guid? DocumentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
    }
}
