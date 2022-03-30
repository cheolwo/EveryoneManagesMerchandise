using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGenericRepository;
using BusinessData.ofOrder.ofDbContext;
using BusinessData.ofOrder.ofInterface.ofEmployee;
using BusinessData.ofOrder.ofInterface.ofEmployer;
using BusinessData.ofOrder.ofInterface.ofPlatform;
using BusinessData.ofOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofOrder;
using BusinessLogic.ofManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofOrder.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofOrder.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofOrder.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var OrderDbConnectionString = builder.Configuration.GetConnectionString("OrderDbConnection");
builder.Services.AddDbContext<OrderDbContext>(options =>
    options.UseSqlServer(OrderDbConnectionString));

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

builder.Services.AddScoped<IOrderCenterManager, OrderCenterManager>();
builder.Services.AddScoped<IOCommodityManager, OCommodityManager>();
builder.Services.AddScoped<ISOCommodityManager, SOCommodityManager>();
builder.Services.AddScoped<IMOCommodityManager, MOCommodityManager>();
builder.Services.AddScoped<IEOCommodityManager, EOCommodityManager>();

builder.Services.AddScoped<IEmployeeOrderCenterManager, OrderCenterManager>();
builder.Services.AddScoped<IEmployeeOCommodityManager, OCommodityManager>();
builder.Services.AddScoped<IEmployeeSOCommodityManager, SOCommodityManager>();
builder.Services.AddScoped<IEmployeeMOCommodityManager, MOCommodityManager>();
builder.Services.AddScoped<IEmployeeEOCommodityManager, EOCommodityManager>();

builder.Services.AddScoped<IEmployerOrderCenterManager, OrderCenterManager>();
builder.Services.AddScoped<IEmployerOCommodityManager, OCommodityManager>();
builder.Services.AddScoped<IEmployerSOCommodityManager, SOCommodityManager>();
builder.Services.AddScoped<IEmployerMOCommodityManager, MOCommodityManager>();
builder.Services.AddScoped<IEmployerEOCommodityManager, EOCommodityManager>();

builder.Services.AddScoped<IPlatformOrderCenterManager, OrderCenterManager>();
builder.Services.AddScoped<IPlatformOCommodityManager, OCommodityManager>();
builder.Services.AddScoped<IPlatformSOCommodityManager, SOCommodityManager>();
builder.Services.AddScoped<IPlatformMOCommodityManager, MOCommodityManager>();
builder.Services.AddScoped<IPlatformEOCommodityManager, EOCommodityManager>();

builder.Services.AddScoped<IOrderCenterRepository, OrderCenterRepository>();
builder.Services.AddScoped<IOCommodityRepository, OCommodityRepository>();
builder.Services.AddScoped<ISOCommodityRepository, SOCommodityRepository>();
builder.Services.AddScoped<IMOCommodityRepository, MOCommodityRepository>();
builder.Services.AddScoped<IEOCommodityRepository, EOCommodityRepository>();

builder.Services.AddScoped<IEmployeeOrderCenterRepository, OrderCenterRepository>();
builder.Services.AddScoped<IEmployeeOCommodityRepository, OCommodityRepository>();
builder.Services.AddScoped<IEmployeeSOCommodityRepository, SOCommodityRepository>();
builder.Services.AddScoped<IEmployeeMOCommodityRepository, MOCommodityRepository>();
builder.Services.AddScoped<IEmployeeEOCommodityRepository, EOCommodityRepository>();

builder.Services.AddScoped<IEmployerOrderCenterRepository, OrderCenterRepository>();
builder.Services.AddScoped<IEmployerOCommodityRepository, OCommodityRepository>();
builder.Services.AddScoped<IEmployerSOCommodityRepository, SOCommodityRepository>();
builder.Services.AddScoped<IEmployerMOCommodityRepository, MOCommodityRepository>();
builder.Services.AddScoped<IEmployerEOCommodityRepository, EOCommodityRepository>();

builder.Services.AddScoped<IPlatformOrderCenterRepository, OrderCenterRepository>();
builder.Services.AddScoped<IPlatformOCommodityRepository, OCommodityRepository>();
builder.Services.AddScoped<IPlatformSOCommodityRepository, SOCommodityRepository>();
builder.Services.AddScoped<IPlatformMOCommodityRepository, MOCommodityRepository>();
builder.Services.AddScoped<IPlatformEOCommodityRepository, EOCommodityRepository>();

builder.Services.AddScoped<IOrderCenterFileFactory, OrderCenterFileFactory>();
builder.Services.AddScoped<IOCommodityFileFactory, OCommodityFileFactory>();
builder.Services.AddScoped<ISOCommodityFileFactory, SOCommodityFileFactory>();
builder.Services.AddScoped<IMOCommodityFileFactory, MOCommodityFileFactory>();
builder.Services.AddScoped<IEOCommodityFileFactory, EOCommodityFileFactory>();

builder.Services.AddScoped<IOrderCenterBlobStorage, OrderCenterBlobStorage>();
builder.Services.AddScoped<IOCommodityBlobStorage, OCommodityBlobStorage>();
builder.Services.AddScoped<ISOCommodityBlobStorage, SOCommodityBlobStorage>();
builder.Services.AddScoped<IMOCommodityBlobStorage, MOCommodityBlobStorage>();
builder.Services.AddScoped<IEOCommodityBlobStorage, EOCommodityBlobStorage>();

builder.Services.AddScoped<IOrderCenterIdFactory, OrderCenterIdFactory>();
builder.Services.AddScoped<IOCommodityIdFactory, OCommodityIdFactory>();
builder.Services.AddScoped<ISOCommodityIdFactory, SOCommodityIdFactory>();
builder.Services.AddScoped<IMOCommodityIdFactory, MOCommodityIdFactory>();
builder.Services.AddScoped<IEOCommodityIdFactory, EOCommodityIdFactory>();

builder.Services.AddScoped<IOrderCenterBlobContainerFactory, OrderCenterBlobContainerFactory>();
builder.Services.AddScoped<IOCommodityBlobContainerFactory, OCommodityBlobContainerFactory>();
builder.Services.AddScoped<ISOCommodityBlobContainerFactory, SOCommodityBlobContainerFactory>();
builder.Services.AddScoped<IMOCommodityBlobContainerFactory, MOCommodityBlobContainerFactory>();
builder.Services.AddScoped<IEOCommodityBlobContainerFactory, EOCommodityBlobContainerFactory>();

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
