using BusinessData;
using BusinessData.ofAccount;
using BusinessData.ofCommon;
using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofHsCode.ofRepository;
using BusinessData.ofCommon.ofKamis.ofDbContext;
using BusinessData.ofCommon.ofKamis.ofRepository;
using BusinessData.ofCommon.ofKAprt.ofRepository;
using BusinessData.ofCommon.ofKApt.ofDbContext;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGenericRepository;
using BusinessData.ofGO.ofRepository;
using BusinessData.ofGroupOrder.ofDbContext;
using BusinessData.ofOrder.ofDbContext;
using BusinessData.ofOrder.ofRepository;
using BusinessData.ofWarehouse.ofDbContext;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManagement;
using BusinessLogic.ofManagement.ofPatform;
using BusinessLogic.ofManager.ofFisheries;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;
using BusinessLogic.ofManager.ofOrder;
using BusinessLogic.ofManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;
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
using PlatformManager.ofComponent.ofGeneric;

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

var WarehosueDbConnectionString = builder.Configuration.GetConnectionString("WarehouseDbConnection");
builder.Services.AddDbContext<WarehouseDbContext>(optoins =>
optoins.UseSqlServer(WarehosueDbConnectionString));

var GODbConnectionString = builder.Configuration.GetConnectionString("GODbConnection");
builder.Services.AddDbContext<GODbContext>(optoins =>
optoins.UseSqlServer(GODbConnectionString));

var FisheriesConnectionString = builder.Configuration.GetConnectionString("FisheriesConnection");
builder.Services.AddDbContext<FisheriesDbContext>(options =>
options.UseSqlServer(FisheriesConnectionString));

var BusinessUserConnectionString = builder.Configuration.GetConnectionString("BusinessUserDbConnection");
builder.Services.AddDbContext<BusinessUserDbContext>(options =>
options.UseSqlServer(BusinessUserConnectionString));

var OrderConnectionString = builder.Configuration.GetConnectionString("OrderDbConnection");
builder.Services.AddDbContext<OrderDbContext>(options =>
options.UseSqlServer(BusinessUserConnectionString));

builder.Services.AddScoped<ProtectedLocalStorage>();
builder.Services.AddScoped<ProtectedSessionStorage>();

builder.Services.AddScoped(typeof(EntityManager<>));
builder.Services.AddScoped(typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(EntityIdFactory<>));
builder.Services.AddScoped(typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(EntityContainerFactory<>));
builder.Services.AddScoped(typeof(DicConvertFactory<>));
builder.Services.AddScoped(typeof(IEntityManager<>), typeof(EntityManager<>));
builder.Services.AddScoped(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(IEntityIdFactory<>), typeof(EntityIdFactory<>));
builder.Services.AddScoped(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(IEntityContainerFactory<>), typeof(EntityContainerFactory<>));

builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped(typeof(ICenterDataRepository<>), typeof(CenterDataRepository<>));
builder.Services.AddScoped(typeof(ICommodityDataRepository<>), typeof(CommodityDataRepository<>));
builder.Services.AddScoped(typeof(IStatusDataRepository<>), typeof(StatusDataRepository<>));

builder.Services.AddScoped(typeof(ICenterIdFactory<>), typeof(CenterIdFactory<>));
builder.Services.AddScoped(typeof(ICommodityIdFactory<>), typeof(CommodityIdFactory<>));
builder.Services.AddScoped(typeof(IStatusIdFactory<>), typeof(StatusIdFactory<>));

builder.Services.AddScoped(typeof(CenterManager<>));
builder.Services.AddScoped(typeof(ICenterManager<>), typeof(CenterManager<>));
builder.Services.AddScoped(typeof(CenterPasswordHasher<>));
builder.Services.AddScoped(typeof(CommodityManager<>));
builder.Services.AddScoped(typeof(ICommodityManager<>), typeof(CommodityManager<>));
builder.Services.AddScoped(typeof(IStatusManager<>), typeof(StatusManager<>));

builder.Services.AddScoped(typeof(ICenterFileFactory<>), typeof(CenterFileFactory<>));
builder.Services.AddScoped(typeof(ICommodityFileFactory<>), typeof(CommodityFileFactory<>));
builder.Services.AddScoped(typeof(IStatusFileFactory<>), typeof(StatusFileFactory<>));

builder.Services.AddScoped(typeof(SStatusManager<>));
builder.Services.AddScoped(typeof(MStatusManager<>));
builder.Services.AddScoped(typeof(EStatusManager<>));
builder.Services.AddScoped(typeof(ISStatusManager<>), typeof(SStatusManager<>));
builder.Services.AddScoped(typeof(IMStatusManager<>), typeof(MStatusManager<>));
builder.Services.AddScoped(typeof(IEStatusManager<>), typeof(EStatusManager<>));

builder.Services.AddScoped<IWarehouseRepository, WarehouseRepository>();
builder.Services.AddScoped<IWarehouseBlobStorage, WarehouseBlobStorage>();
builder.Services.AddScoped<IWarehouseIdFactory, WarehouseIdFactory>();
builder.Services.AddScoped<IWarehouseBlobContainerFactory, WarehouseBlobContainerFactory>();
builder.Services.AddScoped<IWarehouseFileFactory, WarehouseFileFactory>();
builder.Services.AddScoped<IWarehouseManager, WarehouseManager>();


builder.Services.AddScoped<IWCommodityRepository, WCommodityRepository>();
builder.Services.AddScoped<IWCommodityBlobStorage, WCommodityBlobStorage>();
builder.Services.AddScoped<IWCommodityIdFactory, WCommodityIdFactory>();
builder.Services.AddScoped<IWCommodityBlobContainerFactory, WCommodityBlobContainerFactory>();
builder.Services.AddScoped<IWCommodityFileFactory, WCommodityFileFactory>();

builder.Services.AddScoped<ISWCommodityRepository, SWCommodityRepository>();
builder.Services.AddScoped<ISWCommodityBlobStorage, SWCommodityBlobStorage>();
builder.Services.AddScoped<ISWCommodityIdFactory, SWCommodityIdFactory>();
builder.Services.AddScoped<ISWCommodityBlobContainerFactory, SWCommodityBlobContainerFactory>();
builder.Services.AddScoped<ISWCommodityFileFactory, SWCommodityFileFactory>();

builder.Services.AddScoped<IMWCommodityRepository, MWCommodityRepository>();
builder.Services.AddScoped<IMWCommodityBlobStorage, MWCommodityBlobStorage>();
builder.Services.AddScoped<IMWCommodityIdFactory, MWCommodityIdFactory>();
builder.Services.AddScoped<IMWCommodityBlobContainerFactory, MWCommodityBlobContainerFactory>();
builder.Services.AddScoped<IMWCommodityFileFactory, MWCommodityFileFactory>();

builder.Services.AddScoped<IEWCommodityRepository, EWCommodityRepository>();
builder.Services.AddScoped<IEWCommodityBlobStorage, EWCommodityBlobStorage>();
builder.Services.AddScoped<IEWCommodityIdFactory, EWCommodityIdFactory>();
builder.Services.AddScoped<IEWCommodityBlobContainerFactory, EWCommodityBlobContainerFactory>();
builder.Services.AddScoped<IEWCommodityFileFactory, EWCommodityFileFactory>();

builder.Services.AddScoped<IOrderCenterRepository, OrderCenterRepository>();
builder.Services.AddScoped<IOrderCenterBlobStorage, OrderCenterBlobStorage>();
builder.Services.AddScoped<IOrderCenterIdFactory, OrderCenterIdFactory>();
builder.Services.AddScoped<IOrderCenterBlobContainerFactory, OrderCenterBlobContainerFactory>();
builder.Services.AddScoped<IOrderCenterFileFactory, OrderCenterFileFactory>();
builder.Services.AddScoped<IOrderCenterManager, OrderCenterManager>();

builder.Services.AddScoped<IOCommodityRepository, OCommodityRepository>();
builder.Services.AddScoped<IOCommodityBlobStorage, OCommodityBlobStorage>();
builder.Services.AddScoped<IOCommodityIdFactory, OCommodityIdFactory>();
builder.Services.AddScoped<IOCommodityBlobContainerFactory, OCommodityBlobContainerFactory>();
builder.Services.AddScoped<IOCommodityFileFactory, OCommodityFileFactory>();
builder.Services.AddScoped<IOCommodityManager, OCommodityManager>();

builder.Services.AddScoped<ISOCommodityRepository, SOCommodityRepository>();
builder.Services.AddScoped<ISOCommodityBlobStorage, SOCommodityBlobStorage>();
builder.Services.AddScoped<ISOCommodityIdFactory, SOCommodityIdFactory>();
builder.Services.AddScoped<ISOCommodityBlobContainerFactory, SOCommodityBlobContainerFactory>();
builder.Services.AddScoped<ISOCommodityFileFactory, SOCommodityFileFactory>();
builder.Services.AddScoped<ISOCommodityManager, SOCommodityManager>();

builder.Services.AddScoped<IMOCommodityRepository, MOCommodityRepository>();
builder.Services.AddScoped<IMOCommodityBlobStorage, MOCommodityBlobStorage>();
builder.Services.AddScoped<IMOCommodityIdFactory, MOCommodityIdFactory>();
builder.Services.AddScoped<IMOCommodityBlobContainerFactory, MOCommodityBlobContainerFactory>();
builder.Services.AddScoped<IMOCommodityFileFactory, MOCommodityFileFactory>();
builder.Services.AddScoped<IMOCommodityManager, MOCommodityManager>();

builder.Services.AddScoped<IEOCommodityRepository, EOCommodityRepository>();
builder.Services.AddScoped<IEOCommodityBlobStorage, EOCommodityBlobStorage>();
builder.Services.AddScoped<IEOCommodityIdFactory, EOCommodityIdFactory>();
builder.Services.AddScoped<IEOCommodityBlobContainerFactory, EOCommodityBlobContainerFactory>();
builder.Services.AddScoped<IEOCommodityFileFactory, EOCommodityFileFactory>();
builder.Services.AddScoped<IEOCommodityManager, EOCommodityManager>();

builder.Services.AddScoped<IGOCRepository, GOCRepository>();
builder.Services.AddScoped<IGOCBlobStorage, GOCBlobStorage>();
builder.Services.AddScoped<IGOCIdFactory, GOCIdFactory>();
builder.Services.AddScoped<IGOCBlobContainerFactory, GOCBlobContainerFactory>();
builder.Services.AddScoped<IGOCFileFactory, GOCFileFactory>();
builder.Services.AddScoped<IGOCManager, GOCManager>();

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

builder.Services.AddScoped<FisheriesAPIManager>();
builder.Services.AddScoped<FisheriesRequestFactory>();
builder.Services.AddScoped<FisheriesManagement>();

builder.Services.AddScoped<PlatFormManagement>();
builder.Services.AddScoped<HsCodeManagement>();
builder.Services.AddScoped<KamisManagement>();
builder.Services.AddScoped<KAptManagement>();
builder.Services.AddScoped<GOCManagement>();

builder.Services.AddScoped(typeof(EntityTableComponent<>));

/********************************************/
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
