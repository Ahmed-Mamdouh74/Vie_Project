using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Vie_Cap.Shared;

namespace Vie_Cap.Client.Service
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
        private readonly ILocalStorageService _LocalStorageService;

        public AuthService(HttpClient http, ILocalStorageService localStorageService)

        {
            _LocalStorageService = localStorageService;
            _http = http;
        }



        public async Task<ServiceResponse<string>> Login(LoginModel request)
        {
            var result = await _http.PostAsJsonAsync("https://localhost:44321/api/auth/login", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await _http.PostAsJsonAsync("https://localhost:44321/api/auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
