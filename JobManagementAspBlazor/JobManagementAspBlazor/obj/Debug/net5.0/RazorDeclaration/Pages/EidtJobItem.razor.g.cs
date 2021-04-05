// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor"
using JobManagementAspBlazor.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor"
using JobManagementAspBlazor.Data;

#line default
#line hidden
#nullable disable
    public partial class EidtJobItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor"
       
    private async Task Alert(string message)
    {
        await JSRuntime.InvokeAsync<object>("Alert", message);
    }
    private JobContextDb jobConText = new JobContextDb();
    [Parameter]
    public bool IsShowEdit { get; set; }
    [Parameter]
    public Job Job { get; set; } = new Job();

    [Parameter]
    public EventCallback HandleDone { get; set; }

    [Parameter]
    public EventCallback HandleCancel { get; set; }

    protected async Task DoneEdit()
    {
        if (!string.IsNullOrWhiteSpace(Job.JobName) && !string.IsNullOrWhiteSpace(Job.TimeStart.ToLongTimeString()) &&
             !string.IsNullOrWhiteSpace(Job.Address))
        {
            
                jobConText.Update<Job>(Job);
                IsShowEdit = false;
                jobConText.SaveChanges();
                await HandleDone.InvokeAsync();
                await JSRuntime.InvokeVoidAsync("initMap", null);
            
        }
        else
        {
            await Alert("Thông tin bị trống, mời nhập lại!!!");
        }
        StateHasChanged();
    }
    private void CancelEdit()
    {
        IsShowEdit = false;
        HandleCancel.InvokeAsync();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591