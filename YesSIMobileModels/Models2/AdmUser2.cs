using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmUser")]
    public partial class AdmUser2
    {
        public AdmUser2()
        {
            AdmChatFromUsers = new HashSet<AdmChat>();
            AdmChatToUsers = new HashSet<AdmChat>();
            AdmFormsLogs = new HashSet<AdmFormsLog>();
            AdmNotificationFromUsers = new HashSet<AdmNotification>();
            AdmNotificationToUsers = new HashSet<AdmNotification>();
            AdmToDoLists = new HashSet<AdmToDoList>();
            AdmUserHabilitations = new HashSet<AdmUserHabilitation>();
            AdmUserRoles = new HashSet<AdmUserRole>();
            AdmWebSessions = new HashSet<AdmWebSession>();
            BuyConsultationStatusHistories = new HashSet<BuyConsultationStatusHistory>();
            BuyDocumentStatusHistories = new HashSet<BuyDocumentStatusHistory>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            PrjMarketStatusHistories = new HashSet<PrjMarketStatusHistory>();
            StkFeasibilityStudyStatusHistories = new HashSet<StkFeasibilityStudyStatusHistory>();
            StlDepositUsers = new HashSet<StlDepositUser>();
            StlSettlementHistories = new HashSet<StlSettlementHistory>();
            StrInterveners = new HashSet<StrIntervener>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Required]
        public string Code { get; set; }
        public string Pass { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public int? LinesPerPage { get; set; }
        public bool? ConfirmDelete { get; set; }
        public int? LockDelay { get; set; }
        public Guid? WebRoleId { get; set; }
        public Guid? WebCultureId { get; set; }
        public Guid? WebAlertDefinitionId { get; set; }
        public bool? Disabled { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        public bool? IsVisibleForChat { get; set; }
        public bool? CanDisapearNotification { get; set; }
        [StringLength(255)]
        public string EmailPassword { get; set; }
        public int? EmailPortNumber { get; set; }
        [Column("EmailSMTPServer")]
        [StringLength(255)]
        public string EmailSmtpserver { get; set; }
        [Column("EmailSSLActive")]
        public bool? EmailSslactive { get; set; }
        [StringLength(255)]
        public string OpenBeeCode { get; set; }
        [StringLength(255)]
        public string OpenBeePass { get; set; }

        [ForeignKey(nameof(CfgEmployeeId))]
        [InverseProperty(nameof(CfgTier.AdmUsers))]
        public virtual CfgTier CfgEmployee { get; set; }
        [ForeignKey(nameof(WebAlertDefinitionId))]
        [InverseProperty(nameof(AdmWebAlertDefinition.AdmUsers))]
        public virtual AdmWebAlertDefinition WebAlertDefinition { get; set; }
        [ForeignKey(nameof(WebCultureId))]
        [InverseProperty(nameof(AdmWebCulture.AdmUsers))]
        public virtual AdmWebCulture WebCulture { get; set; }
        [ForeignKey(nameof(WebRoleId))]
        [InverseProperty(nameof(AdmRole.AdmUsers))]
        public virtual AdmRole WebRole { get; set; }
        [InverseProperty(nameof(AdmChat.FromUser))]
        public virtual ICollection<AdmChat> AdmChatFromUsers { get; set; }
        [InverseProperty(nameof(AdmChat.ToUser))]
        public virtual ICollection<AdmChat> AdmChatToUsers { get; set; }
        [InverseProperty(nameof(AdmFormsLog.AdmUser))]
        public virtual ICollection<AdmFormsLog> AdmFormsLogs { get; set; }
        [InverseProperty(nameof(AdmNotification.FromUser))]
        public virtual ICollection<AdmNotification> AdmNotificationFromUsers { get; set; }
        [InverseProperty(nameof(AdmNotification.ToUser))]
        public virtual ICollection<AdmNotification> AdmNotificationToUsers { get; set; }
        [InverseProperty(nameof(AdmToDoList.AdmUser))]
        public virtual ICollection<AdmToDoList> AdmToDoLists { get; set; }
        [InverseProperty(nameof(AdmUserHabilitation.AdmUser))]
        public virtual ICollection<AdmUserHabilitation> AdmUserHabilitations { get; set; }
        [InverseProperty(nameof(AdmUserRole.AdmUser))]
        public virtual ICollection<AdmUserRole> AdmUserRoles { get; set; }
        [InverseProperty(nameof(AdmWebSession.User))]
        public virtual ICollection<AdmWebSession> AdmWebSessions { get; set; }
        [InverseProperty(nameof(BuyConsultationStatusHistory.AdmUser))]
        public virtual ICollection<BuyConsultationStatusHistory> BuyConsultationStatusHistories { get; set; }
        [InverseProperty(nameof(BuyDocumentStatusHistory.AdmUser))]
        public virtual ICollection<BuyDocumentStatusHistory> BuyDocumentStatusHistories { get; set; }
        [InverseProperty(nameof(ComActionMessage.AdmUser))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.AdmUser))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(PrjMarketStatusHistory.AdmUser))]
        public virtual ICollection<PrjMarketStatusHistory> PrjMarketStatusHistories { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyStatusHistory.AdmUser))]
        public virtual ICollection<StkFeasibilityStudyStatusHistory> StkFeasibilityStudyStatusHistories { get; set; }
        [InverseProperty(nameof(StlDepositUser.AdmUser))]
        public virtual ICollection<StlDepositUser> StlDepositUsers { get; set; }
        [InverseProperty(nameof(StlSettlementHistory.AdmUser))]
        public virtual ICollection<StlSettlementHistory> StlSettlementHistories { get; set; }
        [InverseProperty(nameof(StrIntervener.AdmUser))]
        public virtual ICollection<StrIntervener> StrInterveners { get; set; }
    }
}
