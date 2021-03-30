using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkVocation")]
    public partial class StkVocation
    {
        public StkVocation()
        {
            ComFolderStatuses = new HashSet<ComFolderStatus>();
            ComFolderWorkFlows = new HashSet<ComFolderWorkFlow>();
            ComFolders = new HashSet<ComFolder>();
            ComProspections = new HashSet<ComProspection>();
            ComSettlementCategories = new HashSet<ComSettlementCategory>();
            RntFolders = new HashSet<RntFolder>();
            SavClaimGroups = new HashSet<SavClaimGroup>();
            SavServiceExpenses = new HashSet<SavServiceExpense>();
            SavServices = new HashSet<SavService>();
            StkItems = new HashSet<StkItem>();
            StlItemPricings = new HashSet<StlItemPricing>();
            SynFolders = new HashSet<SynFolder>();
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

        [InverseProperty(nameof(ComFolderStatus.StkVocation))]
        public virtual ICollection<ComFolderStatus> ComFolderStatuses { get; set; }
        [InverseProperty(nameof(ComFolderWorkFlow.StkVocation))]
        public virtual ICollection<ComFolderWorkFlow> ComFolderWorkFlows { get; set; }
        [InverseProperty(nameof(ComFolder.StkVocation))]
        public virtual ICollection<ComFolder> ComFolders { get; set; }
        [InverseProperty(nameof(ComProspection.StkVocation))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(ComSettlementCategory.StkVocation))]
        public virtual ICollection<ComSettlementCategory> ComSettlementCategories { get; set; }
        [InverseProperty(nameof(RntFolder.StkVocation))]
        public virtual ICollection<RntFolder> RntFolders { get; set; }
        [InverseProperty(nameof(SavClaimGroup.StkVocation))]
        public virtual ICollection<SavClaimGroup> SavClaimGroups { get; set; }
        [InverseProperty(nameof(SavServiceExpense.StkVocation))]
        public virtual ICollection<SavServiceExpense> SavServiceExpenses { get; set; }
        [InverseProperty(nameof(SavService.StkVocation))]
        public virtual ICollection<SavService> SavServices { get; set; }
        [InverseProperty(nameof(StkItem.StkVocation))]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(StlItemPricing.StkVocation))]
        public virtual ICollection<StlItemPricing> StlItemPricings { get; set; }
        [InverseProperty(nameof(SynFolder.StkVocation))]
        public virtual ICollection<SynFolder> SynFolders { get; set; }
    }
}
