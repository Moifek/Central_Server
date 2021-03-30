using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyFolder")]
    public partial class BuyFolder
    {
        public BuyFolder()
        {
            BuyDocuments = new HashSet<BuyDocument>();
            BuyFolderPrjProjectVentilations = new HashSet<BuyFolderPrjProjectVentilation>();
            ComActions = new HashSet<ComAction>();
        }

        [Key]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsClosed { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }

        [InverseProperty(nameof(BuyDocument.BuyFolder))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuyFolderPrjProjectVentilation.BuyFolder))]
        public virtual ICollection<BuyFolderPrjProjectVentilation> BuyFolderPrjProjectVentilations { get; set; }
        [InverseProperty(nameof(ComAction.BuyFolder))]
        public virtual ICollection<ComAction> ComActions { get; set; }
    }
}
