using BusinessData;
using BusinessData.ofOrder.ofDbContext;
using BusinessData.ofOrder.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofOrder;
using BusinessLogic.ofManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var OrderDbConnectionString = builder.Configuration.GetConnectionString("OrderDbConnection");
builder.Services.AddDbContext<OrderDbContext>(options =>
    options.UseSqlServer(OrderDbConnectionString));

builder.Services.AddScoped(typeof(IEntityManager<>), typeof(EntityManager<>));
builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(IEntityContainerFactory<>), typeof(EntityContainerFactory<>));
builder.Services.AddScoped(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(DicConvertFactory<>));

builder.Services.AddScoped<OrderCenterManager>();
builder.Services.AddScoped<OCommodityManager>();
builder.Services.AddScoped<SOCommodityManager>();
builder.Services.AddScoped<MOCommodityManager>();
builder.Services.AddScoped<EOCommodityManager>();

builder.Services.AddScoped<IOrderCenterRepository, OrderCenterRepository>();
builder.Services.AddScoped<IOCommodityRepository, OCommodityRepository>();
builder.Services.AddScoped<ISOCommodityRepository, SOCommodityRepository>();
builder.Services.AddScoped<IMOCommodityRepository, MOCommodityRepository>();
builder.Services.AddScoped<IEOCommodityRepository, EOCommodityRepository>();

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
