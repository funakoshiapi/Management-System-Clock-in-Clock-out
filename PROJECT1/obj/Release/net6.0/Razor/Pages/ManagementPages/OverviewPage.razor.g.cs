#pragma checksum "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2646b49a7c4fdb3cf632d8cb438593ae50fb1504"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/overviewpage")]
    public partial class OverviewPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudItem>(0);
            __builder.AddAttribute(1, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
             4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudDateRangePicker>(3);
                __builder2.AddAttribute(4, "DateRange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DateRange>(
#nullable restore
#line 5 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
                                        range

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "DateRangeChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MudBlazor.DateRange>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MudBlazor.DateRange>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => range = __value, range))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n   ");
                __builder2.OpenComponent<MudBlazor.MudButton>(7);
                __builder2.AddAttribute(8, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
                        Search

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Search");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<MudBlazor.MudItem>(12);
            __builder.AddAttribute(13, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
             8

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.PROJECT1.Pages.ManagementPages.OverviewPage.TypeInference.CreateMudTable_0(__builder2, 15, 16, 
#nullable restore
#line 10 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
                      Logs

#line default
#line hidden
#nullable disable
                , 17, 
#nullable restore
#line 10 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
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
                        __builder4.AddContent(33, "Date ended");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(35);
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(37, "Time spent");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(39);
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(41, "Job");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(43);
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(45, "Worker");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 46, (context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTd>(47);
                    __builder3.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (21,23)-(21,44) 26 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
__builder4.AddContent(49, context.Id.ToString());

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
#line (22,23)-(22,115) 26 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
__builder4.AddContent(53, dbcontext.FarmBuildingsTable.First(fb => fb.Id.ToString() == context.Building).BuildingTitle);

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
#line (23,23)-(23,42) 26 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
__builder4.AddContent(57, context.DateStarted);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(59);
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (24,23)-(24,40) 26 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
__builder4.AddContent(61, context.DateEnded);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, " \r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Web.ErrorBoundary>(63);
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTd>(65);
                        __builder4.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line (26,33)-(26,97) 26 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
__builder5.AddContent(67, context.DateEnded.Value.Subtract(context.DateStarted).TotalHours);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(69);
                    __builder3.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (28,23)-(28,100) 26 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
__builder4.AddContent(71, dbcontext.FarmJobsTable.First(fj => fj.Id.ToString() == context.Job).JobTitle);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(73);
                    __builder3.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (29,23)-(29,107) 26 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
__builder4.AddContent(75, dbcontext.FarmWorkersTable.First(fw => fw.Id.ToString() == context.Worker).FirstName);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, " \r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(77);
                    __builder3.CloseComponent();
                }
                , 78, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTablePager>(79);
                    __builder3.AddAttribute(80, "PageSizeOptions", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 33 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
                                            new int[]{10, 20}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                , 81, (__builder3) => {
                }
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Main Files\Conficiens solutio\manning stuff\blazor serverside project\vs projects\project 5\PROJECT1\PROJECT1\Pages\ManagementPages\OverviewPage.razor"
       
    List<TableModels.WorkLogsTable> Logs = new List<TableModels.WorkLogsTable>();

    DateRange range = new DateRange() { Start = DateTime.UtcNow.Subtract(new TimeSpan(10, 0, 0, 0)), End = DateTime.UtcNow };

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Logs = dbcontext.WorkLogsTable.Where(wl => wl.DateEnded.HasValue && wl.DateEnded <= range.End && wl.DateStarted >= range.Start).ToList(); 
        }
        catch (Exception e)
        {

        }
    }

    async Task Search()
    { 
        try
        {
            Logs = dbcontext.WorkLogsTable.Where(wl => wl.DateEnded.HasValue && wl.DateEnded <= range.End && wl.DateStarted >= range.Start).ToList(); 
        }
        catch (Exception e)
        {

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContextForDB dbcontext { get; set; }
    }
}
namespace __Blazor.PROJECT1.Pages.ManagementPages.OverviewPage
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
