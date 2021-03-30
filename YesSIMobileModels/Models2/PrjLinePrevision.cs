using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjLinePrevision")]
    public partial class PrjLinePrevision
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Achievement { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountNet { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PrevAchievement { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PrevAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UserPrevAchievement { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UserPrevAmount { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("documentReference")]
        [StringLength(255)]
        public string DocumentReference { get; set; }
        [Column("docType")]
        [StringLength(255)]
        public string DocType { get; set; }
        public Guid PrjPrevisionVersionId { get; set; }
        [Column("prjMarketId")]
        public Guid? PrjMarketId { get; set; }

        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjLinePrevisions")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(PrjPrevisionVersionId))]
        [InverseProperty("PrjLinePrevisions")]
        public virtual PrjPrevisionVersion PrjPrevisionVersion { get; set; }
    }
}
