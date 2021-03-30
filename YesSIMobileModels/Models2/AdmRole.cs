using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmRole")]
    public partial class AdmRole
    {
        public AdmRole()
        {
            AdmReportDataRoles = new HashSet<AdmReportDataRole>();
            AdmRights = new HashSet<AdmRight>();
            AdmUserRoles = new HashSet<AdmUserRole>();
            AdmUsers = new HashSet<AdmUser2>();
            AdmWebRights = new HashSet<AdmWebRight>();
            BuyConsultationWorkFlowAdmRoles = new HashSet<BuyConsultationWorkFlowAdmRole>();
            BuyDocumentWorkFlowAdmRoles = new HashSet<BuyDocumentWorkFlowAdmRole>();
            ComFolderWorkFlowAdmRoles = new HashSet<ComFolderWorkFlowAdmRole>();
            PrjMarketWorkFlowAdmRoles = new HashSet<PrjMarketWorkFlowAdmRole>();
            RntFolderWorkFlowAdmRoles = new HashSet<RntFolderWorkFlowAdmRole>();
            StkFeasibilityStudyWorkFlowAdmRoles = new HashSet<StkFeasibilityStudyWorkFlowAdmRole>();
            StrInterveners = new HashSet<StrIntervener>();
        }

        [StringLength(255)]
        public string Code { get; set; }
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? WithReportRestriction { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? WithDeleteAttachementRestriction { get; set; }
        public bool? WithAuditRestriction { get; set; }
        public bool? WithSpecificFieldsRestriction { get; set; }
        public bool? WithAddActionMessageRestriction { get; set; }
        public bool? WithEditActionMessageRestriction { get; set; }
        public bool? WithDeleteActionMessageRestriction { get; set; }
        public bool? WithEditAttachementRestriction { get; set; }
        public bool? WithAddAttachementRestriction { get; set; }
        public bool? WithSequenceFreeRestriction { get; set; }

        [InverseProperty(nameof(AdmReportDataRole.AdmRole))]
        public virtual ICollection<AdmReportDataRole> AdmReportDataRoles { get; set; }
        [InverseProperty(nameof(AdmRight.AdmRole))]
        public virtual ICollection<AdmRight> AdmRights { get; set; }
        [InverseProperty(nameof(AdmUserRole.AdmRole))]
        public virtual ICollection<AdmUserRole> AdmUserRoles { get; set; }
        [InverseProperty(nameof(AdmUser2.WebRole))]
        public virtual ICollection<AdmUser2> AdmUsers { get; set; }
        [InverseProperty(nameof(AdmWebRight.Role))]
        public virtual ICollection<AdmWebRight> AdmWebRights { get; set; }
        [InverseProperty(nameof(BuyConsultationWorkFlowAdmRole.AdmRole))]
        public virtual ICollection<BuyConsultationWorkFlowAdmRole> BuyConsultationWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(BuyDocumentWorkFlowAdmRole.AdmRole))]
        public virtual ICollection<BuyDocumentWorkFlowAdmRole> BuyDocumentWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(ComFolderWorkFlowAdmRole.AdmRole))]
        public virtual ICollection<ComFolderWorkFlowAdmRole> ComFolderWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(PrjMarketWorkFlowAdmRole.AdmRole))]
        public virtual ICollection<PrjMarketWorkFlowAdmRole> PrjMarketWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(RntFolderWorkFlowAdmRole.AdmRole))]
        public virtual ICollection<RntFolderWorkFlowAdmRole> RntFolderWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyWorkFlowAdmRole.AdmRole))]
        public virtual ICollection<StkFeasibilityStudyWorkFlowAdmRole> StkFeasibilityStudyWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(StrIntervener.AdmRole))]
        public virtual ICollection<StrIntervener> StrInterveners { get; set; }
    }
}
