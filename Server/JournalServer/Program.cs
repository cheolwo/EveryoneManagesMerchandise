using BusinessData;
using BusinessData.ofFinancial;
using BusinessData.ofFinancial.ofRepository;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGenericRepository;
using BusinessData.ofJournal.ofInterface.ofEmployee;
using BusinessData.ofJournal.ofInterface.ofEmployer;
using BusinessData.ofJournal.ofInterface.ofPlatform;
using BusinessLogic.ofManager;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofJournal.ofIdFactory;
using BusinessLogic.ofManager.ofJournal.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofJournal.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofJournal.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

bool IsProduct = false;
string JournalDbConnectionString = "";
if(IsProduct)
{
    // Add services to the container.
   JournalDbConnectionString = builder.Configuration.GetConnectionString("JournalDbConnection");
}
else
{
    JournalDbConnectionString = DevelopmentDbConnetionString.JournalDbConnection;
}
builder.Services.AddDbContext<JournalDbContext>(options =>
    options.UseSqlServer(JournalDbConnectionString));

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

builder.Services.AddScoped(typeof(CenterPasswordHasher<>));

builder.Services.AddScoped<IJournalCenterManager, JournalCenterManager>();
builder.Services.AddScoped<IJCommodityManager, JCommodityManager>();
builder.Services.AddScoped<IJournalManager, JournalManager>();

builder.Services.AddScoped<IEmployeeJournalCenterManager, JournalCenterManager>();
builder.Services.AddScoped<IEmployeeJCommodityManager, JCommodityManager>();
builder.Services.AddScoped<IEmployeeJournalManager, JournalManager>();

builder.Services.AddScoped<IEmployerJournalCenterManager, JournalCenterManager>();
builder.Services.AddScoped<IEmployerJCommodityManager, JCommodityManager>();
builder.Services.AddScoped<IEmployerJournalManager, JournalManager>();

builder.Services.AddScoped<IPlatformJournalCenterManager, JournalCenterManager>();
builder.Services.AddScoped<IPlatformJCommodityManager, JCommodityManager>();
builder.Services.AddScoped<IPlatformJournalManager, JournalManager>();

builder.Services.AddScoped<IJournalCenterRepository, JournalCenterRepository>();
builder.Services.AddScoped<IJCommodityRepository, JCommodityRepository>();
builder.Services.AddScoped<IJournalRepository, JournalRepository>();

builder.Services.AddScoped<IEmployeeJournalCenterRepository, JournalCenterRepository>();
builder.Services.AddScoped<IEmployeeJCommodityRepository, JCommodityRepository>();
builder.Services.AddScoped<IEmployeeJournalRepository, JournalRepository>();

builder.Services.AddScoped<IEmployerJournalCenterRepository, JournalCenterRepository>();
builder.Services.AddScoped<IEmployerJCommodityRepository, JCommodityRepository>();
builder.Services.AddScoped<IEmployerJournalRepository, JournalRepository>();

builder.Services.AddScoped<IPlatformJournalCenterRepository, JournalCenterRepository>();
builder.Services.AddScoped<IPlatformJCommodityRepository, JCommodityRepository>();
builder.Services.AddScoped<IPlatformJournalRepository, JournalRepository>();

builder.Services.AddScoped<IJournalCenterIdFactory, JournalCenterIdFactory>();
builder.Services.AddScoped<IJCommodityIdFactory, JCommodityIdFactory>();
builder.Services.AddScoped<IJournalIdFactory, JournalIdFactory>();

builder.Services.AddScoped<IJournalCenterFileFactory, JournalCenterFileFactory>();
builder.Services.AddScoped<IJCommodityFileFactory, JCommodityFileFactory>();
builder.Services.AddScoped<IJournalFileFactory, JournalFileFactory>();


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
