using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SynFolderWorkFlowAdmRole")]
    public partial class SynFolderWorkFlowAdmRole
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? SynFolderWorkFlowId { get; set; }
        public Guid? AdmRoleId { get; set; }

        [ForeignKey(nameof(SynFolderWorkFlowId))]
        [InverseProperty("SynFolderWorkFlowAdmRoles")]
        public virtual SynFolderWorkFlow SynFolderWorkFlow { get; set; }
    }
}
