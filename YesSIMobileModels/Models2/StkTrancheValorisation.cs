using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StkTrancheValorisation
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("CfgProjectPKey")]
        public Guid CfgProjectPkey { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        [Column("CfgCompanyPKey")]
        public Guid CfgCompanyPkey { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public int? CountAllItem { get; set; }
        public int? CountUnderItem { get; set; }
        public int? CountItem { get; set; }
        public int? CountItemFree { get; set; }
        public int? CountItemReserverd { get; set; }
        [Column("PriceAllItemHT", TypeName = "decimal(38, 12)")]
        public decimal PriceAllItemHt { get; set; }
        [Column("PriceItemHT", TypeName = "decimal(38, 12)")]
        public decimal PriceItemHt { get; set; }
        [Column("PriceUnderItemHT", TypeName = "decimal(38, 12)")]
        public decimal PriceUnderItemHt { get; set; }
        [Column("PriceAllItemFloorHT", TypeName = "decimal(38, 12)")]
        public decimal PriceAllItemFloorHt { get; set; }
        [Column("PriceItemFloorHT", TypeName = "decimal(38, 12)")]
        public decimal PriceItemFloorHt { get; set; }
        [Column("PriceUnderItemFloorHT", TypeName = "decimal(38, 12)")]
        public decimal PriceUnderItemFloorHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PriceAllItem { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PriceItem { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PriceUnderItem { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PriceAllItemFloor { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PriceItemFloor { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PriceUnderItemFloor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingEndDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcarttypeConcretisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcarttypeFinalisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConcretisationPercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkEndDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvancePercent { get; set; }
        public bool? IsForSale { get; set; }
        public bool? IsForRent { get; set; }
        public bool? IsForProject { get; set; }
        public bool? IsForBuy { get; set; }
        public bool? IsForSav { get; set; }
    }
}
