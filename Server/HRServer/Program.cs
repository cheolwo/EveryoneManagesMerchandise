using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofHR.ofDbContext;
using BusinessData.ofHRCenter.ofRepository;
using BusinessData.ofHumanResouce.ofIdFactory;
using BusinessData.ofHumanResource.ofInterface.ofEmployee;
using BusinessData.ofHumanResource.ofInterface.ofEmployer;
using BusinessData.ofHumanResource.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofHumanResouce;
using BusinessLogic.ofManager.ofHumanResouce.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofHumanResouce.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofHumanResouce.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
bool IsProduct = false;
bool IsInMemory = false;
string HRDbConnectionString = "";
if(IsProduct)
{
    // Add services to the container.
   HRDbConnectionString = builder.Configuration.GetConnectionString("HRDbConnection");
}
else
{
    HRDbConnectionString = DevelopmentDbConnetionString.HRDbConnection;
}
if (IsInMemory)
{
    builder.Services.AddDbContext<HRDbContext>(options =>
       options.UseSqlServer(HRDbConnectionString).UseInMemoryDatabase("HRTestDb"));
}
else
{
    builder.Services.AddDbContext<HRDbContext>(options =>
           options.UseSqlServer(HRDbConnectionString));
}
// Add services to the container.
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

builder.Services.AddScoped(typeof(CenterPasswordHasher<>));

builder.Services.AddScoped<IHRCenterManager, HRCenterManager>();
builder.Services.AddScoped<IEmployeeHRCenterManager, HRCenterManager>();
builder.Services.AddScoped<IEmployerHRCenterManager, HRCenterManager>();
builder.Services.AddScoped<IPlatformHRCenterManager, HRCenterManager>();
builder.Services.AddScoped<IHRCenterRepository, HRCenterRepository>();
builder.Services.AddScoped<IEmployeeHRCenterRepository, HRCenterRepository>();
builder.Services.AddScoped<IEmployerHRCenterRepository, HRCenterRepository>();
builder.Services.AddScoped<IPlatformHRCenterRepository, HRCenterRepository>();
builder.Services.AddScoped<IHRCenterIdFactory, HRCenterIdFactory>();
builder.Services.AddScoped<IHRCenterFileFactory, HRCenterFileFactory>();
builder.Services.AddScoped<IHRCenterBlobStorage, HRCenterBlobStorage>();
builder.Services.AddScoped<IHRCenterBlobContainerFactory, HRCenterBlobContainerFactory>();

builder.Services.AddScoped<IHRBusinessPartManager, HRBusinessPartManager>();
builder.Services.AddScoped<IEmployeeHRBusinessPartManager, HRBusinessPartManager>();
builder.Services.AddScoped<IEmployerHRBusinessPartManager, HRBusinessPartManager>();
builder.Services.AddScoped<IPlatformHRBusinessPartManager, HRBusinessPartManager>();
builder.Services.AddScoped<IHRBusinessPartRepository, HRBusinessPartRepository>();
builder.Services.AddScoped<IEmployeeHRBusinessPartRepository, HRBusinessPartRepository>();
builder.Services.AddScoped<IEmployerHRBusinessPartRepository, HRBusinessPartRepository>();
builder.Services.AddScoped<IPlatformHRBusinessPartRepository, HRBusinessPartRepository>();
builder.Services.AddScoped<IHRBusinessPartIdFactory, HRBusinessPartIdFactory>();
builder.Services.AddScoped<IHRBusinessPartFileFactory, HRBusinessPartFileFactory>();
builder.Services.AddScoped<IHRBusinessPartBlobStorage, HRBusinessPartBlobStorage>();
builder.Services.AddScoped<IHRBusinessPartBlobContainerFactory, HRBusinessPartBlobContainerFactory>();

builder.Services.AddScoped<IHREmployeeManager, HREmployeeManager>();
builder.Services.AddScoped<IHRRoleManager, HRRoleManager>();
builder.Services.AddScoped<IEmployeeRoleManager, EmployeeRoleManager>();

builder.Services.AddScoped<IEmployeeHREmployeeManager, HREmployeeManager>();
builder.Services.AddScoped<IEmployeeHRRoleManager, HRRoleManager>();
builder.Services.AddScoped<IEmployeeEmployeeRoleManager, EmployeeRoleManager>();

builder.Services.AddScoped<IEmployerHREmployeeManager, HREmployeeManager>();
builder.Services.AddScoped<IEmployerHRRoleManager, HRRoleManager>();
builder.Services.AddScoped<IEmployerEmployeeRoleManager, EmployeeRoleManager>();

builder.Services.AddScoped<IPlatformHREmployeeManager, HREmployeeManager>();
builder.Services.AddScoped<IPlatformHRRoleManager, HRRoleManager>();
builder.Services.AddScoped<IPlatformEmployeeRoleManager, EmployeeRoleManager>();

builder.Services.AddScoped<IHREmployeeRepository, HREmployeeRepository>();
builder.Services.AddScoped<IHRRoleRepository, HRRoleRepository>();
builder.Services.AddScoped<IEmployeeRoleRepository, EmployeeRoleRepository>();

builder.Services.AddScoped<IEmployeeHREmployeeRepository, HREmployeeRepository>();
builder.Services.AddScoped<IEmployeeHRRoleRepository, HRRoleRepository>();
builder.Services.AddScoped<IEmployeeEmployeeRoleRepository, EmployeeRoleRepository>();

builder.Services.AddScoped<IEmployerHREmployeeRepository, HREmployeeRepository>();
builder.Services.AddScoped<IEmployerHRRoleRepository, HRRoleRepository>();
builder.Services.AddScoped<IEmployerEmployeeRoleRepository, EmployeeRoleRepository>();

builder.Services.AddScoped<IPlatformHREmployeeRepository, HREmployeeRepository>();
builder.Services.AddScoped<IPlatformHRRoleRepository, HRRoleRepository>();
builder.Services.AddScoped<IPlatformEmployeeRoleRepository, EmployeeRoleRepository>();

builder.Services.AddScoped<IHREmployeeIdFactory, HREmployeeIdFactory>();
builder.Services.AddScoped<IHRRoleIdFactory, HRRoleIdFactory>();
builder.Services.AddScoped<IEmployeeRoleIdFactory, EmployeeRoleIdFactory>();

builder.Services.AddScoped<IHREmployeeFileFactory, HREmployeeFileFactory>();
builder.Services.AddScoped<IHRRoleFileFactory, HRRoleFileFactory>();
builder.Services.AddScoped<IEmployeeRoleFileFactory, EmployeeRoleFileFactory>();

builder.Services.AddScoped<IHREmployeeBlobStorage, HREmployeeBlobStorage>();
builder.Services.AddScoped<IHRRoleBlobStorage, HRRoleBlobStorage>();
builder.Services.AddScoped<IEmployeeRoleBlobStorage, EmployeeRoleBlobStorage>();

builder.Services.AddScoped<IHREmployeeBlobContainerFactory, HREmployeeBlobContainerFactory>();
builder.Services.AddScoped<IHRRoleBlobContainerFactory, HRRoleBlobContainerFactory>();
builder.Services.AddScoped<IEmployeeRoleBlobContainerFactory, EmployeeRoleBlobContainerFactory>();

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
