using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofGenericRepository;
using BusinessData.ofGO.ofRepository;
using BusinessData.ofGroupOrder.ofDbContext;
using BusinessData.ofGroupOrder.ofInterface.ofEmployee;
using BusinessData.ofGroupOrder.ofInterface.ofEmployer;
using BusinessData.ofGroupOrder.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder;
using BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofIdFactory;
using BusinessLogic.ofManager.ofGroupOrder.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofGroupOrder.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofGroupOrder.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofOrder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

bool IsProduct = false;
string GroupOrderDbConnectionString = "";
if(IsProduct)
{
    // Add services to the container.
   GroupOrderDbConnectionString = builder.Configuration.GetConnectionString("GroupOrderDbConnection");
}
else
{
    GroupOrderDbConnectionString = DevelopmentDbConnetionString.GroupOrderDbConnection;
}
builder.Services.AddDbContext<GODbContext>(options =>
    options.UseSqlServer(GroupOrderDbConnectionString));

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

builder.Services.AddScoped<IGOCManager, GOCManager>();
builder.Services.AddScoped<IGOCCManager, GOCCManager>();
builder.Services.AddScoped<ISGOCManager, SGOCManager>();
builder.Services.AddScoped<IMGOCManager, MGOCManager>();
builder.Services.AddScoped<IEGOCManager, EGOCManager>();

builder.Services.AddScoped<IEmployeeGOCManager, GOCManager>();
builder.Services.AddScoped<IEmployeeGOCCManager, GOCCManager>();
builder.Services.AddScoped<IEmployeeSGOCManager, SGOCManager>();
builder.Services.AddScoped<IEmployeeMGOCManager, MGOCManager>();
builder.Services.AddScoped<IEmployeeEGOCManager, EGOCManager>();

builder.Services.AddScoped<IEmployerGOCManager, GOCManager>();
builder.Services.AddScoped<IEmployerGOCCManager, GOCCManager>();
builder.Services.AddScoped<IEmployerSGOCManager, SGOCManager>();
builder.Services.AddScoped<IEmployerMGOCManager, MGOCManager>();
builder.Services.AddScoped<IEmployerEGOCManager, EGOCManager>();

builder.Services.AddScoped<IPlatformGOCManager, GOCManager>();
builder.Services.AddScoped<IPlatformGOCCManager, GOCCManager>();
builder.Services.AddScoped<IPlatformSGOCManager, SGOCManager>();
builder.Services.AddScoped<IPlatformMGOCManager, MGOCManager>();
builder.Services.AddScoped<IPlatformEGOCManager, EGOCManager>();

builder.Services.AddScoped<IGOCRepository, GOCRepository>();
builder.Services.AddScoped<IGOCCRepository, GOCCRepository>();
builder.Services.AddScoped<ISGOCRepository, SGOCRepository>();
builder.Services.AddScoped<IMGOCRepository, MGOCRepository>();
builder.Services.AddScoped<IEGOCRepository, EGOCRepository>();

builder.Services.AddScoped<IEmployeeGOCRepository, GOCRepository>();
builder.Services.AddScoped<IEmployeeGOCCRepository, GOCCRepository>();
builder.Services.AddScoped<IEmployeeSGOCRepository, SGOCRepository>();
builder.Services.AddScoped<IEmployeeMGOCRepository, MGOCRepository>();
builder.Services.AddScoped<IEmployeeEGOCRepository, EGOCRepository>();

builder.Services.AddScoped<IEmployerGOCRepository, GOCRepository>();
builder.Services.AddScoped<IEmployerGOCCRepository, GOCCRepository>();
builder.Services.AddScoped<IEmployerSGOCRepository, SGOCRepository>();
builder.Services.AddScoped<IEmployerMGOCRepository, MGOCRepository>();
builder.Services.AddScoped<IEmployerEGOCRepository, EGOCRepository>();

builder.Services.AddScoped<IPlatformGOCRepository, GOCRepository>();
builder.Services.AddScoped<IPlatformGOCCRepository, GOCCRepository>();
builder.Services.AddScoped<IPlatformSGOCRepository, SGOCRepository>();
builder.Services.AddScoped<IPlatformMGOCRepository, MGOCRepository>();
builder.Services.AddScoped<IPlatformEGOCRepository, EGOCRepository>();

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

builder.Services.AddScoped<IGOCIdFactory, GOCIdFactory>();
builder.Services.AddScoped<IGOCCIdFactory, GOCCIdFactory>();
builder.Services.AddScoped<ISGOCIdFactory, SGOCIdFactory>();
builder.Services.AddScoped<IMGOCIdFactory, MGOCIdFactory>();
builder.Services.AddScoped<IEGOCIdFactory, EGOCIdFactory>();

builder.Services.AddScoped<IGOCBlobContainerFactory, GOCBlobContainerFactory>();
builder.Services.AddScoped<IGOCCBlobContainerFactory, GOCCBlobContainerFactory>();
builder.Services.AddScoped<ISGOCBlobContainerFactory, SGOCBlobContainerFactory>();
builder.Services.AddScoped<IMGOCBlobContainerFactory, MGOCBlobContainerFactory>();
builder.Services.AddScoped<IEGOCBlobContainerFactory, EGOCBlobContainerFactory>();

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
