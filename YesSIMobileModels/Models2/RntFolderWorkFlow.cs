using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntFolderWorkFlow")]
    public partial class RntFolderWorkFlow
    {
        public RntFolderWorkFlow()
        {
            RntFolderWorkFlowAdmRoles = new HashSet<RntFolderWorkFlowAdmRole>();
            RntFolderWorkFlowDocumentToAttaches = new HashSet<RntFolderWorkFlowDocumentToAttach>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? RntFolderStatusStartId { get; set; }
        public Guid? RntFolderStatusEndId { get; set; }
        [StringLength(1000)]
        public string MandatoryFields { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? NotesMandatory { get; set; }
        public bool? WithNotification { get; set; }
        public bool? SendEmailToUsers { get; set; }
        public Guid? StrEntityId { get; set; }

        [ForeignKey(nameof(RntFolderStatusEndId))]
        [InverseProperty(nameof(RntFolderStatus.RntFolderWorkFlowRntFolderStatusEnds))]
        public virtual RntFolderStatus RntFolderStatusEnd { get; set; }
        [ForeignKey(nameof(RntFolderStatusStartId))]
        [InverseProperty(nameof(RntFolderStatus.RntFolderWorkFlowRntFolderStatusStarts))]
        public virtual RntFolderStatus RntFolderStatusStart { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("RntFolderWorkFlows")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(RntFolderWorkFlowAdmRole.RntFolderWorkFlow))]
        public virtual ICollection<RntFolderWorkFlowAdmRole> RntFolderWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(RntFolderWorkFlowDocumentToAttach.RntFolderWorkFlow))]
        public virtual ICollection<RntFolderWorkFlowDocumentToAttach> RntFolderWorkFlowDocumentToAttaches { get; set; }
    }
}
