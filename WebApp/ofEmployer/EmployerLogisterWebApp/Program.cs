using BusinessRazor.Components.ofUser;
using BusinessView.ofCommon.ofServices;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;
using BusinessView.ofUser;
using BusinessView.ofUser.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse;
using BusinessView.ofWarehouse.ofEmployer;
using EmployerLogisterWebApp.Areas.Identity;
using EmployerLogisterWebApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

// Add services to the container.
var IdentityConnectionString = builder.Configuration.GetConnectionString("IdentityDbConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(IdentityConnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireUppercase = false;

}).AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<IActorViewService<IdentityUserDTO>, UserActor>();
builder.Services.AddScoped<GetUserViewModel>();
builder.Services.AddScoped<PostUserViewModel>();
builder.Services.AddScoped<PutUserViewModel>();
builder.Services.AddScoped<DeleteUserViewModel>();
builder.Services.AddScoped<GetsUserViewModel>();

builder.Services.AddScoped<GetsEmployerWarehouseViewModel>();
builder.Services.AddScoped<PostEmployerWarehouseViewModel>();
builder.Services.AddScoped<PutEmployerWarehouseViewModel>();
builder.Services.AddScoped<DeleteEmployerWarehouseViewModel>();
builder.Services.AddScoped<GetsEmployerWarehouseViewModel>();

builder.Services.AddScoped<GetsEmployerDividedTagViewModel>();
builder.Services.AddScoped<PostEmployerDividedTagViewModel>();
builder.Services.AddScoped<PutEmployerDividedTagViewModel>();
builder.Services.AddScoped<DeleteEmployerDividedTagViewModel>();
builder.Services.AddScoped<GetsEmployerDividedTagViewModel>();

builder.Services.AddScoped<GetsEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<PostEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<PutEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<DeleteEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<GetsEmployerDotBarcodeViewModel>();

builder.Services.AddScoped<GetsEmployerEWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerEWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerEWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerEWCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerEWCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerIncomingTagViewModel>();
builder.Services.AddScoped<PostEmployerIncomingTagViewModel>();
builder.Services.AddScoped<PutEmployerIncomingTagViewModel>();
builder.Services.AddScoped<DeleteEmployerIncomingTagViewModel>();
builder.Services.AddScoped<GetsEmployerIncomingTagViewModel>();

builder.Services.AddScoped<GetsEmployerLoadFrameViewModel>();
builder.Services.AddScoped<PostEmployerLoadFrameViewModel>();
builder.Services.AddScoped<PutEmployerLoadFrameViewModel>();
builder.Services.AddScoped<DeleteEmployerLoadFrameViewModel>();
builder.Services.AddScoped<GetsEmployerLoadFrameViewModel>();

builder.Services.AddScoped<GetsEmployerMWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerMWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerMWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerMWCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerMWCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerSWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerSWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerSWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerSWCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerSWCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<PostEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<PutEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<DeleteEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<GetsEmployerWorkingDeskViewModel>();

builder.Services.AddScoped<GetsEmployerWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerWCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerWCommodityViewModel>();

builder.Services.AddScoped<IActorViewService<EmployerWarehouse>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerDividedTag>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerDotBarcode>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerEWCommodity>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerIncomingTag>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerLoadFrame>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerMWCommodity>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerSWCommodity>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerWorkingDesk>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerWCommodity>, EmployerLogister>();

builder.Services.AddMudServices();
builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

services.AddAuthentication().AddGoogle(googleOptions =>
{
    googleOptions.ClientId = configuration["Authentication:Google:ClientId"];
    googleOptions.ClientSecret = configuration["Authentication:Google:ClientSecret"];
});

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
