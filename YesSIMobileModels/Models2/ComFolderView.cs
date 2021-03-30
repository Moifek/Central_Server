using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComFolderView
    {
        public Guid StkItemId { get; set; }
        public Guid ComFolderId { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        public Guid ComFolderStatusId { get; set; }
        [Column(TypeName = "image")]
        public byte[] StatusImg { get; set; }
        public int IsCancellation { get; set; }
        [StringLength(255)]
        public string ArticleCode { get; set; }
        [StringLength(255)]
        public string ArticleDescription { get; set; }
        [StringLength(255)]
        public string TitleNumber { get; set; }
        [StringLength(255)]
        public string Blok { get; set; }
        public int? RawNumber { get; set; }
        [StringLength(255)]
        public string Category { get; set; }
        [StringLength(255)]
        public string Type { get; set; }
        [StringLength(255)]
        public string PresentationType { get; set; }
        public bool? IsOldCustomer { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [StringLength(255)]
        public string CustomerDescription { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        [StringLength(255)]
        public string CfgTierFirstName { get; set; }
        [StringLength(255)]
        public string CfgTierLastName { get; set; }
        [StringLength(30)]
        public string CfgTierMobile1 { get; set; }
        [StringLength(10)]
        public string CfgTierMobile1Indicatif { get; set; }
        [Column("CfgTierIDNumber")]
        [StringLength(255)]
        public string CfgTierIdnumber { get; set; }
        [StringLength(43)]
        public string Mobile { get; set; }
        [StringLength(43)]
        public string Phone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AdvanceDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservationDateCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReservationRegistryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AgreementDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BankRecordDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InterventionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InsuranceDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OccupancyPermitsDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreditApprovalDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreditPossessionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementSavingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementSavingDateCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDateReal { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDateRealCustomer { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryRegistryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? OwnershipCertificateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementRegistryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival1ValidityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival2ValidityDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StatusValidityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiscountChangeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementDatePrevisionel { get; set; }
        public bool? IsConfirmedAgreementDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProspectionDocDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReceptionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LoanCompanySendDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LoanCompanyDecisionDate { get; set; }
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
        public int? ModificationSateCount { get; set; }
        [StringLength(255)]
        public string Commercial { get; set; }
        [StringLength(255)]
        public string SaleManager { get; set; }
        [StringLength(255)]
        public string SaleManager2 { get; set; }
        public Guid? CfgLawyerId { get; set; }
        [StringLength(255)]
        public string Lawyer { get; set; }
        public Guid? StkHierarchyId { get; set; }
        [Column("H1Code")]
        [StringLength(255)]
        public string H1code { get; set; }
        [Column("H1Description")]
        [StringLength(255)]
        public string H1description { get; set; }
        [Column("H2Code")]
        [StringLength(255)]
        public string H2code { get; set; }
        [Column("H2Description")]
        [StringLength(255)]
        public string H2description { get; set; }
        [Column("H3Code")]
        [StringLength(255)]
        public string H3code { get; set; }
        [Column("H3Description")]
        [StringLength(255)]
        public string H3description { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginDescription { get; set; }
        [StringLength(255)]
        public string ComProspectionOriginSupportDescription { get; set; }
        [StringLength(255)]
        public string ComActionDescription { get; set; }
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
        public decimal? UnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ItemPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceBeforeDiscount { get; set; }
        [Column("VATRatio", TypeName = "decimal(26, 6)")]
        public decimal? Vatratio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DiscountAmount { get; set; }
        [Column("UnitCostHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitCostHt { get; set; }
        [Column("ItemPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceHt { get; set; }
        [Column("UnderItemsPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPriceHt { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column("UnitCostTTC", TypeName = "decimal(38, 12)")]
        public decimal? UnitCostTtc { get; set; }
        [Column("ItemPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceTtc { get; set; }
        [Column("UnderItemsPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPriceTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(38, 12)")]
        public decimal? ComSaleUnitCost { get; set; }
        [Column("ComSaleUnitCostHT", TypeName = "decimal(38, 6)")]
        public decimal? ComSaleUnitCostHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProbabilityOfFinalisation { get; set; }
        public int? GiftNumber { get; set; }
        public bool? IsWithGiftChoiceLater { get; set; }
        public int? DelayConcretisation { get; set; }
        public int? DelayLawyer { get; set; }
        public int? DelayCredit { get; set; }
        public int? DelayDelivery { get; set; }
        public int? DelayDeliveryCredit { get; set; }
        public int DelaiLoanCompany { get; set; }
        public int ThereIsInstructionNotRead { get; set; }
        public Guid? CfgCommercialForInstructionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastCommunicationDate { get; set; }
        [Required]
        [StringLength(255)]
        public string LastCommunicationResult { get; set; }
        [Required]
        public string LastCommunicationMessage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastActiveAlertDate { get; set; }
        public int? ActionsMessageNumber { get; set; }
        public Guid? ComLoanCompanyDecisionId { get; set; }
        [StringLength(255)]
        public string ComLoanCompanyDecisionDescription { get; set; }
        public Guid? CreditBankId { get; set; }
        [StringLength(255)]
        public string CreditBankDescription { get; set; }
        public string UnderItemsCode { get; set; }
        public string UnderItemsDescription { get; set; }
        public string OtherCustomers { get; set; }
        public Guid? CfgCompanyId { get; set; }
    }
}
