using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComSaleFolderView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ComActionId { get; set; }
        [StringLength(255)]
        public string ComActionCode { get; set; }
        [StringLength(255)]
        public string ComActionDescription { get; set; }
        public Guid? ComProspectionId { get; set; }
        [StringLength(255)]
        public string ComProspectionCode { get; set; }
        public Guid? ComProspectionKindId { get; set; }
        [StringLength(255)]
        public string ComProspectionKindCode { get; set; }
        [StringLength(255)]
        public string ComProspectionKindDescription { get; set; }
        public Guid? ComProspectionOriginId { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginCode { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginDescription { get; set; }
        public Guid? ComProspectionOriginSupportId { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginSupportCode { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginSupportDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StkItemOccupancyPermitsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ComProspectionDocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StatusValidityDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AdvanceDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservationDateCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservationRegistryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReceptionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementDatePrevisionel { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AgreementDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementSavingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementSavingDateCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementRegistryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? OwnershipCertificateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival1ValidityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival2ValidityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BankRecordDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreditApprovalDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreditPossessionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InterventionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InsuranceDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDateReal { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDateRealCustomer { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryRegistryDate { get; set; }
        [Column("loanCompanySendDate", TypeName = "datetime")]
        public DateTime? LoanCompanySendDate { get; set; }
        [Column("loanCompanyDecisionDate", TypeName = "datetime")]
        public DateTime? LoanCompanyDecisionDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CancelDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiscountChangeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrecisionActDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrecisionActDateCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrecisionActRegistryDate { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractPrintDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        [StringLength(255)]
        public string Usage { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryRatio { get; set; }
        public int? DeliveryMaxNumber { get; set; }
        public int? DeliveryNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DeliveryAmount { get; set; }
        public bool? IsConfirmedAgreementDate { get; set; }
        public int? GiftNumber { get; set; }
        public bool? IsWithGiftChoiceLater { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? GlobalArea { get; set; }
        [Column("UnitCosBeforeDiscounttHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitCosBeforeDiscounttHt { get; set; }
        [Column("ItemPriceBeforeDiscountHT", TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceBeforeDiscountHt { get; set; }
        [Column("UnderItemsPriceBeforeDiscountHT", TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPriceBeforeDiscountHt { get; set; }
        [Column("PriceBeforeDiscountHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceBeforeDiscountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DiscountAmount { get; set; }
        [Column("UnitCostHT", TypeName = "decimal(38, 12)")]
        public decimal? UnitCostHt { get; set; }
        [Column("ItemPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceHt { get; set; }
        [Column("UnderItemsPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ItemPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceBeforeDiscount { get; set; }
        [Column("VATRatio", TypeName = "decimal(26, 6)")]
        public decimal? Vatratio { get; set; }
        [Column("UnitCostTTC", TypeName = "decimal(38, 12)")]
        public decimal? UnitCostTtc { get; set; }
        [Column("ItemPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceTtc { get; set; }
        [Column("UnderItemsPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPriceTtc { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column("PriceVAT", TypeName = "decimal(27, 6)")]
        public decimal? PriceVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalToPay { get; set; }
        public bool? PriceWithModification { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceAfterDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AgreementAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseFolder { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseFolderSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseSyndic { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseSyndicSettled { get; set; }
        [Column("ModificationsAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? ModificationsAmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ModificationsAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ModificationsSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? SelfFinancingAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? SelfFinancingSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CreditAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CreditSettled { get; set; }
        public Guid? CreditBankId { get; set; }
        [StringLength(255)]
        public string CfgCreditBankDescription { get; set; }
        [StringLength(255)]
        public string CreditAgency { get; set; }
        [StringLength(255)]
        public string PenalityDescription { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PenalityAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PenalitySettled { get; set; }
        public int IsCancellation { get; set; }
        [StringLength(1000)]
        public string CancelDescription { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CancelAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CancelSettled { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AgreementPrice { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AgreementPriceSettled { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProbabilityOfFinalisation { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AgreementRatio { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AgreementSettled { get; set; }
        [Column("AmountSettledIN", TypeName = "decimal(38, 6)")]
        public decimal? AmountSettledIn { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TropPercuSettled { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        [StringLength(255)]
        public string StkItemTitleNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemArea { get; set; }
        [StringLength(1000)]
        public string StkItemContenance { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        [StringLength(255)]
        public string StkItemCategoryCode { get; set; }
        [StringLength(255)]
        public string StkItemCategoryDescription { get; set; }
        public Guid? StkItemTypeId { get; set; }
        [StringLength(255)]
        public string StkItemTypeCode { get; set; }
        [StringLength(255)]
        public string StkItemTypeDescription { get; set; }
        public Guid? StkPresentationTypeId { get; set; }
        [StringLength(255)]
        public string StkPresentationTypeCode { get; set; }
        [StringLength(255)]
        public string StkPresentationTypeDescription { get; set; }
        public Guid? StkFlooreId { get; set; }
        [StringLength(255)]
        public string StkFloorCode { get; set; }
        [StringLength(255)]
        public string StkFloorDescription { get; set; }
        public int? StkFloorSorting { get; set; }
        public Guid? StkBuildingId { get; set; }
        [StringLength(255)]
        public string StkBuildingCode { get; set; }
        [StringLength(255)]
        public string StkBuildingDescription { get; set; }
        public string UnderItemsCode { get; set; }
        public string UnderItemsDescription { get; set; }
        public Guid CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid StkVocationId { get; set; }
        [StringLength(255)]
        public string StkVocationCode { get; set; }
        [StringLength(255)]
        public string StkVocationDecsription { get; set; }
        public Guid ComFolderStatusId { get; set; }
        [StringLength(255)]
        public string ComFolderStatusCode { get; set; }
        [StringLength(255)]
        public string ComFolderStatusDescription { get; set; }
        public Guid? ComFolderStatusCfgImageId { get; set; }
        public bool? IsSaleIncome { get; set; }
        public Guid? CfgCommercialId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCommercialDescription { get; set; }
        public Guid? CfgSaleManagerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgSaleManagerDescription { get; set; }
        public Guid? CfgSaleManager2Id { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgSaleManager2Description { get; set; }
        public Guid? CfgLawyerId { get; set; }
        [StringLength(255)]
        public string CfgLawyerDescription { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PartPercent { get; set; }
        public bool? IsOldCustomer { get; set; }
        [Required]
        public string OtherCustomer { get; set; }
        public Guid? ComLoanCompanyDecisionId { get; set; }
        [StringLength(255)]
        public string ComLoanCompanyDecisionDescription { get; set; }
        [Column(TypeName = "decimal(38, 12)")]
        public decimal? ComSaleUnitCost { get; set; }
        [Column("ComSaleUnitCostHT", TypeName = "decimal(38, 6)")]
        public decimal? ComSaleUnitCostHt { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Advance { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? SelfFinancingRest { get; set; }
        public int WithCredit { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CreditRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseFolderRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExpenseSyndicRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ModificationsRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PenalityRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CancelRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AgreementPriceRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PriceSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PriceRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Total { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TropPercu { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TropPercuRest { get; set; }
    }
}
