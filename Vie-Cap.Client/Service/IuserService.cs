using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vie_Cap.Shared;

namespace Vie_Cap.Client.Service
{
    public interface IuserService
    {

        public int National_ID { get; set; }
        public int C_ID { get; set; }
        public string JopTitle { get; set; }
        public float OwnerShip { get; set; }
        public string Phone { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public List<Vie_Cap.Shared.UpdateUser> us { set; get; }

        Task<User> GetUserById(int id);

        //Task Edit(int id);
        Task<List<UpdateUser>> Edit(UpdateUser user, int id);

        event Action OnChange;


    }
}
