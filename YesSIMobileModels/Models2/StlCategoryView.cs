using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlCategoryView
    {
        [Column("PKey")]
        public Guid? Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string CodeCountable { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsCredit { get; set; }
        public Guid? ParentId { get; set; }
        public bool? IsWithoutPrevision { get; set; }
        public Guid? StlAccountId { get; set; }
        public int? Sorting { get; set; }
        public bool? IsCharge { get; set; }
        public int? Level { get; set; }
        [StringLength(255)]
        public string Path { get; set; }
        [StringLength(4000)]
        public string PathDescription { get; set; }
    }
}
