using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlPaymentAuthorizationLine")]
    public partial class StlPaymentAuthorizationLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public Guid? ComDocumentId { get; set; }
        public Guid? StlPaymentAuthorizationId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? RntDocumentId { get; set; }
        public Guid? StlDocumentId { get; set; }

        [ForeignKey(nameof(ComDocumentId))]
        [InverseProperty("StlPaymentAuthorizationLines")]
        public virtual ComDocument ComDocument { get; set; }
        [ForeignKey(nameof(RntDocumentId))]
        [InverseProperty("StlPaymentAuthorizationLines")]
        public virtual RntDocument RntDocument { get; set; }
        [ForeignKey(nameof(StlDocumentId))]
        [InverseProperty("StlPaymentAuthorizationLines")]
        public virtual StlDocument StlDocument { get; set; }
        [ForeignKey(nameof(StlPaymentAuthorizationId))]
        [InverseProperty("StlPaymentAuthorizationLines")]
        public virtual StlPaymentAuthorization StlPaymentAuthorization { get; set; }
    }
}
