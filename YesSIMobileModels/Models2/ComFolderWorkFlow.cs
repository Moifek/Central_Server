using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComFolderWorkFlow")]
    public partial class ComFolderWorkFlow
    {
        public ComFolderWorkFlow()
        {
            ComFolderWorkFlowAdmRoles = new HashSet<ComFolderWorkFlowAdmRole>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid StkVocationId { get; set; }
        public Guid? ComFolderStatusStartId { get; set; }
        public Guid? ComFolderStatusEndId { get; set; }
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
        public bool? WithAutomaticTransition { get; set; }
        public bool? IsOnlyValidForCreditSale { get; set; }
        public bool? IsOnlyValidForCashSale { get; set; }

        [ForeignKey(nameof(ComFolderStatusEndId))]
        [InverseProperty(nameof(ComFolderStatus.ComFolderWorkFlowComFolderStatusEnds))]
        public virtual ComFolderStatus ComFolderStatusEnd { get; set; }
        [ForeignKey(nameof(ComFolderStatusStartId))]
        [InverseProperty(nameof(ComFolderStatus.ComFolderWorkFlowComFolderStatusStarts))]
        public virtual ComFolderStatus ComFolderStatusStart { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("ComFolderWorkFlows")]
        public virtual StkVocation StkVocation { get; set; }
        [InverseProperty(nameof(ComFolderWorkFlowAdmRole.ComFolderWorkFlow))]
        public virtual ICollection<ComFolderWorkFlowAdmRole> ComFolderWorkFlowAdmRoles { get; set; }
    }
}
