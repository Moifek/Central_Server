using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Index(nameof(LanguageId), Name = "IX_LanguageId")]
    public partial class AdmWebCulture
    {
        public AdmWebCulture()
        {
            AdmUsers = new HashSet<AdmUser2>();
            AdmWebSystemParams = new HashSet<AdmWebSystemParam>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string Code { get; set; }
        public string DateExtjsShortFormat { get; set; }
        public string DateExtjsLongFormat { get; set; }
        public string DateExtjsAltFormat { get; set; }
        public string DateShortFormat { get; set; }
        public string DateLongFormat { get; set; }
        public string DateSeparator { get; set; }
        public int? NumberNegativeFormat { get; set; }
        public int? NumberGrouping { get; set; }
        public int? NumberDecimalCount { get; set; }
        public string NumberGroupingSymbol { get; set; }
        public string NumberDecimalSymbol { get; set; }
        public string NumberNegativeSymbol { get; set; }
        public string NumberPosifiveSymbol { get; set; }
        public int? PercentageNegativeFormat { get; set; }
        public int? PercentagePositiveFormat { get; set; }
        public int? PercentageGroupingNumber { get; set; }
        public int? PercentageNumberofDecimal { get; set; }
        public string PercentageSymbol { get; set; }
        public string PercentageNumberGroupingSymbol { get; set; }
        public string PercentageDecimalSymbol { get; set; }
        public string PercentageThousandSymbol { get; set; }
        public string TimeExtjsFormat { get; set; }
        public string TimeShortFormat { get; set; }
        public string TimeLongFormat { get; set; }
        public string TimeSeparator { get; set; }
        public string TimeMorningSymbol { get; set; }
        public string TimeEveningSymbol { get; set; }
        public int? DeviceNegativeFormat { get; set; }
        public int? DevicePositiveFormat { get; set; }
        public int? DeviseGrouping { get; set; }
        public int? DeviseDecimalCount { get; set; }
        public string DeviseGroupingSymbol { get; set; }
        public string DeviseDecimalSymbol { get; set; }
        public Guid LanguageId { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(LanguageId))]
        [InverseProperty(nameof(AdmWebLanguage.AdmWebCultures))]
        public virtual AdmWebLanguage Language { get; set; }
        [InverseProperty(nameof(AdmUser2.WebCulture))]
        public virtual ICollection<AdmUser2> AdmUsers { get; set; }
        [InverseProperty(nameof(AdmWebSystemParam.Culture))]
        public virtual ICollection<AdmWebSystemParam> AdmWebSystemParams { get; set; }
    }
}
