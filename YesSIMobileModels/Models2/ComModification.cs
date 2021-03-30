using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComModification")]
    public partial class ComModification
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DemandDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TechnicalValidationDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Cost { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CustomerValidationDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommercialAmount { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? ComFolderId { get; set; }
        [Column("CommercialAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? CommercialAmountHt { get; set; }

        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ComModifications")]
        public virtual ComFolder ComFolder { get; set; }
    }
}
