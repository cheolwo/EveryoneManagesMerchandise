using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGenericRepository;
using BusinessData.ofTrade.ofDbContext;
using BusinessData.ofTrade.ofinterface.ofEmployee;
using BusinessData.ofTrade.ofinterface.ofEmployer;
using BusinessData.ofTrade.ofinterface.ofPlatform;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter;
using BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofTradeCenter.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofIdFactory;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofTradeCenter.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

bool IsProduct = false;
bool IsInMemory = false;
string TradeDbConnectionString = "";
if(IsProduct)
{
    // Add services to the container.
   TradeDbConnectionString = builder.Configuration.GetConnectionString("TradeDbConnection");
}
else
{
    TradeDbConnectionString = DevelopmentDbConnetionString.TradeDbConnection;
}
if(IsInMemory)
{
    builder.Services.AddDbContext<TradeDbContext>(options =>
    options.UseSqlServer(TradeDbConnectionString).UseInMemoryDatabase("TradeTestDb"));
}
else
{
    builder.Services.AddDbContext<TradeDbContext>(options =>
    options.UseSqlServer(TradeDbConnectionString));
}


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

builder.Services.AddScoped<ITradeCenterManager, TradeCenterManager>();
builder.Services.AddScoped<ITCommodityManager, TCommodityManager>();
builder.Services.AddScoped<ISTCommodityManager, STCommodityManager>();
builder.Services.AddScoped<IMTCommodityManager, MTCommodityManager>();
builder.Services.AddScoped<IETCommodityManager, ETCommodityManager>();

builder.Services.AddScoped<IEmployeeTradeCenterManager, TradeCenterManager>();
builder.Services.AddScoped<IEmployeeTCommodityManager, TCommodityManager>();
builder.Services.AddScoped<IEmployeeSTCommodityManager, STCommodityManager>();
builder.Services.AddScoped<IEmployeeMTCommodityManager, MTCommodityManager>();
builder.Services.AddScoped<IEmployeeETCommodityManager, ETCommodityManager>();

builder.Services.AddScoped<IEmployerTradeCenterManager, TradeCenterManager>();
builder.Services.AddScoped<IEmployerTCommodityManager, TCommodityManager>();
builder.Services.AddScoped<IEmployerSTCommodityManager, STCommodityManager>();
builder.Services.AddScoped<IEmployerMTCommodityManager, MTCommodityManager>();
builder.Services.AddScoped<IEmployerETCommodityManager, ETCommodityManager>();

builder.Services.AddScoped<IPlatformTradeCenterManager, TradeCenterManager>();
builder.Services.AddScoped<IPlatformTCommodityManager, TCommodityManager>();
builder.Services.AddScoped<IPlatformSTCommodityManager, STCommodityManager>();
builder.Services.AddScoped<IPlatformMTCommodityManager, MTCommodityManager>();
builder.Services.AddScoped<IPlatformETCommodityManager, ETCommodityManager>();

builder.Services.AddScoped<ITradeCenterRepository, TradeCenterRepository>();
builder.Services.AddScoped<ITCommodityRepository, TCommodityRepository>();
builder.Services.AddScoped<ISTCommodityRepository, STCommodityRepository>();
builder.Services.AddScoped<IMTCommodityRepository, MTCommodityRepository>();
builder.Services.AddScoped<IETCommodityRepository, ETCommodityRepository>();

builder.Services.AddScoped<IEmployeeTradeCenterRepository, TradeCenterRepository>();
builder.Services.AddScoped<IEmployeeTCommodityRepository, TCommodityRepository>();
builder.Services.AddScoped<IEmployeeSTCommodityRepository, STCommodityRepository>();
builder.Services.AddScoped<IEmployeeMTCommodityRepository, MTCommodityRepository>();
builder.Services.AddScoped<IEmployeeETCommodityRepository, ETCommodityRepository>();

builder.Services.AddScoped<IEmployerTradeCenterRepository, TradeCenterRepository>();
builder.Services.AddScoped<IEmployerTCommodityRepository, TCommodityRepository>();
builder.Services.AddScoped<IEmployerSTCommodityRepository, STCommodityRepository>();
builder.Services.AddScoped<IEmployerMTCommodityRepository, MTCommodityRepository>();
builder.Services.AddScoped<IEmployerETCommodityRepository, ETCommodityRepository>();

builder.Services.AddScoped<IPlatformTradeCenterRepository, TradeCenterRepository>();
builder.Services.AddScoped<IPlatformTCommodityRepository, TCommodityRepository>();
builder.Services.AddScoped<IPlatformSTCommodityRepository, STCommodityRepository>();
builder.Services.AddScoped<IPlatformMTCommodityRepository, MTCommodityRepository>();
builder.Services.AddScoped<IPlatformETCommodityRepository, ETCommodityRepository>();

builder.Services.AddScoped<ITradeCenterFileFactory, TradeCenterFileFactory>();
builder.Services.AddScoped<ITCommodityFileFactory, TCommodityFileFactory>();
builder.Services.AddScoped<ISTCommodityFileFactory, STCommodityFileFactory>();
builder.Services.AddScoped<IMTCommodityFileFactory, MTCommodityFileFactory>();
builder.Services.AddScoped<IETCommodityFileFactory, ETCommodityFileFactory>();

builder.Services.AddScoped<ITradeCenterBlobStorage, TradeCenterBlobStorage>();
builder.Services.AddScoped<ITCommodityBlobStorage, TCommodityBlobStorage>();
builder.Services.AddScoped<ISTCommodityBlobStorage, STCommodityBlobStorage>();
builder.Services.AddScoped<IMTCommodityBlobStorage, MTCommodityBlobStorage>();
builder.Services.AddScoped<IETCommodityBlobStorage, ETCommodityBlobStorage>();

builder.Services.AddScoped<ITradeCenterIdFactory, TradeCenterIdFactory>();
builder.Services.AddScoped<ITCommodityIdFactory, TCommodityIdFactory>();
builder.Services.AddScoped<ISTCommodityIdFactory, STCommodityIdFactory>();
builder.Services.AddScoped<IMTCommodityIdFactory, MTCommodityIdFactory>();
builder.Services.AddScoped<IETCommodityIdFactory, ETCommodityIdFactory>();

builder.Services.AddScoped<ITradeCenterBlobContainerFactory, TradeCenterBlobContainerFactory>();
builder.Services.AddScoped<ITCommodityBlobContainerFactory, TCommodityBlobContainerFactory>();
builder.Services.AddScoped<ISTCommodityBlobContainerFactory, STCommodityBlobContainerFactory>();
builder.Services.AddScoped<IMTCommodityBlobContainerFactory, MTCommodityBlobContainerFactory>();
builder.Services.AddScoped<IETCommodityBlobContainerFactory, ETCommodityBlobContainerFactory>();

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
