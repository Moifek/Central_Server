using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    public partial class AdmWebLanguage
    {
        public AdmWebLanguage()
        {
            AdmWebCultures = new HashSet<AdmWebCulture>();
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

        [InverseProperty(nameof(AdmWebCulture.Language))]
        public virtual ICollection<AdmWebCulture> AdmWebCultures { get; set; }
        [InverseProperty(nameof(AdmWebSystemParam.Language))]
        public virtual ICollection<AdmWebSystemParam> AdmWebSystemParams { get; set; }
    }
}
