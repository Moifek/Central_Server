using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrmRequestOffer")]
    public partial class PrmRequestOffer
    {
        public PrmRequestOffer()
        {
            ComActionMessages = new HashSet<ComActionMessage>();
            ComProspectionCategories = new HashSet<ComProspectionCategory>();
            ComProspectionSelectedProfiles = new HashSet<ComProspectionSelectedProfile>();
            ComProspectionTypes = new HashSet<ComProspectionType>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(500)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Address3 { get; set; }
        [StringLength(255)]
        public string ZipCode { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Budget { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        public Guid? AdmCountryId { get; set; }
        public Guid? AdmCityId { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? PrmPropertyId { get; set; }
        public Guid? CfgCommercialId { get; set; }
        public Guid? PrmPropertyCategoryId { get; set; }
        public Guid? PrmPropertyTypeId { get; set; }
        public Guid? CfgIntermediateId { get; set; }
        public Guid? CfgOwnerId { get; set; }
        public Guid? CfgCustomerId { get; set; }
        public bool? IsOccupied { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractEndDate { get; set; }
        public Guid? StrStatusId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommissionRate { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        public Guid? ComActionId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? ComProspectionKindId { get; set; }
        public Guid? ComActionMessageTypeId { get; set; }
        public Guid? ComProspectionOriginId { get; set; }
        public Guid? ComProspectionOriginSupportId { get; set; }
        public Guid? CfgProposerId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingCredit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingOwnBase { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLatitude { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLongitude { get; set; }
        public bool? IsReversmentBasedOnPayment { get; set; }

        [ForeignKey(nameof(AdmCityId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual AdmCity AdmCity { get; set; }
        [ForeignKey(nameof(AdmCountryId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual AdmCountry AdmCountry { get; set; }
        [ForeignKey(nameof(CfgCommercialId))]
        [InverseProperty("PrmRequestOfferCfgCommercials")]
        public virtual CfgTier CfgCommercial { get; set; }
        [ForeignKey(nameof(CfgCustomerId))]
        [InverseProperty("PrmRequestOfferCfgCustomers")]
        public virtual CfgTier CfgCustomer { get; set; }
        [ForeignKey(nameof(CfgIntermediateId))]
        [InverseProperty("PrmRequestOfferCfgIntermediates")]
        public virtual CfgTier CfgIntermediate { get; set; }
        [ForeignKey(nameof(CfgOwnerId))]
        [InverseProperty("PrmRequestOfferCfgOwners")]
        public virtual CfgTier CfgOwner { get; set; }
        [ForeignKey(nameof(CfgProposerId))]
        [InverseProperty("PrmRequestOfferCfgProposers")]
        public virtual CfgTier CfgProposer { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("PrmRequestOfferCfgTiers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(ComActionId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual ComAction ComAction { get; set; }
        [ForeignKey(nameof(ComActionMessageTypeId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual ComActionMessageType ComActionMessageType { get; set; }
        [ForeignKey(nameof(ComProspectionKindId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual ComProspectionKind ComProspectionKind { get; set; }
        [ForeignKey(nameof(ComProspectionOriginId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual ComProspectionOrigin ComProspectionOrigin { get; set; }
        [ForeignKey(nameof(ComProspectionOriginSupportId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual ComProspectionOriginSupport ComProspectionOriginSupport { get; set; }
        [ForeignKey(nameof(PrmPropertyId))]
        [InverseProperty(nameof(StkItem.PrmRequestOffers))]
        public virtual StkItem PrmProperty { get; set; }
        [ForeignKey(nameof(PrmPropertyCategoryId))]
        [InverseProperty(nameof(StkItemCategory.PrmRequestOffers))]
        public virtual StkItemCategory PrmPropertyCategory { get; set; }
        [ForeignKey(nameof(PrmPropertyTypeId))]
        [InverseProperty(nameof(StkItemType.PrmRequestOffers))]
        public virtual StkItemType PrmPropertyType { get; set; }
        [ForeignKey(nameof(RntPeriodicityId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual RntPeriodicity RntPeriodicity { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("PrmRequestOffers")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(ComActionMessage.PrmRequestOffer))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComProspectionCategory.PrmRequestOffer))]
        public virtual ICollection<ComProspectionCategory> ComProspectionCategories { get; set; }
        [InverseProperty(nameof(ComProspectionSelectedProfile.PrmRequestOffer))]
        public virtual ICollection<ComProspectionSelectedProfile> ComProspectionSelectedProfiles { get; set; }
        [InverseProperty(nameof(ComProspectionType.PrmRequestOffer))]
        public virtual ICollection<ComProspectionType> ComProspectionTypes { get; set; }
    }
}
