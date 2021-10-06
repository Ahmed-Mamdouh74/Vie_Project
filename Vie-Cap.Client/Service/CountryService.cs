using Blazored.Toast.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Vie_Cap.Client.Service
{
    public class CountryService : ICountry
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _http;
        public CountryService(IToastService toastService, HttpClient httpClient)
        {
            _toastService = toastService;
            _http = httpClient;
        }



        public IList<Vie_Cap.Shared.Country> Countries { get; set; } = new List<Vie_Cap.Shared.Country>();

        public async Task LoadCounrtAsync()
        {
            if (Countries.Count == 0)
            {
                Countries = await _http.GetFromJsonAsync<IList<Vie_Cap.Shared.Country>>("https://localhost:44321/api/COuntry");

            }
        }
    }
}
