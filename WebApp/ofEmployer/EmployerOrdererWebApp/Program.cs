using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder;
using EmployerOrdererWebApp.Areas.Identity;
using EmployerOrdererWebApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var IdentityConnectionString = builder.Configuration.GetConnectionString("IdentityDbConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(IdentityConnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// GroupOrder, Order, Trade, Warehouse
builder.Services.AddScoped<GetUserViewModel>();
builder.Services.AddScoped<PostUserViewModel>();
builder.Services.AddScoped<PutUserViewModel>();
builder.Services.AddScoped<DeleteUserViewModel>();
builder.Services.AddScoped<GetsUserViewModel>();

builder.Services.AddScoped<BaseRoleViewModel>();
builder.Services.AddScoped<PostRoleViewModel>();
builder.Services.AddScoped<PutRoleViewModel>();
builder.Services.AddScoped<DeleteRoleViewModel>();
builder.Services.AddScoped<GetsRoleViewModel>();

builder.Services.AddScoped<BaseEmployerEGOCViewModel>();
builder.Services.AddScoped<PostEmployerEGOCViewModel>();
builder.Services.AddScoped<PutEmployerEGOCViewModel>();
builder.Services.AddScoped<DeleteEmployerEGOCViewModel>();
builder.Services.AddScoped<GetsEmployerEGOCViewModel>();

builder.Services.AddScoped<BaseEmployerGOCCViewModel>();
builder.Services.AddScoped<PostEmployerGOCCViewModel>();
builder.Services.AddScoped<PutEmployerGOCCViewModel>();
builder.Services.AddScoped<DeleteEmployerGOCCViewModel>();
builder.Services.AddScoped<GetsEmployerGOCCViewModel>();

builder.Services.AddScoped<BaseEmployerGOCViewModel>();
builder.Services.AddScoped<PostEmployerGOCViewModel>();
builder.Services.AddScoped<PutEmployerGOCViewModel>();
builder.Services.AddScoped<DeleteEmployerGOCViewModel>();
builder.Services.AddScoped<GetsEmployerGOCViewModel>();

builder.Services.AddScoped<BaseEmployerMGOCViewModel>();
builder.Services.AddScoped<PostEmployerMGOCViewModel>();
builder.Services.AddScoped<PutEmployerMGOCViewModel>();
builder.Services.AddScoped<DeleteEmployerMGOCViewModel>();
builder.Services.AddScoped<GetsEmployerMGOCViewModel>();

builder.Services.AddScoped<BaseEmployerSGOCViewModel>();
builder.Services.AddScoped<PostEmployerSGOCViewModel>();
builder.Services.AddScoped<PutEmployerSGOCViewModel>();
builder.Services.AddScoped<DeleteEmployerSGOCViewModel>();
builder.Services.AddScoped<GetsEmployerSGOCViewModel>();

builder.Services.AddScoped<BaseEmployerEOCommodityViewModel>();
builder.Services.AddScoped<PostEmployerEOCommodityViewModel>();
builder.Services.AddScoped<PutEmployerEOCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerEOCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerEOCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerMOCommodityViewModel>();
builder.Services.AddScoped<PostEmployerMOCommodityViewModel>();
builder.Services.AddScoped<PutEmployerMOCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerMOCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerMOCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerOCommodityViewModel>();
builder.Services.AddScoped<PostEmployerOCommodityViewModel>();
builder.Services.AddScoped<PutEmployerOCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerOCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerOCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerSOCommodityViewModel>();
builder.Services.AddScoped<PostEmployerSOCommodityViewModel>();
builder.Services.AddScoped<PutEmployerSOCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerSOCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerSOCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerOrderCenterViewModel>();
builder.Services.AddScoped<PostEmployerOrderCenterViewModel>();
builder.Services.AddScoped<PutEmployerOrderCenterViewModel>();
builder.Services.AddScoped<DeleteEmployerOrderCenterViewModel>();
builder.Services.AddScoped<GetsEmployerOrderCenterViewModel>();

builder.Services.AddScoped<BaseEmployerETCommodityViewModel>();
builder.Services.AddScoped<PostEmployerETCommodityViewModel>();
builder.Services.AddScoped<PutEmployerETCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerETCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerETCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerMTCommodityViewModel>();
builder.Services.AddScoped<PostEmployerMTCommodityViewModel>();
builder.Services.AddScoped<PutEmployerMTCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerMTCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerMTCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerSTCommodityViewModel>();
builder.Services.AddScoped<PostEmployerSTCommodityViewModel>();
builder.Services.AddScoped<PutEmployerSTCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerSTCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerSTCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerTCommodityViewModel>();
builder.Services.AddScoped<PostEmployerTCommodityViewModel>();
builder.Services.AddScoped<PutEmployerTCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerTCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerTCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerTradeCenterViewModel>();
builder.Services.AddScoped<PostEmployerTradeCenterViewModel>();
builder.Services.AddScoped<PutEmployerTradeCenterViewModel>();
builder.Services.AddScoped<DeleteEmployerTradeCenterViewModel>();
builder.Services.AddScoped<GetsEmployerTradeCenterViewModel>();

builder.Services.AddScoped<BaseEmployerDividedTagViewModel>();
builder.Services.AddScoped<PostEmployerDividedTagViewModel>();
builder.Services.AddScoped<PutEmployerDividedTagViewModel>();
builder.Services.AddScoped<DeleteEmployerDividedTagViewModel>();
builder.Services.AddScoped<GetsEmployerDividedTagViewModel>();

builder.Services.AddScoped<BaseEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<PostEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<PutEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<DeleteEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<GetsEmployerDotBarcodeViewModel>();

builder.Services.AddScoped<BaseEmployerEWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerEWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerEWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerEWCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerEWCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerIncomingTagViewModel>();
builder.Services.AddScoped<PostEmployerIncomingTagViewModel>();
builder.Services.AddScoped<PutEmployerIncomingTagViewModel>();
builder.Services.AddScoped<DeleteEmployerIncomingTagViewModel>();
builder.Services.AddScoped<GetsEmployerIncomingTagViewModel>();

builder.Services.AddScoped<BaseEmployerLoadFrameViewModel>();
builder.Services.AddScoped<PostEmployerLoadFrameViewModel>();
builder.Services.AddScoped<PutEmployerLoadFrameViewModel>();
builder.Services.AddScoped<DeleteEmployerLoadFrameViewModel>();
builder.Services.AddScoped<GetsEmployerLoadFrameViewModel>();

builder.Services.AddScoped<BaseEmployerMWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerMWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerMWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerMWCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerMWCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerSWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerSWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerSWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerSWCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerSWCommodityViewModel>();

builder.Services.AddScoped<BaseEmployerWarehouseViewModel>();
builder.Services.AddScoped<PostEmployerWarehouseViewModel>();
builder.Services.AddScoped<PutEmployerWarehouseViewModel>();
builder.Services.AddScoped<DeleteEmployerWarehouseViewModel>();
builder.Services.AddScoped<GetsEmployerWarehouseViewModel>();

builder.Services.AddScoped<BaseEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<PostEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<PutEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<DeleteEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<GetsEmployerWorkingDeskViewModel>();

builder.Services.AddScoped<BaseEmployerWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerWCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerWCommodityViewModel>();

builder.Services.AddMudServices();
builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
