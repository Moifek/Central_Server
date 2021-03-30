using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntFolderWorkFlowAdmRole")]
    public partial class RntFolderWorkFlowAdmRole
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? RntFolderWorkFlowId { get; set; }
        public Guid? AdmRoleId { get; set; }

        [ForeignKey(nameof(AdmRoleId))]
        [InverseProperty("RntFolderWorkFlowAdmRoles")]
        public virtual AdmRole AdmRole { get; set; }
        [ForeignKey(nameof(RntFolderWorkFlowId))]
        [InverseProperty("RntFolderWorkFlowAdmRoles")]
        public virtual RntFolderWorkFlow RntFolderWorkFlow { get; set; }
    }
}
