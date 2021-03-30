using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlDeposit")]
    public partial class StlDeposit
    {
        public StlDeposit()
        {
            ActDefaultSettlements = new HashSet<ActDefaultSettlement>();
            StlAcountDepositStlDepositTos = new HashSet<StlAcountDeposit>();
            StlAcountDepositStlDeposits = new HashSet<StlAcountDeposit>();
            StlDepositUsers = new HashSet<StlDepositUser>();
            StlSettlements = new HashSet<StlSettlement>();
            StlSlips = new HashSet<StlSlip>();
            StlTransmissionSheetStlDepositFroms = new HashSet<StlTransmissionSheet>();
            StlTransmissionSheetStlDepositTos = new HashSet<StlTransmissionSheet>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsBank { get; set; }
        public bool? IsSupplier { get; set; }
        public bool? IsCustomer { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlDeposits")]
        public virtual CfgCompany CfgCompany { get; set; }
        [InverseProperty(nameof(ActDefaultSettlement.StlDeposit))]
        public virtual ICollection<ActDefaultSettlement> ActDefaultSettlements { get; set; }
        [InverseProperty(nameof(StlAcountDeposit.StlDepositTo))]
        public virtual ICollection<StlAcountDeposit> StlAcountDepositStlDepositTos { get; set; }
        [InverseProperty(nameof(StlAcountDeposit.StlDeposit))]
        public virtual ICollection<StlAcountDeposit> StlAcountDepositStlDeposits { get; set; }
        [InverseProperty(nameof(StlDepositUser.StlDeposit))]
        public virtual ICollection<StlDepositUser> StlDepositUsers { get; set; }
        [InverseProperty(nameof(StlSettlement.StlDeposit))]
        public virtual ICollection<StlSettlement> StlSettlements { get; set; }
        [InverseProperty(nameof(StlSlip.StlDeposit))]
        public virtual ICollection<StlSlip> StlSlips { get; set; }
        [InverseProperty(nameof(StlTransmissionSheet.StlDepositFrom))]
        public virtual ICollection<StlTransmissionSheet> StlTransmissionSheetStlDepositFroms { get; set; }
        [InverseProperty(nameof(StlTransmissionSheet.StlDepositTo))]
        public virtual ICollection<StlTransmissionSheet> StlTransmissionSheetStlDepositTos { get; set; }
    }
}
