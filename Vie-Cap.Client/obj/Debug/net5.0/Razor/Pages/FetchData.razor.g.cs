#pragma checksum "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17da258218d3fbdcd4756c0a6204468a8d7924bb"
// <auto-generated/>
#pragma warning disable 1591
namespace Vie_Cap.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Vie_Cap.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Vie_Cap.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Vie_Cap.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Blazored.LocalStorage.StorageOptions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Blazored.LocalStorage.JsonConverters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Blazored.LocalStorage.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Vie_Cap.Client.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\ss\BlazorServer\Vie-Cap.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
using Vie_Cap.Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 10 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 29 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 32 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\ss\BlazorServer\Vie-Cap.Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
