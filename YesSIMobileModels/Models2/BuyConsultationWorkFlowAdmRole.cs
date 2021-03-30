using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyConsultationWorkFlowAdmRole")]
    public partial class BuyConsultationWorkFlowAdmRole
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? BuyConsultationWorkFlowId { get; set; }
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
        [InverseProperty("BuyConsultationWorkFlowAdmRoles")]
        public virtual AdmRole AdmRole { get; set; }
        [ForeignKey(nameof(BuyConsultationWorkFlowId))]
        [InverseProperty("BuyConsultationWorkFlowAdmRoles")]
        public virtual BuyConsultationWorkFlow BuyConsultationWorkFlow { get; set; }
    }
}
