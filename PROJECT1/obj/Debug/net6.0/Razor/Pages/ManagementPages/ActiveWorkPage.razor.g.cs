#pragma checksum "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f865d47e3b22b17e066599a1264bece39009b170"
// <auto-generated/>
#pragma warning disable 1591
namespace PROJECT1.Pages.ManagementPages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/activeworkpage")]
    public partial class ActiveWorkPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudItem>(0);
            __builder.AddAttribute(1, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 3 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
             12

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "p");
                __builder2.AddContent(4, "Next update in ");
#nullable restore
#line (4,24)-(4,40) 25 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
__builder2.AddContent(5, timetonextupdate);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, " seconds ");
                __builder2.OpenComponent<MudBlazor.MudButton>(7);
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(9, "Refresh");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenElement(11, "p");
                __builder2.AddAttribute(12, "style", "color:red");
#nullable restore
#line (5,27)-(5,39) 26 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
__builder2.AddContent(13, updatererror);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __Blazor.PROJECT1.Pages.ManagementPages.ActiveWorkPage.TypeInference.CreateMudTable_0(__builder2, 15, 16, 
#nullable restore
#line 6 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
                      Logs

#line default
#line hidden
#nullable disable
                , 17, 
#nullable restore
#line 6 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
                                   true

#line default
#line hidden
#nullable disable
                , 18, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTh>(19);
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(21, "Id");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(23);
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(25, "Building");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(27);
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(29, "Date started");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(31);
                    __builder3.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(33, "Job");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(35);
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(37, "Worker");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 38, (context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTd>(39);
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (15,23)-(15,44) 26 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
__builder4.AddContent(41, context.Id.ToString());

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(43);
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (16,23)-(16,115) 26 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
__builder4.AddContent(45, dbcontext.FarmBuildingsTable.First(fb => fb.Id.ToString() == context.Building).BuildingTitle);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(47);
                    __builder3.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (17,23)-(17,42) 26 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
__builder4.AddContent(49, context.DateStarted);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(51);
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (18,23)-(18,100) 26 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
__builder4.AddContent(53, dbcontext.FarmJobsTable.First(fj => fj.Id.ToString() == context.Job).JobTitle);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(55);
                    __builder3.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (19,23)-(19,107) 26 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
__builder4.AddContent(57, dbcontext.FarmWorkersTable.First(fw => fw.Id.ToString() == context.Worker).FirstName);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(59);
                    __builder3.CloseComponent();
                }
                , 60, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTablePager>(61);
                    __builder3.AddAttribute(62, "PageSizeOptions", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 23 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
                                            new int[]{10, 20}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                , 63, (__builder3) => {
                }
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\fsilva\Desktop\live-projects\management sytem\part4\PROJECT1\PROJECT1\PROJECT1\Pages\ManagementPages\ActiveWorkPage.razor"
       
    List<TableModels.WorkLogsTable> Logs = new List<TableModels.WorkLogsTable>();

    int timetonextupdate = 60;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Logs = dbcontext.WorkLogsTable.Where(wl => !wl.DateEnded.HasValue).ToList();

            _ = Updater();
        }
        catch (Exception e)
        {

        }
    }

    string updatererror;

    async Task Updater()
    {
        try
        {
            while (true)
            {
                updatererror = null;
                timetonextupdate = 60; 
                StateHasChanged();
                while (timetonextupdate > 0)
                {
                    timetonextupdate--;
                    StateHasChanged();
                    await Task.Delay(1000);
                }

                try
                {
                    Logs = dbcontext.WorkLogsTable.Where(wl => !wl.DateEnded.HasValue).ToList();
                }
                catch (Exception e)
                {
                    updatererror = "Failed to refresh, if it keeps failing refresh the page";
                }
               

            }
           
        }
        catch (Exception e)
        {
              updatererror = "Failed to refresh, refresh the page";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContextForDB dbcontext { get; set; }
    }
}
namespace __Blazor.PROJECT1.Pages.ManagementPages.ActiveWorkPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "HeaderContent", __arg2);
        __builder.AddAttribute(__seq3, "RowTemplate", __arg3);
        __builder.AddAttribute(__seq4, "PagerContent", __arg4);
        __builder.AddAttribute(__seq5, "FooterContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
