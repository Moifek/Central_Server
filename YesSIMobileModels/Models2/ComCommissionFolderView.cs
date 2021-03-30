using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComCommissionFolderView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public Guid ComFolderStatusId { get; set; }
        [StringLength(255)]
        public string StatusDescription { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid StkItemCategoryId { get; set; }
        [StringLength(255)]
        public string StkItemCategoryDescription { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [StringLength(255)]
        public string CfgCustomerDescription { get; set; }
        public Guid? CfgCommercialId { get; set; }
        [StringLength(255)]
        public string CfgCommercialDescription { get; set; }
        public bool? IsExtern { get; set; }
        public Guid? CfgSaleManagerId { get; set; }
        [StringLength(255)]
        public string CfgSaleManagerDescription { get; set; }
        public bool? IsSaleManagerExtern { get; set; }
        public Guid? CfgSaleManager2Id { get; set; }
        [StringLength(255)]
        public string CfgSaleManager2Description { get; set; }
        public bool? IsSaleManager2Extern { get; set; }
        public Guid CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? ComProspectionId { get; set; }
        [StringLength(255)]
        public string ComProspectionCode { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AdvanceDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgreementSavingDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AgreementDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CancelDate { get; set; }
        [Column(TypeName = "decimal(38, 16)")]
        public decimal? CommissionDeliveryAmount { get; set; }
        [Column(TypeName = "decimal(38, 16)")]
        public decimal? CommissionDelivery2Amount { get; set; }
        [Column(TypeName = "decimal(38, 16)")]
        public decimal? CommissionConcretisationAmount { get; set; }
        [Column(TypeName = "decimal(38, 16)")]
        public decimal? CommissionCancellationAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceAfterDiscount { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}
