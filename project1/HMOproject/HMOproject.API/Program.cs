using HMO_COVID19.Core.Services;
using HMO_COVID19.Service;
using HMOproject.Core.Repositories;
using HMOproject.Core.Services;
using HMOproject.Data;
using HMOproject.Data.Repositories;
using HMOproject.Service;
using System.ComponentModel.Design;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt=>opt.AddPolicy("MyPolicy", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));
builder.Services.AddScoped<IMembersService, MembersService>();
builder.Services.AddScoped<IMembersRepository, MembersRepository>();
builder.Services.AddScoped<IManufacturerService,ManufacturerService>();
builder.Services.AddScoped<IManufacturerRepository, ManufacturerRepository>();
builder.Services.AddScoped<IVaccinationService, VaccinationService>();
builder.Services.AddScoped<IVaccinationRepository, VaccinationRepository>();
builder.Services.AddDbContext<DataContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
