using InzynierkaTest.Context;
using InzynierkaTest.Models;
using InzynierkaTest.Repositories;
using InzynierkaTest.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<InzynierkaTestContext>(options => options.UseSqlServer("Server=DESKTOP-BHAFUI9\\\\SQLEXPRESS02;Database=InzynierkaTest;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddScoped <IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

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