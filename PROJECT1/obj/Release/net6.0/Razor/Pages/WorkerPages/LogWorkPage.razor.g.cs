#pragma checksum "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\WorkerPages\LogWorkPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af5254518a9600602af3f467848132d085d53c1"
// <auto-generated/>
#pragma warning disable 1591
namespace PROJECT1.Pages.WorkerPages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/logworkpage")]
    public partial class LogWorkPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\WorkerPages\LogWorkPage.razor"
 if (is_working)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PROJECT1.Pages.WorkerPages.CurrentWorkComponent>(0);
            __builder.AddAttribute(1, "OnEndJob", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\WorkerPages\LogWorkPage.razor"
                                      () =>  { is_working = false; }

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 8 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\WorkerPages\LogWorkPage.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PROJECT1.Pages.WorkerPages.BeginWorkComponent>(2);
            __builder.AddAttribute(3, "OnBegin", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 12 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\WorkerPages\LogWorkPage.razor"
                                   () =>  { is_working = true; }

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 13 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\WorkerPages\LogWorkPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\WorkerPages\LogWorkPage.razor"
       
    bool is_working = true;

    protected override async Task OnInitializedAsync()
    {
        try
        {

        }
        catch (Exception e)
        {
            
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
