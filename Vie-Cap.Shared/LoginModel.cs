using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vie_Cap.Shared
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter the email")]
        public String Email { get; set; }
        [Required]

        public string Password { get; set; }

    }

}
