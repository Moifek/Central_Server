using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyDocumentWorkFlowDocumentToAttach")]
    public partial class BuyDocumentWorkFlowDocumentToAttach
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? BuyDocumentWorkFlowId { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? WithTitle { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? AdmAttachedFileTypeId { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        public bool? ForFirstWorkingOut { get; set; }
        public bool? ForIntermediateWorkingOut { get; set; }
        public bool? ForFinalWorkingOut { get; set; }

        [ForeignKey(nameof(AdmAttachedFileTypeId))]
        [InverseProperty("BuyDocumentWorkFlowDocumentToAttaches")]
        public virtual AdmAttachedFileType AdmAttachedFileType { get; set; }
        [ForeignKey(nameof(BuyDocumentWorkFlowId))]
        [InverseProperty("BuyDocumentWorkFlowDocumentToAttaches")]
        public virtual BuyDocumentWorkFlow BuyDocumentWorkFlow { get; set; }
        [ForeignKey(nameof(PrjMarketTypeId))]
        [InverseProperty("BuyDocumentWorkFlowDocumentToAttaches")]
        public virtual PrjMarketType PrjMarketType { get; set; }
    }
}
