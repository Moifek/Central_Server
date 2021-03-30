using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StkStockView
    {
        public Guid StkVocationId { get; set; }
        [StringLength(255)]
        public string StkVocationCode { get; set; }
        [StringLength(255)]
        public string StkVocationDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid StkItemCategoryId { get; set; }
        [StringLength(255)]
        public string StkItemCategoryCode { get; set; }
        [StringLength(255)]
        public string StkItemCategoryDescription { get; set; }
        public bool? IsUnderItem { get; set; }
        [Required]
        [StringLength(12)]
        public string IsUnderItemDescription { get; set; }
        public int CountItem { get; set; }
        public int CountItemFree { get; set; }
        public int CountUnderReserved { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal StockAreaFloor { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal StockPriceFloor { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal StockArea { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal StockPrice { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal SalePrice { get; set; }
    }
}
