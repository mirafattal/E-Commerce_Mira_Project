using E_BLL.Services.Authorization;
using E_Commerce_Mira.Extensions;
using E_DAL.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// add services
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policy => policy.AddRequirements(new RoleRequirement("Admin")));
    options.AddPolicy("Accounting", policy => policy.AddRequirements(new RoleRequirement("Accounting")));
});


builder.Services.AddAutoMapperConfig();
builder.Services.addDb(builder.Configuration);
builder.Services.AddRepository();
builder.Services.AddService();
builder.Services.AddControllers();

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
