using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketDocumentToAttach")]
    public partial class PrjMarketDocumentToAttach
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? PrjMarketId { get; set; }
        public Guid? AdmAttachedFileTypeId { get; set; }
        public Guid? PrjMarketWorkFlowId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmAttachedFileTypeId))]
        [InverseProperty("PrjMarketDocumentToAttaches")]
        public virtual AdmAttachedFileType AdmAttachedFileType { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketDocumentToAttaches")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(PrjMarketWorkFlowId))]
        [InverseProperty("PrjMarketDocumentToAttaches")]
        public virtual PrjMarketWorkFlow PrjMarketWorkFlow { get; set; }
    }
}
