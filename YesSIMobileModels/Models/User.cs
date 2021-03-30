using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YesSIMobileModels.Models
{
    public class User
    {
        [Required(ErrorMessage = "The UserName is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The Password is Required")]
        public string Password { get; set; }
    }
}
