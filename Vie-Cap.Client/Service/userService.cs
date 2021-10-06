using Blazored.LocalStorage;
using Blazored.Toast.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Vie_Cap.Shared;

namespace Vie_Cap.Client.Service
{
    public class userService : IuserService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _http;
        private readonly ILocalStorageService _LocalStorageService;

        public int National_ID { get ; set ; }
        public int C_ID { get; set; }
        public string JopTitle { get ; set ; }
        public float OwnerShip { get ; set ; }
        public string Phone { get ; set ; }
        public string ImageUrl { get ; set ; }
        public string Address { get; set ; }
        public string State { get ; set; }
        public int ZipCode { get; set ; }
        public List<UpdateUser> us { get; set; } = new List<UpdateUser>();

        public userService(IToastService toastService, HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _toastService = toastService;
            _http = httpClient;
            _LocalStorageService = localStorageService;
        }

        public event Action OnChange;
        void UserChanged() => OnChange.Invoke();

        public async Task<List<UpdateUser>> Edit (UpdateUser user, int id)
        {
            var U_Id = await _LocalStorageService.GetItemAsync<int>("id");
            id = U_Id;
            var result = await _http.PutAsJsonAsync($"https://localhost:44321/api/User/User/{id}",user);
            user.C_ID = await result.Content.ReadFromJsonAsync<int>();
            user.JopTitle = await result.Content.ReadFromJsonAsync<string>();
            user.National_ID = await result.Content.ReadFromJsonAsync<int>();
            user.OwnerShip = await result.Content.ReadFromJsonAsync<int>();
            user.Phone = await result.Content.ReadFromJsonAsync<string>();
            user.ImageUrl = await result.Content.ReadFromJsonAsync<string>();
            user.Address = await result.Content.ReadFromJsonAsync<string>();
            user.State = await result.Content.ReadFromJsonAsync<string>();
            user.ZipCode = await result.Content.ReadFromJsonAsync<int>();

            OnChange.Invoke();
            return us;
        }


        // public int U_Id { get; set; }

        public async Task<User> GetUserById(int id)
        {


         var  U_Id = await _LocalStorageService.GetItemAsync<int>("id");
          id = U_Id;
           
            return await _http.GetFromJsonAsync<Vie_Cap.Shared.User>($"https://localhost:44321/api/user/{id}");

        }
    }
}
