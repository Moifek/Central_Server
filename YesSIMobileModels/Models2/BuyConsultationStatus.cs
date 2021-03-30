using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyConsultationStatus")]
    public partial class BuyConsultationStatus
    {
        public BuyConsultationStatus()
        {
            BuyConsultationDocumentToAttaches = new HashSet<BuyConsultationDocumentToAttach>();
            BuyConsultationStatusHistories = new HashSet<BuyConsultationStatusHistory>();
            BuyConsultationWorkFlowBuyConsultationStatusEnds = new HashSet<BuyConsultationWorkFlow>();
            BuyConsultationWorkFlowBuyConsultationStatusStarts = new HashSet<BuyConsultationWorkFlow>();
            BuyConsultations = new HashSet<BuyConsultation>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        public Guid? CfgImageId { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string MandatoryFields { get; set; }
        [StringLength(255)]
        public string TierMandatoryFields { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        public int? Delay { get; set; }
        public Guid? AdmWorkFlowStateTypeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? WithPrevision { get; set; }
        public bool? WithBordereau { get; set; }
        public bool? WithDepouillement { get; set; }
        public bool? WithDecomposition { get; set; }
        public bool? WithMarketAdvance { get; set; }
        public bool? WithWorkingOutAdvance { get; set; }
        public bool? WithWorkingOut { get; set; }
        public bool? WithTendersOffers { get; set; }
        public bool? IsCancellation { get; set; }
        [Column("IsAMarketEffectif")]
        public bool? IsAmarketEffectif { get; set; }

        [ForeignKey(nameof(AdmWorkFlowStateTypeId))]
        [InverseProperty("BuyConsultationStatuses")]
        public virtual AdmWorkFlowStateType AdmWorkFlowStateType { get; set; }
        [InverseProperty(nameof(BuyConsultationDocumentToAttach.BuyConsultationStatus))]
        public virtual ICollection<BuyConsultationDocumentToAttach> BuyConsultationDocumentToAttaches { get; set; }
        [InverseProperty(nameof(BuyConsultationStatusHistory.BuyConsultationStatus))]
        public virtual ICollection<BuyConsultationStatusHistory> BuyConsultationStatusHistories { get; set; }
        [InverseProperty(nameof(BuyConsultationWorkFlow.BuyConsultationStatusEnd))]
        public virtual ICollection<BuyConsultationWorkFlow> BuyConsultationWorkFlowBuyConsultationStatusEnds { get; set; }
        [InverseProperty(nameof(BuyConsultationWorkFlow.BuyConsultationStatusStart))]
        public virtual ICollection<BuyConsultationWorkFlow> BuyConsultationWorkFlowBuyConsultationStatusStarts { get; set; }
        [InverseProperty(nameof(BuyConsultation.BuyConsultationStatus))]
        public virtual ICollection<BuyConsultation> BuyConsultations { get; set; }
    }
}
