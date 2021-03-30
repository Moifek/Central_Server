using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketStatus")]
    public partial class PrjMarketStatus
    {
        public PrjMarketStatus()
        {
            PrjMarketStatusHistories = new HashSet<PrjMarketStatusHistory>();
            PrjMarketStatusReports = new HashSet<PrjMarketStatusReport>();
            PrjMarketWorkFlowPrjMarketStatusEnds = new HashSet<PrjMarketWorkFlow>();
            PrjMarketWorkFlowPrjMarketStatusStarts = new HashSet<PrjMarketWorkFlow>();
            PrjMarkets = new HashSet<PrjMarket>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        public Guid? CfgImageId { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string MandatoryFields { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        public int? Delay { get; set; }
        public Guid? AdmWorkFlowStateTypeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? WithPrevision { get; set; }
        public bool? WithBordereau { get; set; }
        public bool? WithDepouillement { get; set; }
        public bool? WithDecomposition { get; set; }
        public bool? WithMarketAdvance { get; set; }
        public bool? WithWorkingOutAdvance { get; set; }
        public bool? WithWorkingOut { get; set; }
        public bool? WithTendersOffers { get; set; }
        public bool? IsCancellation { get; set; }
        [Column("IsAMarketEffectif")]
        public bool? IsAmarketEffectif { get; set; }

        [ForeignKey(nameof(AdmWorkFlowStateTypeId))]
        [InverseProperty("PrjMarketStatuses")]
        public virtual AdmWorkFlowStateType AdmWorkFlowStateType { get; set; }
        [InverseProperty(nameof(PrjMarketStatusHistory.PrjMarketStatus))]
        public virtual ICollection<PrjMarketStatusHistory> PrjMarketStatusHistories { get; set; }
        [InverseProperty(nameof(PrjMarketStatusReport.PrjMarketStatus))]
        public virtual ICollection<PrjMarketStatusReport> PrjMarketStatusReports { get; set; }
        [InverseProperty(nameof(PrjMarketWorkFlow.PrjMarketStatusEnd))]
        public virtual ICollection<PrjMarketWorkFlow> PrjMarketWorkFlowPrjMarketStatusEnds { get; set; }
        [InverseProperty(nameof(PrjMarketWorkFlow.PrjMarketStatusStart))]
        public virtual ICollection<PrjMarketWorkFlow> PrjMarketWorkFlowPrjMarketStatusStarts { get; set; }
        [InverseProperty(nameof(PrjMarket.PrjMarketStatus))]
        public virtual ICollection<PrjMarket> PrjMarkets { get; set; }
    }
}
