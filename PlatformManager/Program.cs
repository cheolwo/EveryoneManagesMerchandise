using BusinessData;
using BusinessData.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofCommon.ofHsCode.ofRepository;
using BusinessLogic.ofManagement.ofPatform;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using PlatformManager.Areas.Identity;
using PlatformManager.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

var HsDbConnectionString = builder.Configuration.GetConnectionString("HsDbConnection");
builder.Services.AddDbContext<HsDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped(typeof(IEntityDataRepository<>), typeof(EntityDataRepository<>));
builder.Services.AddScoped<PlatFormManagement>();
builder.Services.AddScoped<HsCodePartRepository>();
builder.Services.AddScoped<PracticalHsCodeRepository>();
builder.Services.AddScoped<SubPartofHsCodeRepository>();
builder.Services.AddScoped<DetailPracticalHsCodeRepository>();
builder.Services.AddScoped<CountryRepository>();

builder.Services.AddMudServices();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
