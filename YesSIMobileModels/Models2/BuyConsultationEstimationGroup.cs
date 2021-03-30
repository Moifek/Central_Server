using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyConsultationEstimationGroup")]
    public partial class BuyConsultationEstimationGroup
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? BuyConsultationId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IsStock { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }

        [ForeignKey(nameof(BuyConsultationId))]
        [InverseProperty("BuyConsultationEstimationGroups")]
        public virtual BuyConsultation BuyConsultation { get; set; }
    }
}
