using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlRecoveryFolder")]
    public partial class StlRecoveryFolder
    {
        public StlRecoveryFolder()
        {
            ComDocuments = new HashSet<ComDocument>();
            RntDocuments = new HashSet<RntDocument>();
            StlDocuments = new HashSet<StlDocument>();
            StlPaymentAuthorizations = new HashSet<StlPaymentAuthorization>();
            StlRecoveryFolderLines = new HashSet<StlRecoveryFolderLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? CfgCustomerId { get; set; }
        public Guid? CfgDebtManagerId { get; set; }
        public Guid? CfgDebtCollectorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusValidityDate { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlRecoveryFolders")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgCustomerId))]
        [InverseProperty(nameof(CfgTier.StlRecoveryFolderCfgCustomers))]
        public virtual CfgTier CfgCustomer { get; set; }
        [ForeignKey(nameof(CfgDebtCollectorId))]
        [InverseProperty(nameof(CfgTier.StlRecoveryFolderCfgDebtCollectors))]
        public virtual CfgTier CfgDebtCollector { get; set; }
        [ForeignKey(nameof(CfgDebtManagerId))]
        [InverseProperty(nameof(CfgTier.StlRecoveryFolderCfgDebtManagers))]
        public virtual CfgTier CfgDebtManager { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("StlRecoveryFolders")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("StlRecoveryFolders")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StlRecoveryFolders")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("StlRecoveryFolders")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(ComDocument.StlRecoveryFolder))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
        [InverseProperty(nameof(RntDocument.StlRecoveryFolder))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
        [InverseProperty(nameof(StlDocument.StlRecoveryFolder))]
        public virtual ICollection<StlDocument> StlDocuments { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorization.StlRecoveryFolder))]
        public virtual ICollection<StlPaymentAuthorization> StlPaymentAuthorizations { get; set; }
        [InverseProperty(nameof(StlRecoveryFolderLine.StlRecoveryFolder))]
        public virtual ICollection<StlRecoveryFolderLine> StlRecoveryFolderLines { get; set; }
    }
}
