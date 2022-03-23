using BusinessData;
using BusinessData.ofTrade.ofDbContext;
using BusinessData.ofTrade.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofTradeCenter;
using BusinessLogic.ofManager.ofTradeCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofTradeCenter.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var TradeDbConnectionString = builder.Configuration.GetConnectionString("TradeDbConnection");
builder.Services.AddDbContext<TradeDbContext>(options =>
    options.UseSqlServer(TradeDbConnectionString));

builder.Services.AddScoped(typeof(IEntityManager<>), typeof(EntityManager<>));
builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(IEntityContainerFactory<>), typeof(EntityContainerFactory<>));
builder.Services.AddScoped(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(DicConvertFactory<>));

builder.Services.AddScoped<TradeCenterManager>();
builder.Services.AddScoped<TCommodityManager>();
builder.Services.AddScoped<STCommodityManager>();
builder.Services.AddScoped<MTCommodityManager>();
builder.Services.AddScoped<ETCommodityManager>();

builder.Services.AddScoped<ITradeCenterRepository, TradeCenterRepository>();
builder.Services.AddScoped<ITCommodityRepository, TCommodityRepository>();
builder.Services.AddScoped<ISTCommodityRepository, STCommodityRepository>();
builder.Services.AddScoped<IMTCommodityRepository, MTCommodityRepository>();
builder.Services.AddScoped<IETCommodityRepository, ETCommodityRepository>();

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
