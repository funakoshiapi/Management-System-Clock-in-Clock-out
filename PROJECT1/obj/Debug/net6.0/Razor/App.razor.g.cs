#pragma checksum "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c2789fd2c4e43d3ae33b28af7733108ddaddae8"
// <auto-generated/>
#pragma warning disable 1591
namespace PROJECT1
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using PROJECT1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using PROJECT1.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\App.razor"
                      typeof(App).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(3);
                __builder2.AddAttribute(4, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.FocusOnNavigate>(7);
                __builder2.AddAttribute(8, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\App.razor"
                                     routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Selector", "h1");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(10, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Web.PageTitle>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "Not found");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(15);
                __builder2.AddAttribute(16, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 8 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "<p role=\"alert\">Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(20);
            __builder.AddAttribute(21, "Theme", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 13 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\App.razor"
                          theme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(23);
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(25);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\App.razor"
       
            MudTheme theme = new MudTheme()
            {
                Palette = new Palette()
                {
                    AppbarText = new MudBlazor.Utilities.MudColor(255, 255, 255, 1),
                    AppbarBackground = new MudBlazor.Utilities.MudColor(57, 162, 37, 0.8),
                    Primary = new MudBlazor.Utilities.MudColor(57, 162, 37, 0.8)
        }
    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
