using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGenericRepository;
using BusinessData.ofWarehouse.ofDbContext;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

bool IsProduct = false;
string WarehouseDbConnectionString = "";
if(IsProduct)
{
    // Add services to the container.
   WarehouseDbConnectionString = builder.Configuration.GetConnectionString("WarehouseDbConnection");
}
else
{
    WarehouseDbConnectionString = DevelopmentDbConnetionString.WarehouseDbConnection;
}
builder.Services.AddDbContext<WarehouseDbContext>(options =>
       options.UseSqlServer(WarehouseDbConnectionString));

builder.Services.AddScoped(typeof(IEntityManager<>), typeof(EntityManager<>));
builder.Services.AddScoped(typeof(IEntityIdFactory<>), typeof(EntityIdFactory<>));
builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(IEntityContainerFactory<>), typeof(EntityContainerFactory<>));
builder.Services.AddScoped(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(DicConvertFactory<>));

builder.Services.AddScoped(typeof(ICenterManager<>), typeof(CenterManager<>));
builder.Services.AddScoped(typeof(ICenterIdFactory<>), typeof(CenterIdFactory<>));
builder.Services.AddScoped(typeof(ICenterDataRepository<>), typeof(CenterDataRepository<>));
builder.Services.AddScoped(typeof(ICenterFileFactory<>), typeof(CenterFileFactory<>));

builder.Services.AddScoped(typeof(ICommodityManager<>), typeof(CommodityManager<>));
builder.Services.AddScoped(typeof(ICommodityIdFactory<>), typeof(CommodityIdFactory<>));
builder.Services.AddScoped(typeof(ICommodityDataRepository<>), typeof(CommodityDataRepository<>));
builder.Services.AddScoped(typeof(ICommodityFileFactory<>), typeof(CommodityFileFactory<>));

builder.Services.AddScoped(typeof(IStatusIdFactory<>), typeof(StatusIdFactory<>));
builder.Services.AddScoped(typeof(IStatusManager<>), typeof(StatusManager<>));
builder.Services.AddScoped(typeof(IStatusDataRepository<>), typeof(StatusDataRepository<>));
builder.Services.AddScoped(typeof(IStatusFileFactory<>), typeof(StatusFileFactory<>));

builder.Services.AddScoped(typeof(ISStatusManager<>), typeof(SStatusManager<>));
builder.Services.AddScoped(typeof(ISStatusDataRepository<>), typeof(SStatusDataRepository<>));

builder.Services.AddScoped(typeof(IMStatusManager<>), typeof(MStatusManager<>));
builder.Services.AddScoped(typeof(IMStatusDataRepository<>), typeof(MStatusDataRepository<>));

builder.Services.AddScoped(typeof(IEStatusManager<>), typeof(EStatusManager<>));
builder.Services.AddScoped(typeof(IEStatusDataRepository<>), typeof(EStatusDataRepository<>));

builder.Services.AddScoped<IWarehouseManager, WarehouseManager>();
builder.Services.AddScoped<IWCommodityManager, WCommodityManager>();
builder.Services.AddScoped<ISWCommodityManager, SWCommodityManager>();
builder.Services.AddScoped<IMWCommodityManager, MWCommodityManager>();
builder.Services.AddScoped<IEWCommodityManager, EWCommodityManager>();

builder.Services.AddScoped<IEmployeeWarehouseManager, WarehouseManager>();
builder.Services.AddScoped<IEmployeeWCommodityManager, WCommodityManager>();
builder.Services.AddScoped<IEmployeeSWCommodityManager, SWCommodityManager>();
builder.Services.AddScoped<IEmployeeMWCommodityManager, MWCommodityManager>();
builder.Services.AddScoped<IEmployeeEWCommodityManager, EWCommodityManager>();

builder.Services.AddScoped<IEmployerWarehouseManager, WarehouseManager>();
builder.Services.AddScoped<IEmployerWCommodityManager, WCommodityManager>();
builder.Services.AddScoped<IEmployerSWCommodityManager, SWCommodityManager>();
builder.Services.AddScoped<IEmployerMWCommodityManager, MWCommodityManager>();
builder.Services.AddScoped<IEmployerEWCommodityManager, EWCommodityManager>();

builder.Services.AddScoped<IPlatformWarehouseManager, WarehouseManager>();
builder.Services.AddScoped<IPlatformWCommodityManager, WCommodityManager>();
builder.Services.AddScoped<IPlatformSWCommodityManager, SWCommodityManager>();
builder.Services.AddScoped<IPlatformMWCommodityManager, MWCommodityManager>();
builder.Services.AddScoped<IPlatformEWCommodityManager, EWCommodityManager>();

builder.Services.AddScoped<IWarehouseRepository, WarehouseRepository>();
builder.Services.AddScoped<IWCommodityRepository, WCommodityRepository>();
builder.Services.AddScoped<ISWCommodityRepository, SWCommodityRepository>();
builder.Services.AddScoped<IMWCommodityRepository, MWCommodityRepository>();
builder.Services.AddScoped<IEWCommodityRepository, EWCommodityRepository>();

builder.Services.AddScoped<IEmployeeWarehouseRepository, WarehouseRepository>();
builder.Services.AddScoped<IEmployeeWCommodityRepository, WCommodityRepository>();
builder.Services.AddScoped<IEmployeeSWCommodityRepository, SWCommodityRepository>();
builder.Services.AddScoped<IEmployeeMWCommodityRepository, MWCommodityRepository>();
builder.Services.AddScoped<IEmployeeEWCommodityRepository, EWCommodityRepository>();

builder.Services.AddScoped<IEmployerWarehouseRepository, WarehouseRepository>();
builder.Services.AddScoped<IEmployerWCommodityRepository, WCommodityRepository>();
builder.Services.AddScoped<IEmployerSWCommodityRepository, SWCommodityRepository>();
builder.Services.AddScoped<IEmployerMWCommodityRepository, MWCommodityRepository>();
builder.Services.AddScoped<IEmployerEWCommodityRepository, EWCommodityRepository>();

builder.Services.AddScoped<IPlatformWarehouseRepository, WarehouseRepository>();
builder.Services.AddScoped<IPlatformWCommodityRepository, WCommodityRepository>();
builder.Services.AddScoped<IPlatformSWCommodityRepository, SWCommodityRepository>();
builder.Services.AddScoped<IPlatformMWCommodityRepository, MWCommodityRepository>();
builder.Services.AddScoped<IPlatformEWCommodityRepository, EWCommodityRepository>();

builder.Services.AddScoped<IWarehouseFileFactory, WarehouseFileFactory>();
builder.Services.AddScoped<IWCommodityFileFactory, WCommodityFileFactory>();
builder.Services.AddScoped<ISWCommodityFileFactory, SWCommodityFileFactory>();
builder.Services.AddScoped<IMWCommodityFileFactory, MWCommodityFileFactory>();
builder.Services.AddScoped<IEWCommodityFileFactory, EWCommodityFileFactory>();

builder.Services.AddScoped<IWarehouseBlobStorage, WarehouseBlobStorage>();
builder.Services.AddScoped<IWCommodityBlobStorage, WCommodityBlobStorage>();
builder.Services.AddScoped<ISWCommodityBlobStorage, SWCommodityBlobStorage>();
builder.Services.AddScoped<IMWCommodityBlobStorage, MWCommodityBlobStorage>();
builder.Services.AddScoped<IEWCommodityBlobStorage, EWCommodityBlobStorage>();

builder.Services.AddScoped<IWarehouseIdFactory, WarehouseIdFactory>();
builder.Services.AddScoped<IWCommodityIdFactory, WCommodityIdFactory>();
builder.Services.AddScoped<ISWCommodityIdFactory, SWCommodityIdFactory>();
builder.Services.AddScoped<IMWCommodityIdFactory, MWCommodityIdFactory>();
builder.Services.AddScoped<IEWCommodityIdFactory, EWCommodityIdFactory>();

builder.Services.AddScoped<IWarehouseBlobContainerFactory, WarehouseBlobContainerFactory>();
builder.Services.AddScoped<IWCommodityBlobContainerFactory, WCommodityBlobContainerFactory>();
builder.Services.AddScoped<ISWCommodityBlobContainerFactory, SWCommodityBlobContainerFactory>();
builder.Services.AddScoped<IMWCommodityBlobContainerFactory, MWCommodityBlobContainerFactory>();
builder.Services.AddScoped<IEWCommodityBlobContainerFactory, EWCommodityBlobContainerFactory>();

builder.Services.AddScoped(typeof(CenterPasswordHasher<>));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
