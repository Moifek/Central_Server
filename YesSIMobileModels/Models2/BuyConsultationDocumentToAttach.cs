using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyConsultationDocumentToAttach")]
    public partial class BuyConsultationDocumentToAttach
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? BuyConsultationId { get; set; }
        public Guid? AdmAttachedFileTypeId { get; set; }
        public Guid? BuyConsultationWorkFlowId { get; set; }
        public Guid? BuyConsultationStatusId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsMandatory { get; set; }

        [ForeignKey(nameof(AdmAttachedFileTypeId))]
        [InverseProperty("BuyConsultationDocumentToAttaches")]
        public virtual AdmAttachedFileType AdmAttachedFileType { get; set; }
        [ForeignKey(nameof(BuyConsultationStatusId))]
        [InverseProperty("BuyConsultationDocumentToAttaches")]
        public virtual BuyConsultationStatus BuyConsultationStatus { get; set; }
        [ForeignKey(nameof(BuyConsultationWorkFlowId))]
        [InverseProperty("BuyConsultationDocumentToAttaches")]
        public virtual BuyConsultationWorkFlow BuyConsultationWorkFlow { get; set; }
    }
}
