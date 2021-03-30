using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketWorkFlowAdmRole")]
    public partial class PrjMarketWorkFlowAdmRole
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? PrjMarketWorkFlowId { get; set; }
        public Guid? AdmRoleId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(AdmRoleId))]
        [InverseProperty("PrjMarketWorkFlowAdmRoles")]
        public virtual AdmRole AdmRole { get; set; }
        [ForeignKey(nameof(PrjMarketWorkFlowId))]
        [InverseProperty("PrjMarketWorkFlowAdmRoles")]
        public virtual PrjMarketWorkFlow PrjMarketWorkFlow { get; set; }
    }
}
