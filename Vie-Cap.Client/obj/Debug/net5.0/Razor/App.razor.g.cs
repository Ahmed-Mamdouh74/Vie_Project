#pragma checksum "D:\ss\BlazorServer\Vie-Cap.Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "773e5de6e032aaa91c8e89c71c292754f5efc836"
// <auto-generated/>
#pragma warning disable 1591
namespace Vie_Cap.Client
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
#line 16 "D:\ss\BlazorServer\Vie-Cap.Client\App.razor"
using Vie_Cap.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(8);
                __builder2.AddAttribute(9, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 18 "D:\ss\BlazorServer\Vie-Cap.Client\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "PreferExactMatches", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\ss\BlazorServer\Vie-Cap.Client\App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(12);
                    __builder3.AddAttribute(13, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 20 "D:\ss\BlazorServer\Vie-Cap.Client\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 20 "D:\ss\BlazorServer\Vie-Cap.Client\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(16, "<h2 style=\"color:red\">\r\n                        Whoops!\r\n                    </h2>\r\n                    ");
                        __builder4.AddMarkupContent(17, "<p>\r\n                        It seems you\'re  not logged , please login to see this page\r\n                    </p>\r\n\r\n                    ");
                        __builder4.OpenComponent<Vie_Cap.Client.Shared.Login>(18);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(19, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(20);
                    __builder3.AddAttribute(21, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 34 "D:\ss\BlazorServer\Vie-Cap.Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(23, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
