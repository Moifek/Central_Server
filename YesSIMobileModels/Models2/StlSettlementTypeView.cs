using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlSettlementTypeView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsReferenceUnique { get; set; }
        public bool? IsReferenceMandatory { get; set; }
        public bool? IsBankMandatory { get; set; }
        public bool? IsNotContabilized { get; set; }
        public bool? IsDeposit { get; set; }
        public bool? IsAccount { get; set; }
        public bool? IsTierUnique { get; set; }
        [StringLength(255)]
        public string RefFormat { get; set; }
        public bool? IsLawyerMandatory { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }
        public Guid? ActAccountCreditId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountCreditCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountCreditDescription { get; set; }
        [StringLength(514)]
        public string ActAccountCreditLabel { get; set; }
        public Guid? ActAccountDebitId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountDebitCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountDebitDescription { get; set; }
        [StringLength(514)]
        public string ActAccountDebitLabel { get; set; }
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
