using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyMonitoringWarrantyView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid ObjectId { get; set; }
        [StringLength(255)]
        public string ObjectPath { get; set; }
        [StringLength(255)]
        public string ObjectForm { get; set; }
        [Column(TypeName = "decimal(37, 6)")]
        public decimal? AmountRetained { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountPenality { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRefunded { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public Guid? BuyConsultationId { get; set; }
        [StringLength(255)]
        public string BuyConsultationCode { get; set; }
        [StringLength(255)]
        public string BuyConsultationDescription { get; set; }
    }
}
