#pragma checksum "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\Pages\Login - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5edaad6314a29543198c6aa3e9b52750ab79de6b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SEP3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\Pages\Login - Copy.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\Pages\Login - Copy.razor"
using SEP3.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\jakob\OneDrive\Documents\GitHub\SEP3\SEP3\Pages\Login - Copy.razor"
       

    public User user;
    public bool isCorrect;

    protected override async Task OnInitializedAsync()
    {
        user = new User();

    }
    public async void UserLogin()
    {
        bool temp = await userService.LoginAsync(user);

        if (temp = true)
        {
            navManager.NavigateTo("/library");
        }

    }

    private async Task<bool> createAccountPage()
    {
        Console.WriteLine("*************** USER ACCOUNT CREATE******************");
        return await Task.FromResult(true);
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
    }
}
#pragma warning restore 1591
