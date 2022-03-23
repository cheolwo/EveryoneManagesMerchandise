using BusinessData;
using BusinessData.ofGO.ofRepository;
using BusinessData.ofGroupOrder.ofDbContext;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofOrder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var GOCDbConnectionString = builder.Configuration.GetConnectionString("GOCDbConnection");
builder.Services.AddDbContext<GODbContext>(options =>
    options.UseSqlServer(GOCDbConnectionString));

builder.Services.AddScoped(typeof(IEntityManager<>), typeof(EntityManager<>));
builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(IEntityContainerFactory<>), typeof(EntityContainerFactory<>));
builder.Services.AddScoped(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(DicConvertFactory<>));

builder.Services.AddScoped<GOCManager>();
builder.Services.AddScoped<GOCManager>();
builder.Services.AddScoped<SGOCManager>();
builder.Services.AddScoped<MGOCManager>();
builder.Services.AddScoped<EGOCManager>();

builder.Services.AddScoped<IGOCRepository, GOCRepository>();
builder.Services.AddScoped<IGOCCRepository, GOCCRepository>();
builder.Services.AddScoped<ISGOCRepository, SGOCRepository>();
builder.Services.AddScoped<IMGOCRepository, MGOCRepository>();
builder.Services.AddScoped<IEGOCRepository, EGOCRepository>();

builder.Services.AddScoped<IGOCFileFactory, GOCFileFactory>();
builder.Services.AddScoped<IGOCCFileFactory, GOCCFileFactory>();
builder.Services.AddScoped<ISGOCFileFactory, SGOCFileFactory>();
builder.Services.AddScoped<IMGOCFileFactory, MGOCFileFactory>();
builder.Services.AddScoped<IEGOCFileFactory, EGOCFileFactory>();

builder.Services.AddScoped<IGOCBlobStorage, GOCBlobStorage>();
builder.Services.AddScoped<IGOCCBlobStorage, GOCCBlobStorage>();
builder.Services.AddScoped<ISGOCBlobStorage, SGOCBlobStorage>();
builder.Services.AddScoped<IMGOCBlobStorage, MGOCBlobStorage>();
builder.Services.AddScoped<IEGOCBlobStorage, EGOCBlobStorage>();

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
