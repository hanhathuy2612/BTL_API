#pragma checksum "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f9f8153faa8ed0702cce2b736a1d3935db0a3da"
// <auto-generated/>
#pragma warning disable 1591
namespace JobManagementAspBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using JobManagementAspBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\_Imports.razor"
using JobManagementAspBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
using JobManagementAspBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "jobcontrol");
#nullable restore
#line 5 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
         if (IsShowAdd)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<JobManagementAspBlazor.Pages.AddJobItem>(3);
            __builder.AddAttribute(4, "LoadPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
                                  OnInitialized

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 8 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
        }else if (IsShowEdit)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<JobManagementAspBlazor.Pages.EidtJobItem>(5);
            __builder.AddAttribute(6, "Job", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<JobManagementAspBlazor.Data.Job>(
#nullable restore
#line 10 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
                               Job

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "IsShowEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
                                                 IsShowEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "HandleCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
                                                                           SetShow

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "HandleDone", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
                                                                                                SetShow

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 11 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<JobManagementAspBlazor.Pages.ListJob>(10);
            __builder.AddAttribute(11, "OnHandleEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<JobManagementAspBlazor.Data.Job>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<JobManagementAspBlazor.Data.Job>(this, 
#nullable restore
#line 12 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
                               EditItem

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenComponent<JobManagementAspBlazor.Pages.Map>(13);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\Index.razor"
      
    public bool IsShowEdit { get; set; } = false;
    public bool IsShowAdd { get; set; } = true;
    public Job Job { get; set; } = new Job();

    private void EditItem(Job job)
    {
        IsShowAdd = false;
        IsShowEdit = true;
        Job = job;
        StateHasChanged();
    }
    private void SetShow()
    {
        IsShowAdd = true;
        IsShowEdit = false;
        StateHasChanged();
    }
    protected override void OnInitialized()
    {
        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591