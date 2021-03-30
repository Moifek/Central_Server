using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    public partial class AdmWebCountry
    {
        public AdmWebCountry()
        {
            AdmWebSystemParams = new HashSet<AdmWebSystemParam>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public string Code { get; set; }
        [Column("ISOAlpha3")]
        public string Isoalpha3 { get; set; }
        public string Description { get; set; }
        [Column("Description_an")]
        public string DescriptionAn { get; set; }
        [Column("ISOName")]
        public string Isoname { get; set; }
        public string NationCode { get; set; }
        public string PhoneCode { get; set; }
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(AdmWebSystemParam.Country))]
        public virtual ICollection<AdmWebSystemParam> AdmWebSystemParams { get; set; }
    }
}
