#pragma checksum "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec0d7efa1307023a099588365f53b2646646bad8"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "editcontrol");
            __builder.OpenElement(2, "form");
            __builder.AddAttribute(3, "class", "row g-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-12");
            __builder.AddMarkupContent(6, "<label for=\"inputEmail4\" class=\"form-label\" style=\"color:rgb(0, 0, 0)\">Tên công việc</label>\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "inputEmail4");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor"
                          Job.JobName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Job.JobName = __value, Job.JobName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-12");
            __builder.AddMarkupContent(16, "<label for=\"inputPassword4\" class=\"form-label\" style=\"color:rgb(0, 0, 0)\">Thời gian bắt đầu</label>\r\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "time");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "id", "inputPassword4");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor"
                          Job.TimeStart

#line default
#line hidden
#nullable disable
            , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Job.TimeStart = __value, Job.TimeStart, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-12");
            __builder.AddMarkupContent(26, "<label for=\"inputPassword4\" class=\"form-label\" style=\"color:rgb(0, 0, 0)\">Ngày</label>\r\n            ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "date");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "id", "inputPassword4");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor"
                          Job.DateInit

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Job.DateInit = __value, Job.DateInit, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-12");
            __builder.AddMarkupContent(36, "<label for=\"inputAddress2\" class=\"form-label\" style=\"color:rgb(0, 0, 0)\">Address </label>\r\n            ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "id", "inputAddress2");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor"
                          Job.Address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Job.Address = __value, Job.Address));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n      \r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-12");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor"
                              DoneEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn btn-primary btn-add");
            __builder.AddMarkupContent(50, "\r\n                Xong\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\CÁC MÔN TRÊN TRƯỜNG\Kỳ 6\Lập trình API\BTL\JobManagementAspBlazor\JobManagementAspBlazor\Pages\EidtJobItem.razor"
                              CancelEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-primary btn-add");
            __builder.AddMarkupContent(56, "\r\n                Thoát\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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