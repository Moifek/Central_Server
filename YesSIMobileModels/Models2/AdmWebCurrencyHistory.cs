using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(CurrencyId), Name = "IX_CurrencyId")]
    public partial class AdmWebCurrencyHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid CurrencyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EffectiveDate { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Rate { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CurrencyId))]
        [InverseProperty(nameof(AdmWebCurrency.AdmWebCurrencyHistories))]
        public virtual AdmWebCurrency Currency { get; set; }
    }
}
