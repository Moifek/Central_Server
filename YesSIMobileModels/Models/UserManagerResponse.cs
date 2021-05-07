using System;
using System.Collections.Generic;
using System.Text;

namespace YesSIMobileModels.Models
{
    public class UserManagerResponse
    {
        public string Message { get; set; }
        public string IsSuccess { get; set; }
        public Dictionary<string, string> UserInfo { get; set;}
        public string[] Errors { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
