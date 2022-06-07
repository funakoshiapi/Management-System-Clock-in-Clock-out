// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class CurrentWorkComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\WorkerPages\CurrentWorkComponent.razor"
 
    [Parameter]
    public EventCallback OnEndJob { get; set; }

    
    [Parameter]
    public string UserId { get; set; }

    TableModels.WorkLogsTable log;

    string error;



    protected override async Task OnInitializedAsync()
    {
        try
        {
            log =  dbcontext.WorkLogsTable.ToList().First(w => w.Worker == UserId  && w.DateEnded == null); 
        }
        catch (Exception e)
        {
            await  OnEndJob.InvokeAsync();
        }
    }

    

    async Task EndJob()
    {
        try
        {
            dbcontext.WorkLogsTable.Single(w => w.Id == log.Id).DateEnded = DateTime.UtcNow;

            int changes =  dbcontext.SaveChanges();
            if (changes == 1)
            {
               await OnEndJob.InvokeAsync();
            }
            else
            {
                 error = "Unable to end";
            }
        }
            catch (Exception e)
            {
                error = "Unable to end";
            }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContextForDB dbcontext { get; set; }
    }
}
#pragma warning restore 1591
