using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("FSPrevision")]
    public partial class Fsprevision
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Ratio { get; set; }
        [StringLength(255)]
        public string Note { get; set; }
        public Guid? FeasibilityStudyId { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? GlobalRatio { get; set; }
        public Guid? UnityId { get; set; }
        public Guid? ParentId { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        public bool? Undivided { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApplyOnDate { get; set; }
        public bool? IsForProject { get; set; }
        public Guid? PrjMarketPrevisionModelId { get; set; }

        [ForeignKey(nameof(FeasibilityStudyId))]
        [InverseProperty(nameof(StkFeasibilityStudy.Fsprevisions))]
        public virtual StkFeasibilityStudy FeasibilityStudy { get; set; }
        [ForeignKey(nameof(PrjMarketPrevisionModelId))]
        [InverseProperty("Fsprevisions")]
        public virtual PrjMarketPrevisionModel PrjMarketPrevisionModel { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("Fsprevisions")]
        public virtual StlCategory StlCategory { get; set; }
    }
}
