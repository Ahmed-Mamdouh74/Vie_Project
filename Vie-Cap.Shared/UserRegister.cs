using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vie_Cap.Shared
{
    public class UserRegister
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public String FristName { get; set; }
        [Required]
        public String LastName { get; set; }

        public int National_ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Error the password do not match")]
        public string ConfirmPassword { get; set; }
        [Required]
        public DateTime DateOfBrith { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        [Range(typeof(bool), "true", "true", ErrorMessage = " confirmed user. ")]
        public bool IsConfirmed { get; set; } = true;
    }

}
