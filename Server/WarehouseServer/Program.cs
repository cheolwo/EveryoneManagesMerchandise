using BusinessData;
using BusinessData.ofWarehouse.ofDbContext;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var IdentityConnectionString = builder.Configuration.GetConnectionString("WarehouseDbConnection");
builder.Services.AddDbContext<WarehouseDbContext>(options =>
    options.UseSqlServer(IdentityConnectionString));

builder.Services.AddSingleton(typeof(IEntityManager<>), typeof(EntityManager<>));
builder.Services.AddSingleton(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddSingleton(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddSingleton(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddSingleton(typeof(DicConvertFactory<>));

builder.Services.AddSingleton<IWarehouseRepository, WarehouseRepository>();
builder.Services.AddSingleton<IWarehouseRepository, WarehouseRepository>();
builder.Services.AddSingleton<IWarehouseRepository, WarehouseRepository>();
builder.Services.AddSingleton<IWarehouseRepository, WarehouseRepository>();
builder.Services.AddSingleton<IWarehouseRepository, WarehouseRepository>();


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
