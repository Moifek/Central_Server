using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    public partial class AdmWebCurrency
    {
        public AdmWebCurrency()
        {
            AdmWebCurrencyHistories = new HashSet<AdmWebCurrencyHistory>();
            AdmWebSystemParams = new HashSet<AdmWebSystemParam>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(AdmWebCurrencyHistory.Currency))]
        public virtual ICollection<AdmWebCurrencyHistory> AdmWebCurrencyHistories { get; set; }
        [InverseProperty(nameof(AdmWebSystemParam.Currency))]
        public virtual ICollection<AdmWebSystemParam> AdmWebSystemParams { get; set; }
    }
}
