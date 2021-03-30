using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class CfgTrancheView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        public bool? IsForSale { get; set; }
        public bool? IsForRent { get; set; }
        public bool? IsForProject { get; set; }
        public bool? IsForBuy { get; set; }
        public bool? IsForSav { get; set; }
        public bool? IsForPrm { get; set; }
        public bool? IsForRom { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseEcarttypeConcretisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseEcarttypeFinalisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseConcretisationPercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseMarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseEndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseStartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseMarketingEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceptionDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CoveredFloorArea { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OccupancyPermitsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival1Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrevisionMarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrevisionEndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrevisionStartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrevisionMarketingEndDate { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Address3 { get; set; }
        [StringLength(255)]
        public string ZipCode { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        public Guid? AdmCountryId { get; set; }
        [StringLength(255)]
        public string AdmCountryDescription { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Mobile { get; set; }
        [StringLength(255)]
        public string Fax { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string WebSite { get; set; }
        [Required]
        [StringLength(1535)]
        public string MainAddress { get; set; }
        [StringLength(255)]
        public string SignatureCity { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [StringLength(255)]
        public string CfgTierTitle { get; set; }
        public Guid? AdmSignatoryId { get; set; }
        [StringLength(255)]
        public string CfgSignatoryDescription { get; set; }
        public Guid? CfgTechnicalManagerId { get; set; }
        [StringLength(255)]
        public string CfgTechnicalManagerDescription { get; set; }
        [StringLength(255)]
        public string CfgTechnicalManagerTitle { get; set; }
        public Guid? CfgSalesManagerId { get; set; }
        [StringLength(255)]
        public string CfgSalesManagerDescription { get; set; }
        [StringLength(255)]
        public string CfgSalesManagerTitle { get; set; }
        public Guid? CfgClaimsManagerId { get; set; }
        [StringLength(255)]
        public string CfgClaimsManagerDescription { get; set; }
        [StringLength(255)]
        public string CfgClaimsManagerTitle { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BeforeReservationAmount { get; set; }
        public bool? AdvanceBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvancePercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultExpenseAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CancellationPenalityPercent { get; set; }
        public bool? CancellationPenalityBasedOnItemPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ArticleTransferPenality { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SliceTransferPenality { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CustomerTransferPenality { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmount { get; set; }
        public int? SyndicPeriod { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OtherExpenseAmount { get; set; }
        public int? AgreementFirstDelay { get; set; }
        public int? AgreementSecondDelay { get; set; }
        public int? InterventionMinimumDelai { get; set; }
        public int? MaxVisitNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AgreementFirstPenaltyPercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AgreementSecondPenaltyPercent { get; set; }
        public int? PaymentBalanceDelay { get; set; }
        public int? WarrantyDelay { get; set; }
        public int? WarrantyDelayAdded { get; set; }
        [StringLength(255)]
        public string CommerceTribunal { get; set; }
        [StringLength(255)]
        public string CancellationRightCode { get; set; }
        public int? WithdrawalDelay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BeforeReservationAmountDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvancePercentDiscount { get; set; }
        public bool? IsActiveAdvancePercentDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultExpenseAmountDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CancellationPenalityPercentDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ArticleTransferPenalityDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SliceTransferPenalityDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CustomerTransferPenalityDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OtherExpenseAmountDiscount { get; set; }
        [StringLength(255)]
        public string SavAddress { get; set; }
        public bool? IsWithGiftForProposer { get; set; }
        public bool? IsWithGiftForOldCustomer { get; set; }
        public bool? IsWithGiftForProspectionOrigin { get; set; }
        public bool? AccumulatedGifts { get; set; }
        public int? DelayLawyerMinute { get; set; }
        public int? DelayMinuteAllSettled { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConcretisationPercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcarttypeFinalisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcarttypeConcretisation { get; set; }
        public Guid? StkLevelingId { get; set; }
        public Guid? CfgTierOtherId { get; set; }
        [StringLength(255)]
        public string CfgTierOtherDescription { get; set; }
        [StringLength(255)]
        public string CfgTierOtherTitle { get; set; }
        public Guid? CfgTrancheStandingId { get; set; }
        [StringLength(255)]
        public string CfgTrancheStandingCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheStandingDescription { get; set; }
        public Guid? LndLevelId { get; set; }
        [StringLength(255)]
        public string LndLevelCode { get; set; }
        [StringLength(255)]
        public string LndLevelDescription { get; set; }
        public Guid? ComFolderStatusDeliveryId1 { get; set; }
        [StringLength(255)]
        public string ComFolderStatusDelivery1Description { get; set; }
        public Guid? ComFolderStatusDeliveryId2 { get; set; }
        [StringLength(255)]
        public string ComFolderStatusDelivery2Description { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
