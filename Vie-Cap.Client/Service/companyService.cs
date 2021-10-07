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
    public class companyService : IcompanyService
    {
        private readonly HttpClient _http;
        public companyService(HttpClient http)

        {
            _http = http;
        }
        public event Action OnChange;

        public List<ModeViewCompany> companies { get; set; } = new List<ModeViewCompany>();
        //public async Task<List<ModeViewCompany>> Postcompany(ModeViewCompany company)
        //{

        //    var result = await _http.PostAsJsonAsync($"https://localhost:44321/api/company", company);

        //    return await result.Content.ReadFromJsonAsync<List<ModeViewCompany>>();
        //    //  companies = await result.Content.ReadFromJsonAsync<List<ModeViewCompany>>();
        //    //OnChange.Invoke();
        //    // return companies;
        //}

        public async Task<ModeViewCompany> Postcompany(ModeViewCompany company)
        {

            var result = await _http.PostAsJsonAsync("https://localhost:44321/api/company", company);

            return await result.Content.ReadFromJsonAsync<ModeViewCompany>();
            //  companies = await result.Content.ReadFromJsonAsync<List<ModeViewCompany>>();
            //OnChange.Invoke();
            // return companies;
        }

       

    }
}
