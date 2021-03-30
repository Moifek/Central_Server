using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmWorkFlowStateType")]
    public partial class AdmWorkFlowStateType
    {
        public AdmWorkFlowStateType()
        {
            BuyConsultationStatuses = new HashSet<BuyConsultationStatus>();
            BuyDocumentStatuses = new HashSet<BuyDocumentStatus>();
            PrjMarketStatuses = new HashSet<PrjMarketStatus>();
            RntFolderStatuses = new HashSet<RntFolderStatus>();
            StkFeasibilityStudyStatuses = new HashSet<StkFeasibilityStudyStatus>();
            SynFolderStatuses = new HashSet<SynFolderStatus>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(BuyConsultationStatus.AdmWorkFlowStateType))]
        public virtual ICollection<BuyConsultationStatus> BuyConsultationStatuses { get; set; }
        [InverseProperty(nameof(BuyDocumentStatus.AdmWorkFlowStateType))]
        public virtual ICollection<BuyDocumentStatus> BuyDocumentStatuses { get; set; }
        [InverseProperty(nameof(PrjMarketStatus.AdmWorkFlowStateType))]
        public virtual ICollection<PrjMarketStatus> PrjMarketStatuses { get; set; }
        [InverseProperty(nameof(RntFolderStatus.AdmWorkFlowStateType))]
        public virtual ICollection<RntFolderStatus> RntFolderStatuses { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyStatus.AdmWorkFlowStateType))]
        public virtual ICollection<StkFeasibilityStudyStatus> StkFeasibilityStudyStatuses { get; set; }
        [InverseProperty(nameof(SynFolderStatus.AdmWorkFlowStateType))]
        public virtual ICollection<SynFolderStatus> SynFolderStatuses { get; set; }
    }
}
