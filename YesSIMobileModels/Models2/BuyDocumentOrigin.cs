using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyDocumentOrigin")]
    public partial class BuyDocumentOrigin
    {
        [Key]
        public Guid Pkey { get; set; }
        public Guid? BuyDocumentId { get; set; }
        public Guid? BuyOriginId { get; set; }
        [StringLength(255)]
        public string BuyOrigin { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("BuyDocumentOrigins")]
        public virtual BuyDocument BuyDocument { get; set; }
    }
}
