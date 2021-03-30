using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkOrientation")]
    public partial class StkOrientation
    {
        public StkOrientation()
        {
            ComFolderItems = new HashSet<ComFolderItem>();
            ComSaleWithdrawalProductNewUnderItems = new HashSet<ComSaleWithdrawalProductNewUnderItem>();
            ComSaleWithdrawalProductUnderItems = new HashSet<ComSaleWithdrawalProductUnderItem>();
            LndLands = new HashSet<LndLand>();
            RntFolderItems = new HashSet<RntFolderItem>();
            StkItems = new HashSet<StkItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
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

        [InverseProperty(nameof(ComFolderItem.StkOrientation))]
        public virtual ICollection<ComFolderItem> ComFolderItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductNewUnderItem.StkOrientation))]
        public virtual ICollection<ComSaleWithdrawalProductNewUnderItem> ComSaleWithdrawalProductNewUnderItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductUnderItem.StkOrientation))]
        public virtual ICollection<ComSaleWithdrawalProductUnderItem> ComSaleWithdrawalProductUnderItems { get; set; }
        [InverseProperty(nameof(LndLand.StkOrientation))]
        public virtual ICollection<LndLand> LndLands { get; set; }
        [InverseProperty(nameof(RntFolderItem.StkOrientation))]
        public virtual ICollection<RntFolderItem> RntFolderItems { get; set; }
        [InverseProperty(nameof(StkItem.StkOrientation))]
        public virtual ICollection<StkItem> StkItems { get; set; }
    }
}
