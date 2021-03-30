using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComFolderStatus")]
    public partial class ComFolderStatus
    {
        public ComFolderStatus()
        {
            CfgTrancheComFolderStatusDeliveryId1Navigations = new HashSet<CfgTranche>();
            CfgTrancheComFolderStatusDeliveryId2Navigations = new HashSet<CfgTranche>();
            CfgTrancheStatuses = new HashSet<CfgTrancheStatus>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComCommissionLines = new HashSet<ComCommissionLine>();
            ComFolderStatusDocumentToAttaches = new HashSet<ComFolderStatusDocumentToAttach>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            ComFolderStatusReports = new HashSet<ComFolderStatusReport>();
            ComFolderWorkFlowComFolderStatusEnds = new HashSet<ComFolderWorkFlow>();
            ComFolderWorkFlowComFolderStatusStarts = new HashSet<ComFolderWorkFlow>();
            ComFolders = new HashSet<ComFolder>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid StkVocationId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        public bool? IsClosing { get; set; }
        public Guid? CfgImageId { get; set; }
        [Column("IsASale")]
        public bool? IsAsale { get; set; }
        public int? Delay { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsCancellation { get; set; }
        public Guid? AdmWorkFlowStateTypeId { get; set; }
        [Column("thresholdOperator")]
        public int? ThresholdOperator { get; set; }
        [Column("thresholdRatio", TypeName = "decimal(26, 6)")]
        public decimal? ThresholdRatio { get; set; }
        [StringLength(1000)]
        public string MandatoryFields { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        public bool? ForCashSale { get; set; }
        public bool? ForCreditSale { get; set; }
        public Guid? ComFolderStatusPaymentTypeId { get; set; }
        public bool? CanTransfertProduct { get; set; }
        public bool? CanTransfertClient { get; set; }
        public bool? ConvertProspectToClient { get; set; }
        [StringLength(1000)]
        public string TierMandatoryFields { get; set; }
        public bool? ApplyFees { get; set; }
        public bool? WhithShemaVerif { get; set; }
        [StringLength(255)]
        public string GiftMandatoryFields { get; set; }
        public bool? CanCancelFolder { get; set; }
        public bool? IsWithGiftVerification { get; set; }
        public bool? IsWithGiftOrder { get; set; }
        public bool? WithSalesManagerAffect { get; set; }
        [StringLength(255)]
        public string AssociatedFolderDate { get; set; }
        public bool? IsAvailableForProspection { get; set; }
        public bool? IsAvailableForSaleInWebSite { get; set; }
        public bool? IsSaleIncome { get; set; }

        [ForeignKey(nameof(ComFolderStatusPaymentTypeId))]
        [InverseProperty("ComFolderStatuses")]
        public virtual ComFolderStatusPaymentType ComFolderStatusPaymentType { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("ComFolderStatuses")]
        public virtual StkVocation StkVocation { get; set; }
        [InverseProperty(nameof(CfgTranche.ComFolderStatusDeliveryId1Navigation))]
        public virtual ICollection<CfgTranche> CfgTrancheComFolderStatusDeliveryId1Navigations { get; set; }
        [InverseProperty(nameof(CfgTranche.ComFolderStatusDeliveryId2Navigation))]
        public virtual ICollection<CfgTranche> CfgTrancheComFolderStatusDeliveryId2Navigations { get; set; }
        [InverseProperty(nameof(CfgTrancheStatus.ComFolderStatus))]
        public virtual ICollection<CfgTrancheStatus> CfgTrancheStatuses { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComFolderStatus))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComCommissionLine.ComFolderStatus))]
        public virtual ICollection<ComCommissionLine> ComCommissionLines { get; set; }
        [InverseProperty(nameof(ComFolderStatusDocumentToAttach.ComFolderStatus))]
        public virtual ICollection<ComFolderStatusDocumentToAttach> ComFolderStatusDocumentToAttaches { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.ComFolderStatus))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(ComFolderStatusReport.ComFolderStatus))]
        public virtual ICollection<ComFolderStatusReport> ComFolderStatusReports { get; set; }
        [InverseProperty(nameof(ComFolderWorkFlow.ComFolderStatusEnd))]
        public virtual ICollection<ComFolderWorkFlow> ComFolderWorkFlowComFolderStatusEnds { get; set; }
        [InverseProperty(nameof(ComFolderWorkFlow.ComFolderStatusStart))]
        public virtual ICollection<ComFolderWorkFlow> ComFolderWorkFlowComFolderStatusStarts { get; set; }
        [InverseProperty(nameof(ComFolder.ComFolderStatus))]
        public virtual ICollection<ComFolder> ComFolders { get; set; }
    }
}
