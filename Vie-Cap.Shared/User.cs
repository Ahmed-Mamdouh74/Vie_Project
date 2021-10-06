using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vie_Cap.Shared
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBrith { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public bool IsConfirmed { get; set; }
        public int National_ID { get; set; }

        [ForeignKey("Country")]

        public Nullable<int> C_ID { get; set; }

        public virtual Country Country { get; set; }

        public string JopTitle { get; set; }
        public float OwnerShip { get; set; }
        public string Phone { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }



    }

}
