using AnimalBusinessLogic.Implementation;
using AnimalBusinessLogic.Interface;
using AnimalDataAccessLayer.Implementation;
using AnimalDataAccessLayer.Interface;
using AnimalEntities.DBEntities;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AnimalDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("AnimalDBConnection")));

builder.Services.AddTransient<IAnimalBL, AnimalBL>();
builder.Services.AddTransient<IAnimalDAL, AnimalDAL>();

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
