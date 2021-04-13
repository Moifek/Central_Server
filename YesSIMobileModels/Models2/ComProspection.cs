using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [JsonObject(MemberSerialization.OptIn)]
    [Table("ComProspection")]
    [Index(nameof(CfgProspectId), Name = "_dta_index_ComProspection_5_322100188__K9_65")]
    [Index(nameof(Pkey), Name = "_dta_index_ComProspection_7_322100188__K1_2")]
    [Index(nameof(Pkey), nameof(ComProspectionOriginSupportId), nameof(ComProspectionOriginId), nameof(ComActionId), Name = "_dta_index_ComProspection_7_322100188__K1_K61_K8_K60_2")]
    public partial class ComProspection
    {
        public ComProspection()
        {
            ComActionMessages = new HashSet<ComActionMessage>();
            ComFolderGifts = new HashSet<ComFolderGift>();
            ComFolders = new HashSet<ComFolder>();
            ComOffers = new HashSet<ComOffer>();
            ComProspectionCategories = new HashSet<ComProspectionCategory>();
            ComProspectionCities = new HashSet<ComProspectionCity>();
            ComProspectionProjects = new HashSet<ComProspectionProject>();
            ComProspectionSelectedProfiles = new HashSet<ComProspectionSelectedProfile>();
            ComProspectionTypes = new HashSet<ComProspectionType>();
            RntFolders = new HashSet<RntFolder>();
        }

        [Key]
        [JsonProperty]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        public Guid? ComProspectionOriginId { get; set; }
        public Guid? CfgProspectId { get; set; }
        [StringLength(1000)]
        [JsonProperty]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaTo { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceTo { get; set; }
        public Guid? StkVocationId { get; set; }
        public Guid? ComProspectionKindId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingOwnBase { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingCredit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FundingOther { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        [JsonProperty]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComActionId { get; set; }
        public Guid? ComProspectionOriginSupportId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AlertValidityDate { get; set; }
        [StringLength(255)]
        public string AlertMessage { get; set; }
        [JsonProperty]
        public Guid? CfgCommercialId { get; set; }
        [JsonProperty]
        public Guid? StkHierarchyId { get; set; }
        [JsonProperty]
        public Guid? StkItemId { get; set; }
        [JsonProperty]
        public bool? IsClosed { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        public Guid? ComProspectionClosingReasonId { get; set; }
        [StringLength(255)]
        public string ClosingReasonText { get; set; }
        public Guid? CfgProposerId { get; set; }
        public Guid? ComActionMessageTypeId { get; set; }
        public bool? IsOldCustomer { get; set; }
        public bool? IsPreProspection { get; set; }
        [StringLength(255)]
        public string TempDescription { get; set; }
        [Column("TempEMail")]
        [StringLength(255)]
        public string TempEmail { get; set; }
        [StringLength(255)]
        public string TempTel { get; set; }
        [StringLength(255)]
        public string TempField1 { get; set; }
        [StringLength(255)]
        public string TempField2 { get; set; }
        [StringLength(255)]
        public string TempField3 { get; set; }
        [StringLength(255)]
        public string TempField4 { get; set; }
        [StringLength(255)]
        public string TempField5 { get; set; }
        [StringLength(255)]
        public string TempField6 { get; set; }
        [StringLength(255)]
        public string TempField7 { get; set; }
        [StringLength(255)]
        public string TempField8 { get; set; }
        [StringLength(255)]
        public string TempField9 { get; set; }
        [StringLength(255)]
        public string TempField10 { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? AdmCountryId { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLatitude { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLongitude { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapRadius { get; set; }
        public Guid? CfgIntermediateId { get; set; }
        public Guid? ComPaymentMethodId { get; set; }

        [ForeignKey(nameof(AdmCountryId))]
        [InverseProperty("ComProspections")]
        public virtual AdmCountry AdmCountry { get; set; }
        [ForeignKey(nameof(CfgCommercialId))]
        [InverseProperty(nameof(CfgTier.ComProspectionCfgCommercials))]
        public virtual CfgTier CfgCommercial { get; set; }
        [ForeignKey(nameof(CfgIntermediateId))]
        [InverseProperty(nameof(CfgTier.ComProspectionCfgIntermediates))]
        public virtual CfgTier CfgIntermediate { get; set; }
        [ForeignKey(nameof(CfgProposerId))]
        [InverseProperty(nameof(CfgTier.ComProspectionCfgProposers))]
        public virtual CfgTier CfgProposer { get; set; }
        [ForeignKey(nameof(CfgProspectId))]
        [InverseProperty(nameof(CfgTier.ComProspectionCfgProspects))]
        public virtual CfgTier CfgProspect { get; set; }
        [ForeignKey(nameof(ComActionId))]
        [InverseProperty("ComProspections")]
        public virtual ComAction ComAction { get; set; }
        [ForeignKey(nameof(ComActionMessageTypeId))]
        [InverseProperty("ComProspections")]
        public virtual ComActionMessageType ComActionMessageType { get; set; }
        [ForeignKey(nameof(ComPaymentMethodId))]
        [InverseProperty("ComProspections")]
        public virtual ComPaymentMethod ComPaymentMethod { get; set; }
        [ForeignKey(nameof(ComProspectionClosingReasonId))]
        [InverseProperty("ComProspections")]
        public virtual ComProspectionClosingReason ComProspectionClosingReason { get; set; }
        [ForeignKey(nameof(ComProspectionKindId))]
        [InverseProperty("ComProspections")]
        [JsonProperty]
        public virtual ComProspectionKind ComProspectionKind { get; set; }
        [ForeignKey(nameof(ComProspectionOriginId))]
        [InverseProperty("ComProspections")]
        [JsonProperty]
        public virtual ComProspectionOrigin ComProspectionOrigin { get; set; }
        [ForeignKey(nameof(ComProspectionOriginSupportId))]
        [InverseProperty("ComProspections")]
        public virtual ComProspectionOriginSupport ComProspectionOriginSupport { get; set; }
        [ForeignKey(nameof(StkHierarchyId))]
        [InverseProperty(nameof(CfgTranche.ComProspections))]
        [JsonProperty]
        public virtual CfgTranche StkHierarchy { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComProspections")]
        [JsonProperty]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("ComProspections")]
        public virtual StkVocation StkVocation { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("ComProspections")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComProspection))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComFolderGift.ComProspection))]
        public virtual ICollection<ComFolderGift> ComFolderGifts { get; set; }
        [InverseProperty(nameof(ComFolder.ComProspection))]
        public virtual ICollection<ComFolder> ComFolders { get; set; }
        [InverseProperty(nameof(ComOffer.ComProspection))]
        public virtual ICollection<ComOffer> ComOffers { get; set; }
        [InverseProperty(nameof(ComProspectionCategory.ComProspection))]
        public virtual ICollection<ComProspectionCategory> ComProspectionCategories { get; set; }
        [InverseProperty(nameof(ComProspectionCity.ComProspection))]
        public virtual ICollection<ComProspectionCity> ComProspectionCities { get; set; }
        [InverseProperty(nameof(ComProspectionProject.ComProspection))]
        public virtual ICollection<ComProspectionProject> ComProspectionProjects { get; set; }
        [InverseProperty(nameof(ComProspectionSelectedProfile.ComProspection))]
        public virtual ICollection<ComProspectionSelectedProfile> ComProspectionSelectedProfiles { get; set; }
        [InverseProperty(nameof(ComProspectionType.ComProspection))]
        public virtual ICollection<ComProspectionType> ComProspectionTypes { get; set; }
        [InverseProperty(nameof(RntFolder.ComProspection))]
        public virtual ICollection<RntFolder> RntFolders { get; set; }
    }
}
