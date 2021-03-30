using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyConsultationWorkFlow")]
    public partial class BuyConsultationWorkFlow
    {
        public BuyConsultationWorkFlow()
        {
            BuyConsultationDocumentToAttaches = new HashSet<BuyConsultationDocumentToAttach>();
            BuyConsultationWorkFlowAdmRoles = new HashSet<BuyConsultationWorkFlowAdmRole>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? BuyConsultationStatusStartId { get; set; }
        public Guid? BuyConsultationStatusEndId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(1000)]
        public string MandatoryFields { get; set; }

        [ForeignKey(nameof(BuyConsultationStatusEndId))]
        [InverseProperty(nameof(BuyConsultationStatus.BuyConsultationWorkFlowBuyConsultationStatusEnds))]
        public virtual BuyConsultationStatus BuyConsultationStatusEnd { get; set; }
        [ForeignKey(nameof(BuyConsultationStatusStartId))]
        [InverseProperty(nameof(BuyConsultationStatus.BuyConsultationWorkFlowBuyConsultationStatusStarts))]
        public virtual BuyConsultationStatus BuyConsultationStatusStart { get; set; }
        [InverseProperty(nameof(BuyConsultationDocumentToAttach.BuyConsultationWorkFlow))]
        public virtual ICollection<BuyConsultationDocumentToAttach> BuyConsultationDocumentToAttaches { get; set; }
        [InverseProperty(nameof(BuyConsultationWorkFlowAdmRole.BuyConsultationWorkFlow))]
        public virtual ICollection<BuyConsultationWorkFlowAdmRole> BuyConsultationWorkFlowAdmRoles { get; set; }
    }
}
