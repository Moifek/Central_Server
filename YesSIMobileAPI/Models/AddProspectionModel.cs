using System;
using System.Collections.Generic;
using YesSIMobileModels.Models2;
using System.Linq;
using System.Threading.Tasks;

namespace YesSIMobileAPI.Models
{
    public partial class AddProspectionModel
    {
#nullable enable
        public ComProspection? Prospections { get; set; } = new();
#nullable enable
        public YesSIMobileModels.Models2.CfgTier? Tier { get; set; } = new();
#nullable enable
        public AdmUser? user { get; set; } = new();
#nullable enable
        public ComProspectionCategory? Category { get; set; } = new();
#nullable enable
        public ComProspectionType? Type { get; set; } = new();

        public AddProspectionModel(YesSIMobileModels.Models2.CfgTier person, ComProspection Prospection, AdmUser user, ComProspectionCategory Category, ComProspectionType type)
        {
            Tier = person; Prospections = Prospection; ; this.user = user; this.Category = Category; this.Type = type;
        }

    }
             
        
        
}
