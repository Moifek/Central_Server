using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkCostCategory")]
    public partial class StkCostCategory
    {
        public StkCostCategory()
        {
            ComFolderItems = new HashSet<ComFolderItem>();
            ComOfferItems = new HashSet<ComOfferItem>();
            ComSaleWithdrawalProductNewUnderItems = new HashSet<ComSaleWithdrawalProductNewUnderItem>();
            ComSaleWithdrawalProductUnderItems = new HashSet<ComSaleWithdrawalProductUnderItem>();
            PrjCoefficientCosts = new HashSet<PrjCoefficientCost>();
            RntFolderItems = new HashSet<RntFolderItem>();
            StkItems = new HashSet<StkItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(ComFolderItem.StkCostCategory))]
        public virtual ICollection<ComFolderItem> ComFolderItems { get; set; }
        [InverseProperty(nameof(ComOfferItem.StkCostCategory))]
        public virtual ICollection<ComOfferItem> ComOfferItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductNewUnderItem.StkCostCategory))]
        public virtual ICollection<ComSaleWithdrawalProductNewUnderItem> ComSaleWithdrawalProductNewUnderItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductUnderItem.StkCostCategory))]
        public virtual ICollection<ComSaleWithdrawalProductUnderItem> ComSaleWithdrawalProductUnderItems { get; set; }
        [InverseProperty(nameof(PrjCoefficientCost.StkCostCategory))]
        public virtual ICollection<PrjCoefficientCost> PrjCoefficientCosts { get; set; }
        [InverseProperty(nameof(RntFolderItem.StkCostCategory))]
        public virtual ICollection<RntFolderItem> RntFolderItems { get; set; }
        [InverseProperty(nameof(StkItem.StkCostCategory))]
        public virtual ICollection<StkItem> StkItems { get; set; }
    }
}
