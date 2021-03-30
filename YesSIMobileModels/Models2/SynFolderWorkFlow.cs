using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SynFolderWorkFlow")]
    public partial class SynFolderWorkFlow
    {
        public SynFolderWorkFlow()
        {
            SynFolderWorkFlowAdmRoles = new HashSet<SynFolderWorkFlowAdmRole>();
            SynFolderWorkFlowDocumentToAttaches = new HashSet<SynFolderWorkFlowDocumentToAttach>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? SynFolderStatusStartId { get; set; }
        public Guid? SynFolderStatusEndId { get; set; }
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

        [ForeignKey(nameof(SynFolderStatusEndId))]
        [InverseProperty(nameof(SynFolderStatus.SynFolderWorkFlowSynFolderStatusEnds))]
        public virtual SynFolderStatus SynFolderStatusEnd { get; set; }
        [ForeignKey(nameof(SynFolderStatusStartId))]
        [InverseProperty(nameof(SynFolderStatus.SynFolderWorkFlowSynFolderStatusStarts))]
        public virtual SynFolderStatus SynFolderStatusStart { get; set; }
        [InverseProperty(nameof(SynFolderWorkFlowAdmRole.SynFolderWorkFlow))]
        public virtual ICollection<SynFolderWorkFlowAdmRole> SynFolderWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(SynFolderWorkFlowDocumentToAttach.SynFolderWorkFlow))]
        public virtual ICollection<SynFolderWorkFlowDocumentToAttach> SynFolderWorkFlowDocumentToAttaches { get; set; }
    }
}
