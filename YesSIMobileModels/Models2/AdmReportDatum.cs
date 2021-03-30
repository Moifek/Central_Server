using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(Code), nameof(CategoryId), Name = "U_Code", IsUnique = true)]
    [Index(nameof(Code), Name = "U_Code_AdmReportData", IsUnique = true)]
    public partial class AdmReportDatum
    {
        public AdmReportDatum()
        {
            AdmReportDataRoles = new HashSet<AdmReportDataRole>();
            ComFolderStatusReports = new HashSet<ComFolderStatusReport>();
            PrjMarketStatusReports = new HashSet<PrjMarketStatusReport>();
            StrNotifications = new HashSet<StrNotification>();
            StrReports = new HashSet<StrReport>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Type { get; set; }
        public bool? IsSystem { get; set; }
        [Column(TypeName = "image")]
        public byte[] ReportFile { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string GroupName { get; set; }
        public Guid? CfgImageId { get; set; }
        public Guid? CategoryId { get; set; }
        [StringLength(255)]
        public string Category { get; set; }
        public bool? OpenBeeSendActivated { get; set; }
        public int? OpenBeeFolderId { get; set; }

        [ForeignKey(nameof(CfgImageId))]
        [InverseProperty("AdmReportData")]
        public virtual CfgImage CfgImage { get; set; }
        [InverseProperty(nameof(AdmReportDataRole.AdmReportData))]
        public virtual ICollection<AdmReportDataRole> AdmReportDataRoles { get; set; }
        [InverseProperty(nameof(ComFolderStatusReport.AdmReportData))]
        public virtual ICollection<ComFolderStatusReport> ComFolderStatusReports { get; set; }
        [InverseProperty(nameof(PrjMarketStatusReport.AdmReportData))]
        public virtual ICollection<PrjMarketStatusReport> PrjMarketStatusReports { get; set; }
        [InverseProperty(nameof(StrNotification.AdmReport))]
        public virtual ICollection<StrNotification> StrNotifications { get; set; }
        [InverseProperty(nameof(StrReport.AdmReport))]
        public virtual ICollection<StrReport> StrReports { get; set; }
    }
}
