using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TestAPIContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("TestAPIContext") ?? throw new InvalidOperationException("Connection string 'TestAPIContext' not found.")));

// Add services to the container.

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