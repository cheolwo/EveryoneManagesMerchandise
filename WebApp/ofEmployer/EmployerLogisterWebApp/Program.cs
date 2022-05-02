using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;
using BusinessView.ofUser;
using BusinessView.ofUser.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder;
using BusinessView.ofWarehouse.ofEmployer;
using EmployerLogisterWebApp.Areas.Identity;
using EmployerLogisterWebApp.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
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

builder.Services.AddScoped<GetsEmployerEmployeeRoleViewModel>();
builder.Services.AddScoped<PostEmployerEmployeeRoleViewModel>();
builder.Services.AddScoped<PutEmployerEmployeeRoleViewModel>();
builder.Services.AddScoped<DeleteEmployerEmployeeRoleViewModel>();
builder.Services.AddScoped<GetsEmployerEmployeeRoleViewModel>();

builder.Services.AddScoped<GetsEmployerHRBusinessPartViewModel>();
builder.Services.AddScoped<PostEmployerHRBusinessPartViewModel>();
builder.Services.AddScoped<PutEmployerHRBusinessPartViewModel>();
builder.Services.AddScoped<DeleteEmployerHRBusinessPartViewModel>();
builder.Services.AddScoped<GetsEmployerHRBusinessPartViewModel>();

builder.Services.AddScoped<GetsEmployerHRCenterViewModel>();
builder.Services.AddScoped<PostEmployerHRCenterViewModel>();
builder.Services.AddScoped<PutEmployerHRCenterViewModel>();
builder.Services.AddScoped<DeleteEmployerHRCenterViewModel>();
builder.Services.AddScoped<GetsEmployerHRCenterViewModel>();

builder.Services.AddScoped<GetsEmployerHREmployeeViewModel>();
builder.Services.AddScoped<PostEmployerHREmployeeViewModel>();
builder.Services.AddScoped<PutEmployerHREmployeeViewModel>();
builder.Services.AddScoped<DeleteEmployerHREmployeeViewModel>();
builder.Services.AddScoped<GetsEmployerHREmployeeViewModel>();

builder.Services.AddScoped<GetsEmployerHRRoleViewModel>();
builder.Services.AddScoped<PostEmployerHRRoleViewModel>();
builder.Services.AddScoped<PutEmployerHRRoleViewModel>();
builder.Services.AddScoped<DeleteEmployerHRRoleViewModel>();
builder.Services.AddScoped<GetsEmployerHRRoleViewModel>();

builder.Services.AddScoped<GetsEmployerJCommodityViewModel>();
builder.Services.AddScoped<PostEmployerJCommodityViewModel>();
builder.Services.AddScoped<PutEmployerJCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerJCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerJCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerJournalViewModel>();
builder.Services.AddScoped<PostEmployerJournalViewModel>();
builder.Services.AddScoped<PutEmployerJournalViewModel>();
builder.Services.AddScoped<DeleteEmployerJournalViewModel>();
builder.Services.AddScoped<GetsEmployerJournalViewModel>();

builder.Services.AddScoped<GetsEmployerJournalCenterViewModel>();
builder.Services.AddScoped<PostEmployerJournalCenterViewModel>();
builder.Services.AddScoped<PutEmployerJournalCenterViewModel>();
builder.Services.AddScoped<DeleteEmployerJournalCenterViewModel>();
builder.Services.AddScoped<GetsEmployerJournalCenterViewModel>();

builder.Services.AddScoped<GetsEmployerTradeCenterViewModel>();
builder.Services.AddScoped<PostEmployerTradeCenterViewModel>();
builder.Services.AddScoped<PutEmployerTradeCenterViewModel>();
builder.Services.AddScoped<DeleteEmployerTradeCenterViewModel>();
builder.Services.AddScoped<GetsEmployerTradeCenterViewModel>();

builder.Services.AddScoped<GetsEmployerTCommodityViewModel>();
builder.Services.AddScoped<PostEmployerTCommodityViewModel>();
builder.Services.AddScoped<PutEmployerTCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerTCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerTCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerSTCommodityViewModel>();
builder.Services.AddScoped<PostEmployerSTCommodityViewModel>();
builder.Services.AddScoped<PutEmployerSTCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerSTCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerSTCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerMTCommodityViewModel>();
builder.Services.AddScoped<PostEmployerMTCommodityViewModel>();
builder.Services.AddScoped<PutEmployerMTCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerMTCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerMTCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerETCommodityViewModel>();
builder.Services.AddScoped<PostEmployerETCommodityViewModel>();
builder.Services.AddScoped<PutEmployerETCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerETCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerETCommodityViewModel>();

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
