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
    [Table("ComProspectionOrigin")]
    public partial class ComProspectionOrigin
    {
        public ComProspectionOrigin()
        {
            ComProspectionOriginSupports = new HashSet<ComProspectionOriginSupport>();
            ComProspections = new HashSet<ComProspection>();
            ComSaleWithdrawalCancellations = new HashSet<ComSaleWithdrawalCancellation>();
            ComSaleWithdrawalClients = new HashSet<ComSaleWithdrawalClient>();
            ComSaleWithdrawalProducts = new HashSet<ComSaleWithdrawalProduct>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
        }

        [Key]
        [Column("PKey")]
        [JsonProperty]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string Code { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsWithProposer { get; set; }
        public bool? IsWithGift { get; set; }
        public bool? IsWithSupport { get; set; }

        [InverseProperty(nameof(ComProspectionOriginSupport.ComProspectionOrigin))]
        public virtual ICollection<ComProspectionOriginSupport> ComProspectionOriginSupports { get; set; }
        [InverseProperty(nameof(ComProspection.ComProspectionOrigin))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalCancellation.ComProspectionOrigin))]
        public virtual ICollection<ComSaleWithdrawalCancellation> ComSaleWithdrawalCancellations { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClient.ComProspectionOrigin))]
        public virtual ICollection<ComSaleWithdrawalClient> ComSaleWithdrawalClients { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProduct.ComProspectionOrigin))]
        public virtual ICollection<ComSaleWithdrawalProduct> ComSaleWithdrawalProducts { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.ComProspectionOrigin))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
    }
}
