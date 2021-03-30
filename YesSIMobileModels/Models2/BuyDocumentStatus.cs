using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyDocumentStatus")]
    public partial class BuyDocumentStatus
    {
        public BuyDocumentStatus()
        {
            BuyDocumentStatusDocumentToAttaches = new HashSet<BuyDocumentStatusDocumentToAttach>();
            BuyDocumentStatusHistories = new HashSet<BuyDocumentStatusHistory>();
            BuyDocumentWorkFlowEndStatuses = new HashSet<BuyDocumentWorkFlow>();
            BuyDocumentWorkFlowStartStatuses = new HashSet<BuyDocumentWorkFlow>();
            BuyDocuments = new HashSet<BuyDocument>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        public bool? IsOkForPayement { get; set; }
        public bool? IsValidatedOnAccounting { get; set; }
        public int? Delay { get; set; }
        [StringLength(1000)]
        public string MandatoryFields { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
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
        [StringLength(1000)]
        public string SupplierMandatoryFields { get; set; }
        public bool? IsReadOnly { get; set; }

        [ForeignKey(nameof(AdmWorkFlowStateTypeId))]
        [InverseProperty("BuyDocumentStatuses")]
        public virtual AdmWorkFlowStateType AdmWorkFlowStateType { get; set; }
        [ForeignKey(nameof(CfgImageId))]
        [InverseProperty("BuyDocumentStatuses")]
        public virtual CfgImage CfgImage { get; set; }
        [InverseProperty(nameof(BuyDocumentStatusDocumentToAttach.BuyDocumentStatus))]
        public virtual ICollection<BuyDocumentStatusDocumentToAttach> BuyDocumentStatusDocumentToAttaches { get; set; }
        [InverseProperty(nameof(BuyDocumentStatusHistory.BuyDocumentStatus))]
        public virtual ICollection<BuyDocumentStatusHistory> BuyDocumentStatusHistories { get; set; }
        [InverseProperty(nameof(BuyDocumentWorkFlow.EndStatus))]
        public virtual ICollection<BuyDocumentWorkFlow> BuyDocumentWorkFlowEndStatuses { get; set; }
        [InverseProperty(nameof(BuyDocumentWorkFlow.StartStatus))]
        public virtual ICollection<BuyDocumentWorkFlow> BuyDocumentWorkFlowStartStatuses { get; set; }
        [InverseProperty(nameof(BuyDocument.BuyDocumentStatus))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
    }
}
