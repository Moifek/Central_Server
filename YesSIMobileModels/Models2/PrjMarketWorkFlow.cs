using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketWorkFlow")]
    public partial class PrjMarketWorkFlow
    {
        public PrjMarketWorkFlow()
        {
            PrjMarketDocumentToAttaches = new HashSet<PrjMarketDocumentToAttach>();
            PrjMarketWorkFlowAdmRoles = new HashSet<PrjMarketWorkFlowAdmRole>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? PrjMarketStatusStartId { get; set; }
        public Guid? PrjMarketStatusEndId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(PrjMarketStatusEndId))]
        [InverseProperty(nameof(PrjMarketStatus.PrjMarketWorkFlowPrjMarketStatusEnds))]
        public virtual PrjMarketStatus PrjMarketStatusEnd { get; set; }
        [ForeignKey(nameof(PrjMarketStatusStartId))]
        [InverseProperty(nameof(PrjMarketStatus.PrjMarketWorkFlowPrjMarketStatusStarts))]
        public virtual PrjMarketStatus PrjMarketStatusStart { get; set; }
        [InverseProperty(nameof(PrjMarketDocumentToAttach.PrjMarketWorkFlow))]
        public virtual ICollection<PrjMarketDocumentToAttach> PrjMarketDocumentToAttaches { get; set; }
        [InverseProperty(nameof(PrjMarketWorkFlowAdmRole.PrjMarketWorkFlow))]
        public virtual ICollection<PrjMarketWorkFlowAdmRole> PrjMarketWorkFlowAdmRoles { get; set; }
    }
}
