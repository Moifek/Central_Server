using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComActionMessageSubCategory")]
    public partial class ComActionMessageSubCategory
    {
        public ComActionMessageSubCategory()
        {
            AdmEvents = new HashSet<AdmEvent>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComProspectionKinds = new HashSet<ComProspectionKind>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? ComActionMessageCategoryId { get; set; }
        public bool? IsRevivalMandatory { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComActionMessageSubCategoryStatusId { get; set; }
        public bool? UpdateFinancialSchema { get; set; }

        [ForeignKey(nameof(ComActionMessageCategoryId))]
        [InverseProperty("ComActionMessageSubCategories")]
        public virtual ComActionMessageCategory ComActionMessageCategory { get; set; }
        [ForeignKey(nameof(ComActionMessageSubCategoryStatusId))]
        [InverseProperty("ComActionMessageSubCategories")]
        public virtual ComActionMessageSubCategoryStatus ComActionMessageSubCategoryStatus { get; set; }
        [InverseProperty(nameof(AdmEvent.ComActionMessageSubCategory))]
        public virtual ICollection<AdmEvent> AdmEvents { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComActionMessageSubCategory))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComProspectionKind.ComActionMessageSubCategory))]
        public virtual ICollection<ComProspectionKind> ComProspectionKinds { get; set; }
    }
}
