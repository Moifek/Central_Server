using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntFolderStatus")]
    public partial class RntFolderStatus
    {
        public RntFolderStatus()
        {
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            RntFolderStatusDocumentToAttaches = new HashSet<RntFolderStatusDocumentToAttach>();
            RntFolderWorkFlowRntFolderStatusEnds = new HashSet<RntFolderWorkFlow>();
            RntFolderWorkFlowRntFolderStatusStarts = new HashSet<RntFolderWorkFlow>();
            RntFolders = new HashSet<RntFolder>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("IsARent")]
        public bool? IsArent { get; set; }
        public int? Delay { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(1000)]
        public string MandatoryFields { get; set; }
        [StringLength(1000)]
        public string TierMandatoryFields { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        public Guid? CfgImageId { get; set; }
        public Guid? AdmWorkFlowStateTypeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsClosing { get; set; }
        public bool? IsCancellation { get; set; }
        public bool? IsAvailableForProspection { get; set; }
        public bool? IsAvailableForRentInWebSite { get; set; }

        [ForeignKey(nameof(AdmWorkFlowStateTypeId))]
        [InverseProperty("RntFolderStatuses")]
        public virtual AdmWorkFlowStateType AdmWorkFlowStateType { get; set; }
        [ForeignKey(nameof(CfgImageId))]
        [InverseProperty("RntFolderStatuses")]
        public virtual CfgImage CfgImage { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.RntFolderStatus))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(RntFolderStatusDocumentToAttach.RntFolderStatus))]
        public virtual ICollection<RntFolderStatusDocumentToAttach> RntFolderStatusDocumentToAttaches { get; set; }
        [InverseProperty(nameof(RntFolderWorkFlow.RntFolderStatusEnd))]
        public virtual ICollection<RntFolderWorkFlow> RntFolderWorkFlowRntFolderStatusEnds { get; set; }
        [InverseProperty(nameof(RntFolderWorkFlow.RntFolderStatusStart))]
        public virtual ICollection<RntFolderWorkFlow> RntFolderWorkFlowRntFolderStatusStarts { get; set; }
        [InverseProperty(nameof(RntFolder.RntFolderStatus))]
        public virtual ICollection<RntFolder> RntFolders { get; set; }
    }
}
