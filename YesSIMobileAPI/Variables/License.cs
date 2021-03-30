using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YesSIMobileAPI.Variables
{
    public class License
    {
        public Guid _Pkey;
        public License(Guid pkey) => this._Pkey = pkey;

       public int ActiveUsers { get; set; }

        public void DecrementUsers()
        {
            ActiveUsers--;
        }


        
    }
}
