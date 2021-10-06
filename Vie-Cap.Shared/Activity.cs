using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vie_Cap.Shared
{
    public class Activity
    {
        [Key]
        public int A_Id { get; set; }
        public string Name { get; set; }
        public ICollection<Company> companies { get; set; }

    }
}
