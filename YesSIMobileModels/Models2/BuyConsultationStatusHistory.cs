using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyConsultationStatusHistory")]
    public partial class BuyConsultationStatusHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? BuyConsultationStatusId { get; set; }
        public Guid? BuyConsultationId { get; set; }
        public Guid? AdmUserId { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("BuyConsultationStatusHistories")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(BuyConsultationId))]
        [InverseProperty("BuyConsultationStatusHistories")]
        public virtual BuyConsultation BuyConsultation { get; set; }
        [ForeignKey(nameof(BuyConsultationStatusId))]
        [InverseProperty("BuyConsultationStatusHistories")]
        public virtual BuyConsultationStatus BuyConsultationStatus { get; set; }
    }
}
