#pragma checksum "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd9caa6485a6942f38bd23024859056e19ced87"
// <auto-generated/>
#pragma warning disable 1591
namespace PROJECT1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using PROJECT1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\_Imports.razor"
using PROJECT1.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudAppBar>(0);
            __builder.AddAttribute(1, "Fixed", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Shared\MainLayout.razor"
                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(3);
                __builder2.AddAttribute(4, "Link", "/identityverificationpage");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(6, "Log work");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudButton>(10);
                __builder2.AddAttribute(11, "Link", "/managefarmassetspage");
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "Manage assets");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudButton>(15);
                __builder2.AddAttribute(16, "Link", "/assignfarmassetspage");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Manage assignments");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(20);
            __builder.AddAttribute(21, "Style", "width:100%;padding:10px;");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line (11,6)-(11,10) 26 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Shared\MainLayout.razor"
__builder2.AddContent(23, Body);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
