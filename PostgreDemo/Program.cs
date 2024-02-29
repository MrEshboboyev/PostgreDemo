using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PostgreDemo.Data;

var builder = WebApplication.CreateBuilder(args);

//Add PostgreSql connection
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();