using OrderingAppMFBackend.Models;

using Microsoft.EntityFrameworkCore;
using OrderingAppMFBackend.Repositories;
using OrderingAppMFBackend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<OrderingAppContext>(options => options.UseSqlServer("Server=tcp:mssql-orderingapp-server.database.windows.net,1433;Initial Catalog=OrderingAppDB;User ID=sqladmin;Password=Password123;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
builder.Services.AddScoped <IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IMenuOptionsService,MenuOptionsService>();
builder.Services.AddScoped<IMenuOptionsRepository,MenuOptionsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();