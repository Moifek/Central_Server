using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SavService")]
    public partial class SavService
    {
        public SavService()
        {
            StlItems = new HashSet<StlItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("PriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? PriceTtc { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? StkVocationId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? CfgServiceManagerId { get; set; }
        public Guid? SavOriginId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusValidityDate { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StlItemGroupId { get; set; }

        [ForeignKey(nameof(CfgServiceManagerId))]
        [InverseProperty(nameof(CfgTier.SavServices))]
        public virtual CfgTier CfgServiceManager { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("SavServices")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("SavServices")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(SavOriginId))]
        [InverseProperty("SavServices")]
        public virtual SavOrigin SavOrigin { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("SavServices")]
        public virtual StkVocation StkVocation { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("SavServices")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StlItemGroupId))]
        [InverseProperty("SavServices")]
        public virtual StlItemGroup StlItemGroup { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("SavServices")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("SavServices")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(StlItem.SavService))]
        public virtual ICollection<StlItem> StlItems { get; set; }
    }
}
