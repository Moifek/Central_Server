using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class AdmParamsView
    {
        [Required]
        [StringLength(1000)]
        public string CurrencyLabel { get; set; }
        [Required]
        [StringLength(1000)]
        public string CurrencyFraction { get; set; }
        public int CurrencyDecimalDigits { get; set; }
    }
}
