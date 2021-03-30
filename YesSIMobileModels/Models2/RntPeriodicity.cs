using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntPeriodicity")]
    public partial class RntPeriodicity
    {
        public RntPeriodicity()
        {
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
            RntDocuments = new HashSet<RntDocument>();
            RntFolderClauseLines = new HashSet<RntFolderClauseLine>();
            RntFolderClauseRntDocuments = new HashSet<RntFolderClauseRntDocument>();
            RntFolderRntPeriodicities = new HashSet<RntFolder>();
            RntFolderRntPeriodicityReverses = new HashSet<RntFolder>();
            StkItems = new HashSet<StkItem>();
            SynFolderClauseLines = new HashSet<SynFolderClauseLine>();
            SynFolderClauseRntDocuments = new HashSet<SynFolderClauseRntDocument>();
            SynFolders = new HashSet<SynFolder>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? MonthNumber { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string Unity { get; set; }

        [InverseProperty(nameof(PrmRequestOffer.RntPeriodicity))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
        [InverseProperty(nameof(RntDocument.RntPeriodicity))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
        [InverseProperty(nameof(RntFolderClauseLine.RntPeriodicity))]
        public virtual ICollection<RntFolderClauseLine> RntFolderClauseLines { get; set; }
        [InverseProperty(nameof(RntFolderClauseRntDocument.RntPeriodicity))]
        public virtual ICollection<RntFolderClauseRntDocument> RntFolderClauseRntDocuments { get; set; }
        [InverseProperty(nameof(RntFolder.RntPeriodicity))]
        public virtual ICollection<RntFolder> RntFolderRntPeriodicities { get; set; }
        [InverseProperty(nameof(RntFolder.RntPeriodicityReverse))]
        public virtual ICollection<RntFolder> RntFolderRntPeriodicityReverses { get; set; }
        [InverseProperty(nameof(StkItem.RntPeriodicity))]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(SynFolderClauseLine.RntPeriodicity))]
        public virtual ICollection<SynFolderClauseLine> SynFolderClauseLines { get; set; }
        [InverseProperty(nameof(SynFolderClauseRntDocument.RntPeriodicity))]
        public virtual ICollection<SynFolderClauseRntDocument> SynFolderClauseRntDocuments { get; set; }
        [InverseProperty(nameof(SynFolder.RntPeriodicity))]
        public virtual ICollection<SynFolder> SynFolders { get; set; }
    }
}
