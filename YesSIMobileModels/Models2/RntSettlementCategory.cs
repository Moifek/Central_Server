using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntSettlementCategory")]
    public partial class RntSettlementCategory
    {
        public RntSettlementCategory()
        {
            RntDocuments = new HashSet<RntDocument>();
            RntFolderClauseLines = new HashSet<RntFolderClauseLine>();
            SynFolderClauseLines = new HashSet<SynFolderClauseLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsCredit { get; set; }
        public bool? IsRentCaution { get; set; }
        public bool? IsRentAmount { get; set; }
        public bool? IsRentExpense { get; set; }
        public bool? IsRentResiliation { get; set; }
        public bool? IsSyndic { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? CanGenerateDocument { get; set; }
        public bool? WithFiscalStamp { get; set; }
        [StringLength(500)]
        public string ReportDescription { get; set; }
        public bool? IsWithReversment { get; set; }

        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("RntSettlementCategories")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(RntDocument.RntSettlementCategory))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
        [InverseProperty(nameof(RntFolderClauseLine.RntSettlementCategory))]
        public virtual ICollection<RntFolderClauseLine> RntFolderClauseLines { get; set; }
        [InverseProperty(nameof(SynFolderClauseLine.RntSettlementCategory))]
        public virtual ICollection<SynFolderClauseLine> SynFolderClauseLines { get; set; }
    }
}
