using BusinessData;
using BusinessData.ofProduct.ofDbContext;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofProduct;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
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
builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(IEntityContainerFactory<>), typeof(EntityContainerFactory<>));
builder.Services.AddScoped(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(DicConvertFactory<>));

builder.Services.AddScoped<ProductCenterManager>();
builder.Services.AddScoped<PCommodityManager>();
builder.Services.AddScoped<SPCommodityManager>();
builder.Services.AddScoped<MPCommodityManager>();
builder.Services.AddScoped<EPCommodityManager>();

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
