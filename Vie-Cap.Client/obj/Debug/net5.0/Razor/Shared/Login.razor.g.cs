#pragma checksum "D:\ss\BlazorServer\Vie-Cap.Client\Shared\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "773b9ceef187bd05c9a621ad1160c734d97f304b"
// <auto-generated/>
#pragma warning disable 1591
namespace Vie_Cap.Client.Shared
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
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    input:focus {\r\n        outline: none !important;\r\n    }\r\n\r\n    .valid.modified:not([type=checkbox]) {\r\n        outline: none #26b050;\r\n    }\r\n\r\n    .valid.modified:not([type=text]) {\r\n        outline: none #26b050;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Please Log-in below or <a href=\"/register\"> register</a> For a new account.</h3>\r\n<hr>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "D:\ss\BlazorServer\Vie-Cap.Client\Shared\Login.razor"
                 user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 30 "D:\ss\BlazorServer\Vie-Cap.Client\Shared\Login.razor"
                                      Handlelogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "<label for=\"email\">\r\n            Email\r\n        </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "email");
                __builder2.AddAttribute(13, "class", "");
                __builder2.AddAttribute(14, "type", "email");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\ss\BlazorServer\Vie-Cap.Client\Shared\Login.razor"
                                           user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"password\">\r\n            Password\r\n        </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "password");
                __builder2.AddAttribute(24, "class", "");
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "D:\ss\BlazorServer\Vie-Cap.Client\Shared\Login.razor"
                                              user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    <hr>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(32, "<hr>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n\r\n\r\n    ");
                __builder2.AddMarkupContent(34, "<button type=\"submit\" class=\"btn btn-info \"> Login</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\ss\BlazorServer\Vie-Cap.Client\Shared\Login.razor"
       
    bool isAuthenticated = false;
    private LoginModel user = new LoginModel();

    private async void Handlelogin()
    {
        // user.UserName =

        //Console.WriteLine($"USER NAME :{user.UserName} , password:  {user.Password}");

        //isAuthenticated = true;

        var result = await AuthService.Login(user);
        if (result.Success)
        {
            ToastService.ShowSuccess("welcome");

            //ToastService.ShowSuccess(result.Message);
            //await LocalStorage.SetItemAsync<bool>("isAuthenticated", true);

            await LocalStorage.SetItemAsync<string>("authToken", result.Data);
            await AuthenticationStateProvider.GetAuthenticationStateAsync();
        }
        else
        {
            ToastService.ShowError(result.Message);
        }

        //await LocalStorage.SetItemAsync<bool>("isAuthenticated", true);
        //await AuthenticationStateProvider.GetAuthenticationStateAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
