using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyFolderPrjProjectVentilation")]
    public partial class BuyFolderPrjProjectVentilation
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? BuyFolderId { get; set; }
        public Guid? PrjProjectId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VentilationRate { get; set; }

        [ForeignKey(nameof(BuyFolderId))]
        [InverseProperty("BuyFolderPrjProjectVentilations")]
        public virtual BuyFolder BuyFolder { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("BuyFolderPrjProjectVentilations")]
        public virtual PrjProject PrjProject { get; set; }
    }
}
