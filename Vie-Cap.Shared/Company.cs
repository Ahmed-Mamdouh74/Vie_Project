using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vie_Cap.Shared
{
    public class Company
    {
        [Key]
        public int Cop_ID { get; set; }
        public string Company_Name { get; set; }
        public string Web_Site { get; set; }

        public string Legal_Bussiness { get; set; }
        [ForeignKey("Activity")]

        public int A_Id { get; set; }
        public Activity Activity { get; set; }
        public string Describe { get; set; }
        public string Major { get; set; }

        public bool Isvolved { get; set; }
        [ForeignKey("Country")]
        public int C_ID { get; set; }
        public virtual Country Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }


    }

}
