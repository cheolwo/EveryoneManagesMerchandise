using BusinessData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PlanLogisticsWebApp.Data;

var builder = WebApplication.CreateBuilder(args);
bool IsProduct = false;
string IdentityDbConnectionString = "";
// Add services to the container.
if (IsProduct)
{
    // Add services to the container.
    IdentityDbConnectionString = builder.Configuration.GetConnectionString("IdentityDbConnection");
}
else
{
    IdentityDbConnectionString = DevelopmentDbConnetionString.IdentityDbConnection;
}
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(IdentityDbConnectionString));
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireUppercase = false;

}).AddEntityFrameworkStores<ApplicationDbContext>();

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
