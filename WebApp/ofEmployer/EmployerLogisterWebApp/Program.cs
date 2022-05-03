using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofHR;
using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofUser;
using BusinessView.ofUser.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
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
builder.Services.AddScoped<BaseEmployerWarehouseViewModel>();

builder.Services.AddScoped<GetsEmployerDividedTagViewModel>();
builder.Services.AddScoped<PostEmployerDividedTagViewModel>();
builder.Services.AddScoped<PutEmployerDividedTagViewModel>();
builder.Services.AddScoped<DeleteEmployerDividedTagViewModel>();
builder.Services.AddScoped<BaseEmployerDividedTagViewModel>();

builder.Services.AddScoped<GetsEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<PostEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<PutEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<DeleteEmployerDotBarcodeViewModel>();
builder.Services.AddScoped<BaseEmployerDotBarcodeViewModel>();

builder.Services.AddScoped<GetsEmployerEWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerEWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerEWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerEWCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerEWCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerIncomingTagViewModel>();
builder.Services.AddScoped<PostEmployerIncomingTagViewModel>();
builder.Services.AddScoped<PutEmployerIncomingTagViewModel>();
builder.Services.AddScoped<DeleteEmployerIncomingTagViewModel>();
builder.Services.AddScoped<BaseEmployerIncomingTagViewModel>();

builder.Services.AddScoped<GetsEmployerLoadFrameViewModel>();
builder.Services.AddScoped<PostEmployerLoadFrameViewModel>();
builder.Services.AddScoped<PutEmployerLoadFrameViewModel>();
builder.Services.AddScoped<DeleteEmployerLoadFrameViewModel>();
builder.Services.AddScoped<BaseEmployerLoadFrameViewModel>();

builder.Services.AddScoped<GetsEmployerMWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerMWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerMWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerMWCommodityViewModel>();
builder.Services.AddScoped<GetsEmployerMWCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerSWCommodityViewModel>();
builder.Services.AddScoped<PostEmployerSWCommodityViewModel>();
builder.Services.AddScoped<PutEmployerSWCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerSWCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerSWCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<PostEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<PutEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<DeleteEmployerWorkingDeskViewModel>();
builder.Services.AddScoped<BaseEmployerWorkingDeskViewModel>();

builder.Services.AddScoped<GetsEmployerEmployeeRoleViewModel>();
builder.Services.AddScoped<PostEmployerEmployeeRoleViewModel>();
builder.Services.AddScoped<PutEmployerEmployeeRoleViewModel>();
builder.Services.AddScoped<DeleteEmployerEmployeeRoleViewModel>();
builder.Services.AddScoped<BaseEmployerEmployeeRoleViewModel>();

builder.Services.AddScoped<GetsEmployerHRBusinessPartViewModel>();
builder.Services.AddScoped<PostEmployerHRBusinessPartViewModel>();
builder.Services.AddScoped<PutEmployerHRBusinessPartViewModel>();
builder.Services.AddScoped<DeleteEmployerHRBusinessPartViewModel>();
builder.Services.AddScoped<BaseEmployerHRBusinessPartViewModel>();

builder.Services.AddScoped<GetsEmployerHRCenterViewModel>();
builder.Services.AddScoped<PostEmployerHRCenterViewModel>();
builder.Services.AddScoped<PutEmployerHRCenterViewModel>();
builder.Services.AddScoped<DeleteEmployerHRCenterViewModel>();
builder.Services.AddScoped<BaseEmployerHRCenterViewModel>();

builder.Services.AddScoped<GetsEmployerHREmployeeViewModel>();
builder.Services.AddScoped<PostEmployerHREmployeeViewModel>();
builder.Services.AddScoped<PutEmployerHREmployeeViewModel>();
builder.Services.AddScoped<DeleteEmployerHREmployeeViewModel>();
builder.Services.AddScoped<BaseEmployerHREmployeeViewModel>();

builder.Services.AddScoped<GetsEmployerHRRoleViewModel>();
builder.Services.AddScoped<PostEmployerHRRoleViewModel>();
builder.Services.AddScoped<PutEmployerHRRoleViewModel>();
builder.Services.AddScoped<DeleteEmployerHRRoleViewModel>();
builder.Services.AddScoped<BaseEmployerHRRoleViewModel>();

builder.Services.AddScoped<GetsEmployerJCommodityViewModel>();
builder.Services.AddScoped<PostEmployerJCommodityViewModel>();
builder.Services.AddScoped<PutEmployerJCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerJCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerJCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerJournalViewModel>();
builder.Services.AddScoped<PostEmployerJournalViewModel>();
builder.Services.AddScoped<PutEmployerJournalViewModel>();
builder.Services.AddScoped<DeleteEmployerJournalViewModel>();
builder.Services.AddScoped<BaseEmployerJournalViewModel>();

builder.Services.AddScoped<GetsEmployerJournalCenterViewModel>();
builder.Services.AddScoped<PostEmployerJournalCenterViewModel>();
builder.Services.AddScoped<PutEmployerJournalCenterViewModel>();
builder.Services.AddScoped<DeleteEmployerJournalCenterViewModel>();
builder.Services.AddScoped<BaseEmployerJournalCenterViewModel>();

builder.Services.AddScoped<GetsEmployerTradeCenterViewModel>();
builder.Services.AddScoped<PostEmployerTradeCenterViewModel>();
builder.Services.AddScoped<PutEmployerTradeCenterViewModel>();
builder.Services.AddScoped<DeleteEmployerTradeCenterViewModel>();
builder.Services.AddScoped<BaseEmployerTradeCenterViewModel>();

builder.Services.AddScoped<GetsEmployerTCommodityViewModel>();
builder.Services.AddScoped<PostEmployerTCommodityViewModel>();
builder.Services.AddScoped<PutEmployerTCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerTCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerTCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerSTCommodityViewModel>();
builder.Services.AddScoped<PostEmployerSTCommodityViewModel>();
builder.Services.AddScoped<PutEmployerSTCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerSTCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerSTCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerMTCommodityViewModel>();
builder.Services.AddScoped<PostEmployerMTCommodityViewModel>();
builder.Services.AddScoped<PutEmployerMTCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerMTCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerMTCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerETCommodityViewModel>();
builder.Services.AddScoped<PostEmployerETCommodityViewModel>();
builder.Services.AddScoped<PutEmployerETCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerETCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerETCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerGOCViewModel>();
builder.Services.AddScoped<PostEmployerGOCViewModel>();
builder.Services.AddScoped<PutEmployerGOCViewModel>();
builder.Services.AddScoped<DeleteEmployerGOCViewModel>();
builder.Services.AddScoped<BaseEmployerGOCViewModel>();

builder.Services.AddScoped<GetsEmployerGOCCViewModel>();
builder.Services.AddScoped<PostEmployerGOCCViewModel>();
builder.Services.AddScoped<PutEmployerGOCCViewModel>();
builder.Services.AddScoped<DeleteEmployerGOCCViewModel>();
builder.Services.AddScoped<BaseEmployerGOCCViewModel>();

builder.Services.AddScoped<GetsEmployerSGOCViewModel>();
builder.Services.AddScoped<PostEmployerSGOCViewModel>();
builder.Services.AddScoped<PutEmployerSGOCViewModel>();
builder.Services.AddScoped<DeleteEmployerSGOCViewModel>();
builder.Services.AddScoped<BaseEmployerSGOCViewModel>();

builder.Services.AddScoped<GetsEmployerMGOCViewModel>();
builder.Services.AddScoped<PostEmployerMGOCViewModel>();
builder.Services.AddScoped<PutEmployerMGOCViewModel>();
builder.Services.AddScoped<DeleteEmployerMGOCViewModel>();
builder.Services.AddScoped<BaseEmployerMGOCViewModel>();

builder.Services.AddScoped<GetsEmployerEGOCViewModel>();
builder.Services.AddScoped<PostEmployerEGOCViewModel>();
builder.Services.AddScoped<PutEmployerEGOCViewModel>();
builder.Services.AddScoped<DeleteEmployerEGOCViewModel>();
builder.Services.AddScoped<BaseEmployerEGOCViewModel>();

builder.Services.AddScoped<GetsEmployerOrderCenterViewModel>();
builder.Services.AddScoped<PostEmployerOrderCenterViewModel>();
builder.Services.AddScoped<PutEmployerOrderCenterViewModel>();
builder.Services.AddScoped<DeleteEmployerOrderCenterViewModel>();
builder.Services.AddScoped<BaseEmployerOrderCenterViewModel>();

builder.Services.AddScoped<GetsEmployerOCommodityViewModel>();
builder.Services.AddScoped<PostEmployerOCommodityViewModel>();
builder.Services.AddScoped<PutEmployerOCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerOCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerOCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerSOCommodityViewModel>();
builder.Services.AddScoped<PostEmployerSOCommodityViewModel>();
builder.Services.AddScoped<PutEmployerSOCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerSOCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerSOCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerMOCommodityViewModel>();
builder.Services.AddScoped<PostEmployerMOCommodityViewModel>();
builder.Services.AddScoped<PutEmployerMOCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerMOCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerMOCommodityViewModel>();

builder.Services.AddScoped<GetsEmployerEOCommodityViewModel>();
builder.Services.AddScoped<PostEmployerEOCommodityViewModel>();
builder.Services.AddScoped<PutEmployerEOCommodityViewModel>();
builder.Services.AddScoped<DeleteEmployerEOCommodityViewModel>();
builder.Services.AddScoped<BaseEmployerEOCommodityViewModel>();

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

builder.Services.AddScoped<IActorViewService<EmployerTradeCenter>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerTCommodity>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerSTCommodity>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerMTCommodity>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerETCommodity>, EmployerLogister>();

builder.Services.AddScoped<IActorViewService<EmployerOrderCenter>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerOCommodity>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerSOCommodity>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerMOCommodity>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerEOCommodity>, EmployerLogister>();

builder.Services.AddScoped<IActorViewService<EmployerGOC>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerGOCC>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerSGOC>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerMGOC>, EmployerLogister>();
builder.Services.AddScoped<IActorViewService<EmployerEGOC>, EmployerLogister>();

builder.Services.AddScoped<IActorViewService<EmployerEmployeeRole>, EmployerActor>();
builder.Services.AddScoped<IActorViewService<EmployerHRBusinessPart>, EmployerActor>();
builder.Services.AddScoped<IActorViewService<EmployerHRCenter>, EmployerActor>();
builder.Services.AddScoped<IActorViewService<EmployerHREmployee>, EmployerActor>();
builder.Services.AddScoped<IActorViewService<EmployerHRRole>, EmployerActor>();
builder.Services.AddScoped<IActorViewService<EmployerJCommodity>, EmployerActor>();
builder.Services.AddScoped<IActorViewService<EmployerJournal>, EmployerActor>();
builder.Services.AddScoped<IActorViewService<EmployerJournalCenter>, EmployerActor>();

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
