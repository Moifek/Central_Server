using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlCurrencyConversion")]
    public partial class StlCurrencyConversion
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? StlCurrencyFromId { get; set; }
        public Guid? StlCurrencyToId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConvertValue { get; set; }
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
        public int? Unit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConvertValueBuy { get; set; }

        [ForeignKey(nameof(StlCurrencyFromId))]
        [InverseProperty(nameof(StlCurrency.StlCurrencyConversionStlCurrencyFroms))]
        public virtual StlCurrency StlCurrencyFrom { get; set; }
        [ForeignKey(nameof(StlCurrencyToId))]
        [InverseProperty(nameof(StlCurrency.StlCurrencyConversionStlCurrencyTos))]
        public virtual StlCurrency StlCurrencyTo { get; set; }
    }
}
