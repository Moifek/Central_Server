using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgImage")]
    public partial class CfgImage
    {
        public CfgImage()
        {
            AdmReportData = new HashSet<AdmReportDatum>();
            BuyDocumentStatuses = new HashSet<BuyDocumentStatus>();
            RntFolderStatuses = new HashSet<RntFolderStatus>();
            StkFeasibilityStudyStatuses = new HashSet<StkFeasibilityStudyStatus>();
            SynFolderStatuses = new HashSet<SynFolderStatus>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column(TypeName = "image")]
        public byte[] ImageData { get; set; }

        [InverseProperty(nameof(AdmReportDatum.CfgImage))]
        public virtual ICollection<AdmReportDatum> AdmReportData { get; set; }
        [InverseProperty(nameof(BuyDocumentStatus.CfgImage))]
        public virtual ICollection<BuyDocumentStatus> BuyDocumentStatuses { get; set; }
        [InverseProperty(nameof(RntFolderStatus.CfgImage))]
        public virtual ICollection<RntFolderStatus> RntFolderStatuses { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyStatus.CfgImage))]
        public virtual ICollection<StkFeasibilityStudyStatus> StkFeasibilityStudyStatuses { get; set; }
        [InverseProperty(nameof(SynFolderStatus.CfgImage))]
        public virtual ICollection<SynFolderStatus> SynFolderStatuses { get; set; }
    }
}
