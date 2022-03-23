using BusinessData;
using BusinessData.ofWarehouse.ofDbContext;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var WarehouseDbConnectionString = builder.Configuration.GetConnectionString("WarehouseDbConnection");
builder.Services.AddDbContext<WarehouseDbContext>(options =>
    options.UseSqlServer(WarehouseDbConnectionString));

builder.Services.AddScoped(typeof(IEntityManager<>), typeof(EntityManager<>));
builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(IEntityContainerFactory<>), typeof(EntityContainerFactory<>));
builder.Services.AddScoped(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(DicConvertFactory<>));

builder.Services.AddScoped<WarehouseManager>();
builder.Services.AddScoped<WCommodityManager>();
builder.Services.AddScoped<SWCommodityManager>();
builder.Services.AddScoped<MWCommodityManager>();
builder.Services.AddScoped<EWCommodityManager>();

builder.Services.AddScoped<IWarehouseRepository, WarehouseRepository>();
builder.Services.AddScoped<IWCommodityRepository, WCommodityRepository>();
builder.Services.AddScoped<ISWCommodityRepository, SWCommodityRepository>();
builder.Services.AddScoped<IMWCommodityRepository, MWCommodityRepository>();
builder.Services.AddScoped<IEWCommodityRepository, EWCommodityRepository>();

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
