using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PoPoy.Admin.Services.AuthService;
using PoPoy.Admin.Services.BroadCastService;
using PoPoy.Admin.Services.CategoryService;
using PoPoy.Admin.Services.DashBoardService;
using PoPoy.Admin.Services.HttpRepository;
using PoPoy.Admin.Services.LogService;
using PoPoy.Admin.Services.OrderService;
using PoPoy.Admin.Services.ProductColorService;
using PoPoy.Admin.Services.ProductService;
using PoPoy.Admin.Services.ProductSizeService;
using PoPoy.Shared.Common;
using Radzen;
using Smart.Blazor;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace PoPoy.Admin
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IBroadCastService, BroadCastService>();
            builder.Services.AddScoped<IDashBoardService, DashBoarchService>();
            builder.Services.AddScoped<IProductSizeService, ProductSizeService>();
            builder.Services.AddScoped<IProductColorService, ProductColorService>();
            builder.Services.AddScoped<ILogService, LogService>();
            builder.Services.AddScoped<RefreshTokenService>();
            builder.Services.AddScoped<HttpInterceptorService>();
            builder.Services.AddBlazoredToast();
            builder.Services.AddSmart();


            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();
            builder.Services.AddScoped<TooltipService>();
            builder.Services.AddScoped<ContextMenuService>();

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.Configuration["BackendApiUrl"])
            }.EnableIntercept(sp));
            builder.Services.AddHttpClientInterceptor();



            builder.Services.AddScoped(sp =>
            {
                var broadCastService = sp.GetRequiredService<IBroadCastService>();

                return broadCastService.BuidHubWithToken();
            });

            await builder.Build().RunAsync();
        }
    }
}
