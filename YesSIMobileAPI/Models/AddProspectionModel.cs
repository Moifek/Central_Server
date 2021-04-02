using System;
using System.Collections.Generic;
using YesSIMobileModels.Models2;
using System.Linq;
using System.Threading.Tasks;

namespace YesSIMobileAPI.Models
{
    public partial class AddProspectionModel
    {
        public ComProspection Prospections { get; set; } = new();
        public CfgTier Tier { get; set; } = new();

        public AdmUser user { get; set; } = new();

        public ComProspectionCategory Category { get; set; }

        public ComProspectionType Type { get; set; }

        public AddProspectionModel(CfgTier person, ComProspection Prospection, AdmUser user, ComProspectionCategory Category, ComProspectionType type)
        {
            Tier = person; Prospections = Prospection; ; this.user = user; this.Category = Category; this.Type = type;
        }

    }
             
        
        
}
