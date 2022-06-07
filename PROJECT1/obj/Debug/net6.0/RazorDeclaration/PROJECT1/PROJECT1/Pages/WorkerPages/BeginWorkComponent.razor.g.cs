// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PROJECT1.PROJECT1.PROJECT1.Pages.WorkerPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using PROJECT1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\_Imports.razor"
using PROJECT1.Shared;

#line default
#line hidden
#nullable disable
    public partial class BeginWorkComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\WorkerPages\BeginWorkComponent.razor"
 
    [Parameter]
    public EventCallback OnBegin { get; set; }

    Dictionary<string, string> AvailableJobs = new Dictionary<string, string>();
    Dictionary<string, string> AvailableBuildings = new Dictionary<string, string>();

    
    [Parameter]
    public string UserId { get; set; }

    string SelectedJob;
    string SelectedBuilding;

    string error;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            var assignments = dbcontext.AssignmentsTable.Where(a => a.WorkerId ==  UserId );

            foreach (var assignment in assignments.ToList().DistinctBy(a => a.JobId))
            {
                AvailableJobs.Add(assignment.JobId , dbcontext.FarmJobsTable.First(j => j.Id.ToString() == assignment.JobId).JobTitle);
            }

            foreach (var assignment in assignments.ToList().DistinctBy(a => a.BuildingId))
            {
                AvailableBuildings.Add(assignment.BuildingId , dbcontext.FarmBuildingsTable.First(b => b.Id.ToString() == assignment.BuildingId).BuildingTitle);
            }
        }
        catch (Exception e)
        {

        }
    }

    async Task Begin()
    {
        try
        {  
            if (!dbcontext.WorkLogsTable.ToList().Any(w => w.DateEnded == null))
            {
                    error = null; 

                    var result = await dbcontext.WorkLogsTable.AddAsync(new TableModels.WorkLogsTable() {  Building = SelectedBuilding.ToString(), Job = SelectedJob.ToString(), Worker =  UserId , DateStarted = DateTime.UtcNow });
                    if (result.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                    {
                        int changes = await dbcontext.SaveChangesAsync();
                        if (changes == 1)
                        {
                            await OnBegin.InvokeAsync();
                        }
                        else
                        {
                            error = "Something went wrong";
                        }
                    }
                    else
                    {
                         error = "Something went wrong"; 
                    } 
            }
        }
        catch (Exception e)
        {
             error = "Something went wrong";
        }
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContextForDB dbcontext { get; set; }
    }
}
#pragma warning restore 1591
