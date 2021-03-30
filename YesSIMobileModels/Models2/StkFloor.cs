using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFloor")]
    public partial class StkFloor
    {
        public StkFloor()
        {
            ComFolderItems = new HashSet<ComFolderItem>();
            ComSaleWithdrawalProductNewUnderItems = new HashSet<ComSaleWithdrawalProductNewUnderItem>();
            ComSaleWithdrawalProductUnderItems = new HashSet<ComSaleWithdrawalProductUnderItem>();
            RntFolderItems = new HashSet<RntFolderItem>();
            StkHierarchyPaths = new HashSet<StkHierarchyPath>();
            StkHierarchyPlans = new HashSet<StkHierarchyPlan>();
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

        [InverseProperty(nameof(ComFolderItem.StkFloor))]
        public virtual ICollection<ComFolderItem> ComFolderItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductNewUnderItem.StkFloor))]
        public virtual ICollection<ComSaleWithdrawalProductNewUnderItem> ComSaleWithdrawalProductNewUnderItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductUnderItem.StkFloor))]
        public virtual ICollection<ComSaleWithdrawalProductUnderItem> ComSaleWithdrawalProductUnderItems { get; set; }
        [InverseProperty(nameof(RntFolderItem.StkFloor))]
        public virtual ICollection<RntFolderItem> RntFolderItems { get; set; }
        [InverseProperty(nameof(StkHierarchyPath.StkFloor))]
        public virtual ICollection<StkHierarchyPath> StkHierarchyPaths { get; set; }
        [InverseProperty(nameof(StkHierarchyPlan.StkFloor))]
        public virtual ICollection<StkHierarchyPlan> StkHierarchyPlans { get; set; }
        [InverseProperty(nameof(StkItem.StkFloor))]
        public virtual ICollection<StkItem> StkItems { get; set; }
    }
}
