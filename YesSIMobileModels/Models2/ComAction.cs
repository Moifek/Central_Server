using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComAction")]
    public partial class ComAction
    {
        public ComAction()
        {
            ComActionCfgTranches = new HashSet<ComActionCfgTranche>();
            ComProspections = new HashSet<ComProspection>();
            ComSalesCommissions = new HashSet<ComSalesCommission>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? BuyFolderId { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Budget { get; set; }
        public bool? CanAddTotalCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalCost { get; set; }

        [ForeignKey(nameof(BuyFolderId))]
        [InverseProperty("ComActions")]
        public virtual BuyFolder BuyFolder { get; set; }
        [ForeignKey(nameof(CfgEmployeeId))]
        [InverseProperty(nameof(CfgTier.ComActions))]
        public virtual CfgTier CfgEmployee { get; set; }
        [InverseProperty(nameof(ComActionCfgTranche.ComAction))]
        public virtual ICollection<ComActionCfgTranche> ComActionCfgTranches { get; set; }
        [InverseProperty(nameof(ComProspection.ComAction))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(ComSalesCommission.ComAction))]
        public virtual ICollection<ComSalesCommission> ComSalesCommissions { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.ComAction))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
    }
}
