// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PoPoy.Admin.Pages.ProductView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Shared.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Pages.Ultilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Pages.AccountView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Services.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Admin.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\_Imports.razor"
using PoPoy.Shared.Dto;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listProduct")]
    public partial class ListProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\Myproject\CSharp\DATN2\PoPoy.Admin\Pages\ProductView\ListProduct.razor"
       
    private string searchText = string.Empty;
    private List<ProductVM> Products { get; set; } = new List<ProductVM>();
    private int ProductId { set; get; }
    private Confirmation DeleteConfirmation { set; get; }

    protected override async Task OnInitializedAsync()
    {
        await GetProducts();
    }

    public void OnDeleteTask(int productId)
    {
        ProductId = productId;
        DeleteConfirmation.Show();
    }

    public async Task OnConfirmDeleteTask(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            await ProductService.DeleteProduct(ProductId);
            await GetProducts();
            StateHasChanged();
        }

    }

    private async Task GetProducts()
    {
        var pagingResponse = await ProductService.GetAllProducts();
        if (searchText != null)
        {
            Products = pagingResponse;
        }
    }

    public async Task SearchProducts()
    {
        var pagingResponse = await ProductService.GetAllProducts();
        if (!String.IsNullOrEmpty(searchText))
        {
            Products = await ProductService.SearchProduct(searchText);
        }
        else
        {
            Products = pagingResponse;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
    }
}
#pragma warning restore 1591
