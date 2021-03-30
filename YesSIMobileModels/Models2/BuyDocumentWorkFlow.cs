using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyDocumentWorkFlow")]
    public partial class BuyDocumentWorkFlow
    {
        public BuyDocumentWorkFlow()
        {
            BuyDocumentDocumentToAttaches = new HashSet<BuyDocumentDocumentToAttach>();
            BuyDocumentWorkFlowAdmRoles = new HashSet<BuyDocumentWorkFlowAdmRole>();
            BuyDocumentWorkFlowDocumentToAttaches = new HashSet<BuyDocumentWorkFlowDocumentToAttach>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? StartStatusId { get; set; }
        public Guid? EndStatusId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string MandatoryFields { get; set; }
        public bool? NotesMandatory { get; set; }
        [StringLength(1000)]
        public string SupplierMandatoryFields { get; set; }
        public Guid? StrEntityId { get; set; }
        public bool? IsValidatedByCfgTierTrigger { get; set; }
        public bool? WithNotification { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? SendEmailToUsers { get; set; }
        public bool? NotifyCfgTierTrigger { get; set; }
        [Column("SendEMailToCfgTierTrigger")]
        public bool? SendEmailToCfgTierTrigger { get; set; }

        [ForeignKey(nameof(EndStatusId))]
        [InverseProperty(nameof(BuyDocumentStatus.BuyDocumentWorkFlowEndStatuses))]
        public virtual BuyDocumentStatus EndStatus { get; set; }
        [ForeignKey(nameof(StartStatusId))]
        [InverseProperty(nameof(BuyDocumentStatus.BuyDocumentWorkFlowStartStatuses))]
        public virtual BuyDocumentStatus StartStatus { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("BuyDocumentWorkFlows")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(BuyDocumentDocumentToAttach.BuyDocumentWorkFlow))]
        public virtual ICollection<BuyDocumentDocumentToAttach> BuyDocumentDocumentToAttaches { get; set; }
        [InverseProperty(nameof(BuyDocumentWorkFlowAdmRole.WorkFlow))]
        public virtual ICollection<BuyDocumentWorkFlowAdmRole> BuyDocumentWorkFlowAdmRoles { get; set; }
        [InverseProperty(nameof(BuyDocumentWorkFlowDocumentToAttach.BuyDocumentWorkFlow))]
        public virtual ICollection<BuyDocumentWorkFlowDocumentToAttach> BuyDocumentWorkFlowDocumentToAttaches { get; set; }
    }
}
