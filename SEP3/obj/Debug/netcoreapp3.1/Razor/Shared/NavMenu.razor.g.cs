#pragma checksum "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb595bda2ed37f85708f21668c72b9263371e832"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "top-row pl-4 navbar navbar-dark");
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.AddMarkupContent(6, "<a class=\"navbar-brand\" href=\"main\">Via Online Library</a>\r\n            ");
                __builder2.OpenElement(7, "button");
                __builder2.AddAttribute(8, "class", "navbar-toggler");
                __builder2.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Shared\NavMenu.razor"
                                                     ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(10, "\r\n                <span class=\"navbar-toggler-icon\"></span>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", 
#nullable restore
#line 10 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Shared\NavMenu.razor"
                                                ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "ul");
                __builder2.AddAttribute(18, "class", "nav flex-column");
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "li");
                __builder2.AddAttribute(21, "class", "nav-item px-3");
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
                __builder2.AddAttribute(24, "class", "nav-link");
                __builder2.AddAttribute(25, "href", "main");
                __builder2.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n                        <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n                ");
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "nav-item px-3");
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                __builder2.AddAttribute(35, "class", "nav-link");
                __builder2.AddAttribute(36, "href", "profile");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "\r\n                        <span class=\"oi oi-person\" aria-hidden=\"true\"></span> Profile\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenElement(41, "li");
                __builder2.AddAttribute(42, "class", "nav-item px-3");
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
                __builder2.AddAttribute(45, "class", "nav-link");
                __builder2.AddAttribute(46, "href", "logout");
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(48, "\r\n                        <span class=\"oi oi-account-logout\" aria-hidden=\"true\"></span> Log out\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
