using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGenericRepository;
using BusinessData.ofMarket.ofRepository.ofIdFactory;
using BusinessData.ofProduct.ofDbContext;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofProduct;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofTradeCenter;
using BusinessLogic.ofManager.ofWarehouse;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var ProductDbConnectionString = builder.Configuration.GetConnectionString("ProductDbConnection");
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(ProductDbConnectionString));

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

builder.Services.AddScoped<IProductCenterManager, ProductCenterManager>();
builder.Services.AddScoped<IPCommodityManager, PCommodityManager>();
builder.Services.AddScoped<ISPCommodityManager, SPCommodityManager>();
builder.Services.AddScoped<IMPCommodityManager, MPCommodityManager>();
builder.Services.AddScoped<IEPCommodityManager, EPCommodityManager>();

builder.Services.AddScoped<IEmployeeProductCenterManager, ProductCenterManager>();
builder.Services.AddScoped<IEmployeePCommodityManager, PCommodityManager>();
builder.Services.AddScoped<IEmployeeSPCommodityManager, SPCommodityManager>();
builder.Services.AddScoped<IEmployeeMPCommodityManager, MPCommodityManager>();
builder.Services.AddScoped<IEmployeeEPCommodityManager, EPCommodityManager>();

builder.Services.AddScoped<IEmployerProductCenterManager, ProductCenterManager>();
builder.Services.AddScoped<IEmployerPCommodityManager, PCommodityManager>();
builder.Services.AddScoped<IEmployerSPCommodityManager, SPCommodityManager>();
builder.Services.AddScoped<IEmployerMPCommodityManager, MPCommodityManager>();
builder.Services.AddScoped<IEmployerEPCommodityManager, EPCommodityManager>();

builder.Services.AddScoped<IPlatformProductCenterManager, ProductCenterManager>();
builder.Services.AddScoped<IPlatformPCommodityManager, PCommodityManager>();
builder.Services.AddScoped<IPlatformSPCommodityManager, SPCommodityManager>();
builder.Services.AddScoped<IPlatformMPCommodityManager, MPCommodityManager>();
builder.Services.AddScoped<IPlatformEPCommodityManager, EPCommodityManager>();

builder.Services.AddScoped<IProductCenterRepository, ProductCenterRepository>();
builder.Services.AddScoped<IPCommodityRepository, PCommodityRepository>();
builder.Services.AddScoped<ISPCommodityRepository, SPCommodityRepository>();
builder.Services.AddScoped<IMPCommodityRepository, MPCommodityRepository>();
builder.Services.AddScoped<IEPCommodityRepository, EPCommodityRepository>();

builder.Services.AddScoped<IProductCenterFileFactory, ProductCenterFileFactory>();
builder.Services.AddScoped<IPCommodityFileFactory, PCommodityFileFactory>();
builder.Services.AddScoped<ISPCommodityFileFactory, SPCommodityFileFactory>();
builder.Services.AddScoped<IMPCommodityFileFactory, MPCommodityFileFactory>();
builder.Services.AddScoped<IEPCommodityFileFactory, EPCommodityFileFactory>();

builder.Services.AddScoped<IProductCenterBlobStorage, ProductCenterBlobStorage>();
builder.Services.AddScoped<IPCommodityBlobStorage, PCommodityBlobStorage>();
builder.Services.AddScoped<ISPCommodityBlobStorage, SPCommodityBlobStorage>();
builder.Services.AddScoped<IMPCommodityBlobStorage, MPCommodityBlobStorage>();
builder.Services.AddScoped<IEPCommodityBlobStorage, EPCommodityBlobStorage>();

builder.Services.AddScoped<IProductCenterIdFactory, ProductCenterIdFactory>();
builder.Services.AddScoped<IPCommodityIdFactory, PCommodityIdFactory>();
builder.Services.AddScoped<ISPCommodityIdFactory, SPCommodityIdFactory>();
builder.Services.AddScoped<IMPCommodityIdFactory, MPCommodityIdFactory>();
builder.Services.AddScoped<IEPCommodityIdFactory, EPCommodityIdFactory>();

builder.Services.AddScoped<IProductCenterBlobContainerFactory, ProductCenterBlobContainerFactory>();
builder.Services.AddScoped<IPCommodityBlobContainerFactory, PCommodityBlobContainerFactory>();
builder.Services.AddScoped<ISPCommodityBlobContainerFactory, SPCommodityBlobContainerFactory>();
builder.Services.AddScoped<IMPCommodityBlobContainerFactory, MPCommodityBlobContainerFactory>();
builder.Services.AddScoped<IEPCommodityBlobContainerFactory, EPCommodityBlobContainerFactory>();

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
