using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlDocumentVentilationSynFolderView
    {
        [Column("PKey")]
        public Guid? Pkey { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Rate { get; set; }
        public Guid StlDocumentId { get; set; }
        public Guid? SynFolderId { get; set; }
    }
}
