#pragma checksum "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd3b07d5eaa3447fc0670a5491a9983b8330ead"
// <auto-generated/>
#pragma warning disable 1591
namespace PoPoy.Admin.Pages.AccountView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Shared.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Pages.Ultilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Pages.AccountView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Services.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Myproject\CSharp\DATN\PoPoy.Admin\_Imports.razor"
using PoPoy.Shared.Dto;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roles/{Id}")]
    public partial class AssignRole : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
                     Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
                                           AssignRoles

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
#nullable restore
#line 6 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
         foreach (var model in Model.Roles)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddContent(8, 
#nullable restore
#line 9 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
                 model.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "type", "hidden");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
                                                  Model.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Id = __value, Model.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "hidden");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
                                                   model.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Id = __value, model.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "hidden");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
                                                   model.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Name = __value, model.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "class", "checkbox");
                __builder2.AddAttribute(27, "type", "checkbox");
                __builder2.AddAttribute(28, "checked", 
#nullable restore
#line 15 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
                                 model.Selected

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
                                     model.Selected

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Selected = __value, model.Selected));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 18 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(31, "<div class=\"form-group\"><button type=\"submit\" class=\"btn btn-primary\">Lưu lại</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\Myproject\CSharp\DATN\PoPoy.Admin\Pages\AccountView\AssignRole.razor"
      
    [Parameter]
    public string Id { get; set; }
    public RoleAssignRequest Model = new RoleAssignRequest();

    protected override async Task OnInitializedAsync()
    {
        Model = await AuthService.GetRoleAssignRequest(Guid.Parse(Id));
        Model.Id = Guid.Parse(Id);
    }

    private async Task AssignRoles()
    {
        await AuthService.AssignRole(Model);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591