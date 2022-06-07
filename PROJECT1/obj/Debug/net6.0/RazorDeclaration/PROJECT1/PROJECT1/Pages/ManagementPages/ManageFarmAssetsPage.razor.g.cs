// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PROJECT1.PROJECT1.PROJECT1.Pages.ManagementPages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/managefarmassetspage")]
    public partial class ManageFarmAssetsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ManageFarmAssetsPage.razor"
       
    #region Data for display
    List<TableModels.FarmBuildingsTable> FarmBuildings = new List<TableModels.FarmBuildingsTable>();
    List<TableModels.FarmWorkersTable> FarmWorkers = new List<TableModels.FarmWorkersTable>();
    List<TableModels.FarmJobsTable> FarmJobs = new List<TableModels.FarmJobsTable>();
    #endregion

    #region New data
    TableModels.FarmWorkersTable NewFarmWorkersRecord = new TableModels.FarmWorkersTable() { Id = Guid.NewGuid(), DateAdded = DateTime.UtcNow, WorkerAccessCode = Guid.NewGuid().ToString() };
    TableModels.FarmBuildingsTable NewFarmBuildingsRecord = new TableModels.FarmBuildingsTable() { Id = Guid.NewGuid(), DateAdded = DateTime.UtcNow };
    TableModels.FarmJobsTable NewFarmJobsRecord = new TableModels.FarmJobsTable() { Id = Guid.NewGuid(), DateAdded = DateTime.UtcNow };
    #endregion

    #region Success/Error messages
    string failed_addneworker;
    string failed_addnewjob;
    string failed_addnewbuilding;

    string success_addneworker;
    string success_addnewjob;
    string success_addnewbuilding;
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


    #region Insert new data

    public async Task InsertNewWorker()
    {
        try
        {
            failed_addneworker = null;

            success_addneworker = null;


            var result = await dbcontext.FarmWorkersTable.AddAsync(NewFarmWorkersRecord);
            if (result.State == Microsoft.EntityFrameworkCore.EntityState.Added)
            {
                int changes = await dbcontext.SaveChangesAsync();
                if (changes == 1)
                {
                    FarmWorkers.Add(NewFarmWorkersRecord);
                    NewFarmWorkersRecord = new TableModels.FarmWorkersTable() { Id = Guid.NewGuid(), DateAdded = DateTime.UtcNow, WorkerAccessCode = Guid.NewGuid().ToString() };
                    success_addneworker = "New worker added";
                }
                else
                {
                    failed_addneworker = "Failed to add a worker";
                }
            }
        }
        catch (Exception e)
        {
            failed_addneworker = "Failed to add a worker";
        }
    }

    public async Task InsertNewBuilding()
    {
        try
        {
            failed_addnewbuilding = null;

            success_addnewbuilding = null;

            var result = await dbcontext.FarmBuildingsTable.AddAsync(NewFarmBuildingsRecord);
            if (result.State == Microsoft.EntityFrameworkCore.EntityState.Added)
            {
                int changes = await dbcontext.SaveChangesAsync();
                if (changes == 1)
                {
                    FarmBuildings.Add(NewFarmBuildingsRecord);
                    NewFarmBuildingsRecord = new TableModels.FarmBuildingsTable() { Id = Guid.NewGuid(), DateAdded = DateTime.UtcNow };
                    success_addnewbuilding = "New building added";
                }
                else
                {
                    failed_addnewbuilding = "Failed to add a building";
                }
            }
        }
        catch (Exception e)
        {
            failed_addnewbuilding = "Failed to add a building";
        }
    }

    public async Task InsertNewJob()
    {
        try
        {
            failed_addnewjob = null;

            success_addnewjob = null;

            var result = await dbcontext.FarmJobsTable.AddAsync(NewFarmJobsRecord);
            if (result.State == Microsoft.EntityFrameworkCore.EntityState.Added)
            {
                int changes = await dbcontext.SaveChangesAsync();
                if (changes == 1)
                {
                    FarmJobs.Add(NewFarmJobsRecord);
                    NewFarmJobsRecord = new TableModels.FarmJobsTable() { Id = Guid.NewGuid(), DateAdded = DateTime.UtcNow };
                    success_addnewjob = "New job added";
                }
                else
                {
                    failed_addnewjob = "Failed to add a job";
                }
            }
        }
        catch (Exception e)
        {
            failed_addnewjob = "Failed to add a job";
        }
    }

    #endregion



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContextForDB dbcontext { get; set; }
    }
}
#pragma warning restore 1591