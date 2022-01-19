using BusinessData;
using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofHsCode.ofRepository;
using BusinessData.ofCommon.ofKamis.ofDbContext;
using BusinessData.ofCommon.ofKamis.ofRepository;
using BusinessData.ofCommon.ofKAprt.ofRepository;
using BusinessData.ofCommon.ofKApt.ofDbContext;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessLogic.ofManagement;
using BusinessLogic.ofManagement.ofPatform;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLoogic.ofManager.ofHsCode;
using BusinessLoogic.ofManager.ofKamis;
using BusinessLoogic.ofManager.ofKApt;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using PlatformManager.Areas.Identity;
using PlatformManager.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

var HsDbConnectionString = builder.Configuration.GetConnectionString("HsDbConnection");
builder.Services.AddDbContext<HsDbContext>(options =>
    options.UseSqlServer(HsDbConnectionString));

var KamisDbConnectionString = builder.Configuration.GetConnectionString("KamisDbConnection");
builder.Services.AddDbContext<KamisDbContext>(optoins =>
optoins.UseSqlServer(KamisDbConnectionString));

var KAptDbConnectionString = builder.Configuration.GetConnectionString("KAptDbConnection");
builder.Services.AddDbContext<KAptDbContext>(optoins =>
optoins.UseSqlServer(KAptDbConnectionString));

builder.Services.AddScoped<ProtectedLocalStorage>();
builder.Services.AddScoped<ProtectedSessionStorage>();

builder.Services.AddScoped(typeof(IEntityManager<>), typeof(EntityManager<>));
builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(IEntityIdFactory<>), typeof(EntityIdFactory<>));
builder.Services.AddScoped(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(IEntityContainerFactory<>), typeof(EntityContainerFactory<>));
builder.Services.AddScoped(typeof(DicConvertFactory<>));

builder.Services.AddScoped<KamisPartRepository>();
builder.Services.AddScoped<KamisCommodityRepository>();
builder.Services.AddScoped<KamisKindofCommodityRepository>();
builder.Services.AddScoped<KamisGradeRepository>();
builder.Services.AddScoped<KamisCountryAdministrationPartRepository>();
builder.Services.AddScoped<KamisMarketRepository>();
builder.Services.AddScoped<KamisWholeSalePriceRepository>();
builder.Services.AddScoped<KamisRetailPriceRepository>();

builder.Services.AddScoped<HsCodePartRepository>();
builder.Services.AddScoped<PracticalHsCodeRepository>();
builder.Services.AddScoped<SubPartofHsCodeRepository>();
builder.Services.AddScoped<SubPracticalHsCodeRepository>();
builder.Services.AddScoped<DetailPracticalHsCodeRepository>();
builder.Services.AddScoped<CountryRepository>();
builder.Services.AddScoped<ClaranceInfoofHsCodeRepostiroy>();

builder.Services.AddScoped<KAptBasicInfoRepository>();
builder.Services.AddScoped<KAptBasicInfoManager>();

builder.Services.AddScoped<HsCodePartManager>();
builder.Services.AddScoped<PracticalHsCodeManager>();
builder.Services.AddScoped<SubPartofHsCodeManager>();
builder.Services.AddScoped<SubPracticalHsCodeManager>();
builder.Services.AddScoped<DetailPracticalHsCodeManager>();
builder.Services.AddScoped<CountryManager>();
builder.Services.AddScoped<ClearanceInfoofHsCodeManager>();

builder.Services.AddScoped<KamisPartManager>();
builder.Services.AddScoped<KamisCommodityManager>();
builder.Services.AddScoped<KamisKindofCommodityManager>();
builder.Services.AddScoped<KamisGradeManager>();
builder.Services.AddScoped<KamisCountryAdministrationPartManager>();
builder.Services.AddScoped<KamisMarketManager>();
builder.Services.AddScoped<KamisWholeSalePriceManager>();
builder.Services.AddScoped<KamisRetailPriceManager>();
builder.Services.AddScoped<KamisAPIManager>();
builder.Services.AddScoped<KamisRequestFactory>();

builder.Services.AddScoped<PlatFormManagement>();
builder.Services.AddScoped<HsCodeManagement>();
builder.Services.AddScoped<KamisManagement>();
builder.Services.AddScoped<KAptManagement>();

builder.Services.AddMudServices();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

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
