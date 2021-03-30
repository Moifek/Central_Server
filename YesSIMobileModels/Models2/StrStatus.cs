using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrStatus")]
    public partial class StrStatus
    {
        public StrStatus()
        {
            BuyRequests = new HashSet<BuyRequest>();
            BuySelections = new HashSet<BuySelection>();
            GrhAdvances = new HashSet<GrhAdvance>();
            GrhCredits = new HashSet<GrhCredit>();
            GrhDisciplines = new HashSet<GrhDiscipline>();
            GrhOverTimes = new HashSet<GrhOverTime>();
            GrhResignations = new HashSet<GrhResignation>();
            GrhTerminations = new HashSet<GrhTermination>();
            GrhVacationGroups = new HashSet<GrhVacationGroup>();
            GrhVacations = new HashSet<GrhVacation>();
            GrhWorkedDays = new HashSet<GrhWorkedDay>();
            LndLands = new HashSet<LndLand>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
            SavClaims = new HashSet<SavClaim>();
            SavServices = new HashSet<SavService>();
            StlInternalTransfers = new HashSet<StlInternalTransfer>();
            StlPaymentAuthorizations = new HashSet<StlPaymentAuthorization>();
            StlRecoveryFolders = new HashSet<StlRecoveryFolder>();
            StlSlips = new HashSet<StlSlip>();
            StlTransmissionSheets = new HashSet<StlTransmissionSheet>();
            StrStatusFields = new HashSet<StrStatusField>();
            StrStatusInterveners = new HashSet<StrStatusIntervener>();
            StrWorkFlowStatusFroms = new HashSet<StrWorkFlow>();
            StrWorkFlowStatusTos = new HashSet<StrWorkFlow>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StrStatusTypeId { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? CfgImageId { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        public int? Delay { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool? CanDelete { get; set; }
        public bool? BoolField001 { get; set; }
        public bool? BoolField002 { get; set; }
        public bool? BoolField003 { get; set; }
        public bool? BoolField004 { get; set; }
        public bool? BoolField005 { get; set; }
        public bool? BoolField006 { get; set; }
        public bool? BoolField007 { get; set; }
        public bool? BoolField008 { get; set; }
        public bool? BoolField009 { get; set; }
        public bool? BoolField010 { get; set; }
        public bool? BoolField011 { get; set; }
        public bool? BoolField012 { get; set; }
        public bool? BoolField013 { get; set; }
        public bool? BoolField014 { get; set; }
        public bool? BoolField015 { get; set; }
        public bool? BoolField016 { get; set; }
        public bool? BoolField017 { get; set; }
        public bool? BoolField018 { get; set; }
        public bool? BoolField019 { get; set; }
        public bool? BoolField020 { get; set; }

        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StrStatuses")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusTypeId))]
        [InverseProperty("StrStatuses")]
        public virtual StrStatusType StrStatusType { get; set; }
        [InverseProperty(nameof(BuyRequest.StrStatus))]
        public virtual ICollection<BuyRequest> BuyRequests { get; set; }
        [InverseProperty(nameof(BuySelection.StrStatus))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty(nameof(GrhAdvance.StrStatus))]
        public virtual ICollection<GrhAdvance> GrhAdvances { get; set; }
        [InverseProperty(nameof(GrhCredit.StrStatus))]
        public virtual ICollection<GrhCredit> GrhCredits { get; set; }
        [InverseProperty(nameof(GrhDiscipline.StrStatus))]
        public virtual ICollection<GrhDiscipline> GrhDisciplines { get; set; }
        [InverseProperty(nameof(GrhOverTime.StrStatus))]
        public virtual ICollection<GrhOverTime> GrhOverTimes { get; set; }
        [InverseProperty(nameof(GrhResignation.StrStatus))]
        public virtual ICollection<GrhResignation> GrhResignations { get; set; }
        [InverseProperty(nameof(GrhTermination.StrStatus))]
        public virtual ICollection<GrhTermination> GrhTerminations { get; set; }
        [InverseProperty(nameof(GrhVacationGroup.StrStatus))]
        public virtual ICollection<GrhVacationGroup> GrhVacationGroups { get; set; }
        [InverseProperty(nameof(GrhVacation.StrStatus))]
        public virtual ICollection<GrhVacation> GrhVacations { get; set; }
        [InverseProperty(nameof(GrhWorkedDay.StrStatus))]
        public virtual ICollection<GrhWorkedDay> GrhWorkedDays { get; set; }
        [InverseProperty(nameof(LndLand.StrStatus))]
        public virtual ICollection<LndLand> LndLands { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.StrStatus))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
        [InverseProperty(nameof(SavClaim.StrStatus))]
        public virtual ICollection<SavClaim> SavClaims { get; set; }
        [InverseProperty(nameof(SavService.StrStatus))]
        public virtual ICollection<SavService> SavServices { get; set; }
        [InverseProperty(nameof(StlInternalTransfer.StrStatus))]
        public virtual ICollection<StlInternalTransfer> StlInternalTransfers { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorization.StrStatus))]
        public virtual ICollection<StlPaymentAuthorization> StlPaymentAuthorizations { get; set; }
        [InverseProperty(nameof(StlRecoveryFolder.StrStatus))]
        public virtual ICollection<StlRecoveryFolder> StlRecoveryFolders { get; set; }
        [InverseProperty(nameof(StlSlip.StrStatus))]
        public virtual ICollection<StlSlip> StlSlips { get; set; }
        [InverseProperty(nameof(StlTransmissionSheet.StrStatus))]
        public virtual ICollection<StlTransmissionSheet> StlTransmissionSheets { get; set; }
        [InverseProperty(nameof(StrStatusField.StrStatus))]
        public virtual ICollection<StrStatusField> StrStatusFields { get; set; }
        [InverseProperty(nameof(StrStatusIntervener.StrStatus))]
        public virtual ICollection<StrStatusIntervener> StrStatusInterveners { get; set; }
        [InverseProperty(nameof(StrWorkFlow.StatusFrom))]
        public virtual ICollection<StrWorkFlow> StrWorkFlowStatusFroms { get; set; }
        [InverseProperty(nameof(StrWorkFlow.StatusTo))]
        public virtual ICollection<StrWorkFlow> StrWorkFlowStatusTos { get; set; }
    }
}
