using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyDocumentStatusHistory")]
    public partial class BuyDocumentStatusHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? BuyDocumentStatusId { get; set; }
        public Guid? BuyDocumentId { get; set; }
        public Guid? AdmUserId { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column("buyDocumentWorkFlowId")]
        public Guid? BuyDocumentWorkFlowId { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("BuyDocumentStatusHistories")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("BuyDocumentStatusHistories")]
        public virtual BuyDocument BuyDocument { get; set; }
        [ForeignKey(nameof(BuyDocumentStatusId))]
        [InverseProperty("BuyDocumentStatusHistories")]
        public virtual BuyDocumentStatus BuyDocumentStatus { get; set; }
    }
}
