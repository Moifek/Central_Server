using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SynFolderStatus")]
    public partial class SynFolderStatus
    {
        public SynFolderStatus()
        {
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            SynFolderWorkFlowSynFolderStatusEnds = new HashSet<SynFolderWorkFlow>();
            SynFolderWorkFlowSynFolderStatusStarts = new HashSet<SynFolderWorkFlow>();
            SynFolders = new HashSet<SynFolder>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("IsASyndic")]
        public bool? IsAsyndic { get; set; }
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

        [ForeignKey(nameof(AdmWorkFlowStateTypeId))]
        [InverseProperty("SynFolderStatuses")]
        public virtual AdmWorkFlowStateType AdmWorkFlowStateType { get; set; }
        [ForeignKey(nameof(CfgImageId))]
        [InverseProperty("SynFolderStatuses")]
        public virtual CfgImage CfgImage { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.SynFolderStatus))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(SynFolderWorkFlow.SynFolderStatusEnd))]
        public virtual ICollection<SynFolderWorkFlow> SynFolderWorkFlowSynFolderStatusEnds { get; set; }
        [InverseProperty(nameof(SynFolderWorkFlow.SynFolderStatusStart))]
        public virtual ICollection<SynFolderWorkFlow> SynFolderWorkFlowSynFolderStatusStarts { get; set; }
        [InverseProperty(nameof(SynFolder.SynFolderStatus))]
        public virtual ICollection<SynFolder> SynFolders { get; set; }
    }
}
