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
#line 1 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\JobItem.razor"
using JobManagementAspBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\JobItem.razor"
using JobManagementAspBlazor.Context;

#line default
#line hidden
#nullable disable
    public partial class JobItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\JobItem.razor"
       
    public JobContextDb context = new JobContextDb();

    [Parameter]
    public EventCallback<Job> OnHandleDelete { get; set; }
    [Parameter]
    public EventCallback<Job> OnHandleEdit { get; set; }
    [Parameter]
    public Job Job { get; set; } = new Job();

    protected async Task DeleteJobItem()
    {
        if(await JSRuntime.InvokeAsync<bool>("Confirm", "Bạn có muốn xóa mục này!!!"))
        {
            await OnHandleDelete.InvokeAsync(Job);
            await InvokeAsync(StateHasChanged);
        }

    }
    protected async Task EditJobItem()
    {
        await OnHandleEdit.InvokeAsync(Job);
        await InvokeAsync(StateHasChanged);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
