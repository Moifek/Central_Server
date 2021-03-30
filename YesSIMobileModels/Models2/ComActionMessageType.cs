using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComActionMessageType")]
    public partial class ComActionMessageType
    {
        public ComActionMessageType()
        {
            ComActionMessages = new HashSet<ComActionMessage>();
            ComProspections = new HashSet<ComProspection>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
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
        public bool? IsSystem { get; set; }

        [InverseProperty(nameof(ComActionMessage.ComActionMessageType))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComProspection.ComActionMessageType))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.ComActionMessageType))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
    }
}
