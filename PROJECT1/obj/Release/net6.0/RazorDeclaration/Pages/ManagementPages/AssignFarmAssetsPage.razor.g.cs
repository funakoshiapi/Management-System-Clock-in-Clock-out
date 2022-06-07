// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PROJECT1.Pages.ManagementPages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/assignfarmassetspage")]
    public partial class AssignFarmAssetsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\AssignFarmAssetsPage.razor"
       
    #region Data for display
    List<TableModels.FarmBuildingsTable> FarmBuildings = new List<TableModels.FarmBuildingsTable>();
    List<TableModels.FarmWorkersTable> FarmWorkers = new List<TableModels.FarmWorkersTable>();
    List<TableModels.FarmJobsTable> FarmJobs = new List<TableModels.FarmJobsTable>();
    #endregion

    TableModels.AssignmentsTable NewAssignment = new TableModels.AssignmentsTable() { Id = Guid.NewGuid(), DateAdded = DateTime.UtcNow  };


    #region Success/failure messages

    string failed_msg;
    string success_msg;

    #endregion


    protected override Task OnInitializedAsync()
    {
        try
        {
            FarmBuildings = dbcontext.FarmBuildingsTable.ToList();
            FarmWorkers = dbcontext.FarmWorkersTable.ToList();
            FarmJobs = dbcontext.FarmJobsTable.ToList();
        }
        catch (Exception e)
        {

        }

        return Task.CompletedTask;
    }

    public async Task AddAssignment()
    {
        try
        {
            failed_msg = null;
            success_msg = null;

            var result = await dbcontext.AssignmentsTable.AddAsync(NewAssignment);
            if (result.State == Microsoft.EntityFrameworkCore.EntityState.Added)
            {
                int changes = await dbcontext.SaveChangesAsync();
                if (changes == 1)
                {
                    success_msg = "Assignment added";
                }
                else
                {
                    failed_msg = "Something went wrong";
                }
                NewAssignment = new TableModels.AssignmentsTable() { Id = Guid.NewGuid(), DateAdded = DateTime.UtcNow  };
            }
        }
        catch (Exception e)
        {
            failed_msg = "Something went wrong";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContextForDB dbcontext { get; set; }
    }
}
#pragma warning restore 1591
