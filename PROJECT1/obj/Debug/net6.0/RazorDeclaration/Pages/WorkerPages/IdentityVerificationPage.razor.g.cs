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
#line 1 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using PROJECT1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\_Imports.razor"
using PROJECT1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\Pages\WorkerPages\IdentityVerificationPage.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/identityverificationpage")]
    public partial class IdentityVerificationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "c:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\Pages\WorkerPages\IdentityVerificationPage.razor"
 
    string providedcode;
     
    string error;
     
    async Task Verify()
    {  
        try
        {
            var user =  dbcontext.FarmWorkersTable.ToList().First(w => w.WorkerAccessCode == providedcode);

            if (user != null)
            {
              await storage.SetAsync("userid", user.Id);
                nv.NavigateTo("/logworkpage");  
            } 
        }
        catch (Exception e)
        {
            error = "Bad code";
        }
         
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContextForDB dbcontext { get; set; }
    }
}
#pragma warning restore 1591
