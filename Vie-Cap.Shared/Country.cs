using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vie_Cap.Shared
{
    public class Country
    {
        [Key]
        public int C_ID { get; set; }
        public int Sk_Country { get; set; }
        public int Number { get; set; }
        public string Alpha2code { get; set; }
        public string Alpha3code { get; set; }
        public string Country_Name { get; set; }
        public ICollection<User> Users { get; set; }

        public ICollection<Company> companies { get; set; }

    }
}
