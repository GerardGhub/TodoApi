using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Microsoft.Extensions.DependencyInjection;
using TodoApi.Data;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TodoApiContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("TodoApiContext") ?? throw new InvalidOperationException("Connection string 'TodoApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoApiContext>(opt =>
opt.UseInMemoryDatabase("Todolist"));



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
