using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(CountryId), Name = "IX_CountryId")]
    [Index(nameof(CultureId), Name = "IX_CultureId")]
    [Index(nameof(CurrencyId), Name = "IX_CurrencyId")]
    [Index(nameof(LanguageId), Name = "IX_LanguageId")]
    public partial class AdmWebSystemParam
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CultureId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? CurrencyId { get; set; }
        public Guid LanguageId { get; set; }
        public string DefaultMailFrom { get; set; }
        [Column("SMTPHost")]
        public string Smtphost { get; set; }
        [Column("SMTPPORT")]
        public int Smtpport { get; set; }
        public string ServerAddress { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty(nameof(AdmWebCountry.AdmWebSystemParams))]
        public virtual AdmWebCountry Country { get; set; }
        [ForeignKey(nameof(CultureId))]
        [InverseProperty(nameof(AdmWebCulture.AdmWebSystemParams))]
        public virtual AdmWebCulture Culture { get; set; }
        [ForeignKey(nameof(CurrencyId))]
        [InverseProperty(nameof(AdmWebCurrency.AdmWebSystemParams))]
        public virtual AdmWebCurrency Currency { get; set; }
        [ForeignKey(nameof(LanguageId))]
        [InverseProperty(nameof(AdmWebLanguage.AdmWebSystemParams))]
        public virtual AdmWebLanguage Language { get; set; }
    }
}
