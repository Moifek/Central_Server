using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StrField")]
    public partial class StrField
    {
        public StrField()
        {
            StrStatusFields = new HashSet<StrStatusField>();
            StrWorkFlowFields = new HashSet<StrWorkFlowField>();
            StrWorkFlowTierFields = new HashSet<StrWorkFlowTierField>();
            StrWorkFlows = new HashSet<StrWorkFlow>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StrEntityId { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StrFields")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(StrStatusField.StrField))]
        public virtual ICollection<StrStatusField> StrStatusFields { get; set; }
        [InverseProperty(nameof(StrWorkFlowField.StrField))]
        public virtual ICollection<StrWorkFlowField> StrWorkFlowFields { get; set; }
        [InverseProperty(nameof(StrWorkFlowTierField.StrField))]
        public virtual ICollection<StrWorkFlowTierField> StrWorkFlowTierFields { get; set; }
        [InverseProperty(nameof(StrWorkFlow.StrFieldDate))]
        public virtual ICollection<StrWorkFlow> StrWorkFlows { get; set; }
    }
}
