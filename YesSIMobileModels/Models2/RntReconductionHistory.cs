using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntReconductionHistory")]
    [Index(nameof(Pkey), nameof(PeriodicityBeginDate), Name = "_dta_index_RntReconductionHistory_5_1522156518__K1_K8_9")]
    [Index(nameof(SynFolderId), nameof(Pkey), nameof(PeriodicityBeginDate), Name = "_dta_index_RntReconductionHistory_5_1522156518__K32_K1_K8_9")]
    [Index(nameof(PeriodicityBeginDate), Name = "_dta_index_RntReconductionHistory_5_1522156518__K8_1_9_31")]
    public partial class RntReconductionHistory
    {
        public RntReconductionHistory()
        {
            RntDocuments = new HashSet<RntDocument>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodicityBeginDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodicityEndDate { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("RntReconductionHistories")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(SynFolderId))]
        [InverseProperty("RntReconductionHistories")]
        public virtual SynFolder SynFolder { get; set; }
        [InverseProperty(nameof(RntDocument.RntReconductionHistory))]
        public virtual ICollection<RntDocument> RntDocuments { get; set; }
    }
}
