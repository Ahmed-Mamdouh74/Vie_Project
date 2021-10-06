using Blazored.Toast.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Vie_Cap.Client.Service
{
    public class ActivitiesService : IActivitiesService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _http;
        public ActivitiesService(IToastService toastService, HttpClient httpClient)
        {
            _toastService = toastService;
            _http = httpClient;
        }

        public IList<Vie_Cap.Shared.Activity> ListActivity { get; set; } = new List<Vie_Cap.Shared.Activity>();


        //IList<Activity> ListActivity { get; set; } = new List<Vie_Cap.Shared.Activity>();

        public async Task LoadActivityAsync()
        {
            if (ListActivity.Count == 0)
            {
                ListActivity = await _http.GetFromJsonAsync<IList<Vie_Cap.Shared.Activity>>("https://localhost:44321/api/Actvities");

            }
        }
    }

}
