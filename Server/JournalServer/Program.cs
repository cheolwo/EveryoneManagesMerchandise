var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var JournalDbConnectionString = builder.Configuration.GetConnectionString("JournalDbConnection");
builder.Services.AddDbContext<JournalDbContext>(options =>
    options.UseSqlServer(JournalDbConnectionString));

builder.Services.AddScoped(typeof(IEntityManager<>), typeof(EntityManager<>));
builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped(typeof(IEntityFileFactory<>), typeof(EntityFileFactory<>));
builder.Services.AddScoped(typeof(IEntityContainerFactory<>), typeof(EntityContainerFactory<>));
builder.Services.AddScoped(typeof(IEntityBlobStorage<>), typeof(EntityBlobStorage<>));
builder.Services.AddScoped(typeof(DicConvertFactory<>));

// builder.Services.AddScoped<JournalCenterManager>();
// builder.Services.AddScoped<JCommodityManager>();
// builder.Services.AddScoped<JournalManager>();

// builder.Services.AddScoped<IJournalCenterRepository, JournalCenterRepository>();
// builder.Services.AddScoped<IOCommodityRepository, OCommodityRepository>();
// builder.Services.AddScoped<IOCommodityRepository, OCommodityRepository>();

// builder.Services.AddScoped<IJournalCenterFileFactory, JournalCenterFileFactory>();
// builder.Services.AddScoped<IOCommodityFileFactory, OCommodityFileFactory>();
// builder.Services.AddScoped<IOCommodityRepository, OCommodityRepository>();

// builder.Services.AddScoped<IJournalCenterBlobStorage, JournalCenterBlobStorage>();
// builder.Services.AddScoped<IOCommodityBlobStorage, OCommodityBlobStorage>();
// builder.Services.AddScoped<IOCommodityRepository, OCommodityRepository>();
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
