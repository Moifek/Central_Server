using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmAttachedFileType")]
    public partial class AdmAttachedFileType
    {
        public AdmAttachedFileType()
        {
            AdmAttachedFileTypeStrEntities = new HashSet<AdmAttachedFileTypeStrEntity>();
            AdmAttachedFiles = new HashSet<AdmAttachedFile>();
            BuyConsultationDocumentToAttaches = new HashSet<BuyConsultationDocumentToAttach>();
            BuyDocumentDocumentToAttaches = new HashSet<BuyDocumentDocumentToAttach>();
            BuyDocumentStatusDocumentToAttaches = new HashSet<BuyDocumentStatusDocumentToAttach>();
            BuyDocumentWorkFlowDocumentToAttaches = new HashSet<BuyDocumentWorkFlowDocumentToAttach>();
            ComFolderDocumentToAttaches = new HashSet<ComFolderDocumentToAttach>();
            ComFolderStatusDocumentToAttaches = new HashSet<ComFolderStatusDocumentToAttach>();
            ComSettlementDocumentToAttaches = new HashSet<ComSettlementDocumentToAttach>();
            PrjMarketDocumentToAttaches = new HashSet<PrjMarketDocumentToAttach>();
            RntFolderDocumentToAttaches = new HashSet<RntFolderDocumentToAttach>();
            RntFolderStatusDocumentToAttaches = new HashSet<RntFolderStatusDocumentToAttach>();
            RntFolderWorkFlowDocumentToAttaches = new HashSet<RntFolderWorkFlowDocumentToAttach>();
            StkFeasibilityStudyStatusDocumentToAttaches = new HashSet<StkFeasibilityStudyStatusDocumentToAttach>();
            StkFeasibilityStudyWorkFlowDocumentToAttaches = new HashSet<StkFeasibilityStudyWorkFlowDocumentToAttach>();
            StrAttachments = new HashSet<StrAttachment>();
            SynFolderWorkFlowDocumentToAttaches = new HashSet<SynFolderWorkFlowDocumentToAttach>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(AdmAttachedFileTypeStrEntity.AdmAttachedFileType))]
        public virtual ICollection<AdmAttachedFileTypeStrEntity> AdmAttachedFileTypeStrEntities { get; set; }
        [InverseProperty(nameof(AdmAttachedFile.AdmAttachedFileType))]
        public virtual ICollection<AdmAttachedFile> AdmAttachedFiles { get; set; }
        [InverseProperty(nameof(BuyConsultationDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<BuyConsultationDocumentToAttach> BuyConsultationDocumentToAttaches { get; set; }
        [InverseProperty(nameof(BuyDocumentDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<BuyDocumentDocumentToAttach> BuyDocumentDocumentToAttaches { get; set; }
        [InverseProperty(nameof(BuyDocumentStatusDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<BuyDocumentStatusDocumentToAttach> BuyDocumentStatusDocumentToAttaches { get; set; }
        [InverseProperty(nameof(BuyDocumentWorkFlowDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<BuyDocumentWorkFlowDocumentToAttach> BuyDocumentWorkFlowDocumentToAttaches { get; set; }
        [InverseProperty(nameof(ComFolderDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<ComFolderDocumentToAttach> ComFolderDocumentToAttaches { get; set; }
        [InverseProperty(nameof(ComFolderStatusDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<ComFolderStatusDocumentToAttach> ComFolderStatusDocumentToAttaches { get; set; }
        [InverseProperty(nameof(ComSettlementDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<ComSettlementDocumentToAttach> ComSettlementDocumentToAttaches { get; set; }
        [InverseProperty(nameof(PrjMarketDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<PrjMarketDocumentToAttach> PrjMarketDocumentToAttaches { get; set; }
        [InverseProperty(nameof(RntFolderDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<RntFolderDocumentToAttach> RntFolderDocumentToAttaches { get; set; }
        [InverseProperty(nameof(RntFolderStatusDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<RntFolderStatusDocumentToAttach> RntFolderStatusDocumentToAttaches { get; set; }
        [InverseProperty(nameof(RntFolderWorkFlowDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<RntFolderWorkFlowDocumentToAttach> RntFolderWorkFlowDocumentToAttaches { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyStatusDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<StkFeasibilityStudyStatusDocumentToAttach> StkFeasibilityStudyStatusDocumentToAttaches { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyWorkFlowDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<StkFeasibilityStudyWorkFlowDocumentToAttach> StkFeasibilityStudyWorkFlowDocumentToAttaches { get; set; }
        [InverseProperty(nameof(StrAttachment.AdmAttachedFileType))]
        public virtual ICollection<StrAttachment> StrAttachments { get; set; }
        [InverseProperty(nameof(SynFolderWorkFlowDocumentToAttach.AdmAttachedFileType))]
        public virtual ICollection<SynFolderWorkFlowDocumentToAttach> SynFolderWorkFlowDocumentToAttaches { get; set; }
    }
}
