using System;
using System.Collections.Generic;
using YesSIMobileModels.Models2;
using System.Linq;
using System.Threading.Tasks;

namespace YesSIMobileAPI.Models
{
    public class AddProspectionModel
    {
        public ComProspection Prospections { get; set; } = new();
        public CfgTier Tier { get; set; } = new();

        public AdmUser user { get; set; } = new();

        public AddProspectionModel(CfgTier person, ComProspection Prospection, AdmUser user)
        {
            Tier = person; Prospections = Prospection; ; this.user = user;
        }

    }
             
        
        
}
